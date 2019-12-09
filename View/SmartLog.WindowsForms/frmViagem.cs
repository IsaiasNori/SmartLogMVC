using SmartLog.WindowsForms.Classes;
using SmartLog.WindowsForms.UserControl;
using SmartLog.WindowsForms.Util;
using SmartLogBusiness.Controller;
using SmartLogBusiness.Exceptions;
using SmartLogBusiness.Model.Entidade;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Model.Entidade.veiculo;
using SmartLogBusiness.Model.Entidade.viagem;
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
	public partial class frmViagem : Form
	{
		ViagemController viagemCtrl = new ViagemController();
		int codigoViagem;
		DataTable tableMotorista = null;
		DataTable tableCliente = null;

		public frmViagem()
		{
			InitializeComponent();
		}
		private void FrmViagem_Load(object sender, EventArgs e)
		{
			Utils.CarregarEstado(ref cbEstadoOrigem);
			Utils.CarregarEstado(ref cbEstadoDestino);
			Utils.CarregarStatusViagem(ref cbStatus);

			CarregarComboMotorista(ref cbMotoristaPesquisar);
			CarregarComboCliente(ref cbClientePesquisa);

			CarregarComboMotorista(ref cbMotoristaViagem);
			CarregarComboCliente(ref cbCliente);
			CarregarComboVeiculo(ref cbVeiculo);

			CarregarComboFuncionario(ref cbAtendente);
			Session.Instance.UserID = 2;
			cbAtendente.PosicionarCombo(Session.Instance.UserID);
		}
		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidateChildren() == false)
				{
					return;
				}
				Endereco origem = new Endereco(txtCepOrigem.Text, txtLograOrigem.Text, Convert.ToInt32(txtNumeroOrigem.Text), txtBairroOrigem.Text, cbCidadeOrigem.PegarComboSelecionado(), cbEstadoOrigem.PegarComboSelecionado());
				Endereco destino = new Endereco(txtCepDestino.Text, txtLograDestino.Text, Convert.ToInt32(txtNumeroDestino.Text), txtBairroDestino.Text, cbCidadeDestino.PegarComboSelecionado(), cbEstadoDestino.PegarComboSelecionado());

				Cliente cli = new Cliente(cbCliente.PegarComboSelecionado());

				Veiculo veic = new Veiculo(cbVeiculo.PegarComboSelecionado());
				Motorista moto = new Motorista(cbMotoristaViagem.PegarComboSelecionado());
				Funcionario func = new Funcionario(cbAtendente.PegarComboSelecionado());

				Viagem viagem = new Viagem(codigoViagem, dtDataViagem.Value, txtDistancia.Text, Convert.ToDecimal(txtValor.Text), origem, txtCompleOrigem.Text, destino, txtCompleDestino.Text, cli, veic, moto, func, (EnumStatusViagem)cbStatus.PegarComboSelecionado());

				if (codigoViagem == 0)
				{
					viagemCtrl.InserirController(viagem);
					Utils.ExibirMensagem("Viagem cadastrada com sucesso.", eTipoMensagem.Sucesso);
				}
				else
				{
					try
					{
						viagemCtrl.AlterarController(viagem);
						Utils.ExibirMensagem("Viagem alterada com sucesso", eTipoMensagem.Sucesso);
					}
					catch (BusinessException ex)
					{
						Utils.ExibirMensagem(ex.Message, eTipoMensagem.Atencao);
						Utils.ExibirMensagem("Viagem alterada com sucesso", eTipoMensagem.Sucesso);
					}

				}

				Utils.LimparCampos(gbDadosDestinoViagem);
				tabCtrlViagem.SelectedTab = tabConsultaViagem;
				Pesquisar();
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
				if (dgViagem.SelectedRows.Count > 0)
				{
					string codigo = dgViagem.SelectedRows[0].Cells[0].Value.ToString();
					int.TryParse(codigo, out codigoViagem);

					if (codigoViagem > 0)
					{
						Viagem viagem = new Viagem(codigoViagem);

						viagem = viagemCtrl.GetObj(viagem);

						dtDataViagem.Value = Convert.ToDateTime(viagem.DataViagem);
						cbStatus.PosicionarCombo(viagem.Status);
						cbMotoristaViagem.PosicionarCombo(viagem.Motorista.Codigo);
						cbVeiculo.PosicionarCombo(viagem.CodVeiculo.CodVei);
						cbAtendente.PosicionarCombo(viagem.Atendente.Codigo);
						cbCliente.PosicionarCombo(viagem.Cliente.Codigo);
						txtValor.Text = viagem.Valor.ToString();
						txtDistancia.Text = viagem.DistanciaKm;

						txtCepOrigem.Text = viagem.Origem.Cep;
						cbEstadoOrigem.PosicionarCombo(viagem.Origem.CodEstado);
						cbCidadeOrigem.PosicionarCombo(viagem.Origem.CodCidade);
						txtLograOrigem.Text = viagem.Origem.Logradouro;
						txtNumeroOrigem.Text = viagem.Origem.Numero.ToString();
						txtBairroOrigem.Text = viagem.Origem.Bairro;

						txtCepDestino.Text = viagem.Destino.Cep;
						cbEstadoDestino.PosicionarCombo(viagem.Destino.CodEstado);
						cbCidadeDestino.PosicionarCombo(viagem.Destino.CodCidade);
						txtLograDestino.Text = viagem.Destino.Logradouro;
						txtNumeroDestino.Text = viagem.Destino.Numero.ToString();
						txtBairroDestino.Text = viagem.Destino.Bairro;

						tabCtrlViagem.SelectedTab = tabCadastroViagem;
						gbDadosOrigemviagem.Enabled = false;
						gbDadosDestinoViagem.Enabled = false;
						cbMotoristaViagem.Enabled = false;
						cbVeiculo.Enabled = false;
						cbCliente.Enabled = false;
						dtDataViagem.Enabled = false;

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
		private void btnGridExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgViagem.SelectedRows.Count > 0)
				{

					if (MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{

						foreach(DataGridViewRow linha in dgViagem.SelectedRows)
						{

							string codigo = linha.Cells[0].Value.ToString();
							int.TryParse(codigo, out codigoViagem);

							if (codigoViagem > 0)
							{
								Viagem viagem = new Viagem(codigoViagem);


								viagemCtrl.DeletarController(viagem);
								
							}

						}

						Utils.ExibirMensagem("Registro excluído com sucesso.", eTipoMensagem.Sucesso);
						Pesquisar();


					}
				}
				else
				{
					Utils.ExibirMensagem("Para excluir um registro, é necessário seleciona-lo.", eTipoMensagem.Atencao);
				}
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void BtnVoltar_Click(object sender, EventArgs e)
		{
			tabCtrlViagem.SelectedTab = tabConsultaViagem;
		}
		private void BtnNovo_Click(object sender, EventArgs e)
		{
			Util.Utils.LimparCampos(gbDadosViagem1);
			Util.Utils.LimparCampos(gbDadosOrigemviagem);
			Util.Utils.LimparCampos(gbDadosDestinoViagem);

			codigoViagem = 0;
			tabCtrlViagem.SelectedTab = tabCadastroViagem;
		}
		private void btnFechaViagem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void cbEstadoOrigem_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Utils.CarregarComboCidade(cbEstadoOrigem.PegarComboSelecionado(), ref cbCidadeOrigem);

			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void cbEstadoDestino_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			try
			{
				Utils.CarregarComboCidade(cbEstadoDestino.PegarComboSelecionado(), ref cbCidadeDestino);
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void btnPesquisarViagem_Click(object sender, EventArgs e)
		{
			Pesquisar();
		}
		private void CbEstado_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Util.Utils.CarregarComboCidade(cbEstadoOrigem.PegarComboSelecionado(), ref cbCidadeOrigem);
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void CbEstadoDestino_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Util.Utils.CarregarComboCidade(cbEstadoDestino.PegarComboSelecionado(), ref cbCidadeDestino);

			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Utils.LimparCampos(gbDadosViagem1);
			Utils.LimparCampos(gbDadosOrigemviagem);
			Utils.LimparCampos(gbDadosDestinoViagem);
		}
		private void Pesquisar()
		{
			try
			{
				DateTime? dtInicio = null;
				DateTime? dtFim = null;
				if (chkData.Checked)
				{
					dtInicio = dtDataInicio.Value;
					dtFim = dtDataFim.Value;
				}
				Cliente cli = new Cliente(cbClientePesquisa.PegarComboSelecionado());

				Motorista motorista = new Motorista(cbMotoristaPesquisar.PegarComboSelecionado());

				Viagem viagem = new Viagem(dtInicio, dtFim, cli, motorista);

				DataTable table = viagemCtrl.GetDataTable(viagem);

				dgViagem.DataSource = table;
				dgViagem.AutoResizeColumns();
				dgViagem.ClearSelection();
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void CarregarComboMotorista(ref SuperComboBox combo)
		{
			try
			{
				MotoristaController motoristaCtrl = new MotoristaController();
				if (tableMotorista == null)
				{
					tableMotorista = motoristaCtrl.ComboMotorista();
				}

				combo.CarregaCombo(tableMotorista, "Cod_Motorista", "Nome_Motorista", UserControl.eTipoMensagem.Selecione);
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void CarregarComboCliente(ref SuperComboBox combo)
		{
			try
			{
				ClienteController cli = new ClienteController();
				if (tableCliente == null)
				{
					tableCliente = cli.ComboCliente();
				}

				combo.CarregaCombo(tableCliente, "Cod_Cliente", "Nome_Cliente", UserControl.eTipoMensagem.Selecione);

			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void CarregarComboVeiculo(ref SuperComboBox combo)
		{
			try
			{
				VeiculoController veicCtrl = new VeiculoController();

				DataTable table = veicCtrl.CarregarComboVeiculo();

				combo.CarregaCombo(table, "Cod_Veiculo", "Modelo", UserControl.eTipoMensagem.Selecione);
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		private void CarregarComboFuncionario(ref SuperComboBox combo)
		{
			try
			{
				FuncionarioController funcCtrl = new FuncionarioController();
				DataTable table = funcCtrl.CarregarComboFuncionario();

				combo.CarregaCombo(table, "Cod_Matricula", "Nome_Funcionario", UserControl.eTipoMensagem.Selecione);
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}

		private void dgViagem_DataSourceChanged(object sender, EventArgs e)
		{
			if (dgViagem.DataSource != null)
			{
				dgViagem.Columns[0].Visible = false;
				dgViagem.AutoResizeColumns();
			}
		}

		private void chkData_CheckedChanged(object sender, EventArgs e)
		{
			if (chkData.Checked)
			{
				dtDataInicio.Enabled = true;
				dtDataFim.Enabled = true;
			}
			else
			{
				dtDataInicio.Enabled = false; ;
				dtDataFim.Enabled = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                frmCalculaValor calcula = new frmCalculaValor();
                calcula.ShowDialog();

                if(calcula.valorTotal > 0)
                {
                    txtValor.Text = calcula.valorTotal.ToString();
                    txtDistancia.Text = calcula.distancia.ToString();
                }
            }
            catch (Exception ex)
            {

                Utils.ExibirMensagem(ex.Message,eTipoMensagem.Erro);
            }
        }
    }
}

