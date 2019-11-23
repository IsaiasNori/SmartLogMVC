using System;

namespace SmartLogBusiness.Model.Entidade.pessoa
{
    public class Cliente : Pessoa
    {
		public DateTime? DataCadastro { get; private set; }
		public string CpfCnpj { get; private set; } 
		public int? CodTipoCli { get; private set; }

		public Cliente()
		{

		}
		public Cliente(int cod): base(cod)
		{
			
		}
        public Cliente(int codigo,string nome, string cpfCnpj, DateTime? dataCadastro, DateTime? dataNasc, string telefone, string email,  int? codTipoCli, Endereco endereco) 
            : base(codigo,nome, dataNasc, telefone, email, endereco)
        {
			DataCadastro = dataCadastro;
			CpfCnpj = cpfCnpj;
			CodTipoCli = codTipoCli;
        }
    }
}
