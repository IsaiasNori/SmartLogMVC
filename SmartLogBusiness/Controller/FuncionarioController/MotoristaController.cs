using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL.FuncionarioDAL;
using SmartLogBusiness.Model.Entidade;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class MotoristaController : IControllerBase<Motorista>
	{
		MotoristaDAO dao = new MotoristaDAO();
		DateTime dataNasc, cnhVencimento;
		int   codCidade, codEstado, numero;

		public void AlterarController(Motorista obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Necessário informar o código para alterar registro.");
				}
				if (obj.Nome == "")
				{
					throw new Exception("O campo nome deve estar preenchido, para salvar motorista.");
				}
				if (obj.DataNasc.Value.ToShortDateString() != System.DateTime.Now.ToShortDateString())
				{
					int idade;

					idade = System.DateTime.Now.Year - obj.DataNasc.Value.Year;


					if (idade < 18)
					{
						throw new Exception("só é possível cadastrar motorista maiores de 18 anos.");
					}
					else if (idade > 60)
					{
						throw new Exception("Não é possível cadastrar motorista com mais de 60 anos.");
					}
					else
					{
						DateTime.TryParse(obj.DataNasc.ToString(), out dataNasc);
					}
				}
				else
				{
					throw new Exception("Informe uma data de nascimento válida");
				}
				
				if (obj.CnhVencimento != System.DateTime.Now && obj.CnhVencimento.Value != null)
				{
					DateTime.TryParse(obj.DataNasc.ToString(), out cnhVencimento);
				}
				else
				{
					throw new Exception("Preencha a data de validade para CNH.");
				}
				if (obj.Telefone == "")
				{
					throw new Exception("O campo Telefone deve estar preenchido.");
				}
				if (obj.Status == null)
				{
					throw new Exception("Selecione o status.");
				}
				
				int.TryParse(obj.Endereco.Numero.ToString(), out numero);
				int.TryParse(obj.Endereco.CodCidade.ToString(), out codCidade);
				int.TryParse(obj.Endereco.CodEstado.ToString(), out codEstado);

				dao.AlterarMotoristaDAO(obj.Codigo, obj.Nome, dataNasc, (EnumCnhCategoriaMotorista)obj.CnhCat, obj.CnhNumero, cnhVencimento, obj.Telefone,
										obj.Email, (int)obj.Status, obj.Endereco.Cep, obj.Endereco.Logradouro, numero,
										obj.Endereco.Bairro, codCidade, codEstado);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void DeletarController(Motorista obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Necessário informar o código para excluir registro.");
				}
				dao.DeletarMotoristaDAO(obj.Codigo);

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public DataTable ComboMotorista()
		{
			try
			{
				return dao.CarregarComboMotoristaDAO();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		public DataTable GetDataTable(Motorista obj)
		{
			try
			{
				return dao.FiltrarMotoristaDAO(obj.Nome, obj.CnhVencimento, obj.CnhVencFinal);

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public Motorista GetObj(Motorista obj)
		{
			try
			{
				if (obj.Codigo != 0)
				{
					DataTable table = dao.CarregarMotoristaDAO(obj.Codigo);


					if (table != null)
					{
						int.TryParse(table.Rows[0]["Numero"].ToString(), out numero);
						int.TryParse(table.Rows[0]["Cod_Cidade"].ToString(), out codCidade);
						int.TryParse(table.Rows[0]["Cod_Estado"].ToString(), out codEstado);

						Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
													table.Rows[0]["Logradouro"].ToString(),
													numero,
													table.Rows[0]["Bairro"].ToString(),
													codCidade, codEstado);

						DateTime.TryParse(table.Rows[0]["Data_Nascimento"].ToString(), out dataNasc);
						DateTime.TryParse(table.Rows[0]["CNH_Vencimento"].ToString(), out cnhVencimento);

						Motorista moto = new Motorista(Convert.ToInt32(table.Rows[0]["Cod_Motorista"]),
													   table.Rows[0]["Nome_Motorista"].ToString(),
													   dataNasc,
													   table.Rows[0]["Telefone_Motorista"].ToString(),
													   table.Rows[0]["Email_Motorista"].ToString(),
													   (EnumStatusMotorista)(table.Rows[0]["Status_Motorista"]), end,
													   (EnumCnhCategoriaMotorista)table.Rows[0]["CNH_Categoria"],
													   table.Rows[0]["CNH_Numero"].ToString(),
													   cnhVencimento);

						return moto;
					}
					else
					{
						throw new Exception("Dados não localizado.");
					}
				}
				else
				{
					throw new Exception("É necessário o código do motorista para obter dados.");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void InserirController(Motorista obj)
		{
			try
			{
				if (obj.Nome == "")
				{
					throw new Exception("É obrigatório informar o nome para cadastrar motorista.");
				}
				if (obj.DataNasc.Value.ToShortDateString() != System.DateTime.Now.ToShortDateString())
				{
					int idade;

					idade = System.DateTime.Now.Year - obj.DataNasc.Value.Year;


					if (idade < 18)
					{
						throw new Exception("só é possível cadastrar motorista maiores de 18 anos.");
					}
					else if (idade > 60)
					{
						throw new Exception("Não é possível cadastrar motorista com mais de 60 anos.");
					}
					else
					{
						DateTime.TryParse(obj.DataNasc.ToString(), out dataNasc);
					}
				}
				else
				{
					throw new Exception("Informe uma data de nascimento válida");
				}

				if (obj.CnhNumero.Length != 11)
				{
					throw new Exception("Verifique se o numero da CNH está corretamente preenchido.");
				}
				if (obj.CnhVencimento.Value.ToShortDateString() != System.DateTime.Now.ToShortDateString() && obj.CnhVencimento.Value != null)
				{
					DateTime.TryParse(obj.DataNasc.ToString(), out cnhVencimento);
				}
				else
				{
					throw new Exception("Preencha a data de validade para CNH.");
				}
				if (obj.Telefone == "")
				{
					throw new Exception("Preencha o campo de Telefone.");
				}

				int.TryParse(obj.Endereco.Numero.ToString(), out numero);
				int.TryParse(obj.Endereco.CodCidade.ToString(), out codCidade);
				int.TryParse(obj.Endereco.CodEstado.ToString(), out codEstado);

				dao.InserirMotoristaDAO(obj.Nome, dataNasc, (EnumCnhCategoriaMotorista)obj.CnhCat, obj.CnhNumero, cnhVencimento,
										obj.Telefone, obj.Email, (int)obj.Status, obj.Endereco.Cep, obj.Endereco.Logradouro, numero,
										obj.Endereco.Bairro, codCidade, codEstado);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public List<Motorista> ListasController(Motorista obj)
		{
			try
			{
				DataTable table = dao.FiltrarMotoristaDAO(obj.Nome, obj.CnhVencimento, obj.CnhVencFinal);
				List<Motorista> lista = new List<Motorista>();
				int cnhCategoria, codStatus;

				if (table == null)
				{
					throw new Exception("Funcionário não localizado.");
				}

				foreach (DataRow item in table.Rows)
				{
					int.TryParse(table.Rows[0]["Numero"].ToString(), out numero);
					int.TryParse(table.Rows[0]["Cod_Cidade"].ToString(), out codCidade);
					int.TryParse(table.Rows[0]["Cod_Estado"].ToString(), out codEstado);

					Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
												table.Rows[0]["Logradouro"].ToString(),
												numero,
												table.Rows[0]["Bairro"].ToString(),
												codCidade, codEstado);

					DateTime.TryParse(table.Rows[0]["Data_Nascimento"].ToString(), out dataNasc);
					DateTime.TryParse(table.Rows[0]["CNH_Vencimento"].ToString(), out cnhVencimento);
					int.TryParse(table.Rows[0]["Status_Motorista"].ToString(), out codStatus);
					int.TryParse(table.Rows[0]["CNH_Categoria"].ToString(), out cnhCategoria);


					Motorista moto = new Motorista(Convert.ToInt32(table.Rows[0]["Cod_Motorista"]),
												   table.Rows[0]["Nome_Motorista"].ToString(),
												   dataNasc,
												   table.Rows[0]["Telefone_Motorista"].ToString(),
												   table.Rows[0]["Email_Motorista"].ToString(),
												   (EnumStatusMotorista)codStatus, end,
												   (EnumCnhCategoriaMotorista)cnhCategoria,
												   table.Rows[0]["CNH_Numero"].ToString(),
												   cnhVencimento);

					lista.Add(moto);
				}
				return lista;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
