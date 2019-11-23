using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLog.WindowsForms.DeskTopPresentation
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
				pictureBox1.Image = SmartLog.WindowsForms.Properties.Resources.icon_sucess;
			}
			else if(tipo == eTipoMensagem.Erro)
			{
				pictureBox1.Image = SmartLog.WindowsForms.Properties.Resources.icon_erro;
			}
			else
			{
				pictureBox1.Image = SmartLog.WindowsForms.Properties.Resources.icon_alert;
			}

		}

		private void frmMensagem_Load(object sender, EventArgs e)
		{

		}
	}
}
