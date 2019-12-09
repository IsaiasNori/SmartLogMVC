using SmartLogBusiness.DAO;
using SmartLogBusiness.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.DAL
{
	public class ManutencaoDAO : ConexaoBanco
	{
		public void InserirManutencaoDAO(DateTime? dataEntrada, DateTime? prevSaida, string descricao, int codVei, EnumStatusManutencao codStatusManutencao)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "INSE");
				AdicionarParametro("@DataEntrada", SqlDbType.Date, 10, dataEntrada);
				AdicionarParametro("@PrevSaida", SqlDbType.Date, 10, prevSaida);
				AdicionarParametro("@DescServico", SqlDbType.NVarChar, 100, descricao);
				AdicionarParametro("@CodVeic", SqlDbType.Int, 10, codVei);
                AdicionarParametro("@codStatusManutencao", SqlDbType.Int, 10, codStatusManutencao);

                ExecuteProcedure("pManutencao");

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public void AlterarManutencaoDAO(int codManu, DateTime? dataEntrada, DateTime? prevSaida, string descricao, int codVeiculo, EnumStatusManutencao codStatusManutencao)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "ALTE");
				AdicionarParametro("@CodManu", SqlDbType.Int, 10, codManu);
				AdicionarParametro("@DataEntrada", SqlDbType.Date, 10, dataEntrada);
				AdicionarParametro("@PrevSaida", SqlDbType.Date, 10, prevSaida);
				AdicionarParametro("@DescServico", SqlDbType.NVarChar, 100, descricao);
				AdicionarParametro("@CodVeic", SqlDbType.Int, 10, codVeiculo);
                AdicionarParametro("@codStatusManutencao", SqlDbType.Int, 10, codStatusManutencao);


                ExecuteProcedure("pManutencao");

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public void DeletarManutencaoDAO(int codManu)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "DELE");
				AdicionarParametro("@CodManu", SqlDbType.Int, 10, codManu);

				ExecuteProcedure("pManutencao");

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarManuVeiculoDAO(int codVeiculo)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "CONV");
				AdicionarParametro("@CodVeic", SqlDbType.Int, 10, codVeiculo);

				return ExecuteProcedure("pManutencao");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable GridManutencaoDAO(DateTime? dataEntrada, DateTime? prevSaida, string descServico, DateTime? dataEntradaFinal,DateTime? prevSaidaFinal)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "GRID");
				AdicionarParametro("@DataEntrada", SqlDbType.DateTime, 10, dataEntrada);
				AdicionarParametro("@DataEntradaFinal", SqlDbType.DateTime, 10, dataEntradaFinal);
				AdicionarParametro("@PrevSaida", SqlDbType.DateTime, 10, prevSaida);
				AdicionarParametro("@PrevSaidaFinal", SqlDbType.DateTime, 10, prevSaidaFinal);
				AdicionarParametro("@DescServico", SqlDbType.NVarChar, 100, descServico);

				return ExecuteProcedure("pManutencao");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarManutencaoDAO(int codManu)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "OBTE");
				AdicionarParametro("@CodManu", SqlDbType.Int, 10, codManu);

				return ExecuteProcedure("pManutencao");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}

