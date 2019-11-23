using SmartLogBusiness.Model.Entidade.pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SmartLogBusiness.DAO;

namespace SmartLog.DAO
{
	public class FuncionarioDAO : ConexaoBanco
	{
		public decimal InserirFuncionario(String nomeFunc, DateTime? dataNascFunc, string telFunc, string emailFunc,  string cpfFunc, int codCargo, string cep, string logra, int numero, string bairro, int codCidade, int codEstado)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "INSE");
				AdicionarParametro("@NomeFunc", SqlDbType.NVarChar, 100, nomeFunc);
				AdicionarParametro("@DataNasc", SqlDbType.DateTime, 10, dataNascFunc);
				AdicionarParametro("@TelFunc", SqlDbType.NVarChar, 14, telFunc);
				AdicionarParametro("@EmailFunc", SqlDbType.NVarChar, 40, emailFunc);
				AdicionarParametro("@CpfFunc", SqlDbType.NVarChar, 20, cpfFunc);
				AdicionarParametro("@CodCargo", SqlDbType.Int, 10, codCargo);
				AdicionarParametro("@Cep", SqlDbType.NVarChar, 10, cep);
				AdicionarParametro("@Logra", SqlDbType.NVarChar, 100, logra);
				AdicionarParametro("@Num", SqlDbType.Int, 10, numero);
				AdicionarParametro("@Bairro", SqlDbType.NVarChar, 50, bairro);
				AdicionarParametro("@CodCidade", SqlDbType.Int, 10, codCidade);
				AdicionarParametro("@CodEstado", SqlDbType.Int, 10, codEstado);


				ExecuteProcedure("pFuncionario");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
			return 0;
		}

		public void AlterarFuncionario(int codFunc, String nomeFunc, DateTime? dataNascFunc, string telFunc, string emailFunc, string cpfFunc, int codCargo, string cep, string logra, int numero, string bairro, int codCidade, int codEstado)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "ALTE");
				AdicionarParametro("@CodMatricula", SqlDbType.NVarChar, 100, codFunc);
				AdicionarParametro("@NomeFunc", SqlDbType.NVarChar, 100, nomeFunc);
				AdicionarParametro("@DataNasc", SqlDbType.DateTime, 10, dataNascFunc);
				AdicionarParametro("@TelFunc", SqlDbType.NVarChar, 14, telFunc);
				AdicionarParametro("@EmailFunc", SqlDbType.NVarChar, 40, emailFunc);
				AdicionarParametro("@CpfFunc", SqlDbType.NVarChar, 20, cpfFunc);
				AdicionarParametro("@CodCargo", SqlDbType.Int, 10, codCargo);
				AdicionarParametro("@Cep", SqlDbType.NVarChar, 10, cep);
				AdicionarParametro("@Logra", SqlDbType.NVarChar, 100, logra);
				AdicionarParametro("@Num", SqlDbType.Int, 10, numero);
				AdicionarParametro("@Bairro", SqlDbType.NVarChar, 50, bairro);
				AdicionarParametro("@CodCidade", SqlDbType.Int, 10, codCidade);
				AdicionarParametro("@CodEstado", SqlDbType.Int, 10, codEstado);

				ExecuteProcedure("pFuncionario");
				
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public void DeletarFuncionario(int codFun)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "DELE");
				AdicionarParametro("@CodMatricula", SqlDbType.Int, 10, codFun);

				ExecuteProcedure("pFuncionario");
				
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable FiltrarFuncionarioDAO(int codFun, string nomeFunc, string cpfFunc)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "GRID");
				AdicionarParametro("@NomeFunc", SqlDbType.NVarChar, 100, nomeFunc);
				AdicionarParametro("@CpfFunc", SqlDbType.NVarChar, 15, cpfFunc);
				AdicionarParametro("@CodMatricula", SqlDbType.Int,10, codFun);

				return ExecuteProcedure("pFuncionario");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarFuncionarioDAO(int codFunc)
		{
			LimparParametro();
			AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "OBTE");
			AdicionarParametro("@CodMatricula", SqlDbType.Int, 10, codFunc);
			
			return ExecuteProcedure("pFuncionario");
		}
		public DataTable LogarDAO(string email, string senha)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "LOGA");
				AdicionarParametro("@EmailFunc", SqlDbType.NVarChar, 40, email);
				AdicionarParametro("@Senha", SqlDbType.NVarChar, 100, senha);

				return ExecuteProcedure("pFuncionario");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

	}
}
