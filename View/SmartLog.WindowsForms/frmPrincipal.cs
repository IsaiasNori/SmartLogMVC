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
	public partial class frmPrincipal : Form
	{

		public bool mouseClicked = false;
		Point clickedAt;


		public string NomeUsuario
		{
			get
			{
				return lblNomeUsuario.Text;
			}
			set
			{
				lblNomeUsuario.Text = value;
			}
		}

	

		public frmPrincipal()
		{
			InitializeComponent();
        }
		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnCliente_Click(object sender, EventArgs e)
		{
			frmCliente cli = new frmCliente();
			CarregarTela(cli, "Cliente");
		}
		private void CarregarTela(Form formulario, string titulo)
		{
			if (this.HasChildren)
			{
				foreach (Form form in this.MdiChildren)
				{
					form.Close();
				}
			}
			formulario.MdiParent = this;
			formulario.Dock = DockStyle.Fill;
			btnTituloTela.Text = titulo;
			btnTituloTela.Visible = true;
			formulario.Show();
		}
		private void btnFuncionario_Click(object sender, EventArgs e)
		{
			frmFuncionario func = new frmFuncionario();
			CarregarTela(func, "Funcionário");
		}
		private void button4_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				this.WindowState = FormWindowState.Maximized;
			}
		}
		private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			mouseClicked = true;
			clickedAt = e.Location;
		}
		private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseClicked)
			{
				this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
			}
		}
		private void panelCabecalho_MouseUp(object sender, MouseEventArgs e)
		{
			mouseClicked = false;
		}
		private void button4_Click_1(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void Relogio_Tick(object sender, EventArgs e)
		{
			lblData.Text = System.DateTime.Now.ToString();
		}
		private void btnViagem_Click(object sender, EventArgs e)
		{
			frmViagem viagem = new frmViagem();
			CarregarTela(viagem, "Viagem");
		}
		private void btnVeiculo_Click(object sender, EventArgs e)
		{
			frmVeiculo vei = new frmVeiculo();
			CarregarTela(vei, "Veiculo");
		}
		private void FrmPrincipal_Shown(object sender, EventArgs e)
		{
		//	this.Visible = false;
			/*frmLogin log = new frmLogin();
			log.ShowDialog();

			

			/*if (log.funcLogado == null || log.funcLogado.Codigo == 0)
			{
				this.Close();
				return;
			}*/

			//this.Visible = true;
			this.MouseDown += new MouseEventHandler(panelCabecalho_MouseDown);
			this.MouseMove += new MouseEventHandler(panelCabecalho_MouseMove);

			//lblNomeUsuario.Text = log.funcLogado.Nome;
			Relogio.Start();
		

		}
	}
}
