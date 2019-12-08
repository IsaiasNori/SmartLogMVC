using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL;
using SmartLogBusiness.Model.Entidade.veiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class VeiculoController : IControllerBase<Veiculo>
	{
		VeiculoDAO dao = new VeiculoDAO();
		int codMarca, codStatus, anoFab;
		DateTime dataAq, ultimaRevisao;
		public void AlterarController(Veiculo obj)
		{
			try
			{
				if (obj.CodVei == 0)
				{
					throw new Exception("Necessário informar código do veículo para alteração de registro.");
				}

				if (obj.CodMarca == 0)
				{
					throw new Exception("Selecione a marca do veículo.");
				}
				else
				{
					int.TryParse(obj.CodMarca.ToString(), out codMarca);
				}

				if (obj.Modelo == "")
				{
					throw new Exception("Informe o modelo do veículo.");
				}
				if (obj.Renavam.Length != 11)
				{
					throw new Exception("Informe um renavam válido.");
				}

				if (obj.Status == 0)
				{
					throw new Exception("Selecione o status.");
				}

				if (obj.DataAquisicao == null)
				{
					throw new Exception("Informe a data de aquisição do veículo.");
				}
				else
				{
					DateTime.TryParse(obj.DataAquisicao.ToString(), out dataAq);
				}

				if (obj.AnoFabricacao != "")
				{
					anoFab = Convert.ToInt32(obj.AnoFabricacao);

					if (System.DateTime.Now.Year - anoFab > 9)
					{
						throw new Exception("Não é possível salvar veículos com 9 anos ou mais de uso.");
					}
				}
				else
				{
					throw new Exception("Preencha o ano de fabricação do veículo.");
				}

				if (obj.KmInicial == "")
				{
					throw new Exception("Preenchar a quilometragem inicial do véiculo.");
				}

				DateTime.TryParse(obj.DataUltimaRevisão.ToString(), out ultimaRevisao);
				enumStatusVeiculo status;
				status = obj.Status;

				dao.AlterarVeiculoDAO(obj.CodVei, codMarca, obj.Modelo, obj.Placa, obj.Renavam, (int)status, dataAq,
									  obj.AnoFabricacao, obj.KmInicial, obj.KmAtual, obj.KmPrev, ultimaRevisao);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);

			}
		}
		public void DeletarController(Veiculo obj)
		{
			try
			{
				if (obj.CodVei == 0)
				{
					throw new Exception("Necessário informar código para exclusão de registro.");
				}
				dao.DeletarVeiculoDAO(obj.CodVei);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public DataTable GetDataTable(Veiculo obj)
		{
			try
			{
				return dao.FiltrarVeiculoDAO(obj.CodMarca, obj.Modelo);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public Veiculo GetObj(Veiculo obj)
		{
			try
			{
				if (obj.CodVei == 0)
				{
					throw new Exception("Necessário informar código do véiculo.");
				}
				DataTable table = dao.ObterVeiculoDAO(obj.CodVei);

				if (table != null)
				{
					int.TryParse(table.Rows[0]["Cod_Marca"].ToString(), out codMarca);
					int.TryParse(table.Rows[0]["Cod_Status"].ToString(), out codStatus);

					DateTime.TryParse(table.Rows[0]["Data_Aquisicao"].ToString(), out dataAq);
					DateTime.TryParse(table.Rows[0]["Ultima_Revisao"].ToString(), out ultimaRevisao);

					Veiculo vei = new Veiculo(Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]),
											  codMarca,
											  table.Rows[0]["Modelo"].ToString(),
											  table.Rows[0]["Placa"].ToString(),
											  table.Rows[0]["Renavam"].ToString(),
											  (enumStatusVeiculo)codStatus, dataAq,
											  table.Rows[0]["Ano_Fabricacao"].ToString(),
											  table.Rows[0]["Km_Inicial"].ToString(),
											  table.Rows[0]["KM_Atual"].ToString(),
											  table.Rows[0]["KM_Prevencao"].ToString(),
											  ultimaRevisao);
					return vei;
				}
				throw new Exception("Veiculo não localizado.");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void InserirController(Veiculo obj)
		{
			string mensagem = "";

			try
			{
				/*if(obj.Modelo == "")
				{
					mensagem = "Informar o modelo do veiculo" + Environment.NewLine;
				}

				if(obj.Renavam == "")
				{
					mensagem += "Informar o renavam" + Environment.NewLine;
				}


				if(mensagem != "")
				{
					throw new Exception(mensagem);
				}*/
				if (obj.CodMarca == 0)
				{
					throw new Exception("Selecione a marca do veículo.");
				}
				else
				{
					int.TryParse(obj.CodMarca.ToString(), out codMarca);
				}

				if (obj.Modelo == "")
				{
					throw new Exception("Informe o modelo do veículo.");
				}
				if (obj.Renavam.Length != 11)
				{
					throw new Exception("Informe um renavam válido.");
				}

				if (obj.DataAquisicao == null)
				{
					throw new Exception("Informe a data de aquisição do veículo.");
				}
				else
				{
					DateTime.TryParse(obj.DataAquisicao.ToString(), out dataAq);
				}

				if (obj.AnoFabricacao != "")
				{
					anoFab = Convert.ToInt32(obj.AnoFabricacao);

					if (System.DateTime.Now.Year - anoFab > 9)
					{
						throw new Exception("Não é possível cadastrar veículos com 9 anos ou mais de uso.");
					}
				}
				else
				{
					throw new Exception("Preencha o ano de fabricação do veículo.");
				}
				if (obj.KmInicial == "")
				{
					throw new Exception("Preenchar a quilometragem inicial do véiculo.");
				}
				DateTime.TryParse(obj.DataUltimaRevisão.ToString(), out ultimaRevisao);
				enumStatusVeiculo status;
				status = obj.Status;

				dao.InserirVeiculoDAO(codMarca, obj.Modelo, obj.Placa, obj.Renavam, (int)status, dataAq, obj.AnoFabricacao, obj.KmInicial, obj.KmAtual,
									  obj.KmPrev, ultimaRevisao);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public List<Veiculo> ListasController(Veiculo obj)
		{
			try
			{
				DataTable table = dao.CarregarVeiculoDAO();

				if (table == null)
				{
					throw new Exception("Não foi possível localizar registro.");
				}
				List<Veiculo> lista = new List<Veiculo>();

				foreach (DataRow item in table.Rows)
				{
					int.TryParse(table.Rows[0]["Cod_Marca"].ToString(), out codMarca);
					int.TryParse(table.Rows[0]["Cod_Status"].ToString(), out codStatus);

					DateTime.TryParse(table.Rows[0]["Data_Aquisicao"].ToString(), out dataAq);
					DateTime.TryParse(obj.DataUltimaRevisão.ToString(), out ultimaRevisao);

					Veiculo vei = new Veiculo(Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]),
											   codMarca,
											  table.Rows[0]["Modelo"].ToString(),
											  table.Rows[0]["Placa"].ToString(),
											  table.Rows[0]["Renavam"].ToString(),
											  (enumStatusVeiculo)codStatus, dataAq,
											  table.Rows[0]["Ano_Fabricacao"].ToString(),
											  table.Rows[0]["Km_Inicial"].ToString(),
											  table.Rows[0]["KM_Atual"].ToString(),
											  table.Rows[0]["KM_Prevencao"].ToString(),
											  ultimaRevisao);

					lista.Add(vei);
				}
				return lista;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarComboVeiculo()
		{
			try
			{
				return dao.CarregarVeiculoDAO();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarVeiculoManu()
		{
			try
			{
				return dao.CarregarVeiculoManutencaoDAO();
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
