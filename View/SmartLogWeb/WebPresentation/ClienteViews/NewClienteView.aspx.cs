using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebPresentation.ExtensionMethods;
using System.Data;
using System.Data.SqlClient;
using SmartLogBusiness.Controller;


namespace WebPresentation.ClienteViews
{
    public partial class NewClienteView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            CarregarEstado();
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

        private void CarregarEstado()
        {
            try
            {
                EstadoController estadoCtrl = new EstadoController();
                DataTable table = estadoCtrl.CarregarEstado();

                if (table != null)
                {
                    foreach(DataRow r in table.Rows)
                    {
                        ListItem listItem = new ListItem(r[1].ToString(),r[0].ToString());
                        UfDropDownList.Items.Add(listItem.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}