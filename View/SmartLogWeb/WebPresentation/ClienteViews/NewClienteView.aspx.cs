using System;
using System.Web.UI;
using WebPresentation.ExtensionMethods;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Controller;

namespace WebPresentation.ClienteViews
{
    public partial class NewClienteView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void SalvarButton_Click(object sender, EventArgs e)
        {
            SalvarCliente();
        }

        protected void LimparButton_Click(object sender, EventArgs e)
        {

            ClearView();
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        protected void SalvarCliente()
        {
            try
            {
                string nome = NomeTextBox.RequiredField();
                string email = EmailTextBox.RequiredRegularAddressMail();
                string telefone = TelefoneTextBox.RequiredField();
                string log = LogradouroTextBox.Text;
                string num = NumeroTextBox.Text;
                string cep = CepTextBox.Text;
                string bairro = BairroTextBox.Text;
                string cidade = CidadeTextBox.Text;
                string uf = UfDropDownList.SelectedIndex.ToString();

                //criacao da entidade cliente e atribuição dos campos dps chamar metodo da classe controller

            //    Cliente cliente = new Cliente(0, nome, "0000000",,, telefone, email,,);


                MensagemLabel.Text = "Dados Salvos com sucesso";
            }
            catch (Exception e)
            {
                MensagemLabel.Text = e.Message.ToString();
            }
        }

        protected void ClearView()
        {
            NomeTextBox.ClearText();
            EmailTextBox.ClearText();
            TelefoneTextBox.ClearText();
            LogradouroTextBox.ClearText();
            NumeroTextBox.ClearText();
            BairroTextBox.ClearText();
            CidadeTextBox.ClearText();
            CepTextBox.ClearText();
            MensagemLabel.ClearText();
        }

        
    }
}