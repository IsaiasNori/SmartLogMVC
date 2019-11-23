using SmartLogBusiness.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.DAL
{
	public class TipoDeCargoDAO : ConexaoBanco
	{
		public DataTable CarregarCargoDAO()
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "COMB");

				return ExecuteProcedure("pTipoCargo");

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public bool InserirCargo(string cargo)
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "INSE");
				AdicionarParametro("@Cargo", SqlDbType.NVarChar, 20, cargo);

				ExecuteProcedure("pTipoCargo");

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}
		public void AlterarCargo(int codCargo, string cargo)
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "ALTE");
				AdicionarParametro("@CodCargo", SqlDbType.Int, 10, codCargo);
				AdicionarParametro("@Cargo", SqlDbType.NVarChar, 20, cargo);

				ExecuteProcedure("pTipoCargo");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void DeletarCargo(int codCargo)
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "DELE");
				AdicionarParametro("@CodCargo", SqlDbType.Int, 10, codCargo);

				ExecuteProcedure("TipoCargo");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
