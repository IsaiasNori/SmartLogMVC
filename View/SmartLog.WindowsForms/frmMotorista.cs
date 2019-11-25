using SmartLog.WindowsForms.Util;
using SmartLogBusiness.Controller;
using SmartLogBusiness.Model.Entidade;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Model.Enums;
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
	public partial class frmMotorista : Form
	{
		MotoristaController motoCtrl = new MotoristaController();
		int codigoMoto;
		public frmMotorista()
		{
			InitializeComponent();
		}
		private void btnPesquisarMotorista_Click(object sender, EventArgs e)
		{
			Pesquisar();
		}
		private void chkVencimentoCnh_CheckedChanged(object sender, EventArgs e)
		{
			if (chkVencimentoCnh.Checked)
			{
				dtCnhVencPesquisa.Enabled = true;
				dtCnhVencFinal.Enabled = true;
			}
			else
			{
				dtCnhVencPesquisa.Enabled = false;
				dtCnhVencFinal.Enabled = false;
			}
		}
		private void btnFechaMotorista_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnVoltar_Click(object sender, EventArgs e)
		{
			tabCtrlMotorista.SelectedTab = tabCadastroMotorista;
		}
		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Utils.LimparCampos(gbDadosMotorista);
		}
		private void btnNovo_Click(object sender, EventArgs e)
		{
			codigoMoto = 0;
			Utils.LimparCampos(gbDadosMotorista);
			tabCtrlMotorista.SelectedTab = tabCadastroMotorista;
		}
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				if(ValidateChildren() == false)
				{
					return;
				}
				if (Utils.IsMaiorIdade(dtDataNasc.Value) == false)
				{
					Utils.ExibirMensagem("Não é possivel cadastrar motorista menor de idade.", eTipoMensagem.Atencao);
					dtDataNasc.Focus();
					return;
				}
				
				int numero;
				int.TryParse(txtNumero.Text, out numero);

				Endereco end = new Endereco(txtCep.Text, txtLogra.Text, numero, txtBairro.Text, cbCidade.PegarComboSelecionado(), cbEstado.PegarComboSelecionado());
				Motorista moto = new Motorista(codigoMoto, txtNomeMoto.Text, dtDataNasc.Value, txtTelMoto.Text, txtEmail.Text, (EnumStatusMotorista)cbStatus.PegarComboSelecionado(), end, (EnumCnhCategoriaMotorista)cbCnhCategoria.PegarComboSelecionado(), txtCnhNum.Text, dtCnhVenc.Value);

				if (codigoMoto == 0)
				{
					motoCtrl.InserirController(moto);
					Utils.ExibirMensagem("Motorista cadastrado com sucesso.", eTipoMensagem.Sucesso);
				}
				else
				{
					motoCtrl.AlterarController(moto);
					Utils.ExibirMensagem("Motorista alterado com sucesso.", eTipoMensagem.Sucesso);
				}

				Utils.LimparCampos(gbDadosMotorista);

				tabCtrlMotorista.SelectedTab = tabConsultaMotorista;

				Pesquisar();
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void CarregarStatusMotorista()
		{
			try
			{
				cbStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("Ativo", (int)EnumStatusMotorista.Ativo));
				cbStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("Inativo", (int)EnumStatusMotorista.Inativo));
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void Pesquisar()
		{
			try
			{
				DateTime? datainicial = null;
				DateTime? dataFinal = null;

				if (chkVencimentoCnh.Checked)
				{
					datainicial = dtCnhVencPesquisa.Value;
					dataFinal = dtCnhVencFinal.Value;

				}

				Motorista moto = new Motorista(0, txtMotoristaPesquisa.Text, null, null, null, null, null, null, null, datainicial, dataFinal);

				DataTable table = motoCtrl.GetDataTable(moto);

				dgMotorista.DataSource = table;
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}

		private void dgMotorista_DataSourceChanged(object sender, EventArgs e)
		{
			try
			{
				if (dgMotorista.DataSource != null)
				{
					dgMotorista.SelectedColumns[0].Visible = false;
				}
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}

		private void btnGridAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgMotorista.SelectedRows.Count > 0)
				{
					string codigo = dgMotorista.SelectedRows[0].Cells[0].Value.ToString();

					int.TryParse(codigo, out codigoMoto);

					Motorista moto = new Motorista(codigoMoto);

					if (codigoMoto > 0)
					{
						moto = motoCtrl.GetObj(moto);

						cbStatus.PosicionarCombo(moto.Status);
						txtNomeMoto.Text = moto.Nome;
						dtDataNasc.Value = Convert.ToDateTime(moto.DataNasc);
						txtTelMoto.Text = moto.Telefone;
						txtEmail.Text = moto.Email;
						txtCnhNum.Text = moto.CnhNumero;
						cbCnhCategoria.PosicionarCombo(moto.CnhNumero);
						dtCnhVenc.Value = Convert.ToDateTime(moto.CnhVencimento);
						txtCep.Text = moto.Endereco.Cep;
						cbEstado.PosicionarCombo(moto.Endereco.CodEstado);
						cbCidade.PosicionarCombo(moto.Endereco.CodCidade);
						txtLogra.Text = moto.Endereco.Logradouro;
						txtNumero.Text = moto.Endereco.Numero.ToString();
						txtBairro.Text = moto.Endereco.Bairro;

						tabCtrlMotorista.SelectedTab = tabCadastroMotorista;

					}
				}
				else
				{
					Utils.ExibirMensagem("Selecione um registro para alterar.", eTipoMensagem.Atencao);
				}
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
	}
}
