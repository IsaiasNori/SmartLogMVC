using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL;
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
							  Convert.ToInt32(obj.CodVeiculo), obj.Motorista.Codigo, Convert.ToInt32(obj.Atendente));
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
				return dao.FiltrarViagemDAO(obj.DataViagem, obj.DataViagemFinal,Convert.ToInt32(obj.Motorista), Convert.ToInt32(obj.Cliente));
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
										Convert.ToInt32(table.Rows[0]["Cidade_Origem"]),
										Convert.ToInt32(table.Rows[0]["UF_Origem"]));

					Endereco endDestino = new Endereco(table.Rows[0]["Cep_Destino"].ToString(),
										table.Rows[0]["Lograd_Destino"].ToString(),
										Convert.ToInt32(table.Rows[0]["Numero_Destino"]),
										table.Rows[0]["Bairro_Destino"].ToString(),
										Convert.ToInt32(table.Rows[0]["Cidade_Destino"]),
										Convert.ToInt32(table.Rows[0]["UF_Destino"]));

					Cliente cli = new Cliente(Convert.ToInt32(table.Rows[0]["Cod_Cliente"]));
					ClienteController cliCtrl = new ClienteController();
					cli = cliCtrl.GetObj(cli);

					Veiculo vei = new Veiculo(Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]));
					VeiculoController veiCtrl = new VeiculoController();
					vei = veiCtrl.GetObj(vei);

					MotoristaController motoCtrl = new MotoristaController();
					Motorista moto = new Motorista(Convert.ToInt32(table.Rows[0]["Cod_Motorista"]));

					FuncionarioController funcCtrl = new FuncionarioController();
					Funcionario func = new Funcionario();
					func = funcCtrl.GetObj(func);

					Viagem viagem = new Viagem(Convert.ToInt32(table.Rows[0]["Cod_Viagem"]),
										Convert.ToDateTime(table.Rows[0]["Data_Viagem"]),
										table.Rows[0]["Distancia_Km"].ToString(),
										Convert.ToDecimal(table.Rows[0]["Valor"]),
										endOrigem, table.Rows[0]["Complemento_Origem"].ToString(),
										endDestino, table.Rows[0]["Complemento_Destino"].ToString(), cli, vei, moto, func);
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
				dao.InserirViagemDAO(obj.DataViagem, obj.DistanciaKm, obj.Valor, obj.Origem.Cep, obj.Origem.Logradouro,
							  obj.Origem.Numero, obj.ComplementoOrigem, obj.Origem.Bairro, obj.Origem.CodCidade.ToString(), obj.Origem.CodEstado.ToString(),
							  obj.Destino.Cep, obj.Destino.Logradouro, obj.Destino.Numero, obj.ComplementoDestino, obj.Destino.Bairro,
							  obj.Destino.CodCidade.ToString(), obj.Destino.CodEstado.ToString(), obj.Cliente.Codigo,
							  Convert.ToInt32(obj.CodVeiculo), obj.Motorista.Codigo, Convert.ToInt32(obj.Atendente));
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
					Convert.ToInt32(table.Rows[0]["Cidade_Origem"]),
					Convert.ToInt32(table.Rows[0]["UF_Origem"]));

					Endereco endDestino = new Endereco(table.Rows[0]["Cep_Destino"].ToString(),
										table.Rows[0]["Lograd_Destino"].ToString(),
										Convert.ToInt32(table.Rows[0]["Numero_Destino"]),
										table.Rows[0]["Bairro_Destino"].ToString(),
										Convert.ToInt32(table.Rows[0]["Cidade_Destino"]),
										Convert.ToInt32(table.Rows[0]["UF_Destino"]));

					Cliente cli = new Cliente(Convert.ToInt32(table.Rows[0]["Cod_Cliente"]));
					ClienteController cliCtrl = new ClienteController();
					cli = cliCtrl.GetObj(cli);

					Veiculo vei = new Veiculo(Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]));
					VeiculoController veiCtrl = new VeiculoController();
					vei = veiCtrl.GetObj(vei);

					MotoristaController motoCtrl = new MotoristaController();
					Motorista moto = new Motorista(Convert.ToInt32(table.Rows[0]["Cod_Motorista"]));

					FuncionarioController funcCtrl = new FuncionarioController();
					Funcionario func = new Funcionario();
					func = funcCtrl.GetObj(func);

					Viagem viagem = new Viagem(Convert.ToInt32(table.Rows[0]["Cod_Viagem"]),
										Convert.ToDateTime(table.Rows[0]["Data_Viagem"]),
										table.Rows[0]["Distancia_Km"].ToString(),
										Convert.ToDecimal(table.Rows[0]["Valor"]),
										endOrigem, table.Rows[0]["Complemento_Origem"].ToString(),
										endDestino, table.Rows[0]["Complemento_Destino"].ToString(), cli, vei, moto, func);
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
