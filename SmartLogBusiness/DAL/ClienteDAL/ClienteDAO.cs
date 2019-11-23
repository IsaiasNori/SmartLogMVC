using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SmartLogBusiness.DAO;

namespace SmartLog.DAO
{
	public class ClienteDAO : ConexaoBanco
	{
		public int InserirClienteDAO(string nome, DateTime? dataNasc, string telCli, string emailCli, string cpfCnpjCli, int? codTipoCli, string cep, string logra, int numero, string bairro, int codCidade, int codEstado)
		{
			try
			{

				LimparParametro();
				AdicionarParametro("@Operaco", SqlDbType.NVarChar, 4, "INSE");
				AdicionarParametro("@NomeCli", SqlDbType.NVarChar, 100, nome);
				AdicionarParametro("@DataNasc", SqlDbType.Date, 10, dataNasc);
				AdicionarParametro("@TelCli", SqlDbType.NVarChar, 14, telCli);
				AdicionarParametro("@EmailCli", SqlDbType.NVarChar, 40, emailCli);
				AdicionarParametro("@CpfCnpj", SqlDbType.NVarChar, 20, cpfCnpjCli);
				AdicionarParametro("@CodTipoCli", SqlDbType.Int, 10, codTipoCli);
				AdicionarParametro("@Cep", SqlDbType.NVarChar, 10, cep);
				AdicionarParametro("@Logra", SqlDbType.NVarChar, 100, logra);
				AdicionarParametro("@Num", SqlDbType.Int, 10, numero);
				AdicionarParametro("@Bairro", SqlDbType.NVarChar, 50, bairro);
				AdicionarParametro("@CodCidade", SqlDbType.Int, 10, codCidade);
				AdicionarParametro("@CodEstado", SqlDbType.Int, 10, codEstado);


				DataTable reader = ExecuteProcedure("pCliente");

				string codigoString = reader.Rows[0]["CODCLI"].ToString();

				int codigo;

				int.TryParse(codigoString, out codigo);

				return codigo;

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}

		}

		public void DeletarClienteDAO(int codCli)
		{
			try
			{
				AdicionarParametro("@peracao", SqlDbType.NVarChar, 4, "DELE");
				AdicionarParametro("@CodCLi", SqlDbType.Int, 10, codCli);

				ExecuteProcedure("pCliente");


			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public void AlterarClienteDAO(int codCli, string nome, DateTime? date, string telCli, string emailCli, string cpfCnpjCli, int? codTipoCli, string cep, string logra, int numero, string bairro, int codCidade, int codEstado)
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "ALTE");
				AdicionarParametro("@CodCli", SqlDbType.Int, 10, codCli);
				AdicionarParametro("@NomeCli", SqlDbType.NVarChar, 100, nome);
				AdicionarParametro("@DataNasc", SqlDbType.Date, 10, date);
				AdicionarParametro("@TelCli", SqlDbType.NVarChar, 14, telCli);
				AdicionarParametro("@EmailCli", SqlDbType.NVarChar, 40, emailCli);
				AdicionarParametro("@CpfCnpjCli", SqlDbType.NVarChar, 20, cpfCnpjCli);
				AdicionarParametro("@CodTipoCli", SqlDbType.Int, 10, codTipoCli);
				AdicionarParametro("@Cep", SqlDbType.NVarChar, 10, cep);
				AdicionarParametro("@Logra", SqlDbType.NVarChar, 100, logra);
				AdicionarParametro("@Num", SqlDbType.Int, 10, numero);
				AdicionarParametro("@Bairro", SqlDbType.NVarChar, 50, bairro);
				AdicionarParametro("@CodCidade", SqlDbType.Int, 10, codCidade);
				AdicionarParametro("@CodEstado", SqlDbType.Int, 10, codEstado);


				ExecuteProcedure("pCliente");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}

		}

		public DataTable ObterClienteDAO(int codCli)
		{
			try
			{
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "OBTE");
				AdicionarParametro("@CodCli", SqlDbType.Int, 10, codCli);

				return ExecuteProcedure("pCliente");

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable FiltrarClienteDAO(string nome, string cpfCnpj)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "GRID");
				AdicionarParametro("@NomeCli", SqlDbType.NVarChar, 100, nome);
				AdicionarParametro("@CpfCnpj", SqlDbType.NVarChar, 20, cpfCnpj);

				return ExecuteProcedure("pCliente");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

	}
}
