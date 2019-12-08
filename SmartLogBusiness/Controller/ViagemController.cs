using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL;
using SmartLogBusiness.Exceptions;
using SmartLogBusiness.Model.Entidade;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Model.Entidade.veiculo;
using SmartLogBusiness.Model.Entidade.viagem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class ViagemController : IControllerBase<Viagem>
	{
		ViagemDAO dao = new ViagemDAO();

		DateTime dataViagem;
		int numOrigem, numDestino;
		int cliente, atendente, motorista, veiculo, status;
		public void AlterarController(Viagem obj)
		{
			try
			{
				if (obj.CodViagem == 0)
				{
					throw new Exception("Necessário informar código para alteração de registro.");
				}
				dao.AlterarViagemDAO(obj.CodViagem, obj.DataViagem, obj.DistanciaKm, obj.Valor, obj.Origem.Cep, obj.Origem.Logradouro,
							  obj.Origem.Numero, obj.ComplementoOrigem, obj.Origem.Bairro, obj.Origem.CodCidade.ToString(), obj.Origem.CodEstado.ToString(),
							  obj.Destino.Cep, obj.Destino.Logradouro, obj.Destino.Numero, obj.ComplementoDestino, obj.Destino.Bairro,
							  obj.Destino.CodCidade.ToString(), obj.Destino.CodEstado.ToString(), obj.Cliente.Codigo,
							  Convert.ToInt32(obj.CodVeiculo.CodVei), obj.Motorista.Codigo, Convert.ToInt32(obj.Atendente.Codigo), (int)obj.Status);

				if (obj.Status == EnumStatusViagem.Finalizada)
				{
					decimal kmPosViagem, kmInicial;
					int distancia, kmAtual;
					VeiculoController veiCtrl = new VeiculoController();
					Veiculo veic = new Veiculo(obj.CodVeiculo.CodVei);

					veic = veiCtrl.GetObj(veic);

					Decimal.TryParse(veic.KmInicial, out kmInicial);
					//	kmInicial = Convert.ToDecimal(veic.KmInicial);
					int.TryParse(obj.DistanciaKm, out distancia);
					int.TryParse(veic.KmAtual, out kmAtual);

					kmPosViagem = distancia + kmAtual;

					veic.KmAtual = kmPosViagem.ToString();

					if (kmPosViagem - kmInicial >= 10000)
					{
						veic.Status = enumStatusVeiculo.Manutencao;
						veic.KmInicial = veic.KmAtual;

						ManutencaoController manuCtrl = new ManutencaoController();
						manuCtrl.InserirController(new Manutencao(0,System.DateTime.Now, System.DateTime.Now.AddDays(5), "Veiculo manutenção preventiva", veic.CodVei));
					}

					veiCtrl.AlterarController(veic);
					if (veic.Status == enumStatusVeiculo.Manutencao)
					{
						throw new BusinessException("Veículo ultrapassou a quilometragem de manutenção preventiva e o sistema alterou para Veículo em Manutenção.");
					}

				}
			}
			catch (BusinessException ex)
			{
				throw new BusinessException(ex.Message);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void DeletarController(Viagem obj)
		{
			try
			{
				if (obj.CodViagem == 0)
				{
					throw new Exception("Necessário informar código para exclusão de registro.");
				}
				dao.DeletarViagemDao(obj.CodViagem);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable GetDataTable(Viagem obj)
		{
			try
			{
				return dao.FiltrarViagemDAO(obj.DataViagem, obj.DataViagemFinal, Convert.ToInt32(obj.Motorista.Codigo), Convert.ToInt32(obj.Cliente.Codigo));
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public Viagem GetObj(Viagem obj)
		{
			try
			{
				DataTable table = dao.CarregarViagemDAO(obj.CodViagem);
				if (obj.CodViagem == 0)
				{
					throw new Exception("Insira o código para localizar viagem!");
				}

				if (table != null)
				{
					Endereco endOrigem = new Endereco(table.Rows[0]["Cep_Origem"].ToString(),
										table.Rows[0]["Lograd_Origem"].ToString(),
										Convert.ToInt32(table.Rows[0]["Numero_Origem"]),
										table.Rows[0]["Bairro_Origem"].ToString(),
										Convert.ToInt32(table.Rows[0]["Cod_CidadeOrigem"]),
										Convert.ToInt32(table.Rows[0]["Cod_UFOrigem"]));

					Endereco endDestino = new Endereco(table.Rows[0]["Cep_Destino"].ToString(),
										table.Rows[0]["Lograd_Destino"].ToString(),
										Convert.ToInt32(table.Rows[0]["Numero_Destino"]),
										table.Rows[0]["Bairro_Destino"].ToString(),
										Convert.ToInt32(table.Rows[0]["Cod_CidadeDestino"]),
										Convert.ToInt32(table.Rows[0]["Cod_UFDestino"]));

					Cliente cli = new Cliente(Convert.ToInt32(table.Rows[0]["Cod_Cliente"]));
					ClienteController cliCtrl = new ClienteController();
					cli = cliCtrl.GetObj(cli);

					Veiculo vei = new Veiculo(Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]));
					VeiculoController veiCtrl = new VeiculoController();
					vei = veiCtrl.GetObj(vei);

					MotoristaController motoCtrl = new MotoristaController();
					Motorista moto = new Motorista(Convert.ToInt32(table.Rows[0]["Cod_Motorista"]));

					FuncionarioController funcCtrl = new FuncionarioController();
					Funcionario func = new Funcionario(Convert.ToInt32(table.Rows[0]["Cod_Atendente"]));
					func = funcCtrl.GetObj(func);

					Viagem viagem = new Viagem(Convert.ToInt32(table.Rows[0]["Cod_Viagem"]),
										Convert.ToDateTime(table.Rows[0]["Data_Viagem"]),
										table.Rows[0]["Distancia_Km"].ToString(),
										Convert.ToDecimal(table.Rows[0]["Valor"]),
										endOrigem, table.Rows[0]["Complemento_Origem"].ToString(),
										endDestino, table.Rows[0]["Complemento_Destino"].ToString(), cli, vei, moto, func, (EnumStatusViagem)table.Rows[0]["Status"]);
					return viagem;
				}
				else
				{
					throw new Exception("Não possível localizar viagem.");
				}

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public void InserirController(Viagem obj)
		{
			try
			{
				if (obj.DataViagem == null)
				{
					throw new Exception("Informe a data da viagem.");
				}
				else
				{
					DateTime.TryParse(obj.DataViagem.ToString(), out dataViagem);
				}
				if (obj.DistanciaKm == "")
				{
					throw new Exception("Informar a quilomentragem da viagem.");
				}
				if (obj.Valor == 0)
				{
					throw new Exception("Informe o valor da viagem.");
				}
				if (obj.Origem.Logradouro == "")
				{
					throw new Exception("Informe o logradouro de origem, para cadastrar a viagem.");
				}
				if (obj.Origem.Bairro == "")
				{
					throw new Exception("Informe o bairro de origem da viagem.");
				}
				if (obj.Origem.CodEstado == 0)
				{
					throw new Exception("Informe o estado de origem.");
				}
				if (obj.Origem.CodCidade == 0)
				{
					throw new Exception("Informe a cidade de origem da viagem.");
				}
				if (obj.Destino.CodEstado == 0)
				{
					throw new Exception("Informe o estado de destino.");
				}
				if (obj.Destino.CodCidade == 0)
				{
					throw new Exception("Informe a cidade de destino.");
				}
				if (obj.Cliente.Codigo == 0)
				{
					throw new Exception("Selecione um cliente.");
				}
				else
				{
					int.TryParse(obj.Cliente.Codigo.ToString(), out cliente);
				}

				if (obj.CodVeiculo.CodVei == 0)
				{
					throw new Exception("Informe o veiculo que realizará a viagem.");
				}
				else
				{
					int.TryParse(obj.CodVeiculo.CodVei.ToString(), out veiculo);
				}

				if (obj.Motorista.Codigo == 0)
				{
					throw new Exception("Informe o motorista.");
				}
				else
				{
					int.TryParse(obj.Motorista.Codigo.ToString(), out motorista);
				}

				if (obj.Atendente.Codigo == 0)
				{
					throw new Exception("Selecione um atendente.");
				}
				else
				{
					int.TryParse(obj.Atendente.Codigo.ToString(), out atendente);
				}

				if (obj.Status == 0)
				{
					throw new Exception("Selecione o status da viagem.");
				}

				int.TryParse(obj.Origem.Numero.ToString(), out numOrigem);
				int.TryParse(obj.Destino.Numero.ToString(), out numDestino);

				dao.InserirViagemDAO(dataViagem, obj.DistanciaKm, obj.Valor, obj.Origem.Cep, obj.Origem.Logradouro,
							  numOrigem, obj.ComplementoOrigem, obj.Origem.Bairro, obj.Origem.CodCidade.ToString(), obj.Origem.CodEstado.ToString(),
							  obj.Destino.Cep, obj.Destino.Logradouro, numDestino, obj.ComplementoDestino, obj.Destino.Bairro,
							  obj.Destino.CodCidade.ToString(), obj.Destino.CodEstado.ToString(), cliente,
							  veiculo, motorista, atendente, (int)obj.Status);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public List<Viagem> ListasController(Viagem obj)
		{
			try
			{
				DataTable table = dao.FiltrarViagemDAO(obj.DataViagem, obj.DataViagemFinal, Convert.ToInt32(obj.Motorista), Convert.ToInt32(obj.Cliente));
				List<Viagem> lista = new List<Viagem>();
				if (table == null)
				{
					throw new Exception("Não foi possível carregar viagem.");
				}
				foreach (DataRow item in table.Rows)
				{
					Endereco endOrigem = new Endereco(table.Rows[0]["Cep_Origem"].ToString(),
					table.Rows[0]["Lograd_Origem"].ToString(),
					Convert.ToInt32(table.Rows[0]["Numero_Origem"]),
					table.Rows[0]["Bairro_Origem"].ToString(),
					Convert.ToInt32(table.Rows[0]["Cod_CidadeOrigem"]),
					Convert.ToInt32(table.Rows[0]["Cod_UFOrigem"]));

					Endereco endDestino = new Endereco(table.Rows[0]["Cep_Destino"].ToString(),
										table.Rows[0]["Lograd_Destino"].ToString(),
										Convert.ToInt32(table.Rows[0]["Numero_Destino"]),
										table.Rows[0]["Bairro_Destino"].ToString(),
										Convert.ToInt32(table.Rows[0]["Cod_CidadeDestino"]),
										Convert.ToInt32(table.Rows[0]["Cod_UFDestino"]));

					Cliente cli = new Cliente(Convert.ToInt32(table.Rows[0]["Cod_Cliente"]));
					ClienteController cliCtrl = new ClienteController();
					cli = cliCtrl.GetObj(cli);

					Veiculo vei = new Veiculo(Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]));
					VeiculoController veiCtrl = new VeiculoController();
					vei = veiCtrl.GetObj(vei);

					MotoristaController motoCtrl = new MotoristaController();
					Motorista moto = new Motorista(Convert.ToInt32(table.Rows[0]["Cod_Motorista"]));

					FuncionarioController funcCtrl = new FuncionarioController();
					Funcionario func = new Funcionario(Convert.ToInt32(table.Rows[0]["Cod_Matricula"]));
					func = funcCtrl.GetObj(func);

					Viagem viagem = new Viagem(Convert.ToInt32(table.Rows[0]["Cod_Viagem"]),
										Convert.ToDateTime(table.Rows[0]["Data_Viagem"]),
										table.Rows[0]["Distancia_Km"].ToString(),
										Convert.ToDecimal(table.Rows[0]["Valor"]),
										endOrigem, table.Rows[0]["Complemento_Origem"].ToString(),
										endDestino, table.Rows[0]["Complemento_Destino"].ToString(), cli, vei, moto, func, (EnumStatusViagem)table.Rows[0]["Status"]);
					lista.Add(viagem);
				}
				return lista;

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
