using SmartLogBusiness.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLog.WindowsForms
{
    public partial class frmCalculaValor : Form
    {
        FuncionarioController funcCtrl = new FuncionarioController();
        public decimal valorTotal;
        public int distancia;

        public frmCalculaValor()
        {
            InitializeComponent();


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
            {
                return;
            }


            decimal valorPedagio;
            decimal valorCombustivel;
            decimal valorKM;

            try
            {


                decimal.TryParse(txtPedagio.Text, out valorPedagio);
                decimal.TryParse(txtCombustivel.Text, out valorCombustivel);
                int.TryParse(txtDistancia.Text, out distancia);
                decimal.TryParse(txtValorKM.Text, out valorKM);
                valorTotal = valorPedagio + valorCombustivel + (distancia * valorKM);


                this.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
