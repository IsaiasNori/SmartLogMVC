using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL.ClienteDAL;
using SmartLogBusiness.Model.Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	class EnderecoClienteController : IControllerBase<Endereco>
	{
		private EnderecoClienteDAO dao = new EnderecoClienteDAO();
		public void AlterarController(Endereco obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Informar o código para alterar o registro.");
				}
				dao.AlterarEnderecoCliDAO(obj.Cep, obj.Logradouro, obj.Numero, obj.Complemento, obj.Bairro, obj.CodCidade, obj.CodEstado, obj.Codigo);

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public void DeletarController(Endereco obj)
		{
			try
			{
				if(obj.Codigo == 0)
				{
					throw new Exception("Informar o código para efetuar exclusão do registro.");
				}
				dao.AlterarEnderecoCliDAO(obj.Cep, obj.Logradouro, obj.Numero, obj.Complemento, obj.Bairro, obj.CodCidade, obj.CodEstado, obj.Codigo);

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public DataTable GetDataTable(Endereco obj)
		{
			throw new NotImplementedException();
		}

		public Endereco GetObj(Endereco obj)
		{
			throw new NotImplementedException();
		}

		public void InserirController(Endereco obj)
		{
			try
			{
				dao.InserirEnderecoCliDAO(obj.Cep,obj.Logradouro,obj.Numero,obj.Complemento,obj.Bairro,obj.CodCidade,obj.CodEstado,obj.Codigo);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public List<Endereco> ListasController(Endereco obj)
		{
			throw new NotImplementedException();
		}
	}
}
