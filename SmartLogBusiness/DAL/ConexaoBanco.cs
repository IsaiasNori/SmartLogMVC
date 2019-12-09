using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SmartLogBusiness.DAO
{
	public abstract class ConexaoBanco
	{
		public SqlConnection conexao = new SqlConnection(@"data source = DESKTOP-VH369CI\SQLEXPRESS; initial catalog = SmartLog; user = sa; pwd= bunny");
		public SqlCommand comando = new SqlCommand();
		public string msgErro;

		protected void LimparParametro()
		{

			comando.Parameters.Clear();
		}
		protected void AdicionarParametro(string nomeParametro, SqlDbType tipo, int tamanho, object valor)
		{
			SqlParameter parameter = new SqlParameter(nomeParametro, tipo, tamanho);
			parameter.Value = valor;
			comando.Parameters.Add(parameter);
		}
		protected DataTable ExecuteProcedure(string sql)
		{
			DataTable table = new DataTable();
			SqlDataReader retorno;
			try
			{
				comando.Connection = conexao;

				if (conexao.State != ConnectionState.Open)
				{
					conexao.Open();
				}

				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.CommandText = sql;

				retorno = comando.ExecuteReader();
				table.Load(retorno);
				conexao.Close();

				return table;


			}
			catch (Exception ex)
			{
				msgErro = ex.Message;
				throw new Exception(ex.Message);

			}


		}

		protected SqlDataReader ExecuteProcedureReader(string sql)
		{
			DataTable table = new DataTable();
			SqlDataReader retorno;
			try
			{
				comando.Connection = conexao;
				conexao.Open();
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.CommandText = sql;

				retorno = comando.ExecuteReader();
				conexao.Close();

				return retorno;


			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}


		}
		protected bool execute(string sql)
		{
			try
			{


				comando.Connection = conexao;
				conexao.Open();
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = sql;

				comando.ExecuteNonQuery();
				conexao.Close();

				return true;

			}
			catch (Exception)
			{

				return false;
			}


		}

	}
}
