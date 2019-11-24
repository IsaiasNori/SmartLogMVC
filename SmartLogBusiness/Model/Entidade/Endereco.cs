namespace SmartLogBusiness.Model.Entidade
{
	public class Endereco
	{
		public string Cep { get; private set; }
		public string Logradouro { get; private set; }
		public int Numero { get; private set; }
		public string Bairro { get; private set; }
		public int CodCidade { get; private set; }
		public int CodEstado { get; private set; }

		public Endereco()
		{

		}
		public Endereco(string cep, string logradouro, int numero, string bairro, int codCidade, int codEstado)
		{
			Cep = cep;
			Logradouro = logradouro;
			Numero = numero;
			Bairro = bairro;
			CodCidade = codCidade;
			CodEstado = codEstado;
		}
		public override string ToString()
		{
			return "Logradouro: "
				+ Logradouro.ToString()
				+ ", Nº: "
				+ Numero.ToString()
				+ "\n" + Bairro.ToString();
		}
	}
}
