using SmartLog.WindowsForms.DeskTopPresentation.Util;
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

namespace SmartLog.WindowsForms.DeskTopPresentation
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
			CarregarEstado();
		}
		private void CarregarTipoCargo()
		{
			TipoDeCargoController cargo = new TipoDeCargoController();

			DataTable table = cargo.GetDataTable(null);

			cbCargo.DataSource = table;
			cbCargo.DisplayMember = "Cargo";
			cbCargo.ValueMember = "Cod_Cargo";
		}
		private void CarregarEstado()
		{
			EstadoController estadoCtrl = new EstadoController();
			DataTable table = estadoCtrl.CarregarEstado();
			try
			{
				if (table != null)
				{
					cbEstado.DataSource = table;
					cbEstado.DisplayMember = "UF_Estado";
					cbEstado.ValueMember = "Cod_Estado";
				}

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		private void CbEstado_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string codEstado = cbEstado.SelectedValue.ToString();
				int cod;

				int.TryParse(codEstado, out cod);
				CidadeController cidCtrl = new CidadeController();

				if (cod > 0)
				{
					DataTable table = cidCtrl.CarregarCidadeController(cod);

					cbCidade.DataSource = table;
					cbCidade.DisplayMember = "Nome_Cidade";
					cbCidade.ValueMember = "Cod_Cidade";
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
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
				Funcionario func = new Funcionario(0,txtNomeFunc.Text,data,txtTelFunc.Text,txtEmail.Text,txtCpfFunc.Text,end,cargo);
				funcCtrl.InserirController(func);

				Utils.ExibirMensagem("Funcionário cadastrado com sucesso", eTipoMensagem.Sucesso);

				

			}
			catch (Exception ex)
			{

				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
	}
}
