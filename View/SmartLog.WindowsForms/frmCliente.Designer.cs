namespace SmartLog.WindowsForms
{
	partial class frmCliente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabCtrlCliente = new System.Windows.Forms.TabControl();
			this.tabConsultaCli = new System.Windows.Forms.TabPage();
			this.btnFechaCliente = new System.Windows.Forms.Button();
			this.dgCliente = new System.Windows.Forms.DataGridView();
			this.gbFiltrarCliente = new System.Windows.Forms.GroupBox();
			this.pnlFiltrarCliente = new System.Windows.Forms.Panel();
			this.lblNomePesquisa = new System.Windows.Forms.Label();
			this.lblCpfPesquisa = new System.Windows.Forms.Label();
			this.txtCpfPesquisar = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNomePesquisar = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.tabCadastroCli = new System.Windows.Forms.TabPage();
			this.gbDadosCliente = new System.Windows.Forms.GroupBox();
			this.cbTipoCli = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbCidade = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbEstado = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.dtDataCadastro = new System.Windows.Forms.DateTimePicker();
			this.txtEmailCli = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCep = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblDataCadastro = new System.Windows.Forms.Label();
			this.txtNumero = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtBairro = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtLogra = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtTelCli = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNomeCli = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
			this.txtCpfCnpjCli = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblCep = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblTipoCli = new System.Windows.Forms.Label();
			this.lblCpfCnpjCli = new System.Windows.Forms.Label();
			this.lblDataNasc = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTelCli = new System.Windows.Forms.Label();
			this.lblNomeCli = new System.Windows.Forms.Label();
			this.lblCodCli = new System.Windows.Forms.Label();
			this.txtCodigoCli = new System.Windows.Forms.TextBox();
			this.btnGridExcluir = new System.Windows.Forms.Button();
			this.btnGridAlterar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnPesquisarCli = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnVoltarCli = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.tabCtrlCliente.SuspendLayout();
			this.tabConsultaCli.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
			this.gbFiltrarCliente.SuspendLayout();
			this.pnlFiltrarCliente.SuspendLayout();
			this.tabCadastroCli.SuspendLayout();
			this.gbDadosCliente.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCtrlCliente
			// 
			this.tabCtrlCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabCtrlCliente.Controls.Add(this.tabConsultaCli);
			this.tabCtrlCliente.Controls.Add(this.tabCadastroCli);
			this.tabCtrlCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabCtrlCliente.Location = new System.Drawing.Point(63, 2);
			this.tabCtrlCliente.Name = "tabCtrlCliente";
			this.tabCtrlCliente.Padding = new System.Drawing.Point(50, 5);
			this.tabCtrlCliente.SelectedIndex = 0;
			this.tabCtrlCliente.Size = new System.Drawing.Size(1056, 641);
			this.tabCtrlCliente.TabIndex = 0;
			// 
			// tabConsultaCli
			// 
			this.tabConsultaCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabConsultaCli.Controls.Add(this.btnFechaCliente);
			this.tabConsultaCli.Controls.Add(this.btnGridExcluir);
			this.tabConsultaCli.Controls.Add(this.btnGridAlterar);
			this.tabConsultaCli.Controls.Add(this.btnNovo);
			this.tabConsultaCli.Controls.Add(this.dgCliente);
			this.tabConsultaCli.Controls.Add(this.gbFiltrarCliente);
			this.tabConsultaCli.Location = new System.Drawing.Point(4, 33);
			this.tabConsultaCli.Name = "tabConsultaCli";
			this.tabConsultaCli.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaCli.Size = new System.Drawing.Size(1048, 604);
			this.tabConsultaCli.TabIndex = 0;
			this.tabConsultaCli.Text = "Consulta";
			// 
			// btnFechaCliente
			// 
			this.btnFechaCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnFechaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnFechaCliente.FlatAppearance.BorderSize = 0;
			this.btnFechaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnFechaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFechaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnFechaCliente.Image = global::SmartLog.WindowsForms.Properties.Resources.iconFechar;
			this.btnFechaCliente.Location = new System.Drawing.Point(722, 233);
			this.btnFechaCliente.Name = "btnFechaCliente";
			this.btnFechaCliente.Size = new System.Drawing.Size(139, 39);
			this.btnFechaCliente.TabIndex = 7;
			this.btnFechaCliente.Text = "Fechar";
			this.btnFechaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechaCliente.UseVisualStyleBackColor = false;
			this.btnFechaCliente.Click += new System.EventHandler(this.btnFechaCliente_Click);
			// 
			// dgCliente
			// 
			this.dgCliente.AllowUserToAddRows = false;
			this.dgCliente.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgCliente.ColumnHeadersHeight = 35;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgCliente.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgCliente.EnableHeadersVisualStyles = false;
			this.dgCliente.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgCliente.Location = new System.Drawing.Point(101, 298);
			this.dgCliente.Name = "dgCliente";
			this.dgCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgCliente.Size = new System.Drawing.Size(859, 293);
			this.dgCliente.TabIndex = 1;
			this.dgCliente.DataSourceChanged += new System.EventHandler(this.dtCliente_DataSourceChanged);
			this.dgCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtCliente_MouseClick);
			// 
			// gbFiltrarCliente
			// 
			this.gbFiltrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbFiltrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbFiltrarCliente.Controls.Add(this.pnlFiltrarCliente);
			this.gbFiltrarCliente.Location = new System.Drawing.Point(101, 27);
			this.gbFiltrarCliente.Name = "gbFiltrarCliente";
			this.gbFiltrarCliente.Size = new System.Drawing.Size(859, 172);
			this.gbFiltrarCliente.TabIndex = 10;
			this.gbFiltrarCliente.TabStop = false;
			this.gbFiltrarCliente.Text = "Filtrar Cliente";
			// 
			// pnlFiltrarCliente
			// 
			this.pnlFiltrarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pnlFiltrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.pnlFiltrarCliente.Controls.Add(this.lblNomePesquisa);
			this.pnlFiltrarCliente.Controls.Add(this.btnPesquisarCli);
			this.pnlFiltrarCliente.Controls.Add(this.lblCpfPesquisa);
			this.pnlFiltrarCliente.Controls.Add(this.txtCpfPesquisar);
			this.pnlFiltrarCliente.Controls.Add(this.txtNomePesquisar);
			this.pnlFiltrarCliente.Location = new System.Drawing.Point(33, 35);
			this.pnlFiltrarCliente.Name = "pnlFiltrarCliente";
			this.pnlFiltrarCliente.Size = new System.Drawing.Size(799, 116);
			this.pnlFiltrarCliente.TabIndex = 9;
			// 
			// lblNomePesquisa
			// 
			this.lblNomePesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblNomePesquisa.AutoSize = true;
			this.lblNomePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNomePesquisa.Location = new System.Drawing.Point(93, 25);
			this.lblNomePesquisa.Name = "lblNomePesquisa";
			this.lblNomePesquisa.Size = new System.Drawing.Size(58, 20);
			this.lblNomePesquisa.TabIndex = 4;
			this.lblNomePesquisa.Text = "Cliente";
			// 
			// lblCpfPesquisa
			// 
			this.lblCpfPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCpfPesquisa.AutoSize = true;
			this.lblCpfPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCpfPesquisa.Location = new System.Drawing.Point(367, 25);
			this.lblCpfPesquisa.Name = "lblCpfPesquisa";
			this.lblCpfPesquisa.Size = new System.Drawing.Size(40, 20);
			this.lblCpfPesquisa.TabIndex = 5;
			this.lblCpfPesquisa.Text = "CPF";
			// 
			// txtCpfPesquisar
			// 
			this.txtCpfPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtCpfPesquisar.CampoObrigatorio = false;
			this.txtCpfPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCpfPesquisar.Location = new System.Drawing.Point(371, 48);
			this.txtCpfPesquisar.MaxLength = 18;
			this.txtCpfPesquisar.MensagemObrigatorio = null;
			this.txtCpfPesquisar.Name = "txtCpfPesquisar";
			this.txtCpfPesquisar.Size = new System.Drawing.Size(188, 24);
			this.txtCpfPesquisar.TabIndex = 2;
			this.txtCpfPesquisar.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
			// 
			// txtNomePesquisar
			// 
			this.txtNomePesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtNomePesquisar.CampoObrigatorio = false;
			this.txtNomePesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNomePesquisar.Location = new System.Drawing.Point(97, 48);
			this.txtNomePesquisar.MensagemObrigatorio = null;
			this.txtNomePesquisar.Name = "txtNomePesquisar";
			this.txtNomePesquisar.Size = new System.Drawing.Size(252, 24);
			this.txtNomePesquisar.TabIndex = 1;
			this.txtNomePesquisar.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// tabCadastroCli
			// 
			this.tabCadastroCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabCadastroCli.Controls.Add(this.btnLimpar);
			this.tabCadastroCli.Controls.Add(this.gbDadosCliente);
			this.tabCadastroCli.Controls.Add(this.lblCodCli);
			this.tabCadastroCli.Controls.Add(this.txtCodigoCli);
			this.tabCadastroCli.Controls.Add(this.btnVoltarCli);
			this.tabCadastroCli.Controls.Add(this.btnSalvar);
			this.tabCadastroCli.Location = new System.Drawing.Point(4, 33);
			this.tabCadastroCli.Name = "tabCadastroCli";
			this.tabCadastroCli.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroCli.Size = new System.Drawing.Size(1048, 604);
			this.tabCadastroCli.TabIndex = 1;
			this.tabCadastroCli.Text = "Cadastro";
			// 
			// gbDadosCliente
			// 
			this.gbDadosCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gbDadosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbDadosCliente.Controls.Add(this.cbTipoCli);
			this.gbDadosCliente.Controls.Add(this.cbCidade);
			this.gbDadosCliente.Controls.Add(this.cbEstado);
			this.gbDadosCliente.Controls.Add(this.dtDataCadastro);
			this.gbDadosCliente.Controls.Add(this.txtEmailCli);
			this.gbDadosCliente.Controls.Add(this.txtCep);
			this.gbDadosCliente.Controls.Add(this.lblDataCadastro);
			this.gbDadosCliente.Controls.Add(this.txtNumero);
			this.gbDadosCliente.Controls.Add(this.txtBairro);
			this.gbDadosCliente.Controls.Add(this.txtLogra);
			this.gbDadosCliente.Controls.Add(this.txtTelCli);
			this.gbDadosCliente.Controls.Add(this.txtNomeCli);
			this.gbDadosCliente.Controls.Add(this.dtDataNasc);
			this.gbDadosCliente.Controls.Add(this.txtCpfCnpjCli);
			this.gbDadosCliente.Controls.Add(this.lblCep);
			this.gbDadosCliente.Controls.Add(this.lblBairro);
			this.gbDadosCliente.Controls.Add(this.lblNumero);
			this.gbDadosCliente.Controls.Add(this.lblLogradouro);
			this.gbDadosCliente.Controls.Add(this.lblCidade);
			this.gbDadosCliente.Controls.Add(this.lblEstado);
			this.gbDadosCliente.Controls.Add(this.lblTipoCli);
			this.gbDadosCliente.Controls.Add(this.lblCpfCnpjCli);
			this.gbDadosCliente.Controls.Add(this.lblDataNasc);
			this.gbDadosCliente.Controls.Add(this.lblEmail);
			this.gbDadosCliente.Controls.Add(this.lblTelCli);
			this.gbDadosCliente.Controls.Add(this.lblNomeCli);
			this.gbDadosCliente.Location = new System.Drawing.Point(131, 57);
			this.gbDadosCliente.Name = "gbDadosCliente";
			this.gbDadosCliente.Size = new System.Drawing.Size(815, 392);
			this.gbDadosCliente.TabIndex = 69;
			this.gbDadosCliente.TabStop = false;
			this.gbDadosCliente.Text = "Dados do Cliente";
			// 
			// cbTipoCli
			// 
			this.cbTipoCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbTipoCli.CampoObrigatorio = true;
			this.cbTipoCli.FormattingEnabled = true;
			this.cbTipoCli.Location = new System.Drawing.Point(101, 154);
			this.cbTipoCli.MensagemCampoObrigatorio = null;
			this.cbTipoCli.Name = "cbTipoCli";
			this.cbTipoCli.Size = new System.Drawing.Size(168, 28);
			this.cbTipoCli.TabIndex = 3;
			// 
			// cbCidade
			// 
			this.cbCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbCidade.CampoObrigatorio = true;
			this.cbCidade.FormattingEnabled = true;
			this.cbCidade.Location = new System.Drawing.Point(569, 269);
			this.cbCidade.MensagemCampoObrigatorio = null;
			this.cbCidade.Name = "cbCidade";
			this.cbCidade.Size = new System.Drawing.Size(194, 28);
			this.cbCidade.TabIndex = 9;
			// 
			// cbEstado
			// 
			this.cbEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbEstado.CampoObrigatorio = true;
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(371, 269);
			this.cbEstado.MensagemCampoObrigatorio = null;
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(118, 28);
			this.cbEstado.TabIndex = 8;
			this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
			// 
			// dtDataCadastro
			// 
			this.dtDataCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dtDataCadastro.Enabled = false;
			this.dtDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataCadastro.Location = new System.Drawing.Point(101, 45);
			this.dtDataCadastro.Name = "dtDataCadastro";
			this.dtDataCadastro.Size = new System.Drawing.Size(148, 26);
			this.dtDataCadastro.TabIndex = 1;
			// 
			// txtEmailCli
			// 
			this.txtEmailCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtEmailCli.CampoObrigatorio = false;
			this.txtEmailCli.Location = new System.Drawing.Point(371, 209);
			this.txtEmailCli.MensagemObrigatorio = null;
			this.txtEmailCli.Name = "txtEmailCli";
			this.txtEmailCli.Size = new System.Drawing.Size(190, 26);
			this.txtEmailCli.TabIndex = 6;
			this.txtEmailCli.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtCep
			// 
			this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtCep.CampoObrigatorio = false;
			this.txtCep.Location = new System.Drawing.Point(101, 271);
			this.txtCep.MensagemObrigatorio = null;
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(168, 26);
			this.txtCep.TabIndex = 7;
			this.txtCep.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// lblDataCadastro
			// 
			this.lblDataCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblDataCadastro.AutoSize = true;
			this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDataCadastro.Location = new System.Drawing.Point(97, 22);
			this.lblDataCadastro.Name = "lblDataCadastro";
			this.lblDataCadastro.Size = new System.Drawing.Size(132, 20);
			this.lblDataCadastro.TabIndex = 99;
			this.lblDataCadastro.Text = "Data de cadastro";
			// 
			// txtNumero
			// 
			this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtNumero.CampoObrigatorio = false;
			this.txtNumero.Location = new System.Drawing.Point(371, 337);
			this.txtNumero.MensagemObrigatorio = null;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(118, 26);
			this.txtNumero.TabIndex = 11;
			this.txtNumero.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtBairro
			// 
			this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtBairro.CampoObrigatorio = false;
			this.txtBairro.Location = new System.Drawing.Point(569, 337);
			this.txtBairro.MensagemObrigatorio = null;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(194, 26);
			this.txtBairro.TabIndex = 12;
			this.txtBairro.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtLogra
			// 
			this.txtLogra.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtLogra.CampoObrigatorio = false;
			this.txtLogra.Location = new System.Drawing.Point(101, 339);
			this.txtLogra.MensagemObrigatorio = null;
			this.txtLogra.Name = "txtLogra";
			this.txtLogra.Size = new System.Drawing.Size(249, 26);
			this.txtLogra.TabIndex = 10;
			this.txtLogra.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtTelCli
			// 
			this.txtTelCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtTelCli.CampoObrigatorio = false;
			this.txtTelCli.Location = new System.Drawing.Point(101, 209);
			this.txtTelCli.MensagemObrigatorio = null;
			this.txtTelCli.Name = "txtTelCli";
			this.txtTelCli.Size = new System.Drawing.Size(167, 26);
			this.txtTelCli.TabIndex = 5;
			this.txtTelCli.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtNomeCli
			// 
			this.txtNomeCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtNomeCli.CampoObrigatorio = true;
			this.txtNomeCli.Location = new System.Drawing.Point(102, 95);
			this.txtNomeCli.MensagemObrigatorio = "Informar o nome";
			this.txtNomeCli.Name = "txtNomeCli";
			this.txtNomeCli.Size = new System.Drawing.Size(441, 26);
			this.txtNomeCli.TabIndex = 1;
			this.txtNomeCli.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// dtDataNasc
			// 
			this.dtDataNasc.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataNasc.Location = new System.Drawing.Point(569, 95);
			this.dtDataNasc.Name = "dtDataNasc";
			this.dtDataNasc.Size = new System.Drawing.Size(148, 26);
			this.dtDataNasc.TabIndex = 2;
			// 
			// txtCpfCnpjCli
			// 
			this.txtCpfCnpjCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtCpfCnpjCli.CampoObrigatorio = false;
			this.txtCpfCnpjCli.Location = new System.Drawing.Point(371, 154);
			this.txtCpfCnpjCli.MaxLength = 18;
			this.txtCpfCnpjCli.MensagemObrigatorio = null;
			this.txtCpfCnpjCli.Name = "txtCpfCnpjCli";
			this.txtCpfCnpjCli.Size = new System.Drawing.Size(190, 26);
			this.txtCpfCnpjCli.TabIndex = 4;
			this.txtCpfCnpjCli.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
			// 
			// lblCep
			// 
			this.lblCep.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCep.AutoSize = true;
			this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCep.Location = new System.Drawing.Point(98, 249);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(41, 20);
			this.lblCep.TabIndex = 89;
			this.lblCep.Text = "CEP";
			// 
			// lblBairro
			// 
			this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblBairro.AutoSize = true;
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblBairro.Location = new System.Drawing.Point(565, 313);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(51, 20);
			this.lblBairro.TabIndex = 88;
			this.lblBairro.Text = "Bairro";
			// 
			// lblNumero
			// 
			this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNumero.Location = new System.Drawing.Point(366, 316);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(26, 20);
			this.lblNumero.TabIndex = 87;
			this.lblNumero.Text = "Nº";
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblLogradouro.Location = new System.Drawing.Point(98, 316);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
			this.lblLogradouro.TabIndex = 86;
			this.lblLogradouro.Text = "Logradouro";
			// 
			// lblCidade
			// 
			this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCidade.AutoSize = true;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCidade.Location = new System.Drawing.Point(565, 246);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(59, 20);
			this.lblCidade.TabIndex = 85;
			this.lblCidade.Text = "Cidade";
			// 
			// lblEstado
			// 
			this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEstado.Location = new System.Drawing.Point(365, 249);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(86, 20);
			this.lblEstado.TabIndex = 84;
			this.lblEstado.Text = "Estado/UF";
			// 
			// lblTipoCli
			// 
			this.lblTipoCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTipoCli.AutoSize = true;
			this.lblTipoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblTipoCli.Location = new System.Drawing.Point(97, 127);
			this.lblTipoCli.Name = "lblTipoCli";
			this.lblTipoCli.Size = new System.Drawing.Size(114, 20);
			this.lblTipoCli.TabIndex = 83;
			this.lblTipoCli.Text = "Tipo de Cliente";
			// 
			// lblCpfCnpjCli
			// 
			this.lblCpfCnpjCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCpfCnpjCli.AutoSize = true;
			this.lblCpfCnpjCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCpfCnpjCli.Location = new System.Drawing.Point(364, 127);
			this.lblCpfCnpjCli.Name = "lblCpfCnpjCli";
			this.lblCpfCnpjCli.Size = new System.Drawing.Size(84, 20);
			this.lblCpfCnpjCli.TabIndex = 82;
			this.lblCpfCnpjCli.Text = "CPF/CNPJ";
			// 
			// lblDataNasc
			// 
			this.lblDataNasc.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblDataNasc.AutoSize = true;
			this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDataNasc.Location = new System.Drawing.Point(565, 72);
			this.lblDataNasc.Name = "lblDataNasc";
			this.lblDataNasc.Size = new System.Drawing.Size(152, 20);
			this.lblDataNasc.TabIndex = 79;
			this.lblDataNasc.Text = "Data de nascimento";
			// 
			// lblEmail
			// 
			this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEmail.Location = new System.Drawing.Point(367, 186);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(53, 20);
			this.lblEmail.TabIndex = 74;
			this.lblEmail.Text = "E-mail";
			// 
			// lblTelCli
			// 
			this.lblTelCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTelCli.AutoSize = true;
			this.lblTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblTelCli.Location = new System.Drawing.Point(98, 186);
			this.lblTelCli.Name = "lblTelCli";
			this.lblTelCli.Size = new System.Drawing.Size(71, 20);
			this.lblTelCli.TabIndex = 72;
			this.lblTelCli.Text = "Telefone";
			// 
			// lblNomeCli
			// 
			this.lblNomeCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblNomeCli.AutoSize = true;
			this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeCli.Location = new System.Drawing.Point(97, 72);
			this.lblNomeCli.Name = "lblNomeCli";
			this.lblNomeCli.Size = new System.Drawing.Size(123, 20);
			this.lblNomeCli.TabIndex = 69;
			this.lblNomeCli.Text = "Nome Completo";
			// 
			// lblCodCli
			// 
			this.lblCodCli.AutoSize = true;
			this.lblCodCli.Location = new System.Drawing.Point(-30, -32);
			this.lblCodCli.Name = "lblCodCli";
			this.lblCodCli.Size = new System.Drawing.Size(59, 20);
			this.lblCodCli.TabIndex = 37;
			this.lblCodCli.Text = "Código";
			// 
			// txtCodigoCli
			// 
			this.txtCodigoCli.Enabled = false;
			this.txtCodigoCli.Location = new System.Drawing.Point(16, -39);
			this.txtCodigoCli.Name = "txtCodigoCli";
			this.txtCodigoCli.Size = new System.Drawing.Size(100, 26);
			this.txtCodigoCli.TabIndex = 36;
			// 
			// btnGridExcluir
			// 
			this.btnGridExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnGridExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnGridExcluir.FlatAppearance.BorderSize = 0;
			this.btnGridExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnGridExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnGridExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGridExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGridExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnGridExcluir.Image = global::SmartLog.WindowsForms.Properties.Resources.iconExcluir;
			this.btnGridExcluir.Location = new System.Drawing.Point(548, 233);
			this.btnGridExcluir.Name = "btnGridExcluir";
			this.btnGridExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnGridExcluir.TabIndex = 6;
			this.btnGridExcluir.Text = "Excluir";
			this.btnGridExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGridExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGridExcluir.UseVisualStyleBackColor = false;
			this.btnGridExcluir.Click += new System.EventHandler(this.btnGridExcluir_Click);
			// 
			// btnGridAlterar
			// 
			this.btnGridAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnGridAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnGridAlterar.FlatAppearance.BorderSize = 0;
			this.btnGridAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnGridAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnGridAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGridAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGridAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnGridAlterar.Image = global::SmartLog.WindowsForms.Properties.Resources.iconEdit;
			this.btnGridAlterar.Location = new System.Drawing.Point(376, 233);
			this.btnGridAlterar.Name = "btnGridAlterar";
			this.btnGridAlterar.Size = new System.Drawing.Size(139, 39);
			this.btnGridAlterar.TabIndex = 5;
			this.btnGridAlterar.Text = "Alterar";
			this.btnGridAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGridAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGridAlterar.UseVisualStyleBackColor = false;
			this.btnGridAlterar.Click += new System.EventHandler(this.btnGridAlterar_Click);
			// 
			// btnNovo
			// 
			this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnNovo.FlatAppearance.BorderSize = 0;
			this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnNovo.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_New;
			this.btnNovo.Location = new System.Drawing.Point(205, 233);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(139, 39);
			this.btnNovo.TabIndex = 4;
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnPesquisarCli
			// 
			this.btnPesquisarCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnPesquisarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnPesquisarCli.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.btnPesquisarCli.FlatAppearance.BorderSize = 0;
			this.btnPesquisarCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnPesquisarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnPesquisarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisarCli.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_search;
			this.btnPesquisarCli.Location = new System.Drawing.Point(587, 41);
			this.btnPesquisarCli.Name = "btnPesquisarCli";
			this.btnPesquisarCli.Size = new System.Drawing.Size(139, 39);
			this.btnPesquisarCli.TabIndex = 3;
			this.btnPesquisarCli.Text = "Pesquisar";
			this.btnPesquisarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPesquisarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisarCli.UseVisualStyleBackColor = false;
			this.btnPesquisarCli.Click += new System.EventHandler(this.btnPesquisarCli_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnLimpar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Limpar;
			this.btnLimpar.Location = new System.Drawing.Point(483, 472);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(139, 39);
			this.btnLimpar.TabIndex = 15;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnVoltarCli
			// 
			this.btnVoltarCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnVoltarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnVoltarCli.FlatAppearance.BorderSize = 0;
			this.btnVoltarCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnVoltarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVoltarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltarCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnVoltarCli.Image = global::SmartLog.WindowsForms.Properties.Resources.iconVoltar_fw;
			this.btnVoltarCli.Location = new System.Drawing.Point(645, 472);
			this.btnVoltarCli.Name = "btnVoltarCli";
			this.btnVoltarCli.Size = new System.Drawing.Size(139, 39);
			this.btnVoltarCli.TabIndex = 16;
			this.btnVoltarCli.Text = "Voltar";
			this.btnVoltarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltarCli.UseVisualStyleBackColor = false;
			this.btnVoltarCli.Click += new System.EventHandler(this.btnVoltarCli_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnSalvar.FlatAppearance.BorderSize = 0;
			this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnSalvar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Salvar_png;
			this.btnSalvar.Location = new System.Drawing.Point(324, 472);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 13;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// frmCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.ClientSize = new System.Drawing.Size(1172, 667);
			this.Controls.Add(this.tabCtrlCliente);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCliente";
			this.Text = "Cliente";
			this.Load += new System.EventHandler(this.FormCliente_Load);
			this.tabCtrlCliente.ResumeLayout(false);
			this.tabConsultaCli.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
			this.gbFiltrarCliente.ResumeLayout(false);
			this.pnlFiltrarCliente.ResumeLayout(false);
			this.pnlFiltrarCliente.PerformLayout();
			this.tabCadastroCli.ResumeLayout(false);
			this.tabCadastroCli.PerformLayout();
			this.gbDadosCliente.ResumeLayout(false);
			this.gbDadosCliente.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtrlCliente;
		private System.Windows.Forms.TabPage tabConsultaCli;
		private System.Windows.Forms.TabPage tabCadastroCli;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label lblCodCli;
		private System.Windows.Forms.TextBox txtCodigoCli;
		private System.Windows.Forms.DataGridView dgCliente;
		private System.Windows.Forms.Label lblCpfPesquisa;
		private System.Windows.Forms.Label lblNomePesquisa;
		private UserControl.SuperTextbox txtCpfPesquisar;
		private UserControl.SuperTextbox txtNomePesquisar;
		private System.Windows.Forms.Panel pnlFiltrarCliente;
		private System.Windows.Forms.Button btnPesquisarCli;
		private System.Windows.Forms.Button btnVoltarCli;
		private System.Windows.Forms.GroupBox gbFiltrarCliente;
		private System.Windows.Forms.Button btnFechaCliente;
		private System.Windows.Forms.Button btnGridExcluir;
		private System.Windows.Forms.Button btnGridAlterar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.GroupBox gbDadosCliente;
		private UserControl.SuperTextbox txtCpfCnpjCli;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblTipoCli;
		private System.Windows.Forms.Label lblCpfCnpjCli;
		private System.Windows.Forms.Label lblDataNasc;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblTelCli;
		private System.Windows.Forms.Label lblNomeCli;
		private System.Windows.Forms.DateTimePicker dtDataNasc;
		private UserControl.SuperTextbox txtEmailCli;
		private UserControl.SuperTextbox txtCep;
		private UserControl.SuperTextbox txtNumero;
		private UserControl.SuperTextbox txtBairro;
		private UserControl.SuperTextbox txtLogra;
		private UserControl.SuperTextbox txtTelCli;
		private UserControl.SuperTextbox txtNomeCli;
		private System.Windows.Forms.DateTimePicker dtDataCadastro;
		private System.Windows.Forms.Label lblDataCadastro;
		private System.Windows.Forms.Button btnLimpar;
		private UserControl.SuperComboBox cbTipoCli;
		private UserControl.SuperComboBox cbCidade;
		private UserControl.SuperComboBox cbEstado;
	}
}

