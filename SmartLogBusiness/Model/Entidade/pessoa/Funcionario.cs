using SmartLogBusiness.Model.Enums;
using System;

namespace SmartLogBusiness.Model.Entidade.pessoa
{
	public class Funcionario : Pessoa
	{
		
		public string Cpf { get; private set; }
		public EnumTipoCargo TipoCargo { get; private set; }
		public string Email { get; private set; }
		public string Senha { get; private set; }
		public Funcionario()
		{
		}
		public Funcionario(string email, string senha)
		{
			Email = email;
			Senha = senha;
		}
		public Funcionario(int codigo, string nome, DateTime dataNasc, string telefone, string email,
						   string cpf, Endereco endereco, EnumTipoCargo cargo)
						: base(codigo,nome, dataNasc,telefone, email, endereco)
		{
			
			Cpf = cpf;
			TipoCargo = cargo;
		}
	}
}
