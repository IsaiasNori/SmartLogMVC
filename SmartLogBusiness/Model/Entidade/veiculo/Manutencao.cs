using System;

namespace SmartLogBusiness.Model.Entidade.veiculo
{
    public class Manutencao
    {
		public int Codigo { get; private set; }
        public DateTime DataEntrada { get; private set; }
		public DateTime DataentradaFinal { get; private set; }
        public DateTime DataPrevistaSaida { get; private set; }
		public DateTime DataPrevSaidaFinal { get; private set; }
   //     public StatusManutencao Status { get; private set; }
		public string DescricaoServico { get; private set; }
		public int CodVeiculo { get; private set; }

		public Manutencao(int cod, DateTime dataEntrada, DateTime dataSaida, string descricao, int codVeiculo)
		{
			Codigo = cod;
			DataEntrada = dataEntrada;
			DataPrevistaSaida = dataSaida;
			DescricaoServico = descricao;
			CodVeiculo = codVeiculo;
		}
	
		public Manutencao(int cod, DateTime dataEntrada, DateTime dataSaida, string descricao, int codVeiculo, DateTime dataEntradaFinal, DateTime prevSaidaFinal)
		{
		Codigo = cod;
		DataEntrada = dataEntrada;
		DataentradaFinal = dataEntradaFinal;
		DataPrevistaSaida = dataSaida;
		DataPrevSaidaFinal = prevSaidaFinal;
		DescricaoServico = descricao;
		CodVeiculo = codVeiculo;
		}
	}

	
	
}
