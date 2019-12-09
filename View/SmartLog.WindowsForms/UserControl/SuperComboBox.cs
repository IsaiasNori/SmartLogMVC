using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLog.WindowsForms.UserControl
{
	public enum eTipoMensagem
	{
		Nada = 1,
		Selecione = 2,
		Todos = 3
	}
	public class SuperComboBox : ComboBox
	{
		public ErrorProvider provider = new ErrorProvider();
		public bool CampoObrigatorio { get; set; }
		public string MensagemCampoObrigatorio { get; set; }

		public bool isControle;

		protected override void OnLeave(EventArgs e)
		{
			isControle = true;
		}
		protected override void OnValidating(CancelEventArgs e)
		{
			if (isControle == false)
			{
				e.Cancel = !VerificarCampoObrigatorio();
			}

			isControle = false;
		}

		public bool VerificarCampoObrigatorio()
		{
			bool valido = true;

			if (CampoObrigatorio)
			{
				if(this.PegarComboSelecionado() <= 0)
				{
					provider.SetError(this, MensagemCampoObrigatorio);
					valido = false;
				}
				else
				{
					provider.Clear();
				}
			}

			return valido;

		}
		public void CarregaCombo(DataTable table, string codigo, string descricao, eTipoMensagem tipo)
		{

			string valor = "";
			this.Items.Clear();


			if (tipo == eTipoMensagem.Selecione)
			{
				valor = "--Selecione--";
			}
			else if (tipo == eTipoMensagem.Todos)
			{
				valor = "--Todos--";
			}

			if (tipo == eTipoMensagem.Selecione || tipo == eTipoMensagem.Todos)
			{
				this.Items.Add(new Classes.Item(valor, 0));
			}

			foreach (DataRow linha in table.Rows)
			{
				this.Items.Add(new Classes.Item(linha[descricao].ToString(), (int)linha[codigo]));
			}

			this.SelectedIndex = 0;


		}

		public int PegarComboSelecionado()
		{
			int comb;

			try
			{
				Classes.Item i = (Classes.Item)this.SelectedItem;
				if(i == null)
				{
					return 0;
				}

				comb = (int)i.Value;
				return comb;
			}
			catch (Exception)
			{
				return -1;
				
			}
			 
		}
		public void PosicionarCombo(object id)
		{

			Classes.Item item = new Classes.Item("", id);

			for (int i = 0; i < this.Items.Count; i++)
			{
				
   
				if ((int)((Classes.Item)this.Items[i]).Value == (int)item.Value)
				{
					this.SelectedIndex = i;
					return;
				}
			}
		}
	}
}
