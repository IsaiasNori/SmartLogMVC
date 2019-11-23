using SmartLogBusiness.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.DAL.VeiculoDAL
{
	public class MarcaVeiculoDAO : ConexaoBanco
	{
		public DataTable CarregarComboMarcaDAO()
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "COMB");

				return ExecuteProcedure("pMarca");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public void InserirMarcaDAO(string descricao)
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "INSE");
				AdicionarParametro("@Descricao", SqlDbType.NVarChar, 20, descricao);

				ExecuteProcedure("pMarca");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public void AlterarMarcaDAO(int codMarca, string descricao)
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "ALTE");
				AdicionarParametro("@CodMarca", SqlDbType.Int, 10, codMarca);
				AdicionarParametro("@Descricao", SqlDbType.NVarChar, 20, descricao);

				ExecuteProcedure("pMarca");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public void DeletarMarcaDAO(int codMarca)
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "DELE");
				AdicionarParametro("@CodMarca", SqlDbType.Int, 10, codMarca);

				ExecuteProcedure("pMarca");
				
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
