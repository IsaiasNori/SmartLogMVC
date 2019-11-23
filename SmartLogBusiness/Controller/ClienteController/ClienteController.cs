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

		public void AlterarController(Cliente obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Informar o código.");
				}

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
				DataTable table = dao.ObterClienteDAO(obj.Codigo);

				if (table != null)
				{

					Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
												table.Rows[0]["Logradouro"].ToString(),
												Convert.ToInt32(table.Rows[0]["Numero"]),
												table.Rows[0]["Bairro"].ToString(),
												Convert.ToInt32(table.Rows[0]["Cod_Cidade"]),
												Convert.ToInt32(table.Rows[0]["Cod_Estado"]));

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

				codigoCliente = dao.InserirClienteDAO(obj.Nome, obj.DataNasc, obj.Telefone, obj.Email, obj.CpfCnpj, obj.CodTipoCli,
								obj.Endereco.Cep, obj.Endereco.Logradouro, obj.Endereco.Numero, obj.Endereco.Bairro, obj.Endereco.CodCidade, obj.Endereco.CodEstado);
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
				DataTable table = dao.ObterClienteDAO(obj.Codigo);

				if (table == null)
				{
					throw new Exception("Cliente não localizado.");
				}
				List<Cliente> lista = new List<Cliente>();
				foreach (DataRow item in table.Rows)
				{

					Endereco end = new Endereco(item["Cep"].ToString(),
												item["Logradouro"].ToString(),
												Convert.ToInt32(item["Numero"]),
												item["Bairro"].ToString(),
												Convert.ToInt32(item["Cod_Cidade"]),
												Convert.ToInt32(item["Cod_Estado"]));

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
	}
}
