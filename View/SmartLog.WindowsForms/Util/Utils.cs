using SmartLogBusiness.Controller;
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
		public static void CarregarComboCidade(int codEstado, ref ComboBox combo)
		{
			try
			{
				ComboBox cb = combo;
				CidadeController cidCtrl = new CidadeController();

				if (codEstado > 0)
				{
					DataTable table = cidCtrl.CarregarCidadeController(codEstado);

					cb.DataSource = table;
					cb.DisplayMember = "Nome_Cidade";
					cb.ValueMember = "Cod_Cidade";
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		//Método para carregar combos de estado.
		public static void CarregarEstado(ref ComboBox combo)
		{
			try
			{
				ComboBox cb = combo;
				EstadoController estadoCtrl = new EstadoController();
				DataTable table = estadoCtrl.CarregarEstado();

				if (table != null)
				{
					cb.DataSource = table;
					cb.DisplayMember = "UF_Estado";
					cb.ValueMember = "Cod_Estado";
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		//Método para validar Maior de idade
		public static bool IsMaiorIdade(DateTime data)
		{
			if(System.DateTime.Now.Year -  data.Year >= 18)
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
			catch (Exception ex)
			{
				return false;
			}
		}
		//Método para validar preenchimento dos campos.
		
		public static void LimparCampos(Control cont)
		{
			if (cont is GroupBox)
			{
				for (int i = 0; i < cont.Controls.Count; i++)
				{
					if (cont.Controls[i] is TextBox)
					{
						(cont.Controls[i] as TextBox).Text = "";
					}
					if (cont.Controls[i] is ComboBox)
					{
						(cont.Controls[i] as ComboBox).SelectedIndex = -1;
					}
					if (cont.Controls[i] is ComboBox)
					{
						(cont.Controls[i] as ComboBox).SelectedValue = -1;
					}
				}

			}
		}
	}
}


