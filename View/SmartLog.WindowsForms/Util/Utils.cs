using SmartLog.WindowsForms.UserControl;
using SmartLogBusiness.Controller;
using SmartLogBusiness.Model.Entidade.veiculo;
using SmartLogBusiness.Model.Entidade.viagem;
using SmartLogBusiness.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLog.WindowsForms.Util
{
	public static class Utils
	{
		//Método para exibir mensagem de erros, sucessos ou alertas.
		public static void ExibirMensagem(string mensagem, eTipoMensagem tipo)
		{
			frmMensagem msg = new frmMensagem(mensagem, tipo);
			msg.ShowDialog();
		}

		//Método para carregar os combos de cidade.
		public static void CarregarComboCidade(int codEstado, ref SuperComboBox combo)
		{
			try
			{

				CidadeController cidCtrl = new CidadeController();

				if (codEstado > 0)
				{
					DataTable table = cidCtrl.CarregarCidadeController(codEstado);

					combo.CarregaCombo(table, "Cod_Cidade", "Nome_Cidade", UserControl.eTipoMensagem.Selecione);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		//Método para carregar combos de estado.
		public static void CarregarEstado(ref SuperComboBox combo)
		{
			try
			{
				EstadoController estadoCtrl = new EstadoController();
				DataTable table = estadoCtrl.CarregarEstado();

				if (table != null)
				{
					combo.CarregaCombo(table, "Cod_Estado", "UF_Estado", UserControl.eTipoMensagem.Selecione);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		//Método para carregar combo de status do motorista.
		public static void CarregarStatusMotorista(ref SuperComboBox combo)
		{
			try
			{
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Ativo", (int)EnumStatusMotorista.Ativo));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Inativo", (int)EnumStatusMotorista.Inativo));
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}

		//Método para carregar combo de categoria da cnh.
		public static void CarregarCnhCategoria(ref SuperComboBox combo)
		{
			try
			{
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("--Selecione--", 0));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("A", EnumCnhCategoriaMotorista.A));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("B", EnumCnhCategoriaMotorista.B));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("C", EnumCnhCategoriaMotorista.C));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("D", EnumCnhCategoriaMotorista.D));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("E", EnumCnhCategoriaMotorista.E));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("AB", EnumCnhCategoriaMotorista.AB));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("AC", EnumCnhCategoriaMotorista.AC));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("AD", EnumCnhCategoriaMotorista.AD));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("AE", EnumCnhCategoriaMotorista.AE));

				combo.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}

		}
		//Método para carregar combo Status Viagem
		public static void CarregarStatusViagem(ref SuperComboBox combo)
		{
			try
			{
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("--Selecione--", 0));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Pendente", EnumStatusViagem.Pendente));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Em Trânsito", EnumStatusViagem.EmTransito));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Finalizada", EnumStatusViagem.Finalizada));

				combo.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}
		}
		public static void CarregarStatusVeiculo(ref SuperComboBox combo)
		{
			try
			{
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("--Selecione--", 0));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Disponivel", enumStatusVeiculo.Disponivel));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Transito", enumStatusVeiculo.Transito));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Manutenção", enumStatusVeiculo.Manutencao));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Sem Licenciamento", enumStatusVeiculo.SemLicenciamento));
				combo.Items.Add(new SmartLog.WindowsForms.Classes.Item("Desativado", enumStatusVeiculo.Desativado));

				combo.SelectedIndex = 0;

			}
			catch (Exception ex)
			{
				Utils.ExibirMensagem(ex.Message, eTipoMensagem.Erro);
			}

		}

		//Método para validar Maior de idade
		public static bool IsMaiorIdade(DateTime data)
		{
			if (System.DateTime.Now.Year - data.Year >= 18)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		//Método para validar conversão data
		public static bool IsDate(string data)
		{
			try
			{
				DateTime dataRetorno;
				DateTime.TryParse(data, out dataRetorno);

				if (dataRetorno.Year > 1)
				{
					return true;
				}
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public static bool IsNumeric(string texto)
		{
			try
			{
				decimal retorno;
				decimal.TryParse(texto, out retorno);

				if (retorno > 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}

		//Método para validar preenchimento dos campos.
		public static void LimparCampos(Control cont)
		{
			try
			{
				if (cont is GroupBox)
				{
					for (int i = 0; i < cont.Controls.Count; i++)
					{
						if (cont.Controls[i] is TextBox)
						{
							(cont.Controls[i] as TextBox).Text = "";
						}
						/*	if (cont.Controls[i] is ComboBox)
							{
								(cont.Controls[i] as ComboBox).SelectedIndex = -1;
							}*/
						if (cont.Controls[i] is ComboBox)
						{
							(cont.Controls[i] as ComboBox).SelectedValue = 0;
						}
					}
				}
			}
			catch (Exception)
			{
				
			}
		}
	}
}


