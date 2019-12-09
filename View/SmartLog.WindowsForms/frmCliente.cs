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

namespace SmartLog.WindowsForms
{
	public partial class frmCliente : Form
	{
		ClienteController cliController = new ClienteController();

		int currentMouseOverRow;
		int currentIndexRow;

		private int codigoCli;
		public frmCliente()
		{
			InitializeComponent();
		}
		private void FormCliente_Load(object sender, EventArgs e)
		{
			Util.Utils.CarregarEstado(ref cbEstado);

			CarregarTipoCliente();
		}
		private void btnPesquisarCli_Click(object sender, EventArgs e)
		{
			PesquisarCliente();
		}
		private void btnVoltarCli_Click(object sender, EventArgs e)
		{
			tabCtrlCliente.SelectedTab = tabConsultaCli;
		}
		private void btnFechaCliente_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnNovo_Click(object sender, EventArgs e)
		{
			Util.Utils.LimparCampos(gbDadosCliente);
			codigoCli = 0;
			tabCtrlCliente.SelectedTab = tabCadastroCli;
		}

		/*public  bool ValidarCampos()
		{
			string msgRetorno= "";
			

			try
			{
				if(txtNomeCli.Text == ""){
					msgRetorno = "Informar o nome do cliente";
				}
			  if (txtCpfCnpjCli.Text == "")
				{
					msgRetorno += "Informar o cpf";
				}

			  if (cbCidade.SelectedValue.ToString() == "")
				{
					msgRetorno += "Informar a ciadade";
				}
					

			}
			catch (Exception)
			{

				throw;
			}


		}*/

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			DateTime dataNasc;
			int numero;
			try
			{
				if (ValidateChildren() == false)
				{
					return;
				}
				DateTime.TryParse(dtDataNasc.Text, out dataNasc);

				if (Util.Utils.IsMaiorIdade(dataNasc) == false)
				{
					Util.Utils.ExibirMensagem("É necessário ser maior de 18 anos.", eTipoMensagem.Atencao);
					dtDataNasc.Focus();
					return;
				}

				int.TryParse(txtNumero.Text, out numero);

				Endereco end = new Endereco(txtCep.Text, txtLogra.Text, numero, txtBairro.Text, cbCidade.PegarComboSelecionado(), cbEstado.PegarComboSelecionado());

				Cliente cli = new Cliente(codigoCli, txtNomeCli.Text, txtCpfCnpjCli.Text, System.DateTime.Now, dataNasc, txtTelCli.Text, txtEmailCli.Text, cbTipoCli.PegarComboSelecionado(), end);
				if (codigoCli == 0)
				{
					cliController.InserirController(cli);

					Util.Utils.ExibirMensagem("Cliente inserido com sucesso.", eTipoMensagem.Sucesso);
				}
				else
				{
					cliController.AlterarController(cli);

					Util.Utils.ExibirMensagem("Cliente alterado com sucesso.", eTipoMensagem.Sucesso);
				}

				Util.Utils.LimparCampos(gbDadosCliente);

				tabCtrlCliente.SelectedTab = tabConsultaCli;

				PesquisarCliente();
			}
			catch (Exception ex)
			{
				Util.Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void btnGridAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgCliente.SelectedRows.Count > 0)
				{
					string codigo = dgCliente.SelectedRows[0].Cells[0].Value.ToString();

					int.TryParse(codigo, out codigoCli);
					if (codigoCli > 0)
					{
						Cliente cli = new Cliente(codigoCli);

						cli = cliController.GetObj(cli);

						txtNomeCli.Text = cli.Nome;
						dtDataCadastro.Text = cli.DataCadastro.ToString();
						dtDataNasc.Text = cli.DataNasc.ToString();
						cbTipoCli.PosicionarCombo(cli.CodTipoCli);
						txtCpfCnpjCli.Text = cli.CpfCnpj.ToString();
						txtTelCli.Text = cli.Telefone.ToString();
						txtEmailCli.Text = cli.Email.ToString();
						txtCep.Text = cli.Endereco.Cep.ToString();
						cbEstado.PosicionarCombo(cli.Endereco.CodEstado);
						cbCidade.PosicionarCombo(cli.Endereco.CodCidade);
						txtLogra.Text = cli.Endereco.Logradouro.ToString();
						txtNumero.Text = cli.Endereco.Numero.ToString();
						txtBairro.Text = cli.Endereco.Bairro.ToString();

						tabCtrlCliente.SelectedTab = tabCadastroCli;
					}
					else
					{
						Util.Utils.ExibirMensagem("Selecione um registro para alterar.", eTipoMensagem.Atencao);
					}
				}
			}
			catch (Exception ex)
			{
				Util.Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void btnGridExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgCliente.SelectedRows.Count > 0)
				{
					string codigo = dgCliente.SelectedRows[0].Cells[0].Value.ToString();

					int.TryParse(codigo, out codigoCli);
					if (codigoCli > 0)
					{

						if (MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
						{
							Cliente cli = new Cliente(codigoCli);
							cliController.DeletarController(cli);

							Util.Utils.ExibirMensagem("Cliente excluído com sucesso.", eTipoMensagem.Sucesso);
							PesquisarCliente();
						}
					}
				}
				else
				{
					Util.Utils.ExibirMensagem("Selecione um registro para excluir.", eTipoMensagem.Atencao);
				}

			}
			catch (Exception ex)
			{
				Util.Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Util.Utils.LimparCampos(gbDadosCliente);
		}
		private void dtCliente_DataSourceChanged(object sender, EventArgs e)
		{
			if (dgCliente.DataSource != null)
			{
				dgCliente.Columns[0].Visible = false;
				dgCliente.AutoResizeColumns();
			}
		}
		private void PesquisarCliente()
		{
			try
			{
				string cpf = "";

				cpf = txtCpfPesquisar.Text.Replace(".", "").Replace("-", "").Replace("/", "");

				Cliente cli = new Cliente(0, txtNomePesquisar.Text, cpf, null, null, null, null, null, null);
				DataTable table = cliController.GetDataTable(cli);

				dgCliente.DataSource = table;
				dgCliente.AutoResizeColumns();
				dgCliente.ClearSelection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void CarregarTipoCliente()
		{
			TipoClienteController cli = new TipoClienteController();
			DataTable table = cli.CarregarTipoClienteController();

			if (table != null)
			{
				cbTipoCli.CarregaCombo(table, "Cod_TipoCliente", "Descricao", UserControl.eTipoMensagem.Selecione);
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

				currentIndexRow = dgCliente.HitTest(e.X, e.Y).RowIndex;
				currentMouseOverRow = Convert.ToInt32(dgCliente.Rows[currentIndexRow].Cells[0].Value.ToString());

				m.Show(dgCliente, new Point(e.X, e.Y));
			}
		}
		private void MenuCopiar_Click(object sender, EventArgs e)
		{
			var newline = System.Environment.NewLine;
			var tab = "\t";
			var clipboard_string = "";
			int iCol = 0;

			foreach (DataGridViewTextBoxCell colunas in dgCliente.Rows[0].Cells)
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
		private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Util.Utils.CarregarComboCidade(cbEstado.PegarComboSelecionado(), ref cbCidade);
			}
			catch (Exception ex)
			{
				Util.Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
	}
}
