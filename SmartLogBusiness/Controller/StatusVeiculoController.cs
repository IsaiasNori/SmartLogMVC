using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL;
using SmartLogBusiness.Model.Entidade.veiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	
	public class StatusVeiculoController : IControllerBase<enumStatusVeiculo>
	{
		StatusVeiculoDAO dao = new StatusVeiculoDAO();
		public void AlterarController(StatusVeiculo obj)
		{
			throw new NotImplementedException();
		}

		public void DeletarController(StatusVeiculo obj)
		{
			throw new NotImplementedException();
		}

		public DataTable GetDataTable(StatusVeiculo obj)
		{
			throw new NotImplementedException();
		}

		public StatusVeiculo GetObj(StatusVeiculo obj)
		{
			throw new NotImplementedException();
		}

		public void InserirController(StatusVeiculo obj)
		{
			throw new NotImplementedException();
		}

		public List<StatusVeiculo> ListasController(StatusVeiculo obj)
		{
			throw new NotImplementedException();
		}
	}
}
