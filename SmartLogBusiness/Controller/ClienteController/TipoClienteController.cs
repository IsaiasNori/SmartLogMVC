using SmartLogBusiness.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class TipoClienteController
	{
		public DataTable CarregarTipoClienteController()
		{
			TipoClienteDAO dao = new TipoClienteDAO();

			return dao.CarregarTipoClienteDAO();

		}
	}
}
