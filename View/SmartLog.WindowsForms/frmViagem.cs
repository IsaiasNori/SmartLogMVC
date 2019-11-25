using SmartLog.WindowsForms.Classes;
using SmartLog.WindowsForms.Util;
using SmartLogBusiness.Controller;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Model.Entidade.viagem;
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
	public partial class frmViagem : Form
	{
		ViagemController viagemCtrl = new ViagemController();
		public frmViagem()
		{
			InitializeComponent();
		}
		private void FrmViagem_Load(object sender, EventArgs e)
		{
			

			Util.Utils.CarregarEstado(ref cbEstadoOrigem);
			Util.Utils.CarregarEstado(ref cbEstadoDestino);

		}
		
		
		private void CbEstado_SelectedIndexChanged(object sender, EventArgs e)
		{

			
			Util.Utils.CarregarComboCidade(cbEstadoOrigem.PegarComboSelecionado(), ref cbCidadeOrigem);
			
		}
		private void CbEstadoDestino_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			Util.Utils.CarregarComboCidade(cbEstadoDestino.PegarComboSelecionado(), ref cbCidadeDestino);

		}
		private void BtnVoltarFunc_Click(object sender, EventArgs e)
		{
			tabCtrlViagem.SelectedTab = tabConsultaViagem;
		}
		private void BtnNovo_Click(object sender, EventArgs e)
		{
			Util.Utils.LimparCampos(gbDadosViagem1);
			Util.Utils.LimparCampos(gbDadosOrigemviagem);
			Util.Utils.LimparCampos(gbDadosDestinoViagem);
			tabCtrlViagem.SelectedTab = tabCadastroViagem;
		}

		private void DtCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			/*cbM
			Motorista motorista = new Motorista(tx)
			
			viagem.GetDataTable*/
		}

		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			//Viagem vi = new Viagem(0,,)


		//	viagemCtrl.InserirController(vi)
				
		}

		private void btnFechaViagem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbEstadoOrigem_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			Utils.CarregarComboCidade(cbEstadoOrigem.PegarComboSelecionado(), ref cbCidadeOrigem);
		}

		private void cbEstadoDestino_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			Utils.CarregarComboCidade(cbEstadoDestino.PegarComboSelecionado(), ref cbCidadeDestino);
		}
	}
}
