using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLogBusiness.Model.Entidade.pessoa
{
	public 	class TipoCargo
	{
		public int Cod { get; private set; }
		public string DescricaoCargo { get; private set; }

		public TipoCargo(int codigo, string descricao)
		{
			Cod = codigo;
			DescricaoCargo = descricao;
		}
	}
}
