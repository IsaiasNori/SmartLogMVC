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
	public partial class frmRecuperarSenha : Form
	{
		FuncionarioController funcCtrl = new FuncionarioController();
		public frmRecuperarSenha()
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
			if(txtNovaSenha.Text != txtSenhaConfirm.Text)
			{
				Util.Utils.ExibirMensagem("A senha não confere, deve ser igual nos campos.",eTipoMensagem.Atencao);
				return;
			}

		
			

		}
	}
}
