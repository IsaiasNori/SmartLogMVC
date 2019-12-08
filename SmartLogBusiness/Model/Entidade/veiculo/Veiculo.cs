using System;

namespace SmartLogBusiness.Model.Entidade.veiculo
{
    public class Veiculo
    {
		public int CodVei { get; private set; }
        public int CodMarca { get; set; }
        public string Modelo { get; set; }
		public string Placa { get; private set; }
		public string Renavam { get; set; }
		public DateTime DataAquisicao { get; private set; }
		public string AnoFabricacao{ get; set; }
        public DateTime? DataUltimaRevisão { get; set; }
		public string KmInicial { get;  set; }
        public string KmAtual { get; set; }
		public string KmPrev { get;  set; }
        public enumStatusVeiculo Status { get; set; }

		public Veiculo(int cod)
		{
			CodVei = cod;
		}
		//Construtor para carregar combo de veículos.
		public Veiculo(int codMarca, string modelo)
		{
			CodMarca = codMarca;
			Modelo = modelo;
		}
        public Veiculo(int codVeic, int codmarca, string modelo,string placa, string renavam, enumStatusVeiculo status, DateTime dataAqui, string anoFabricacao, string kmInicial,  string quilometragemAtual, string kmPrev, DateTime? dataUltimaRevisão)
        {
			CodVei = codVeic;
            CodMarca = codmarca;
            Modelo = modelo;
			Renavam = renavam;
			DataAquisicao = dataAqui;
            AnoFabricacao = anoFabricacao;
            DataUltimaRevisão = dataUltimaRevisão;
			KmInicial = kmInicial;
            KmAtual = quilometragemAtual;
			KmPrev = kmPrev;
			Status = status;
			Placa = placa;
			
        }
    }
}
