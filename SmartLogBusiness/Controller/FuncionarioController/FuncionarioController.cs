using SmartLog.DAO;
using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.Model.Entidade;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;

namespace SmartLogBusiness.Controller
{
	public class FuncionarioController : IControllerBase<Funcionario>
	{
		FuncionarioDAO dao = new FuncionarioDAO();

		public void AlterarController(Funcionario obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Necessário informar o numero da matricula para efetuar alteração.");
				}
				dao.AlterarFuncionario(obj.Codigo, obj.Nome, obj.DataNasc, obj.Telefone, obj.Email,
									   obj.Cpf, Convert.ToInt32(obj.TipoCargo), obj.Endereco.Cep, obj.Endereco.Logradouro, obj.Endereco.Numero, obj.Endereco.Bairro, obj.Endereco.CodCidade, obj.Endereco.CodEstado);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void DeletarController(Funcionario obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Nessecário informar a matricula para excluir o registro.");
				}
				dao.DeletarFuncionario(obj.Codigo);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public DataTable GetDataTable(Funcionario obj)
		{
			try
			{
				DataTable table =  dao.FiltrarFuncionarioDAO(obj.Nome, obj.Cpf);

				return table;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public Funcionario GetObj(Funcionario obj)
		{
			try
			{
				DataTable table = dao.CarregarFuncionarioDAO(obj.Codigo);

				int numero, cidade, estado;
				DateTime dataNasc;

				if(obj.Codigo == 0)
				{
					throw new Exception("Insira o código para localizar viagem!");
				}

				if (table != null)
				{
					int.TryParse(table.Rows[0]["Numero"].ToString(), out numero);
					int.TryParse(table.Rows[0]["Cod_Cidade"].ToString(), out cidade);
					int.TryParse(table.Rows[0]["Cod_Estado"].ToString(), out estado);
					DateTime.TryParse(table.Rows[0]["Data_Nascimento"].ToString(), out dataNasc);

					Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
												table.Rows[0]["Logradouro"].ToString(),
												numero,
												table.Rows[0]["Bairro"].ToString(),
												cidade, estado);

					Funcionario func = new Funcionario(Convert.ToInt32(table.Rows[0]["Cod_Matricula"]),
													  table.Rows[0]["Nome_Funcionario"].ToString(),
													  table.Rows[0]["CPF_Funcionario"].ToString(),
													  dataNasc,
													  table.Rows[0]["Telefone_Funcionario"].ToString(),
													  table.Rows[0]["Email_Funcionario"].ToString(),
													  end, (EnumTipoCargo)Convert.ToInt32(table.Rows[0]["Cod_Cargo"]));

					return func;
				}
				else
				{
					throw new Exception("Funcionário não localizado");
				}

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public void InserirController(Funcionario obj)
		{
			try
			{
				dao.InserirFuncionario(obj.Nome, obj.DataNasc, obj.Telefone, obj.Email, obj.Cpf, Convert.ToInt32(obj.TipoCargo), obj.Endereco.Cep, obj.Endereco.Logradouro, obj.Endereco.Numero, obj.Endereco.Bairro, obj.Endereco.CodCidade, obj.Endereco.CodEstado);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public List<Funcionario> ListasController(Funcionario obj)
		{
			try
			{
				DataTable table = dao.FiltrarFuncionarioDAO(obj.Nome, obj.Cpf);
				List<Funcionario> lista = new List<Funcionario>();
				if (table == null)
				{
					throw new Exception("Funcionário não localizado.");
				}
				
				foreach (DataRow item in table.Rows)
				{
					Endereco end = new Endereco(item["Cep"].ToString(),
												item["Logradouro"].ToString(),
												Convert.ToInt32(item["Numero"]),
												item["Bairro"].ToString(),
												Convert.ToInt32(item["Cod_Cidade"]),
												Convert.ToInt32(item["Cod_Estado"]));

					Funcionario func = new Funcionario(Convert.ToInt32(item["Cod_Matricula"]),
												       item["Nome_Funcionario"].ToString(),
														item["CPF_Funcionario"].ToString(),
														Convert.ToDateTime(item["Data_Nascimento"]),
													   item["Telefone_Funcionario"].ToString(),
													   item["Email_Funcionario"].ToString(),
													 
													   end, (EnumTipoCargo)Convert.ToInt32(item["Cod_Cargo"]));

					lista.Add(func);
				}
				return lista;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public Funcionario LogarController(Funcionario obj)
		{
			try
			{
				if(obj.Email == "" || obj.Senha == "")
				{
					throw new Exception("Informe um usuário/senha.");
				}


				DataTable table = dao.LogarDAO(obj.Email,obj.Senha);
				

				if (table != null && table.Rows.Count != 0)
				{

					int numero;
					int.TryParse(table.Rows[0]["Numero"].ToString(), out numero);

					int cidade;
					int.TryParse(table.Rows[0]["Cod_Cidade"].ToString(), out cidade);
					int estado;
					int.TryParse(table.Rows[0]["Cod_Estado"].ToString(), out estado);

					DateTime data;
					DateTime.TryParse(table.Rows[0]["Data_Nascimento"].ToString(), out data);
					Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
												table.Rows[0]["Logradouro"].ToString(),
												numero,
												table.Rows[0]["Bairro"].ToString(),
												cidade, estado);



					int cargo;
					int.TryParse(table.Rows[0]["Cod_Cargo"].ToString(), out cargo);

					EnumTipoCargo tipo;

					if(cargo == 0)
					{
						tipo = EnumTipoCargo.Atendente;
					}
					else
					{
						tipo = (EnumTipoCargo)cargo;
					}

					Funcionario func = new Funcionario(Convert.ToInt32(table.Rows[0]["Cod_Matricula"]),
													  table.Rows[0]["Nome_Funcionario"].ToString(),
													  table.Rows[0]["CPF_Funcionario"].ToString(),
													  Convert.ToDateTime(table.Rows[0]["Data_nascimento"]),
													  table.Rows[0]["Telefone_Funcionario"].ToString(),
													  table.Rows[0]["Email_Funcionario"].ToString(),
													 
													  end, tipo);

					return func;
				}
				else
				{
					throw new Exception("Funcionário não localizado");
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
