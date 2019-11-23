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
			TipoDeCargoController cargo = new TipoDeCargoController();

			DataTable table = cargo.GetDataTable(null);

			cbCargo.DataSource = table;
			cbCargo.DisplayMember = "Cargo";
			cbCargo.ValueMember = "Cod_Cargo";
		}
		private void CbEstado_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int cod;
				int.TryParse(cbEstado.SelectedValue.ToString(), out cod);

				Utils.CarregarComboCidade(cod, ref cbCidade);
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
				DateTime.TryParse(txtData.Text, out data);

				EnumTipoCargo cargo;
				Enum.TryParse(cbCargo.Text, out cargo);

				Endereco end = new Endereco(txtCep.Text, txtLogra.Text,numero, txtBairro.Text, cidade, estado);
				Funcionario func = new Funcionario(0,txtNomeFunc.Text, txtCpfFunc.Text, data,txtTelFunc.Text,txtEmail.Text,end,cargo);
				funcCtrl.InserirController(func);

				Utils.ExibirMensagem("Funcionário cadastrado com sucesso", eTipoMensagem.Sucesso);
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
			tabctrlFuncionario.SelectedTab = tabCadastroFunc;
		}

		private void btnPesquisarFunc_Click(object sender, EventArgs e)
		{
			try
			{
				string cpf;
				cpf = txtCpfPesquisar.Text.Replace(".", "").Replace("-", "").Replace("/", "");

				Funcionario func = new Funcionario(0, txtNomeFunc.Text, cpf, null, null, null, null, null);
				DataTable table = funcCtrl.GetDataTable(func);

				dtFuncionario.DataSource = table;
			}
			catch (Exception ex)
			{

				Util.Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
	}
}
