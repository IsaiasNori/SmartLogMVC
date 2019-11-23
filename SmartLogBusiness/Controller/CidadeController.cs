using SmartLogBusiness.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class CidadeController
	{
		CidadeDAO dao = new CidadeDAO();

		public DataTable CarregarCidadeController(int codEstado)
		{
			DataTable tt = new DataTable();

			tt = dao.CarregarCidadeDAO(codEstado);

			return tt;
		}

	}
}
