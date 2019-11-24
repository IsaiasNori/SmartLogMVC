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
	public partial class frmFuncionario : Form
	{
		FuncionarioController funcCtrl = new FuncionarioController();

		int codigoFunc;
		public frmFuncionario()
		{
			InitializeComponent();
		}
		private void FormFuncionario_Load(object sender, EventArgs e)
		{
			CarregarTipoCargo();
			Utils.CarregarEstado(ref cbEstado);
		}
		private void CarregarTipoCargo()
		{
			try
			{
				TipoDeCargoController cargo = new TipoDeCargoController();

				DataTable table = cargo.GetDataTable(null);

				cbCargo.DataSource = table;
				cbCargo.DisplayMember = "Cargo";
				cbCargo.ValueMember = "Cod_Cargo";

			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void CbEstado_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if(cbEstado.SelectedValue != null)
				{
					int cod;
					int.TryParse(cbEstado.SelectedValue.ToString(), out cod);

					Utils.CarregarComboCidade(cod, ref cbCidade);

				}
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				int numero,cidade, estado;

				int.TryParse(txtNumero.Text, out numero);
				int.TryParse(cbCidade.SelectedValue.ToString(), out cidade);
				int.TryParse(cbEstado.SelectedValue.ToString(), out estado);

				DateTime data;
				DateTime.TryParse(dtDataNasc.Text, out data);

				EnumTipoCargo cargo;
				Enum.TryParse(cbCargo.Text, out cargo);

				Endereco end = new Endereco(txtCep.Text, txtLogra.Text,numero, txtBairro.Text, cidade, estado);
				Funcionario func = new Funcionario(codigoFunc,txtNomeFunc.Text, txtCpfFunc.Text.Replace(".", "").Replace("-", "").Replace("/", ""), data,txtTelFunc.Text,txtEmail.Text,end,cargo);
				if(codigoFunc > 0)
				{
					funcCtrl.AlterarController(func);
					Utils.ExibirMensagem("Funcionário alterado com sucesso", eTipoMensagem.Sucesso);
				}
				else
				{
					funcCtrl.InserirController(func);
					Utils.ExibirMensagem("Funcionário cadastrado com sucesso", eTipoMensagem.Sucesso);
				}

				Utils.LimparCampos(gbDadosFunc);
				tabctrlFuncionario.SelectedTab = tabConsultaFuncionario;
				PesquisarFunc();
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void btnVoltarCli_Click(object sender, EventArgs e)
		{
			tabctrlFuncionario.SelectedTab = tabConsultaFuncionario;
		}

		private void btnFechaFuncionario_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			Utils.LimparCampos(gbDadosFunc);
			codigoFunc = 0;
			tabctrlFuncionario.SelectedTab = tabCadastroFunc;
		}
		private void btnPesquisarFunc_Click(object sender, EventArgs e)
		{
			PesquisarFunc();
		}
		private void btnAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				string codigo;
				codigo = dgFuncionario.SelectedRows[0].Cells[0].Value.ToString();

				int.TryParse(codigo, out codigoFunc);

				if (codigoFunc > 0)
				{
					Funcionario func = new Funcionario(codigoFunc);

					func =  funcCtrl.GetObj(func);

					cbCargo.SelectedValue = func.TipoCargo;
					txtNomeFunc.Text = func.Nome;
					dtDataNasc.Text = func.DataNasc.ToString();
					txtCpfFunc.Text = func.Cpf;
					txtTelFunc.Text = func.Telefone;
					txtEmail.Text = func.Email;
					txtCep.Text = func.Endereco.Cep;
					cbEstado.SelectedValue = func.Endereco.CodEstado;
					cbCidade.SelectedValue = func.Endereco.CodCidade;
					txtLogra.Text = func.Endereco.Logradouro;
					txtNumero.Text = func.Endereco.Numero.ToString();
					txtBairro.Text = func.Endereco.Bairro;

					tabctrlFuncionario.SelectedTab = tabCadastroFunc;
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
		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Utils.LimparCampos(gbDadosFunc);
		}
		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				string codigo = dgFuncionario.SelectedRows[0].Cells[0].Value.ToString();

				int.TryParse(codigo, out codigoFunc);
				if(codigoFunc > 0)
				{
					if (MessageBox.Show("Deseja realmente excluir este registro?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
					{
						Funcionario func = new Funcionario(codigoFunc);
						funcCtrl.DeletarController(func);
						Utils.ExibirMensagem("Funcionário excluído com sucesso.",eTipoMensagem.Sucesso);
						PesquisarFunc();
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

		private void dtFuncionario_DataSourceChanged(object sender, EventArgs e)
		{
			if(dgFuncionario.DataSource != null)
			{
				dgFuncionario.Columns[0].Visible = false;
			}
		}
		private void PesquisarFunc()
		{
			try
			{
				string cpf;
				cpf = txtCpfPesquisar.Text.Replace(".", "").Replace("-", "").Replace("/", "");

				Funcionario func = new Funcionario(0, txtNomeFunc.Text, cpf, null, null, null, null, null);
				DataTable table = funcCtrl.GetDataTable(func);

				dgFuncionario.DataSource = table;
			}
			catch (Exception ex)
			{
				Util.Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}

	}
}
