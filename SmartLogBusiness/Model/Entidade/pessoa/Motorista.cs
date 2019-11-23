using System;

namespace SmartLogBusiness.Model.Entidade.pessoa
{
    public class Motorista : Pessoa
    {
		
		public DateTime DataNasc { get; private set; }
		public DateTime CnhVencimento { get; private set; }
		public DateTime CnhVencFinal { get; private set; }
		public string CnhCategoria { get; private  set; }
		public string CnhNumero { get; private set; }
		public bool Status { get; private set; }


		public Motorista(int cod):base(cod)
		{

		}
		public Motorista(int codigo,string nome, DateTime dataNasc, string telefone, string email, bool status, Endereco endereco, string cnhCat, string cnhNum, DateTime cnhVenc, DateTime cnhVencFinal)
            : base(codigo,nome, dataNasc, telefone, email,  endereco)
        {
			
			DataNasc = dataNasc;
			CnhVencimento = cnhVenc;
			CnhVencFinal = cnhVencFinal;
			CnhCategoria = cnhCat;
			CnhNumero = cnhNum;
			Status = status;
        }

		public Motorista(int codigo, string nome, DateTime dataNasc, string telefone, string email, bool status, Endereco endereco, string cnhCat, string cnhNum, DateTime cnhVenc)
			: base(codigo,nome, dataNasc, telefone, email, endereco)
		{
			
			DataNasc = dataNasc;
			CnhVencimento = cnhVenc;
			CnhCategoria = cnhCat;
			CnhNumero = cnhNum;
			Status = status;
		}

	}
}
