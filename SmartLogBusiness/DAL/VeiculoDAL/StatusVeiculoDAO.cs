using SmartLogBusiness.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.DAL
{
	public class StatusVeiculoDAO : ConexaoBanco
	{
		public DataTable CarregarStatusVeiculoDAO()
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "COMB");

				return ExecuteProcedure("pStatusVeiculo");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
