using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLog.WindowsForms.UserControl
{

	public enum etipoTextbox
	{
		normal = 1,
		somenteNumero = 2,
		somenteLetra = 3,
		cpf = 4,
		data = 5
	}
	public partial class SuperTextbox : TextBox
	{
		public ErrorProvider provider = new ErrorProvider();

		public etipoTextbox tipoTextbox { get; set; } = etipoTextbox.normal;
		public bool isControle;
		public bool CampoObrigatorio { get; set; }
		public string MensagemObrigatorio { get; set; }

		protected override void OnValidating(CancelEventArgs e)
		{
			e.Cancel = !VerificarCampoObrigatorio();

		}
		public bool VerificarCampoObrigatorio()
		{
			bool valido = true;

			try
			{
				if (CampoObrigatorio)
				{
					if (this.Text == "")
					{
						provider.SetError(this, MensagemObrigatorio);
						valido = false;
					}
					else
					{
						provider.Clear();
					}
				}


				return valido;

			}
			catch (Exception)
			{
				return false;

			}
		}

		public SuperTextbox()
		{
			InitializeComponent();
		}
		protected override void OnKeyDown(KeyEventArgs e)
		{
			//07.825.880/0001-84
			if (tipoTextbox == etipoTextbox.cpf)
			{
				if (isControle)
				{
					return;
				}
				if (this.Text.Length >= 18)
				{
					e.Handled = true;
					return;
				}

				this.Text = FormatCPF(this.Text);
				this.SelectionStart = this.Text.Length;


			}
		}

		private string FormatCPF(string cpfVelho)
		{
			string ret = "";


			if (cpfVelho == "")
			{
				return "";
			}


			cpfVelho = cpfVelho.Replace(".", "").Replace("-", "").Replace("/", "");


			// formata CPF
			if (cpfVelho.Length < 12)
			{
				for (int i = 1; i <= cpfVelho.Length; i++)
				{

					ret += cpfVelho.Substring(i - 1, 1);

					if (i == 3 || i == 6)
					{
						ret += ".";
					}
					else if (i == 9)
					{
						ret += "-";
					}

				}
			}
			else
			{
				for (int i = 1; i <= cpfVelho.Length; i++)
				{


					ret += cpfVelho.Substring(i - 1, 1);


					if (i == 2 || i == 5)
					{
						ret += ".";
					}
					else if (i == 8)
					{
						ret += "/";
					}
					else if (i == 12)
					{
						ret += "-";
					}

				}

			}


			return ret;



		}

		protected override void OnLeave(EventArgs e)
		{

			if (tipoTextbox == etipoTextbox.cpf)
			{
				this.Text = FormatCPF(this.Text);
			}
			else
			{
				base.OnLeave(e);
			}
		}
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if (tipoTextbox == etipoTextbox.somenteNumero)
			{
				if (!char.IsDigit(e.KeyChar))
				{
					e.Handled = true;
				}
				if (char.IsControl(e.KeyChar))
				{
					e.Handled = true;
				}
			}
			else if (tipoTextbox == etipoTextbox.somenteLetra)
			{
				if (char.IsControl(e.KeyChar))
				{
					return;
				}

				if (char.IsDigit(e.KeyChar))
				{
					e.Handled = true;
				}
			}
			else if (tipoTextbox == etipoTextbox.data)
			{

			}
			else if (tipoTextbox == etipoTextbox.cpf)
			{
				isControle = false;

				if (char.IsControl(e.KeyChar))
				{
					isControle = true;
					return;
				}
				if (!char.IsDigit(e.KeyChar))
				{
					e.Handled = true;
				}

			}
		}
	}
}
