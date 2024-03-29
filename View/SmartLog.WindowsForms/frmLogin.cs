﻿using SmartLog.WindowsForms.Classes;
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
		ErrorProvider provider = new ErrorProvider();
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
			if(txtUsuario.Text == "" || txtUsuario.Text == "Informe o usuário")
			{
				provider.SetError(txtUsuario, "Informar usuário.");
				txtUsuario.Focus();
				return;
			}
			else if(txtSenha.Text == "" || txtSenha.Text == "Informe a senha")
			{
				provider.SetError(txtSenha, "Informar senha.");
				txtSenha.Focus();
				return;
			}
			else
			{
				provider.Clear();

				FuncionarioController funcCtrl = new FuncionarioController();
				Funcionario func = new Funcionario(txtUsuario.Text, txtSenha.Text);

				try
				{
					func = funcCtrl.LogarController(func);
					if (func.Codigo == 0)
					{
						MessageBox.Show("Usuario;senha inválido.");
					}
					else
					{
						Session.Instance.UserID = func.Codigo;
                        if(txtSenha.Text == func.Cpf)
                        {
                            frmNovaSenha frmNova = new frmNovaSenha(func.Codigo);
                            frmNova.ShowDialog();

                            if(frmNova.bAlterouSenha == false)
                            {
                                Util.Utils.ExibirMensagem("Necessário alterar a senha",eTipoMensagem.Erro);
                                this.Close();
                                return;
                            }

                            Util.Utils.ExibirMensagem("Por favor logar novamente com a nova senha",eTipoMensagem.Sucesso);
                            txtSenha.Text = string.Empty;
                            return;
                            
                        }

						funcLogado = func;
						this.Close();
					}
				}
				catch (Exception ex)
				{
					Util.Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
				}

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

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmRecuperarSenha recuperar = new frmRecuperarSenha();
			recuperar.Show();
		}
	}
}
