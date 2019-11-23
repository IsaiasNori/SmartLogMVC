using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL;
using SmartLogBusiness.DAO;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class TipoDeCargoController : IControllerBase<TipoCargo>
	{
		TipoDeCargoDAO dao = new TipoDeCargoDAO();

		public void AlterarController(TipoCargo obj)
		{
			try
			{
				if(obj.Cod == 0)
				{
					throw new Exception("Informar o codigo para efetuar alteração no registro.");
				}
				dao.AlterarCargo(obj.Cod, obj.DescricaoCargo);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void DeletarController(TipoCargo obj)
		{
			try
			{
				if(obj.Cod == 0)
				{
					throw new Exception("Informar o código para efetuar a exclusão do registro.");
				}
				dao.DeletarCargo(obj.Cod);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public DataTable GetDataTable(TipoCargo obj)
		{
			try
			{
				return dao.CarregarCargoDAO();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public TipoCargo GetObj(TipoCargo obj)
		{
			throw new NotImplementedException();

		}

		public void InserirController(TipoCargo obj)
		{
			try
			{
				if(obj.DescricaoCargo == "")
				{
					throw new Exception("Favor informar o nome do cargo para inserir um novo registro.");
				}
				dao.InserirCargo(obj.DescricaoCargo);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public List<TipoCargo> ListasController(TipoCargo obj)
		{
			try
			{
				DataTable table = dao.CarregarCargoDAO();
				List<TipoCargo> lista = new List<TipoCargo>();
				if(table == null)
				{
					throw new Exception("Não foi localizado registro.");
				}
				foreach(DataRow item in table.Rows)
				{
					TipoCargo cargo = new TipoCargo(Convert.ToInt32(table.Rows[0]["Cod_Cargo"]), table.Rows[0]["Cargo"].ToString());

					lista.Add(cargo);
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
