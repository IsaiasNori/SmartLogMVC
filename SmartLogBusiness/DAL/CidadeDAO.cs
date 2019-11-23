using SmartLogBusiness.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SmartLogBusiness.DAL
{
	public class CidadeDAO: ConexaoBanco
	{
		public DataTable CarregarCidadeDAO (int codEstado)
		{
			AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "COMB");
			AdicionarParametro("@CodEstado", SqlDbType.Int, 10, codEstado);

			return ExecuteProcedure("pCidade");
					
		}

	}
}
