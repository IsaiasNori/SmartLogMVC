using SmartLog.WindowsForms.UserControl;
using SmartLog.WindowsForms.Util;
using SmartLogBusiness.Controller;
using SmartLogBusiness.Model.Entidade.veiculo;
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
	public partial class frmVeiculo : Form
	{

		private VeiculoController veiCtrl = new VeiculoController();
		int codigoVeic;
		public frmVeiculo()
		{
			InitializeComponent();
		}

		private void frmVeiculo_Load(object sender, EventArgs e)
		{
			CarregarMarca();
			Utils.CarregarStatusVeiculo(ref cbStatus);
			txtKmPrev.Text = "10.000";
		}
		private void btnNovoVeiculo_Click(object sender, EventArgs e)
		{
			codigoVeic = 0;
			Utils.LimparCampos(gbDadosVeiculo);
			tabctrlVeiculo.SelectedTab = tabCadastroVeic;
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidateChildren() == false)
				{
					return;
				}

				DateTime? dataUltima = new DateTime();

				if (Utils.IsDate(txtDataUltRev.Text))
				{
					dataUltima = Convert.ToDateTime(txtDataUltRev.Text);
				}
				if (System.DateTime.Now.Year - Convert.ToInt32(txtAnoFab.Text) >= 9)
				{
					txtAnoFab.Focus();
					Utils.ExibirMensagem("Não é possível cadastrar veículo com 9 anos ou mais de uso.", eTipoMensagem.Atencao);
					return;
				}
				Veiculo vei = new Veiculo(codigoVeic,
										   cbMarca.PegarComboSelecionado(),
										   txtModelo.Text,
										   txtPlaca.Text,
										   txtRenavam.Text,
										   (enumStatusVeiculo)cbStatus.PegarComboSelecionado(),
										   txtData.Value,
										   txtAnoFab.Text,
										   txtKmInicial.Text,
										   txtKmAtual.Text,
										   txtKmPrev.Text, dataUltima);
				if (codigoVeic == 0)
				{
					veiCtrl.InserirController(vei);
					Utils.ExibirMensagem("Veiculo inserido com sucesso", eTipoMensagem.Sucesso);
				}
				else
				{
					veiCtrl.AlterarController(vei);
					Utils.ExibirMensagem("Veiculo alterado com sucesso", eTipoMensagem.Sucesso);
				}


				Utils.LimparCampos(gbDadosVeiculo);

				tabctrlVeiculo.SelectedTab = tabConsultaVeic;

				Pesquisar();
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private bool VerificarCamposObrigatoriosInformados()
		{

			string mensagem = "";

			try
			{


				if (txtModelo.Text == "")
				{
					mensagem += "Informar o modelo" + Environment.NewLine;
					txtModelo.Focus();
				}
				if (txtRenavam.Text == "")
				{
					mensagem += "Informar o renavem" + Environment.NewLine;
					txtRenavam.Focus();
				}


				if (cbStatus.VerificarCampoObrigatorio())
				{

				}

				if (cbMarca.PegarComboSelecionado() <= 0)
				{
					mensagem += "Informar a marca" + Environment.NewLine;
					cbMarca.Focus();
				}
				if (mensagem == "")
				{
					return true;
				}
				else
				{
					Utils.ExibirMensagem(mensagem, eTipoMensagem.Atencao);
					return false;
				}
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
				return false;
			}
		}
		private void btnPesquisarVeiculo_Click(object sender, EventArgs e)
		{
			Pesquisar();
		}
		private void DtVeiculo_DataSourceChanged(object sender, EventArgs e)
		{
			if (dgVeiculo.DataSource != null)
			{
				dgVeiculo.Columns[0].Visible = false;
				dgVeiculo.AutoResizeColumns();
			}
		}
		private void Pesquisar()
		{
			try
			{
				int codmarca = 0;

				Classes.Item marca = (Classes.Item)cbMarcaPesquisa.SelectedItem;
				if (marca != null)
				{
					if ((int)marca.Value != -1)
						codmarca = Convert.ToInt32(marca.Value);
				}

				Veiculo vei = new Veiculo(codmarca, txtModeloPesquisa.Text);
				DataTable table = veiCtrl.GetDataTable(vei);

				if (table != null)
				{
					dgVeiculo.DataSource = table;
					dgVeiculo.AutoResizeColumns();
					dgVeiculo.ClearSelection();
				}
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void btnVoltar_Click(object sender, EventArgs e)
		{
			tabctrlVeiculo.SelectedTab = tabConsultaVeic;
		}
		private void btnFechaVeiculo_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgVeiculo.SelectedRows.Count > 0)
				{
					string codigo = dgVeiculo.SelectedRows[0].Cells[0].Value.ToString();
					int.TryParse(codigo, out codigoVeic);


					if (codigoVeic > 0)
					{
						Veiculo veic = new Veiculo(codigoVeic);

						veic = veiCtrl.GetObj(veic);

						cbStatus.PosicionarCombo((int)veic.Status);
						cbMarca.PosicionarCombo(veic.CodMarca);
						txtModelo.Text = veic.Modelo;
						txtPlaca.Text = veic.Placa;
						cbStatus.SelectedValue = veic.Status;
						txtData.Text = veic.DataAquisicao.ToString();
						txtAnoFab.Text = veic.AnoFabricacao;
						txtRenavam.Text = veic.Renavam;
						txtKmInicial.Text = veic.KmInicial;
						txtKmAtual.Text = veic.KmAtual;
						txtKmPrev.Text = veic.KmPrev;
						txtDataUltRev.Text = veic.DataUltimaRevisão.ToString();

						tabctrlVeiculo.SelectedTab = tabCadastroVeic;
					}
				}
				else
				{
					Utils.ExibirMensagem("Selecione um registro para efetuar alteração.", eTipoMensagem.Atencao);
				}
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void btnExcluir_Click(object sender, EventArgs e)
		{


			try
			{


				if (dgVeiculo.SelectedRows.Count > 0)
				{


					if (MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{

						foreach (DataGridViewRow linha in dgVeiculo.SelectedRows)
						{

							string codigo = linha.Cells[0].Value.ToString();
							int.TryParse(codigo, out codigoVeic);

							if (codigoVeic > 0)
							{
								Veiculo vei = new Veiculo(codigoVeic);
								veiCtrl.DeletarController(vei);
							}
						}

						Utils.ExibirMensagem("Veículo excluído com sucesso.", eTipoMensagem.Sucesso);
						Pesquisar();
					}

				}
				else
				{
					Utils.ExibirMensagem("Selecione um registro para excluir.", eTipoMensagem.Atencao);
				}

			}
			catch (Exception ex)
			{

				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}

		private void CarregarMarca()
		{
			try
			{
				MarcaController marcaCtrl = new MarcaController();
				DataTable table = marcaCtrl.CarregarComborMarcaController();

				cbMarca.CarregaCombo(table, "Cod_Marca", "Descricao", UserControl.eTipoMensagem.Selecione);
				cbMarcaPesquisa.CarregaCombo(table, "Cod_Marca", "Descricao", UserControl.eTipoMensagem.Selecione);

			}
			catch (Exception)
			{

				throw;
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Utils.LimparCampos(gbDadosVeiculo);
		}

	}
}
