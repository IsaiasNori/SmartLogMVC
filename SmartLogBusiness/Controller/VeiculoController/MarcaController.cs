using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL.VeiculoDAL;
using SmartLogBusiness.Model.Entidade.veiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class MarcaController : IControllerBase<Marca>
	{
		MarcaVeiculoDAO dao = new MarcaVeiculoDAO();
		public List<Marca> ListasController(Marca obj)
		{
			try
			{
				DataTable table = dao.CarregarComboMarcaDAO();
				List<Marca> lista = new List<Marca>();
				if (table == null)
				{
					throw new Exception("Registro não localiado.");
				}
				foreach (DataRow item in table.Rows)
				{
					Marca marca = new Marca(Convert.ToInt32(table.Rows[0]["Cod_Marca"]), table.Rows[0]["Descricao"].ToString());

					lista.Add(marca);
				}
				return lista;
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public List<Marca> ListasController()
		{
			try
			{
				DataTable table = dao.CarregarComboMarcaDAO();
				List<Marca> lista = new List<Marca>();
				if (table == null)
				{
					throw new Exception("Registro não localiado.");
				}
				foreach (DataRow item in table.Rows)
				{
					Marca marca = new Marca(Convert.ToInt32(item["Cod_Marca"]), item["Descricao"].ToString());

					lista.Add(marca);
				}
				return lista;
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}


		public void AlterarController(Marca obj)
		{
			try
			{
				if (obj.CodMarca == 0)
				{
					throw new Exception("Favor informar o codigo para efetuar alteração do registro.");
				}
				dao.AlterarMarcaDAO(obj.CodMarca, obj.Descricao);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public void DeletarController(Marca obj)
		{
			try
			{
				if(obj.CodMarca == 0)
				{
					throw new Exception("Favor informar o códig para a exclusão do registro.");
				}
				dao.DeletarMarcaDAO(obj.CodMarca);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	
		public Marca GetObj(Marca obj)
		{
			throw new NotImplementedException();
		}

		public void InserirController(Marca obj)
		{
			try
			{
				if(obj.Descricao == "")
				{
					throw new Exception("Favor inserir no campo para efetuar registro.");
				}
				dao.InserirMarcaDAO(obj.Descricao);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarComborMarcaController()
		{
			try
			{
				return dao.CarregarComboMarcaDAO();
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
