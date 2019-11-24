using SmartLogBusiness.Model.Enums;
using System;

namespace SmartLogBusiness.Model.Entidade.pessoa
{
	public class Funcionario : Pessoa
	{

		public string Cpf { get; private set; }
		public EnumTipoCargo? TipoCargo { get; private set; }
		public string Senha { get; private set; }
		public Funcionario()
		{
		}
		public Funcionario(int codigo) : base(codigo)
		{

		}
		public Funcionario(string email, string senha) :base(email)
		{
			
			Senha = senha;
		}
		public Funcionario(int codigo, string nome, string cpf, DateTime? dataNasc, string telefone, string email
						   , Endereco endereco, EnumTipoCargo? cargo)
						: base(codigo, nome, dataNasc, telefone, email, endereco)
		{

			Cpf = cpf;
			TipoCargo = cargo;
		}
	}
}
