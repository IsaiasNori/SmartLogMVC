using SmartLogBusiness.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLog.WindowsForms.DeskTopPresentation.Util
{
	public static class Utils
	{


		public static void ExibirMensagem(string mensagem, eTipoMensagem tipo)
		{
			frmMensagem msg = new frmMensagem(mensagem, tipo);
			msg.ShowDialog();

		}
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
		public static bool IsDate(string data)
		{
			try
			{
				DateTime dataRetorno;
				DateTime.TryParse(data, out dataRetorno);

				if (dataRetorno.Year > 1900)
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


	}
}
