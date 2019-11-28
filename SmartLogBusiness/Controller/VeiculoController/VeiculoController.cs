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
		public void AlterarController(Veiculo obj)
		{
			try
			{
				if (obj.CodVei == 0)
				{
					throw new Exception("Necessário informar código do veículo para alteração de registro.");
				}
				dao.AlterarVeiculoDAO(obj.CodVei, obj.CodMarca, obj.Modelo, obj.Renavam, Convert.ToInt32(obj.Status), obj.DataAquisicao, obj.AnoFabricacao.ToString(),  obj.KmAtual.ToString(), obj.KmPrev, obj.DataUltimaRevisão);
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
				if(obj.CodVei == 0)
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
				
				if(table != null)
				{
					Veiculo vei = new Veiculo(Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]),
											  Convert.ToInt32(table.Rows[0]["Cod_Marca"]),
											  table.Rows[0]["Modelo"].ToString(),
											  table.Rows[0]["Renavam"].ToString(),
											  (enumStatusVeiculo)table.Rows[0]["Cod_Status"],
											  Convert.ToDateTime( table.Rows[0]["Data_Aquisicao"]),
											  table.Rows[0]["Ano_Fabricacao"].ToString(),
											  table.Rows[0]["KM_Atual"].ToString(),
											  table.Rows[0]["KM_Prevencao"].ToString(),
											  Convert.ToDateTime(table.Rows[0]["Ultima_Revisao"])
											  );
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

				if(obj.Modelo == "")
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
				}


				dao.InserirVeiculoDAO(obj.CodMarca, obj.Modelo, obj.Renavam, Convert.ToInt32(obj.Status), obj.DataAquisicao, obj.AnoFabricacao.ToString(), obj.KmAtual.ToString(), obj.KmPrev, obj.DataUltimaRevisão);
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
				
				if(table == null)
				{
					throw new Exception("Não foi possível localizar registro.");
				}
				List<Veiculo> lista = new List<Veiculo>();

				foreach(DataRow item in table.Rows)
				{
					Veiculo vei = new Veiculo(Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]),
											  Convert.ToInt32(table.Rows[0]["Cod_Marca"]),
											  table.Rows[0]["Modelo"].ToString(),
											  table.Rows[0]["Renavam"].ToString(),
											  (enumStatusVeiculo)table.Rows[0]["Cod_Status"],
											  Convert.ToDateTime(table.Rows[0]["Data_Aquisicao"]),
											  table.Rows[0]["Ano_Fabricacao"].ToString(),
											  table.Rows[0]["KM_Atual"].ToString(),
											  table.Rows[0]["KM_Prevencao"].ToString(),
											  Convert.ToDateTime(table.Rows[0]["Ultima_Revisao"])
											  );

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
	}
}
