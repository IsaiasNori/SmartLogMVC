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
		int codTipoCargo, numero, codCidade, codEstado;
		DateTime dataNasc;
		 
		public void AlterarController(Funcionario obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Necessário informar o numero da matricula para efetuar alteração.");
				}
				if (obj.Nome == "")
				{
					throw new Exception("É necessário informar nome do funcionário para salvar no sistema.");
				}
				if (obj.DataNasc.Value == System.DateTime.Now && obj.DataNasc.Value.Year < 15)
				{
					throw new Exception("Insira uma data de nascimento válida.");
				}
				else
				{
					DateTime.TryParse(obj.DataNasc.ToString(), out dataNasc);
				}
				if (obj.Email == "")
				{
					throw new Exception("Insira um endereço de e-mail válido.");
				}
				if (obj.Cpf.Length < 11 && obj.Cpf == "")
				{
					throw new Exception("É obrigatório preencher o CPF.");
				}
				if (obj.TipoCargo != null)
				{
					int.TryParse(obj.TipoCargo.ToString(), out codTipoCargo);
				}
				else
				{
					throw new Exception("É obrigatório selecionar um cargo para funcionário.");
				}
				int.TryParse(obj.Endereco.Numero.ToString(), out numero);
				int.TryParse(obj.Endereco.CodCidade.ToString(), out codCidade);
				int.TryParse(obj.Endereco.CodEstado.ToString(), out codEstado);
				DateTime.TryParse(obj.DataNasc.ToString(), out dataNasc);

				dao.AlterarFuncionario(obj.Codigo, obj.Nome, dataNasc, obj.Telefone, obj.Email,
									   obj.Cpf, Convert.ToInt32(obj.TipoCargo), obj.Endereco.Cep, obj.Endereco.Logradouro, numero, obj.Endereco.Bairro, codCidade,codEstado);
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
					throw new Exception("É necessário informar o código de  matricula para excluir o registro.");
				}
				dao.DeletarFuncionario(obj.Codigo);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

        public void AlterarSenha(int cod,string senha)
        {
            try
            {
                dao.AlterarSenha(cod, senha);
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
				DataTable table = dao.FiltrarFuncionarioDAO(obj.Nome, obj.Cpf);

				return table;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}


        public Funcionario VerificarFuncionario(string cpf,string email, DateTime DataNasci)
        {
            try
            {
                DataTable table = dao.VerificarFuncionario(email, cpf, DataNasci);

                if (table != null && table.Rows.Count > 0)
                {
                    int.TryParse(table.Rows[0]["Numero"].ToString(), out numero);
                    int.TryParse(table.Rows[0]["Cod_Cidade"].ToString(), out codCidade);
                    int.TryParse(table.Rows[0]["Cod_Estado"].ToString(), out codEstado);
                    DateTime.TryParse(table.Rows[0]["Data_Nascimento"].ToString(), out dataNasc);
                    int.TryParse(table.Rows[0]["Cod_Cargo"].ToString(), out codTipoCargo);

                    Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
                                                table.Rows[0]["Logradouro"].ToString(),
                                                numero,
                                                table.Rows[0]["Bairro"].ToString(),
                                                codCidade, codEstado);

                    Funcionario func = new Funcionario(Convert.ToInt32(table.Rows[0]["Cod_Matricula"]),
                                                      table.Rows[0]["Nome_Funcionario"].ToString(),
                                                      table.Rows[0]["CPF_Funcionario"].ToString(),
                                                      dataNasc,
                                                      table.Rows[0]["Telefone_Funcionario"].ToString(),
                                                      table.Rows[0]["Email_Funcionario"].ToString(),
                                                      end, (EnumTipoCargo)codTipoCargo);

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



        public Funcionario GetObj(Funcionario obj)
		{
			try
			{
				DataTable table = dao.CarregarFuncionarioDAO(obj.Codigo);

				if (obj.Codigo == 0)
				{
					throw new Exception("Insira o código para localizar funcionário!");
				}

				if (table != null)
				{
					int.TryParse(table.Rows[0]["Numero"].ToString(), out numero);
					int.TryParse(table.Rows[0]["Cod_Cidade"].ToString(), out codCidade);
					int.TryParse(table.Rows[0]["Cod_Estado"].ToString(), out codEstado);
					DateTime.TryParse(table.Rows[0]["Data_Nascimento"].ToString(), out dataNasc);
					int.TryParse(table.Rows[0]["Cod_Cargo"].ToString(), out codTipoCargo);

					Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
												table.Rows[0]["Logradouro"].ToString(),
												numero,
												table.Rows[0]["Bairro"].ToString(),
												codCidade, codEstado);

					Funcionario func = new Funcionario(Convert.ToInt32(table.Rows[0]["Cod_Matricula"]),
													  table.Rows[0]["Nome_Funcionario"].ToString(),
													  table.Rows[0]["CPF_Funcionario"].ToString(),
													  dataNasc,
													  table.Rows[0]["Telefone_Funcionario"].ToString(),
													  table.Rows[0]["Email_Funcionario"].ToString(),
													  end, (EnumTipoCargo)codTipoCargo);

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
				if(obj.Nome == "")
				{
					throw new Exception("É necessário informar nome do funcionário para cadastrar no sistema.");
				}
				if(obj.DataNasc.Value == System.DateTime.Now && obj.DataNasc.Value.Year < 15)
				{
					throw new Exception("Insira uma data de nascimento válida.");
				}
				else
				{
					DateTime.TryParse(obj.DataNasc.ToString(), out dataNasc);
				}
				if(obj.Email == "")
				{
					throw new Exception("Insira um endereço de e-mail válido, para obter um Usuário no sistema.");
				}
				if(obj.Cpf.Length < 11 || obj.Cpf == "")
				{
					throw new Exception("É obrigatório fornecer o CPF para o gerar sua primeira senha de acesso ao sistema.");
				}
				if(obj.TipoCargo != null)
				{
					int.TryParse(obj.TipoCargo.ToString(), out codTipoCargo);
				}
				else
				{
					throw new Exception("É obrigatório selecionar um cargo para funcionário.");
				}
				int.TryParse(obj.Endereco.Numero.ToString(), out numero);
				int.TryParse(obj.Endereco.CodCidade.ToString(), out codCidade);
				int.TryParse(obj.Endereco.CodEstado.ToString(), out codEstado);

				dao.InserirFuncionario(obj.Nome, dataNasc, obj.Telefone, obj.Email, obj.Cpf, codTipoCargo, obj.Endereco.Cep, obj.Endereco.Logradouro,numero, obj.Endereco.Bairro, codCidade, codEstado);
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
					int.TryParse(item["Numero"].ToString(), out numero);
					int.TryParse(item["Cod_Cidade"].ToString(),out codCidade);
					int.TryParse(item["Cod_Estado"].ToString(), out codEstado );
					int.TryParse(item["Cod_Cargo"].ToString(), out codTipoCargo);
					DateTime.TryParse(item["Data_Nascimento"].ToString(), out dataNasc);

					Endereco end = new Endereco(item["Cep"].ToString(),
												item["Logradouro"].ToString(),
												numero,
												item["Bairro"].ToString(),
												codCidade,codEstado);

					Funcionario func = new Funcionario(Convert.ToInt32(item["Cod_Matricula"]),
													   item["Nome_Funcionario"].ToString(),
													   item["CPF_Funcionario"].ToString(),
													   dataNasc,
													   item["Telefone_Funcionario"].ToString(),
													   item["Email_Funcionario"].ToString(),
													   end, (EnumTipoCargo)codTipoCargo);

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
				if (obj.Email == "" || obj.Senha == "")
				{
					throw new Exception("Informe um usuário/senha.");
				}

				DataTable table = dao.LogarDAO(obj.Email, obj.Senha);

				if (table != null && table.Rows.Count != 0)
				{
					
					int.TryParse(table.Rows[0]["Numero"].ToString(), out numero);
					
					int.TryParse(table.Rows[0]["Cod_Cidade"].ToString(), out codCidade);

					int.TryParse(table.Rows[0]["Cod_Estado"].ToString(), out codEstado);
					
					DateTime.TryParse(table.Rows[0]["Data_Nascimento"].ToString(), out dataNasc);

					Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
												table.Rows[0]["Logradouro"].ToString(),
												numero,
												table.Rows[0]["Bairro"].ToString(),
												codCidade, codEstado);
					
					int.TryParse(table.Rows[0]["Cod_Cargo"].ToString(), out codTipoCargo);

					EnumTipoCargo tipo;

					if (codTipoCargo == 0)
					{
						tipo = EnumTipoCargo.Atendente;
					}
					else
					{
						tipo = (EnumTipoCargo)codTipoCargo;
					}

					Funcionario func = new Funcionario(Convert.ToInt32(table.Rows[0]["Cod_Matricula"]),
													  table.Rows[0]["Nome_Funcionario"].ToString(),
													  table.Rows[0]["CPF_Funcionario"].ToString(),
													  dataNasc,
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
		public DataTable CarregarComboFuncionario()
		{
			try
			{
				return dao.CarregarComboFuncionario();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
