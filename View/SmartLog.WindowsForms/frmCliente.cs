using SmartLogBusiness.Controller;
using SmartLogBusiness.Model.Entidade;
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

namespace SmartLog.WindowsForms.DeskTopPresentation
{
	public partial class frmCliente : Form
	{
		ClienteController cliController = new ClienteController();
		int currentMouseOverRow;
		int currentIndexRow;

		public frmCliente()
		{
			InitializeComponent();
		}
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			DateTime dataNasc;
			int codTipoCli;
			int numero;
			int cidade;
			int estado;

			try
			{
				DateTime.TryParse(txtData.Text, out dataNasc);

				int.TryParse(cbTipoCli.SelectedValue.ToString(), out codTipoCli);

				int.TryParse(txtNumero.Text, out numero);

				int.TryParse(cbCidade.SelectedValue.ToString(), out cidade);

				int.TryParse(cbEstado.SelectedValue.ToString(), out estado);

				Endereco end = new Endereco(txtCep.Text, txtLogra.Text, numero, txtBairro.Text, cidade, estado);

				Cliente cli = new Cliente(0, txtNomeCli.Text, txtCpfCnpjCli.Text, System.DateTime.Now, dataNasc, txtTelCli.Text, txtEmailCli.Text, codTipoCli, end);
				cliController.InserirController(cli);
				MessageBox.Show("Inserido com sucesso.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao inserir cliente, erro:" + ex.Message);
			}
		}

		private void FormCliente_Load(object sender, EventArgs e)
		{
			CarregarEstado();
			CarregarTipoCliente();
		}
		private void CarregarEstado()
		{
			EstadoController estado = new EstadoController();
			DataTable table = estado.CarregarEstado();
			if (table != null)
			{
				cbEstado.DataSource = table;
				cbEstado.DisplayMember = "UF_Estado";
				cbEstado.ValueMember = "Cod_Estado";
			}
		}
		private void CarregarTipoCliente()
		{
			TipoClienteController cli = new TipoClienteController();
			DataTable table = cli.CarregarTipoClienteController();

			if (table != null)
			{
				cbTipoCli.DataSource = table;
				cbTipoCli.DisplayMember = "Descricao";
				cbTipoCli.ValueMember = "Cod_TipoCliente";
			}
		}

		private void btnPesquisarCli_Click(object sender, EventArgs e)
		{
			try
			{
				string cpf = "";

				cpf = txtCpfPesquisar.Text.Replace(".", "").Replace("-", "").Replace("/", "");

				Cliente cli = new Cliente(0, txtCliPesquisar.Text, cpf, null, null, null, null, null, null);
				DataTable table = cliController.GetDataTable(cli);

				dtCliente.DataSource = table;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dtCliente_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ContextMenu m = new ContextMenu();

				MenuItem menuCopiar = new MenuItem("Copiar");
				MenuItem menuEditar = new MenuItem("Editar");

				menuCopiar.Click += MenuCopiar_Click;
				menuEditar.Click += MenuEditar_Click;

				m.MenuItems.Add(menuEditar);
				m.MenuItems.Add(menuCopiar);

				currentIndexRow = dtCliente.HitTest(e.X, e.Y).RowIndex;
				currentMouseOverRow = Convert.ToInt32(dtCliente.Rows[currentIndexRow].Cells[0].Value.ToString());

				m.Show(dtCliente, new Point(e.X, e.Y));
			}
		}

		private void MenuCopiar_Click(object sender, EventArgs e)
		{
			var newline = System.Environment.NewLine;
			var tab = "\t";
			var clipboard_string = "";
			int iCol = 0;

			foreach (DataGridViewTextBoxCell colunas in dtCliente.Rows[0].Cells)
			{

				if (iCol == 0)
				{
					iCol += 1;
					continue;
				}

				clipboard_string += colunas.Value.ToString() + newline;

			}
			Clipboard.SetText(clipboard_string);
		}
		private void MenuEditar_Click(object sender, EventArgs e)
		{
			MessageBox.Show(currentMouseOverRow.ToString());
		}
		private void dtCliente_DataSourceChanged(object sender, EventArgs e)
		{
			if (dtCliente.DataSource != null)
			{
				dtCliente.Columns[0].Visible = false;
			}
		}

		private void cbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			string codEstado = cbEstado.SelectedValue.ToString();

			CidadeController cidade = new CidadeController();

			int estado;

			int.TryParse(codEstado, out estado);

			if (estado > 0)
			{
				DataTable table = cidade.CarregarCidadeController(estado);

				cbCidade.DataSource = table;
				cbCidade.DisplayMember = "Nome_Cidade";
				cbCidade.ValueMember = "Cod_Cidade";
			}

		}

	}
}
