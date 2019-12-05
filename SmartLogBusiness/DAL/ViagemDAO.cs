using SmartLogBusiness.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.DAL
{
	public class ViagemDAO : ConexaoBanco
	{
		public bool InserirViagemDAO(DateTime? dataViagem, string distancia, decimal valor,
			string cepOrigem, string lograOrigem, int numOrigem, string compleOrigem, string bairroOrigem, string cidadeOrigem, string ufOrigem,
			string cepDestino, string lograDestino, int numDestino, string compleDestino, string bairroDestino, string cidadeDestino, string ufDestino,
			int codCli, int codVeiculo, int codMotorista, int codAtendente, int status)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "INSE");
				AdicionarParametro("@DataVi", SqlDbType.DateTime, 10, dataViagem);
				AdicionarParametro("@DistanciaKm", SqlDbType.NVarChar, 10, distancia);
				AdicionarParametro("@Valor", SqlDbType.Decimal, 18, valor);
				AdicionarParametro("@CepOrig", SqlDbType.NVarChar, 10, cepOrigem);
				AdicionarParametro("@LograOrig", SqlDbType.NVarChar, 100, lograOrigem);
				AdicionarParametro("@NumOrig", SqlDbType.Int, 10, numOrigem);
				AdicionarParametro("@CompleOrig", SqlDbType.NVarChar, 100, compleOrigem);
				AdicionarParametro("@BairroOrig", SqlDbType.NVarChar, 50, bairroOrigem);
				AdicionarParametro("@CidadeOrig", SqlDbType.NVarChar, 50, cidadeOrigem);
				AdicionarParametro("@UfOrig", SqlDbType.NVarChar, 2, ufOrigem);
				AdicionarParametro("@CepDest", SqlDbType.NVarChar, 10, cepDestino);
				AdicionarParametro("@LograDest", SqlDbType.NVarChar, 100, lograDestino);
				AdicionarParametro("@NumDest", SqlDbType.Int, 10, numDestino);
				AdicionarParametro("@CompleDest", SqlDbType.NVarChar, 100, compleDestino);
				AdicionarParametro("@BairroDest", SqlDbType.NVarChar, 50, bairroDestino);
				AdicionarParametro("@CidadeDest", SqlDbType.NVarChar, 50, cidadeDestino);
				AdicionarParametro("@UfDest", SqlDbType.NVarChar, 2, ufDestino);
				AdicionarParametro("@CodCli", SqlDbType.Int, 10, codCli);
				AdicionarParametro("@CodVei", SqlDbType.Int, 10, codVeiculo);
				AdicionarParametro("@CodAte", SqlDbType.Int, 10, codAtendente);
				AdicionarParametro("@CodMot", SqlDbType.Int, 10, codMotorista);
				AdicionarParametro("Status", SqlDbType.Int, 10, status);

				ExecuteProcedure("pViagem");

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public bool AlterarViagemDAO(int codVi,DateTime? dataViagem, string distancia, decimal valor,
			string cepOrigem, string lograOrigem, int numOrigem, string compleOrigem, string bairroOrigem, string cidadeOrigem, string ufOrigem,
			string cepDestino, string lograDestino, int numDestino, string compleDestino, string bairroDestino, string cidadeDestino, string ufDestino,
			int codCli, int codVeiculo, int codMotorista, int codAtendente, int status)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "ALTE");
				AdicionarParametro("@CodVi", SqlDbType.Int, 10, codVi);
				AdicionarParametro("@DataVi", SqlDbType.DateTime, 10, dataViagem);
				AdicionarParametro("@DistanciaKm", SqlDbType.NVarChar, 10, distancia);
				AdicionarParametro("@Valor", SqlDbType.Decimal, 18, valor);
				AdicionarParametro("@CepOrig", SqlDbType.NVarChar, 10, cepOrigem);
				AdicionarParametro("@LograOrig", SqlDbType.NVarChar, 100, lograOrigem);
				AdicionarParametro("@NumOrig", SqlDbType.Int, 10, numOrigem);
				AdicionarParametro("@CompleOrig", SqlDbType.NVarChar, 100, compleOrigem);
				AdicionarParametro("@BairroOrig", SqlDbType.NVarChar, 50, bairroOrigem);
				AdicionarParametro("@CidadeOrig", SqlDbType.NVarChar, 50, cidadeOrigem);
				AdicionarParametro("@UfOrig", SqlDbType.NVarChar, 2, ufOrigem);
				AdicionarParametro("@CepDest", SqlDbType.NVarChar, 10, cepDestino);
				AdicionarParametro("@LograDest", SqlDbType.NVarChar, 100, lograDestino);
				AdicionarParametro("@NumDest", SqlDbType.Int, 10, numDestino);
				AdicionarParametro("@CompleDest", SqlDbType.NVarChar, 100, compleDestino);
				AdicionarParametro("@BairroDest", SqlDbType.NVarChar, 50, bairroDestino);
				AdicionarParametro("@CidadeDest", SqlDbType.NVarChar, 50, cidadeDestino);
				AdicionarParametro("@UfDest", SqlDbType.NVarChar, 2, ufDestino);
				AdicionarParametro("@CodCli", SqlDbType.Int, 10, codCli);
				AdicionarParametro("@CodVei", SqlDbType.Int, 10, codVeiculo);
				AdicionarParametro("@CodAte", SqlDbType.Int, 10, codAtendente);
				AdicionarParametro("@CodMot", SqlDbType.Int, 10, codMotorista);
				AdicionarParametro("@Status", SqlDbType.Int, 10, status);

				ExecuteProcedure("pViagem");

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public bool DeletarViagemDao(int codViagem)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "DELE");
				AdicionarParametro("@CodVi", SqlDbType.Int, 10, codViagem);

				ExecuteProcedure("pViagem");

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public DataTable FiltrarViagemDAO(DateTime? data, DateTime? dataFinal, int codMotorista, int codCliente)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "GRID");
				AdicionarParametro("@DataVi", SqlDbType.DateTime, 10, data);
				AdicionarParametro("@DataViFinal", SqlDbType.DateTime, 10, dataFinal);
				AdicionarParametro("@CodMot", SqlDbType.Int, 10, codMotorista);
				AdicionarParametro("@CodCli", SqlDbType.Int, 10, codCliente);

				return ExecuteProcedure("pViagem");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarViagemDAO(int codVi)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "OBTE");
				AdicionarParametro("@CodVi", SqlDbType.Int, 10, codVi);

				return ExecuteProcedure("pViagem");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

	}
}
