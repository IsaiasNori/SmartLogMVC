using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLog.WindowsForms
{
	public partial class frmSobre : Form
	{
		public frmSobre()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{

		}

		private void btnAjuda_Click(object sender, EventArgs e)
		{
			String caminho = System.AppDomain.CurrentDomain.BaseDirectory;
			Process.Start(caminho + @"\Manual\Manual.pdf");
		}
	}
}
