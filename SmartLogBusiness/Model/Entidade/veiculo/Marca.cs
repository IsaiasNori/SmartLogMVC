using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLogBusiness.Model.Entidade.veiculo
{
	public class Marca
	{
		public int CodMarca { get; private set; }
		public string Descricao { get; private set; }

		public Marca(int cod, string descricao)
		{
			CodMarca = cod;
			Descricao = descricao;
		}
	}
}
