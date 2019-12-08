using SmartLogBusiness.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.DAL
{
	public class VeiculoDAO : ConexaoBanco
	{
		public bool InserirVeiculoDAO(int codMarca, string modelo, string placa, string renavam, int codStatus, DateTime dataAquisicao, string anoFab,string kmInicial,string kmAtual, string kmPrev, DateTime? ultimaRevisao)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "INSE");
				AdicionarParametro("@CodMarca", SqlDbType.Int, 10, codMarca);
				AdicionarParametro("@Modelo", SqlDbType.NVarChar, 20, modelo);
				AdicionarParametro("@Renavam", SqlDbType.NVarChar, 11, renavam);
				AdicionarParametro("@CodStatus", SqlDbType.Int, 10, codStatus);
				AdicionarParametro("@DataAq", SqlDbType.Date, 10, dataAquisicao);
				AdicionarParametro("@AnoFab", SqlDbType.NVarChar, 4, anoFab);
				AdicionarParametro("@KmAtual", SqlDbType.NVarChar, 10, kmAtual);
				AdicionarParametro("@KmPrev", SqlDbType.NVarChar, 10, kmPrev);
				AdicionarParametro("@UltimaRev", SqlDbType.Date, 10, ultimaRevisao);
				AdicionarParametro("@KmInicial", SqlDbType.NVarChar,10, kmInicial);
				AdicionarParametro("@Placa", SqlDbType.NVarChar, 7, placa);


				ExecuteProcedure("pVeiculo");

				return true;
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}


		}
		public bool AlterarVeiculoDAO(int codVei, int codMarca, string modelo, string placa,string renavam, int codStatus, DateTime dataAquisicao, string anoFab, string kmInicial,string kmAtual, string kmPrev, DateTime? ultimaRevisao)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "ALTE");
				AdicionarParametro("@CodVei", SqlDbType.Int, 10, codVei);
				AdicionarParametro("@CodMarca", SqlDbType.Int, 10, codMarca);
				AdicionarParametro("@Modelo", SqlDbType.NVarChar, 20, modelo);
				AdicionarParametro("@Renavam", SqlDbType.NVarChar, 11, renavam);
				AdicionarParametro("@CodStatus", SqlDbType.Int, 10, codStatus);
				AdicionarParametro("@DataAq", SqlDbType.Date, 10, dataAquisicao);
				AdicionarParametro("@AnoFab", SqlDbType.NVarChar, 4, anoFab);
				AdicionarParametro("@KmAtual", SqlDbType.NVarChar, 10, kmAtual);
				AdicionarParametro("@KmPrev", SqlDbType.NVarChar, 10, kmPrev);
				AdicionarParametro("@UltimaRev", SqlDbType.Date, 10, ultimaRevisao);
				AdicionarParametro("@KmInicial", SqlDbType.NVarChar, 10, kmInicial);
				AdicionarParametro("@Placa", SqlDbType.NVarChar, 7, placa);

				ExecuteProcedure("pVeiculo");

				return true;

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public bool DeletarVeiculoDAO(int codVeiculo)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "DELE");
				AdicionarParametro("@CodVei", SqlDbType.Int, 10, codVeiculo);

				ExecuteProcedure("pVeiculo");

				return true;
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable FiltrarVeiculoDAO(int codMarca, string modelo)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "GRID");
				AdicionarParametro("@CodMarca", SqlDbType.Int, 10, codMarca);
				AdicionarParametro("@Modelo", SqlDbType.NVarChar, 20, modelo);

				return ExecuteProcedure("pVeiculo");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarVeiculoDAO()
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "COMB");


				return ExecuteProcedure("pVeiculo");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarVeiculoManutencaoDAO()
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "MANU");


				return ExecuteProcedure("pVeiculo");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable ObterVeiculoDAO(int codVei)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "OBTE");
				AdicionarParametro("@CodVei", SqlDbType.Int, 10, codVei);

				return ExecuteProcedure("pVeiculo");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}


	}
}

