using SmartLog.WindowsForms.Util;
using SmartLogBusiness.Controller;
using SmartLogBusiness.Model.Entidade.veiculo;
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
    public partial class frmManutencao : Form
    {
        ManutencaoController manuCtrl = new ManutencaoController();
        int codigoManu;
        public frmManutencao()
        {
            InitializeComponent();
        }

        private void frmManutencao_Load(object sender, EventArgs e)
        {
            CarregarComboVeiculo();
            CarregarComboStatus();

        }

        private void btnPesquisarManu_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void Pesquisar()
        {
            DateTime? dataEntradaInicio = null;
            DateTime? dataEntradaFinal = null;
            DateTime? dataSaidaInicio = null;
            DateTime? dataSaidaFinal = null;


            try
            {
                if (chkFiltroPerido.Checked)
                {
                    dataEntradaInicio = dtEntradaInicio.Value;
                    dataEntradaFinal = dtEntradaFinal.Value;
                    dataSaidaInicio = dtSaidaInicio.Value;
                    dataSaidaFinal = dtSaidaFinal.Value;
                }

                Manutencao manu = new Manutencao(dataEntradaInicio, dataSaidaInicio, txtDescServicoPesquisa.Text, dataEntradaFinal, dataSaidaFinal);

                DataTable table = manuCtrl.GetDataTable(manu);

                dgManutencao.DataSource = table;
                dgManutencao.AutoResizeColumns();
                dgManutencao.ClearSelection();

            }
            catch (Exception ex)
            {
                Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabCtrlManutencao.SelectedTab = tabCadastroManu;
            comboStatus.PosicionarCombo(1);
            comboStatus.Enabled = false;
            codigoManu = 0;
        }

        private void btnFechaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgManutencao_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgManutencao.DataSource != null)
            {
                dgManutencao.Columns[0].Visible = false;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Utils.LimparCampos(gbDadosManu);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            tabCtrlManutencao.SelectedTab = tabConsultaManu;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren() == false)
                {
                    return;
                }

                Manutencao manu = new Manutencao(codigoManu, dtDataEntradaCadastro.Value, dtSaidaCadastro.Value, txtDescServico.Text, cbVeiculo.PegarComboSelecionado(), (EnumStatusManutencao)comboStatus.PegarComboSelecionado());

                if (codigoManu == 0)
                {
                    manuCtrl.InserirController(manu);
                    Utils.ExibirMensagem("Manutenção cadastrada com sucesso.", eTipoMensagem.Sucesso);
                }
                else
                {
                    manuCtrl.AlterarController(manu);
                    Utils.ExibirMensagem("Manutenção alterada com sucesso.", eTipoMensagem.Sucesso);
                }
                Utils.LimparCampos(gbDadosManu);
                tabCtrlManutencao.SelectedTab = tabConsultaManu;
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
                if (dgManutencao.SelectedRows.Count > 0)
                {
                    string codigo = dgManutencao.SelectedRows[0].Cells[0].Value.ToString();

                    int.TryParse(codigo, out codigoManu);
                    if (codigoManu > 0)
                    {
                        Manutencao manu = new Manutencao(codigoManu);

                        manu = manuCtrl.GetObj(manu);

                        dtDataEntradaCadastro.Value = Convert.ToDateTime(manu.DataEntrada);
                        dtSaidaCadastro.Value = Convert.ToDateTime(manu.DataPrevistaSaida);
                        cbVeiculo.PosicionarCombo(manu.CodVeiculo);
                        txtDescServico.Text = manu.DescricaoServico;
                        comboStatus.PosicionarCombo((int)manu.StatusManutencao);
                        tabCtrlManutencao.SelectedTab = tabCadastroManu;
                        comboStatus.Enabled = true;

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
                if (dgManutencao.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string codigo = dgManutencao.SelectedRows[0].Cells[0].Value.ToString();
                        int.TryParse(codigo, out codigoManu);

                        Manutencao manu = new Manutencao(codigoManu);
                        manuCtrl.DeletarController(manu);
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

        private void chkFiltroPerido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltroPerido.Checked)
            {
                dtEntradaInicio.Enabled = true;
                dtEntradaFinal.Enabled = true;
                dtSaidaInicio.Enabled = true;
                dtSaidaFinal.Enabled = true;

            }
            else
            {
                dtEntradaInicio.Enabled = false;
                dtEntradaFinal.Enabled = false;
                dtSaidaInicio.Enabled = false;
                dtSaidaFinal.Enabled = false;
            }
        }
        private void CarregarComboVeiculo()
        {
            try
            {
                VeiculoController veiCtrl = new VeiculoController();

                DataTable table = veiCtrl.CarregarVeiculoManu();
                if (table != null)
                {
                    cbVeiculo.CarregaCombo(table, "Cod_Veiculo", "Modelo", UserControl.eTipoMensagem.Selecione);

                }

            }
            catch (Exception ex)
            {
                Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
            }

        }

        private void CarregarComboStatus()
        {
            try
            {
                comboStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("--Selecione --", 0));
                comboStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("Aberto", EnumStatusManutencao.Aberto));
                comboStatus.Items.Add(new SmartLog.WindowsForms.Classes.Item("Finalizado", EnumStatusManutencao.Finalizado));
            }
            catch (Exception ex)
            {
                Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
            }

        }

    }
}
