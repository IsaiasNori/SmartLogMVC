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
	public enum eTipoMensagem
	{
		Sucesso = 1 ,
		Atencao = 2 ,
		Erro = 3
	}
	public partial class frmMensagem : Form
	{
		public frmMensagem()
		{
			InitializeComponent();
		}

		public frmMensagem(string mensagem, eTipoMensagem tipo)
		{
			InitializeComponent();
			lblMensagem.Text = mensagem;
			if(tipo == eTipoMensagem.Sucesso)
			{
                lblTitulo.Text = "Sucesso";
                toolStripTop.BackColor =  Color.FromArgb (128, 255, 128);
                toolStripBelow.BackColor = Color.FromArgb(128, 255, 128);

                btnOK.Image = SmartLog.WindowsForms.Properties.Resources.icon_sucess;
			}
			else if(tipo == eTipoMensagem.Erro)
			{
                lblTitulo.Text = "Erro";
                toolStripTop.BackColor = Color.FromArgb(236, 45, 30);
                toolStripBelow.BackColor = Color.FromArgb(236, 45, 30);
                btnOK.Image = SmartLog.WindowsForms.Properties.Resources.icon_erro;
			}
			else
			{
                lblTitulo.Text = "Atenção";
                toolStripTop.BackColor = Color.FromArgb(255, 255, 128);
                toolStripBelow.BackColor = Color.FromArgb(255, 255, 128);
                btnOK.Image = SmartLog.WindowsForms.Properties.Resources.icon_alert;
			}

		}

		private void frmMensagem_Load(object sender, EventArgs e)
		{

		}

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
