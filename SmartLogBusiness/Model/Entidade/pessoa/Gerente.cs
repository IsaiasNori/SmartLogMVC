using System;

namespace SmartLogBusiness.Model.Entidade.pessoa
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome,DateTime dataNasc, string telefone, string email, int matricula,string cpf, Endereco endereco)
            : base(nome, dataNasc,telefone, email, matricula,cpf, endereco, Enums.EnumTipoCargo.Gerente)
        {

        }
    }
}
