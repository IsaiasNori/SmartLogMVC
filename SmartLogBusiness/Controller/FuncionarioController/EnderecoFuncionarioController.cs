using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL.FuncionarioDAL;
using SmartLogBusiness.Model.Entidade.pessoa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class EnderecoFuncionarioController : IControllerBase<Funcionario>
	{
		EnderecoFuncionarioDAO dao = new EnderecoFuncionarioDAO();
		public void AlterarController(Funcionario obj)
		{
			try
			{
				if(obj.Codigo == 0)
				{
					throw new Exception("Informar o codigo.");
				}
				dao.AlterarEnderecoFuncDAO(obj.Endereco.Cep, obj.Endereco.Logradouro, obj.Endereco.Numero, obj.Endereco.Complemento, obj.Endereco.Bairro, obj.Endereco.CodCidade, obj.Endereco.CodEstado, obj.Codigo);
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
					throw new Exception("Informar o código.");
				}
				dao.DeletarEnderecoFuncDAO(obj.Codigo);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public DataTable GetDataTable(Funcionario obj)
		{
			throw new NotImplementedException();
		}

		public Funcionario GetObj(Funcionario obj)
		{
			throw new NotImplementedException();
		}

		public void InserirController(Funcionario obj)
		{
			try
			{
			
				dao.InserirEnderecoFuncDAO(obj.Endereco.Cep, obj.Endereco.Logradouro, obj.Endereco.Numero, obj.Endereco.Complemento, obj.Endereco.Bairro, obj.Endereco.CodCidade, obj.Endereco.CodEstado, obj.Codigo);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public List<Funcionario> ListasController(Funcionario obj)
		{
			throw new NotImplementedException();
		}
	}
}
