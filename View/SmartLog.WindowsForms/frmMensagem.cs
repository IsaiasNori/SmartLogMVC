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
                toolStripTop.BackColor =  Color.FromArgb (43, 100, 63);
                toolStripBelow.BackColor = Color.FromArgb(43, 100, 63);

                btnIcon.Image = SmartLog.WindowsForms.Properties.Resources.iconSucesso;
			}
			else if(tipo == eTipoMensagem.Erro)
			{
                lblTitulo.Text = "Erro";
                toolStripTop.BackColor = Color.FromArgb(192, 0, 0);
                toolStripBelow.BackColor = Color.FromArgb(192, 0, 0);
                btnIcon.Image = SmartLog.WindowsForms.Properties.Resources.iconErro;
			}
			else
			{
                lblTitulo.Text = "Atenção";
				toolStripTop.BackColor = Color.Goldenrod;
				toolStripBelow.BackColor = Color.Goldenrod;
				btnIcon.Image = SmartLog.WindowsForms.Properties.Resources.iconAlert;
			}

		}

		private void frmMensagem_Load(object sender, EventArgs e)
		{

		}

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void toolStripTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
