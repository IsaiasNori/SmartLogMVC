using SmartLogBusiness.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.DAL
{
	public class TipoClienteDAO:ConexaoBanco
	{
		public DataTable CarregarTipoClienteDAO()
		{
			AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "COMB");

			return ExecuteProcedure("pTipoCliente");
		}
	}
}
