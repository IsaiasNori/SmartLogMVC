using System;

namespace SmartLogBusiness.Model.Entidade.pessoa
{
    public class Habilitacao
    {
        public DateTime Vencimento { get; set; }
        public string Categoria { get; set; }
        public int NumRegistro { get; set; }
        public bool Status { get; set; }

        public Habilitacao(DateTime vencimento, int numRegistro, string categoria)
        {
            Vencimento = vencimento;
            NumRegistro = numRegistro;
            Categoria = categoria;
            Status = true;
        }
    }
}
