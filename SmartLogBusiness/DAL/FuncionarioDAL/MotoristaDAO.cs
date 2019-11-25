using SmartLogBusiness.DAO;
using SmartLogBusiness.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.DAL.FuncionarioDAL
{
	public class MotoristaDAO : ConexaoBanco
	{
		public void InserirMotoristaDAO(string nome, DateTime? dataNasc, EnumCnhCategoriaMotorista? cnhCat, string cnhNum, DateTime? cnhVenc, string tel,string email,int status,string cep,string logra,int num,string bairro,int codCidade,int codEstado)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "INSE");
				AdicionarParametro("@Nome", SqlDbType.NVarChar, 100, nome);
				AdicionarParametro("@DataNasc", SqlDbType.DateTime, 10, dataNasc);
				AdicionarParametro("@CnhCat", SqlDbType.NVarChar, 2, cnhCat);
				AdicionarParametro("@CnhNum", SqlDbType.NVarChar, 11, cnhNum);
				AdicionarParametro("@CnhVenc", SqlDbType.DateTime, 10, cnhVenc);
				AdicionarParametro("@Telefone", SqlDbType.NVarChar, 14, tel);
				AdicionarParametro("@Email", SqlDbType.NVarChar, 40, email);
				AdicionarParametro("@Status", SqlDbType.Int, 10, status);
				AdicionarParametro("@Cep", SqlDbType.NVarChar, 10, cep);
				AdicionarParametro("@Logra", SqlDbType.NVarChar, 100, logra);
				AdicionarParametro("@Num", SqlDbType.Int, 10, num);
				AdicionarParametro("@Bairro", SqlDbType.NVarChar, 40, bairro);
				AdicionarParametro("@CodCidade", SqlDbType.Int, 10, codCidade);
				AdicionarParametro("@CodEstado", SqlDbType.Int, 10, codEstado);

				ExecuteProcedure("pMotorista");

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public void AlterarMotoristaDAO(int cod,string nome, DateTime? dataNasc, EnumCnhCategoriaMotorista? cnhCat, string cnhNum, DateTime? cnhVenc, string tel, string email, int status, string cep, string logra, int num, string bairro, int codCidade, int codEstado)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "ALTE");
				AdicionarParametro("@CodMotorista", SqlDbType.Int, 10, cod);
				AdicionarParametro("@Nome", SqlDbType.NVarChar, 100, nome);
				AdicionarParametro("@DataNasc", SqlDbType.DateTime, 10, dataNasc);
				AdicionarParametro("@CnhCat", SqlDbType.NVarChar, 2, cnhCat);
				AdicionarParametro("@CnhNum", SqlDbType.NVarChar, 11, cnhNum);
				AdicionarParametro("@CnhVenc", SqlDbType.DateTime, 10, cnhVenc);
				AdicionarParametro("@Telefone", SqlDbType.NVarChar, 14, tel);
				AdicionarParametro("@Email", SqlDbType.NVarChar, 40, email);
				AdicionarParametro("@Status", SqlDbType.Int, 10, status);
				AdicionarParametro("@Cep", SqlDbType.NVarChar, 10, cep);
				AdicionarParametro("@Logra", SqlDbType.NVarChar, 100, logra);
				AdicionarParametro("@Num", SqlDbType.Int, 10, num);
				AdicionarParametro("@Bairro", SqlDbType.NVarChar, 40, bairro);
				AdicionarParametro("@CodCidade", SqlDbType.Int, 10, codCidade);
				AdicionarParametro("@CodEstado", SqlDbType.Int, 10, codEstado);


				ExecuteProcedure("pMotorista");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public void DeletarMotoristaDAO(int cod)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "DELE");
				AdicionarParametro("@CodMotorista", SqlDbType.Int, 10, cod);

				ExecuteProcedure("pMotorista");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}

		}
		public  DataTable FiltrarMotoristaDAO(string nome, DateTime? cnhVenc, DateTime? cnhVencFinal)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "GRID");
				AdicionarParametro("@NomeMotorista", SqlDbType.NVarChar, 100, nome);
				AdicionarParametro("@CnhVenc", SqlDbType.Date, 10, cnhVenc);
				AdicionarParametro("@CnhVencFinal", SqlDbType.DateTime, 10, cnhVencFinal);

				return ExecuteProcedure("pMotorista");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarComboMotoristaDAO()
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "COMB");
				
				return ExecuteProcedure("pMotorista");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		public DataTable CarregarMotoristaDAO(int cod)
		{
			try
			{
				LimparParametro();
				AdicionarParametro("@Operacao", SqlDbType.NVarChar, 4, "OBTE");
				AdicionarParametro("@CodMotorista", SqlDbType.Int, 10, cod);

				return ExecuteProcedure("pMotorista");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
