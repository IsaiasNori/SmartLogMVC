﻿namespace SmartLog.WindowsForms
{
	partial class frmVeiculo
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
			this.tabctrlVeiculo = new System.Windows.Forms.TabControl();
			this.tabConsultaVeic = new System.Windows.Forms.TabPage();
			this.btnFechaVeiculo = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnNovoVeiculo = new System.Windows.Forms.Button();
			this.dgVeiculo = new System.Windows.Forms.DataGridView();
			this.gbFiltraVeiculo = new System.Windows.Forms.GroupBox();
			this.cbMarcaPesquisa = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.txtModeloPesquisa = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblModeloPesquisa = new System.Windows.Forms.Label();
			this.lblMarcaPesquisa = new System.Windows.Forms.Label();
			this.btnPesquisarVeiculo = new System.Windows.Forms.Button();
			this.tabCadastroVeic = new System.Windows.Forms.TabPage();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.gbDadosVeiculo = new System.Windows.Forms.GroupBox();
			this.txtPlaca = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.txtKmInicial = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblKmInicial = new System.Windows.Forms.Label();
			this.txtAnoFab = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.cbStatus = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbMarca = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.txtData = new System.Windows.Forms.DateTimePicker();
			this.txtDataUltRev = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblUltimaRevisao = new System.Windows.Forms.Label();
			this.txtKmAtual = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtKmPrev = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblAnoFab = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblRenavam = new System.Windows.Forms.Label();
			this.txtRenavam = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblModelo = new System.Windows.Forms.Label();
			this.txtModelo = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblCodCli = new System.Windows.Forms.Label();
			this.txtCodigoCli = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tabctrlVeiculo.SuspendLayout();
			this.tabConsultaVeic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgVeiculo)).BeginInit();
			this.gbFiltraVeiculo.SuspendLayout();
			this.tabCadastroVeic.SuspendLayout();
			this.gbDadosVeiculo.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabctrlVeiculo
			// 
			this.tabctrlVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabctrlVeiculo.Controls.Add(this.tabConsultaVeic);
			this.tabctrlVeiculo.Controls.Add(this.tabCadastroVeic);
			this.tabctrlVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabctrlVeiculo.HotTrack = true;
			this.tabctrlVeiculo.Location = new System.Drawing.Point(62, 40);
			this.tabctrlVeiculo.Name = "tabctrlVeiculo";
			this.tabctrlVeiculo.Padding = new System.Drawing.Point(100, 5);
			this.tabctrlVeiculo.SelectedIndex = 0;
			this.tabctrlVeiculo.ShowToolTips = true;
			this.tabctrlVeiculo.Size = new System.Drawing.Size(995, 687);
			this.tabctrlVeiculo.TabIndex = 1;
			// 
			// tabConsultaVeic
			// 
			this.tabConsultaVeic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.tabConsultaVeic.Controls.Add(this.btnFechaVeiculo);
			this.tabConsultaVeic.Controls.Add(this.btnExcluir);
			this.tabConsultaVeic.Controls.Add(this.btnAlterar);
			this.tabConsultaVeic.Controls.Add(this.btnNovoVeiculo);
			this.tabConsultaVeic.Controls.Add(this.dgVeiculo);
			this.tabConsultaVeic.Controls.Add(this.gbFiltraVeiculo);
			this.tabConsultaVeic.Location = new System.Drawing.Point(4, 33);
			this.tabConsultaVeic.Name = "tabConsultaVeic";
			this.tabConsultaVeic.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaVeic.Size = new System.Drawing.Size(987, 650);
			this.tabConsultaVeic.TabIndex = 0;
			this.tabConsultaVeic.Text = "Consulta";
			// 
			// btnFechaVeiculo
			// 
			this.btnFechaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnFechaVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnFechaVeiculo.FlatAppearance.BorderSize = 0;
			this.btnFechaVeiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnFechaVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFechaVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechaVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnFechaVeiculo.Image = global::SmartLog.WindowsForms.Properties.Resources.iconFechar;
			this.btnFechaVeiculo.Location = new System.Drawing.Point(688, 235);
			this.btnFechaVeiculo.Name = "btnFechaVeiculo";
			this.btnFechaVeiculo.Size = new System.Drawing.Size(139, 39);
			this.btnFechaVeiculo.TabIndex = 25;
			this.btnFechaVeiculo.Text = "Fechar";
			this.btnFechaVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechaVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechaVeiculo.UseVisualStyleBackColor = false;
			this.btnFechaVeiculo.Click += new System.EventHandler(this.btnFechaVeiculo_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnExcluir.Image = global::SmartLog.WindowsForms.Properties.Resources.iconExcluir;
			this.btnExcluir.Location = new System.Drawing.Point(514, 235);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnExcluir.TabIndex = 24;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnAlterar.FlatAppearance.BorderSize = 0;
			this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnAlterar.Image = global::SmartLog.WindowsForms.Properties.Resources.iconEdit;
			this.btnAlterar.Location = new System.Drawing.Point(342, 235);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(139, 39);
			this.btnAlterar.TabIndex = 23;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnNovoVeiculo
			// 
			this.btnNovoVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnNovoVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnNovoVeiculo.FlatAppearance.BorderSize = 0;
			this.btnNovoVeiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnNovoVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnNovoVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovoVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnNovoVeiculo.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_New;
			this.btnNovoVeiculo.Location = new System.Drawing.Point(171, 235);
			this.btnNovoVeiculo.Name = "btnNovoVeiculo";
			this.btnNovoVeiculo.Size = new System.Drawing.Size(139, 39);
			this.btnNovoVeiculo.TabIndex = 22;
			this.btnNovoVeiculo.Text = "Novo";
			this.btnNovoVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovoVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovoVeiculo.UseVisualStyleBackColor = false;
			this.btnNovoVeiculo.Click += new System.EventHandler(this.btnNovoVeiculo_Click);
			// 
			// dgVeiculo
			// 
			this.dgVeiculo.AllowUserToAddRows = false;
			this.dgVeiculo.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgVeiculo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgVeiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgVeiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgVeiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgVeiculo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgVeiculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgVeiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgVeiculo.ColumnHeadersHeight = 35;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgVeiculo.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgVeiculo.EnableHeadersVisualStyles = false;
			this.dgVeiculo.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgVeiculo.Location = new System.Drawing.Point(38, 325);
			this.dgVeiculo.Name = "dgVeiculo";
			this.dgVeiculo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgVeiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgVeiculo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgVeiculo.Size = new System.Drawing.Size(922, 293);
			this.dgVeiculo.TabIndex = 21;
			this.dgVeiculo.DataSourceChanged += new System.EventHandler(this.DtVeiculo_DataSourceChanged);
			// 
			// gbFiltraVeiculo
			// 
			this.gbFiltraVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbFiltraVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.gbFiltraVeiculo.Controls.Add(this.cbMarcaPesquisa);
			this.gbFiltraVeiculo.Controls.Add(this.txtModeloPesquisa);
			this.gbFiltraVeiculo.Controls.Add(this.lblModeloPesquisa);
			this.gbFiltraVeiculo.Controls.Add(this.lblMarcaPesquisa);
			this.gbFiltraVeiculo.Controls.Add(this.btnPesquisarVeiculo);
			this.gbFiltraVeiculo.Location = new System.Drawing.Point(38, 45);
			this.gbFiltraVeiculo.Name = "gbFiltraVeiculo";
			this.gbFiltraVeiculo.Size = new System.Drawing.Size(922, 155);
			this.gbFiltraVeiculo.TabIndex = 10;
			this.gbFiltraVeiculo.TabStop = false;
			this.gbFiltraVeiculo.Text = "Filtrar Veículos";
			// 
			// cbMarcaPesquisa
			// 
			this.cbMarcaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbMarcaPesquisa.CampoObrigatorio = false;
			this.cbMarcaPesquisa.FormattingEnabled = true;
			this.cbMarcaPesquisa.Location = new System.Drawing.Point(124, 72);
			this.cbMarcaPesquisa.MensagemCampoObrigatorio = null;
			this.cbMarcaPesquisa.Name = "cbMarcaPesquisa";
			this.cbMarcaPesquisa.Size = new System.Drawing.Size(207, 28);
			this.cbMarcaPesquisa.TabIndex = 9;
			// 
			// txtModeloPesquisa
			// 
			this.txtModeloPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtModeloPesquisa.CampoObrigatorio = false;
			this.txtModeloPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtModeloPesquisa.Location = new System.Drawing.Point(360, 72);
			this.txtModeloPesquisa.MaxLength = 18;
			this.txtModeloPesquisa.MensagemObrigatorio = "Informar o Modelo";
			this.txtModeloPesquisa.Multiline = true;
			this.txtModeloPesquisa.Name = "txtModeloPesquisa";
			this.txtModeloPesquisa.Size = new System.Drawing.Size(188, 28);
			this.txtModeloPesquisa.TabIndex = 7;
			this.txtModeloPesquisa.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// lblModeloPesquisa
			// 
			this.lblModeloPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblModeloPesquisa.AutoSize = true;
			this.lblModeloPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblModeloPesquisa.Location = new System.Drawing.Point(356, 49);
			this.lblModeloPesquisa.Name = "lblModeloPesquisa";
			this.lblModeloPesquisa.Size = new System.Drawing.Size(61, 20);
			this.lblModeloPesquisa.TabIndex = 5;
			this.lblModeloPesquisa.Text = "Modelo";
			// 
			// lblMarcaPesquisa
			// 
			this.lblMarcaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblMarcaPesquisa.AutoSize = true;
			this.lblMarcaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblMarcaPesquisa.Location = new System.Drawing.Point(120, 49);
			this.lblMarcaPesquisa.Name = "lblMarcaPesquisa";
			this.lblMarcaPesquisa.Size = new System.Drawing.Size(53, 20);
			this.lblMarcaPesquisa.TabIndex = 4;
			this.lblMarcaPesquisa.Text = "Marca";
			// 
			// btnPesquisarVeiculo
			// 
			this.btnPesquisarVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnPesquisarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnPesquisarVeiculo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.btnPesquisarVeiculo.FlatAppearance.BorderSize = 0;
			this.btnPesquisarVeiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnPesquisarVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnPesquisarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisarVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnPesquisarVeiculo.Image = global::SmartLog.WindowsForms.Properties.Resources.icoSearch_fw;
			this.btnPesquisarVeiculo.Location = new System.Drawing.Point(577, 66);
			this.btnPesquisarVeiculo.Name = "btnPesquisarVeiculo";
			this.btnPesquisarVeiculo.Size = new System.Drawing.Size(199, 39);
			this.btnPesquisarVeiculo.TabIndex = 8;
			this.btnPesquisarVeiculo.Text = "Pesquisar";
			this.btnPesquisarVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPesquisarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisarVeiculo.UseVisualStyleBackColor = false;
			this.btnPesquisarVeiculo.Click += new System.EventHandler(this.btnPesquisarVeiculo_Click);
			// 
			// tabCadastroVeic
			// 
			this.tabCadastroVeic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.tabCadastroVeic.Controls.Add(this.btnLimpar);
			this.tabCadastroVeic.Controls.Add(this.btnVoltar);
			this.tabCadastroVeic.Controls.Add(this.btnSalvar);
			this.tabCadastroVeic.Controls.Add(this.gbDadosVeiculo);
			this.tabCadastroVeic.Controls.Add(this.lblCodCli);
			this.tabCadastroVeic.Controls.Add(this.txtCodigoCli);
			this.tabCadastroVeic.Location = new System.Drawing.Point(4, 33);
			this.tabCadastroVeic.Name = "tabCadastroVeic";
			this.tabCadastroVeic.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroVeic.Size = new System.Drawing.Size(987, 650);
			this.tabCadastroVeic.TabIndex = 1;
			this.tabCadastroVeic.Text = "Cadastro";
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
			this.btnLimpar.Location = new System.Drawing.Point(414, 386);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(139, 39);
			this.btnLimpar.TabIndex = 40;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnVoltar.FlatAppearance.BorderSize = 0;
			this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnVoltar.Image = global::SmartLog.WindowsForms.Properties.Resources.iconVoltar_fw;
			this.btnVoltar.Location = new System.Drawing.Point(576, 386);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(139, 39);
			this.btnVoltar.TabIndex = 41;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
			this.btnSalvar.Location = new System.Drawing.Point(255, 386);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 39;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// gbDadosVeiculo
			// 
			this.gbDadosVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gbDadosVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.gbDadosVeiculo.Controls.Add(this.txtPlaca);
			this.gbDadosVeiculo.Controls.Add(this.lblPlaca);
			this.gbDadosVeiculo.Controls.Add(this.txtKmInicial);
			this.gbDadosVeiculo.Controls.Add(this.lblKmInicial);
			this.gbDadosVeiculo.Controls.Add(this.txtAnoFab);
			this.gbDadosVeiculo.Controls.Add(this.cbStatus);
			this.gbDadosVeiculo.Controls.Add(this.cbMarca);
			this.gbDadosVeiculo.Controls.Add(this.txtData);
			this.gbDadosVeiculo.Controls.Add(this.txtDataUltRev);
			this.gbDadosVeiculo.Controls.Add(this.lblUltimaRevisao);
			this.gbDadosVeiculo.Controls.Add(this.txtKmAtual);
			this.gbDadosVeiculo.Controls.Add(this.txtKmPrev);
			this.gbDadosVeiculo.Controls.Add(this.label5);
			this.gbDadosVeiculo.Controls.Add(this.label3);
			this.gbDadosVeiculo.Controls.Add(this.lblAnoFab);
			this.gbDadosVeiculo.Controls.Add(this.label2);
			this.gbDadosVeiculo.Controls.Add(this.lblStatus);
			this.gbDadosVeiculo.Controls.Add(this.lblRenavam);
			this.gbDadosVeiculo.Controls.Add(this.txtRenavam);
			this.gbDadosVeiculo.Controls.Add(this.label1);
			this.gbDadosVeiculo.Controls.Add(this.lblModelo);
			this.gbDadosVeiculo.Controls.Add(this.txtModelo);
			this.gbDadosVeiculo.Location = new System.Drawing.Point(105, 32);
			this.gbDadosVeiculo.Name = "gbDadosVeiculo";
			this.gbDadosVeiculo.Size = new System.Drawing.Size(774, 331);
			this.gbDadosVeiculo.TabIndex = 38;
			this.gbDadosVeiculo.TabStop = false;
			this.gbDadosVeiculo.Text = "Dados do Veículo";
			// 
			// txtPlaca
			// 
			this.txtPlaca.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtPlaca.CampoObrigatorio = true;
			this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPlaca.Location = new System.Drawing.Point(319, 154);
			this.txtPlaca.MensagemObrigatorio = "Informe a placa";
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(147, 26);
			this.txtPlaca.TabIndex = 27;
			this.txtPlaca.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// lblPlaca
			// 
			this.lblPlaca.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(315, 129);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(48, 20);
			this.lblPlaca.TabIndex = 26;
			this.lblPlaca.Text = "Placa";
			// 
			// txtKmInicial
			// 
			this.txtKmInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtKmInicial.CampoObrigatorio = true;
			this.txtKmInicial.Location = new System.Drawing.Point(63, 290);
			this.txtKmInicial.MensagemObrigatorio = "Informar Quilometragem do veículo";
			this.txtKmInicial.Name = "txtKmInicial";
			this.txtKmInicial.Size = new System.Drawing.Size(190, 26);
			this.txtKmInicial.TabIndex = 25;
			this.txtKmInicial.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			this.txtKmInicial.Leave += new System.EventHandler(this.txtKmInicial_Leave);
			// 
			// lblKmInicial
			// 
			this.lblKmInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblKmInicial.AutoSize = true;
			this.lblKmInicial.Location = new System.Drawing.Point(59, 265);
			this.lblKmInicial.Name = "lblKmInicial";
			this.lblKmInicial.Size = new System.Drawing.Size(76, 20);
			this.lblKmInicial.TabIndex = 24;
			this.lblKmInicial.Text = "KM Inicial";
			// 
			// txtAnoFab
			// 
			this.txtAnoFab.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtAnoFab.CampoObrigatorio = true;
			this.txtAnoFab.Location = new System.Drawing.Point(558, 154);
			this.txtAnoFab.MensagemObrigatorio = "Informar o ano de Fabricação";
			this.txtAnoFab.Name = "txtAnoFab";
			this.txtAnoFab.Size = new System.Drawing.Size(139, 26);
			this.txtAnoFab.TabIndex = 23;
			this.txtAnoFab.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// cbStatus
			// 
			this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbStatus.CampoObrigatorio = true;
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Location = new System.Drawing.Point(319, 73);
			this.cbStatus.MensagemCampoObrigatorio = "Selecione o Status";
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(147, 28);
			this.cbStatus.TabIndex = 22;
			// 
			// cbMarca
			// 
			this.cbMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbMarca.CampoObrigatorio = true;
			this.cbMarca.FormattingEnabled = true;
			this.cbMarca.Location = new System.Drawing.Point(63, 154);
			this.cbMarca.MensagemCampoObrigatorio = "Informar a Marca";
			this.cbMarca.Name = "cbMarca";
			this.cbMarca.Size = new System.Drawing.Size(217, 28);
			this.cbMarca.TabIndex = 21;
			// 
			// txtData
			// 
			this.txtData.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtData.Enabled = false;
			this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtData.Location = new System.Drawing.Point(63, 73);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(133, 26);
			this.txtData.TabIndex = 20;
			// 
			// txtDataUltRev
			// 
			this.txtDataUltRev.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtDataUltRev.CampoObrigatorio = false;
			this.txtDataUltRev.Location = new System.Drawing.Point(558, 75);
			this.txtDataUltRev.MensagemObrigatorio = null;
			this.txtDataUltRev.Name = "txtDataUltRev";
			this.txtDataUltRev.Size = new System.Drawing.Size(146, 26);
			this.txtDataUltRev.TabIndex = 19;
			this.txtDataUltRev.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.data;
			// 
			// lblUltimaRevisao
			// 
			this.lblUltimaRevisao.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblUltimaRevisao.AutoSize = true;
			this.lblUltimaRevisao.Location = new System.Drawing.Point(554, 50);
			this.lblUltimaRevisao.Name = "lblUltimaRevisao";
			this.lblUltimaRevisao.Size = new System.Drawing.Size(134, 20);
			this.lblUltimaRevisao.TabIndex = 18;
			this.lblUltimaRevisao.Text = "Ultima revisão em";
			// 
			// txtKmAtual
			// 
			this.txtKmAtual.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtKmAtual.CampoObrigatorio = false;
			this.txtKmAtual.Location = new System.Drawing.Point(578, 290);
			this.txtKmAtual.MensagemObrigatorio = null;
			this.txtKmAtual.Name = "txtKmAtual";
			this.txtKmAtual.Size = new System.Drawing.Size(190, 26);
			this.txtKmAtual.TabIndex = 17;
			this.txtKmAtual.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtKmPrev
			// 
			this.txtKmPrev.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtKmPrev.CampoObrigatorio = false;
			this.txtKmPrev.Enabled = false;
			this.txtKmPrev.Location = new System.Drawing.Point(319, 290);
			this.txtKmPrev.MensagemObrigatorio = null;
			this.txtKmPrev.Name = "txtKmPrev";
			this.txtKmPrev.Size = new System.Drawing.Size(190, 26);
			this.txtKmPrev.TabIndex = 16;
			this.txtKmPrev.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(315, 265);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(212, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Manutenção Preventiva (KM)";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(574, 265);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 20);
			this.label3.TabIndex = 14;
			this.label3.Text = "KM Atual";
			// 
			// lblAnoFab
			// 
			this.lblAnoFab.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblAnoFab.AutoSize = true;
			this.lblAnoFab.Location = new System.Drawing.Point(554, 131);
			this.lblAnoFab.Name = "lblAnoFab";
			this.lblAnoFab.Size = new System.Drawing.Size(143, 20);
			this.lblAnoFab.TabIndex = 11;
			this.lblAnoFab.Text = "Ano de Fabricação";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Data de aquisição";
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(315, 50);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(56, 20);
			this.lblStatus.TabIndex = 6;
			this.lblStatus.Text = "Status";
			// 
			// lblRenavam
			// 
			this.lblRenavam.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblRenavam.AutoSize = true;
			this.lblRenavam.Location = new System.Drawing.Point(315, 195);
			this.lblRenavam.Name = "lblRenavam";
			this.lblRenavam.Size = new System.Drawing.Size(77, 20);
			this.lblRenavam.TabIndex = 5;
			this.lblRenavam.Text = "Renavam";
			// 
			// txtRenavam
			// 
			this.txtRenavam.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtRenavam.CampoObrigatorio = true;
			this.txtRenavam.Location = new System.Drawing.Point(319, 220);
			this.txtRenavam.MensagemObrigatorio = "Informar o Renavam";
			this.txtRenavam.Name = "txtRenavam";
			this.txtRenavam.Size = new System.Drawing.Size(217, 26);
			this.txtRenavam.TabIndex = 4;
			this.txtRenavam.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Marca";
			// 
			// lblModelo
			// 
			this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(59, 195);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(61, 20);
			this.lblModelo.TabIndex = 1;
			this.lblModelo.Text = "Modelo";
			// 
			// txtModelo
			// 
			this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtModelo.CampoObrigatorio = true;
			this.txtModelo.Location = new System.Drawing.Point(63, 218);
			this.txtModelo.MensagemObrigatorio = "Informar o Modelo";
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(217, 26);
			this.txtModelo.TabIndex = 0;
			this.txtModelo.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
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
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(1130, 34);
			this.button1.TabIndex = 13;
			this.button1.Text = "Veículos";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// frmVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
			this.ClientSize = new System.Drawing.Size(1130, 735);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabctrlVeiculo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmVeiculo";
			this.Text = "frmVeiculo";
			this.Load += new System.EventHandler(this.frmVeiculo_Load);
			this.tabctrlVeiculo.ResumeLayout(false);
			this.tabConsultaVeic.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgVeiculo)).EndInit();
			this.gbFiltraVeiculo.ResumeLayout(false);
			this.gbFiltraVeiculo.PerformLayout();
			this.tabCadastroVeic.ResumeLayout(false);
			this.tabCadastroVeic.PerformLayout();
			this.gbDadosVeiculo.ResumeLayout(false);
			this.gbDadosVeiculo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabctrlVeiculo;
		private System.Windows.Forms.TabPage tabConsultaVeic;
		private System.Windows.Forms.Label lblMarcaPesquisa;
		private System.Windows.Forms.Button btnPesquisarVeiculo;
		private System.Windows.Forms.Label lblModeloPesquisa;
		private UserControl.SuperTextbox txtModeloPesquisa;
		private System.Windows.Forms.TabPage tabCadastroVeic;
		private System.Windows.Forms.Label lblCodCli;
		private System.Windows.Forms.TextBox txtCodigoCli;
		private System.Windows.Forms.GroupBox gbFiltraVeiculo;
		private System.Windows.Forms.GroupBox gbDadosVeiculo;
		private System.Windows.Forms.Label lblModelo;
		private UserControl.SuperTextbox txtModelo;
		private UserControl.SuperTextbox txtDataUltRev;
		private System.Windows.Forms.Label lblUltimaRevisao;
		private UserControl.SuperTextbox txtKmAtual;
		private UserControl.SuperTextbox txtKmPrev;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblAnoFab;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblRenavam;
		private UserControl.SuperTextbox txtRenavam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker txtData;
		private UserControl.SuperComboBox cbMarca;
		private UserControl.SuperComboBox cbMarcaPesquisa;
		private UserControl.SuperComboBox cbStatus;
		private UserControl.SuperTextbox txtAnoFab;
		private System.Windows.Forms.DataGridView dgVeiculo;
		private System.Windows.Forms.Button btnFechaVeiculo;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnNovoVeiculo;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnSalvar;
		private UserControl.SuperTextbox txtKmInicial;
		private System.Windows.Forms.Label lblKmInicial;
		private UserControl.SuperTextbox txtPlaca;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Button button1;
	}
}