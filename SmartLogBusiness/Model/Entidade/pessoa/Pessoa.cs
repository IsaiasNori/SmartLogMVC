using SmartLogBusiness.Model.Enums;
using System;

namespace SmartLogBusiness.Model.Entidade.pessoa
{
	abstract public class Pessoa
	{
		public int Codigo { get; private set; }
		public string Nome { get; private set; }
		public DateTime? DataNasc { get; private set; }
		public string Telefone { get; private set; }
		public string Email { get; private set; }
		public Endereco Endereco { get; private set; }
		public bool Status { get; private set; }
	

		protected Pessoa()
		{
		}

		public Pessoa(int cod)
		{
			Codigo = cod;
		}
		public Pessoa(string email)
		{
			Email = email;
		}
		public Pessoa(int codigo,string nome,  DateTime? dataNasc, string telefone, string email, Endereco endereco)
		{
			Codigo = codigo;
			Nome = nome;
			DataNasc = dataNasc;
			Telefone = telefone;
			Email = email;
			Endereco = endereco;
			Status = true;
		}

		public override string ToString()
		{
			string sts;
			sts = (Status) ? "Ativo" : "Inativo";

			return
				"Nome: "
				+ Nome
				+ "\nTelefone: "
				+ Telefone
				+ "\nStatus: "
				+ sts;
		}
	}
}
