namespace SmartLogBusiness.Model.Entidade.pessoa
{
    public class Atendente : Funcionario
    {
        public Atendente(string nome, string telefone, string email, int matricula, Endereco endereco)
            : base(nome, telefone, email, matricula, endereco, Enums.EnumTipoCargo.Atendente)
        {
        }
    }
}
