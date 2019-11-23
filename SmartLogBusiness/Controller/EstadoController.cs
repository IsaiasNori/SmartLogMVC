using SmartLogBusiness.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class EstadoController
	{
		public DataTable CarregarEstado()
		{
			EstadoDAO dao = new EstadoDAO();

			return dao.CarregarEstadoDAO();
		}
	}
}
