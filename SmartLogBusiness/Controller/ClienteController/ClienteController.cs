using SmartLog.DAO;
using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.Model.Entidade;
using SmartLogBusiness.Model.Entidade.pessoa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogBusiness.Controller
{
	public class ClienteController : IControllerBase<Cliente>
	{
		ClienteDAO dao = new ClienteDAO();
		int  numero, codCidade, codEstado;

		public void AlterarController(Cliente obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Informar o código.");
				}
				if (obj.Nome == "")
				{
					throw new Exception("É necessário informar o nome do cliente para cadastrar.");
				}
				if (obj.DataNasc.Value.Year < 18)
				{
					throw new Exception("Só é possível cadastrar Clientes maiores de 18 anos.");
				}
				if (obj.Telefone.Length < 8)
				{
					throw new Exception("Verifique se o campo Telefone, foi informado corretamente.");
				}
				if (obj.CpfCnpj.Length < 11 || obj.CpfCnpj.Length < 14)
				{
					throw new Exception("Verifique se o campo Cpf/Cnpj está corretamente preenchido.");
				}
				if (obj.CodTipoCli == null)
				{
					throw new Exception("Informe o tipo de cliente, ex: Física ou Jurídica.");
				}

				int.TryParse(obj.Endereco.Numero.ToString(), out numero);
				int.TryParse(obj.Endereco.CodCidade.ToString(), out codCidade);
				int.TryParse(obj.Endereco.CodEstado.ToString(), out codEstado);



				dao.AlterarClienteDAO(obj.Codigo, obj.Nome, obj.DataNasc, obj.Telefone, obj.Email, obj.CpfCnpj, obj.CodTipoCli, obj.Endereco.Cep, obj.Endereco.Logradouro, obj.Endereco.Numero, obj.Endereco.Bairro, obj.Endereco.CodCidade, obj.Endereco.CodEstado);

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void DeletarController(Cliente obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Informar o código.");
				}
				dao.DeletarClienteDAO(obj.Codigo);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public DataTable GetDataTable(Cliente obj)
		{
			try
			{

				DataTable table = dao.FiltrarClienteDAO(obj.Nome, obj.CpfCnpj);

				return table;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public Cliente GetObj(Cliente obj)
		{
			try
			{
				if(obj.Codigo == 0)
				{
					throw new Exception("Código inválido.");
				}
				DataTable table = dao.ObterClienteDAO(obj.Codigo);

				int numero, cidade, estado;

				if (table != null)
				{
					int.TryParse(table.Rows[0]["Numero"].ToString(), out numero);
					int.TryParse(table.Rows[0]["Cod_Cidade"].ToString(), out cidade);
					int.TryParse(table.Rows[0]["Cod_Estado"].ToString(), out estado);

					Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
												table.Rows[0]["Logradouro"].ToString(),
												numero,
												table.Rows[0]["Bairro"].ToString(),
												cidade,	estado);
					

					Cliente cli = new Cliente(Convert.ToInt32(table.Rows[0]["Cod_Cliente"]),
												table.Rows[0]["Nome_Cliente"].ToString(),
												table.Rows[0]["Cpf_Cnpj"].ToString(),
												Convert.ToDateTime(table.Rows[0]["Data_Cadastro"]),
												Convert.ToDateTime(table.Rows[0]["Data_Nascimento"]),
												table.Rows[0]["Telefone_Cliente"].ToString(),
												table.Rows[0]["Email_Cliente"].ToString(),
												Convert.ToInt32(table.Rows[0]["Cod_TipoCliente"]),
												end);
					return cli;
				}

				throw new Exception("Cliente não localizado.");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void InserirController(Cliente obj)
		{
			try
			{
				int codigoCliente;

				if (obj.Nome == "")
				{
					throw new Exception("É necessário informar o nome do cliente para cadastrar.");
				}
				if(obj.DataNasc.Value.Year < 18)
				{
					throw new Exception("Só é possível cadastrar Clientes maiores de 18 anos.");
				}
				if(obj.Telefone.Length < 8)
				{
					throw new Exception("Verifique se o campo Telefone, foi informado corretamente.");
				}
				if(obj.CpfCnpj.Length < 11 || obj.CpfCnpj.Length < 14)
				{
					throw new Exception("Verifique se o campo Cpf/Cnpj está corretamente preenchido.");
				}
				if(obj.CodTipoCli == null)
				{
					throw new Exception("Informe o tipo de cliente, ex: Física ou Jurídica.");
				}

				int.TryParse(obj.Endereco.Numero.ToString(), out numero);
				int.TryParse(obj.Endereco.CodCidade.ToString(), out codCidade);
				int.TryParse(obj.Endereco.CodEstado.ToString(), out codEstado);

				codigoCliente = dao.InserirClienteDAO(obj.Nome, obj.DataNasc, obj.Telefone, obj.Email, obj.CpfCnpj, obj.CodTipoCli,
								obj.Endereco.Cep, obj.Endereco.Logradouro, numero, obj.Endereco.Bairro, codCidade, codEstado);

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message.ToString());
			}
		}
		public List<Cliente> ListasController(Cliente obj)
		{
			try
			{
				if(obj.Codigo == 0)
				{
					throw new Exception("Código inválido");
				}
				DataTable table = dao.ObterClienteDAO(obj.Codigo);

				if (table == null)
				{
					throw new Exception("Cliente não localizado.");
				}
				List<Cliente> lista = new List<Cliente>();
				foreach (DataRow item in table.Rows)
				{
					int.TryParse(item["Numero"].ToString(), out numero);
					int.TryParse(item["Cod_Cidade"].ToString(), out codCidade);
					int.TryParse(item["Cod_Estado"].ToString(), out codEstado);

					Endereco end = new Endereco(item["Cep"].ToString(),
												item["Logradouro"].ToString(),
												numero,
												item["Bairro"].ToString(),
												codCidade,codEstado);

					Cliente cli = new Cliente(Convert.ToInt32(item["Cod_Matricula"]),
											item["Nome_Cliente"].ToString(),
											item["Cpf_Cnpj"].ToString(),
											Convert.ToDateTime(item["Data_Cadastro"]),
											Convert.ToDateTime(item["Data_Nascimento"]),
											item["Telefone_Cliente"].ToString(),
											item["Email_Cliente"].ToString(),
											Convert.ToInt32(item["Cod_TipoCliente"]),
											end);

					lista.Add(cli);
				}

				return lista;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public DataTable ComboCliente()
		{
			try
			{
				return dao.ComboCliente();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
