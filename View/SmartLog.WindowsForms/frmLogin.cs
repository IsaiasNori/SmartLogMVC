using SmartLog.WindowsForms.Classes;
using SmartLogBusiness.Controller;
using SmartLogBusiness.Model.Entidade.pessoa;
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
	public partial class frmLogin : Form
	{

		public Funcionario funcLogado;
		public frmLogin()
		{
			InitializeComponent();
		}
		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			FuncionarioController funcCtrl = new FuncionarioController();
			Funcionario func = new Funcionario(txtUsuario.Text, txtSenha.Text);

			try
			{
				func = funcCtrl.LogarController(func);
				if(func.Codigo == 0)
				{
					MessageBox.Show("Usuario;senha inválido.");
				}
				else
				{
					Session.Instance.UserID = func.Codigo;
					funcLogado = func;
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void frmLogin_Load(object sender, EventArgs e)
		{
			txtUsuario.ForeColor = Color.Gray;
			txtSenha.ForeColor = Color.Gray;
			txtUsuario.Text = "Informe o usuário";
			txtSenha.Text = "Informe a senha";
		}
		private void txtUsuario_Leave(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "")
			{
				txtUsuario.ForeColor = Color.Gray;
				txtUsuario.Text = "Informe o usuário";
			}
		}
		private void txtSenha_Leave(object sender, EventArgs e)
		{
			if (txtSenha.Text == "")
			{
				txtSenha.PasswordChar = '\0';
				txtSenha.Text = "Informe a senha";
				txtSenha.ForeColor = Color.Gray;
			}
		}

		private void txtSenha_Enter(object sender, EventArgs e)
		{
			if (txtSenha.Text == "Informe a senha")
			{
				txtSenha.ForeColor = Color.Black;
				txtSenha.Text = "";
				txtSenha.PasswordChar = Convert.ToChar("*");
			}
		}

		private void txtUsuario_Enter(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "Informe o usuário")
			{
				txtUsuario.ForeColor = Color.Black;
				txtUsuario.Text = "";
			}
		}
	}
}
