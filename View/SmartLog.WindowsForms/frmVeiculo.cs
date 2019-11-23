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
		public frmVeiculo()
		{
			InitializeComponent();
		}

		private void frmVeiculo_Load(object sender, EventArgs e)
		{
			CarregarMarca(ref cbMarca);
			CarregarMarca(ref cbMarcaPesquisa);
			CarregarStatusVeiculo();
		}
		private void CarregarMarca(ref ComboBox combo)
		{
			try
			{
				MarcaController marcaCtrl = new MarcaController();
				List<Marca> lista = marcaCtrl.ListasController();
				if(lista != null)
				{
					combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("--Selecione--", -1));

					foreach(Marca marca in lista)
					{
						combo.Items.Add(new SmartLog.WindowsForms.Classes.Item(marca.Descricao, marca.CodMarca));
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		private void CarregarStatusVeiculo()
		{
			try
			{
				cbStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("--Selecione--", -1));
				cbStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("Disponivel",(int)enumStatusVeiculo.Disponivel));
				cbStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("Transito", (int)enumStatusVeiculo.Transito));
				cbStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("Manutenção", (int)enumStatusVeiculo.Manutencao));
				cbStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("Sem Licenciamento", (int)enumStatusVeiculo.SemLicenciamento));
				cbStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("Desativado", (int)enumStatusVeiculo.Desativado));
			}
			catch (Exception)
			{

				throw;
			}
		}

		private void btnNovoVeiculo_Click(object sender, EventArgs e)
		{
			tabctrlVeiculo.SelectTab("tpCadastro");
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{


				if(VerificarCamposObrigatoriosInformados() == false)
				{
					return;
				}



				DateTime? dataUltima = new DateTime();

				if (Utils.IsDate(txtDataUltRev.Text))
				{
					dataUltima = Convert.ToDateTime(txtDataUltRev.Text);
				}

				Classes.Item status = (Classes.Item)cbStatus.SelectedItem;
				Classes.Item marca = (Classes.Item)cbMarca.SelectedItem;
				





				Veiculo vei = new Veiculo(Convert.ToInt32(marca.Value),
										   txtModelo.Text,
										   txtRenavam.Text,
										   (enumStatusVeiculo)status.Value,
										   txtData.Value,
										   txtAnoFab.Text,
										   txtKmAtual.Text,
										   txtKmPrev.Text,dataUltima
										   );
				veiCtrl.InserirController(vei);

				Utils.ExibirMensagem("Veiculo inserido com sucesso", eTipoMensagem.Sucesso);


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
				if(txtModelo.Text == "")
				{
					mensagem += "Informar o modelo" + Environment.NewLine; ;
				}
				if(txtRenavam.Text == "")
				{
					mensagem += "Informar o renavem" + Environment.NewLine; ;
				}

				Classes.Item item = (Classes.Item)cbStatus.SelectedItem;
				if(item==null || item.Value.ToString() == "-1")
				{
					mensagem += "Informar o status" + Environment.NewLine; ;
				}
				Classes.Item marca = (Classes.Item)cbMarca.SelectedItem;
				if(marca==null || marca.Value.ToString() == "-1")
				{
					mensagem += "Informar a marca" + Environment.NewLine;
				}
				if(mensagem == "")
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

				return false;
			}
		}

		private void btnPesquisarVeiculo_Click(object sender, EventArgs e)
		{
			try
			{
				int codmarca= 0 ;

				Classes.Item marca = (Classes.Item)cbMarcaPesquisa.SelectedItem;
				if (marca != null)
				{
					if((int)marca.Value != -1)
					codmarca = Convert.ToInt32(marca.Value);
				}

				Veiculo vei = new Veiculo(codmarca, txtModeloPesquisa.Text);
				DataTable table = veiCtrl.GetDataTable(vei);

				if(table != null)
				{
					dtVeiculo.DataSource = table;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		private void DtVeiculo_DataSourceChanged(object sender, EventArgs e)
		{
			if(dtVeiculo.DataSource != null)
			{
				dtVeiculo.Columns[0].Visible = false;
			}
		}
	}
}
