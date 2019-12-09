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
	public partial class frmNovaSenha : Form
	{
		FuncionarioController funcCtrl = new FuncionarioController();
        public bool bAlterouSenha;
        private int CodMatricula;

		public frmNovaSenha(int _codMatricula)
		{
			InitializeComponent();
            CodMatricula = _codMatricula;

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
			if(txtSenha.Text != txtConfirmarSenha.Text)
			{
				Util.Utils.ExibirMensagem("A senha não confere, deve ser igual nos campos.",eTipoMensagem.Atencao);
				return;
			}



            try
            {
                funcCtrl.AlterarSenha(CodMatricula, txtSenha.Text);
                bAlterouSenha = true;
                this.Close();
            }
            catch (Exception ex)
            {

                Util.Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro) ;
            }
           
			

		}
	}
}
