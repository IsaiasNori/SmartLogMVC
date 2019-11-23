using SmartLogBusiness.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SmartLogBusiness.DAL
{
	public class EstadoDAO: ConexaoBanco
	{
		public DataTable CarregarEstadoDAO()
		{
			AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "COMB");

			return ExecuteProcedure("pEstado");
		}
	
	}
}
