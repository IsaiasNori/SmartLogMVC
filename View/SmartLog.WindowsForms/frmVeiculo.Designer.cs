namespace SmartLog.WindowsForms
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
			this.tabctrlVeiculo = new System.Windows.Forms.TabControl();
			this.tabConsultaVeic = new System.Windows.Forms.TabPage();
			this.btnFechaFuncionario = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnNovoVeiculo = new System.Windows.Forms.Button();
			this.gbFiltraVeiculo = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cbMarcaPesquisa = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.lblMarcaPesquisa = new System.Windows.Forms.Label();
			this.btnPesquisarVeiculo = new System.Windows.Forms.Button();
			this.lblModeloPesquisa = new System.Windows.Forms.Label();
			this.txtModeloPesquisa = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.dgVeiculo = new System.Windows.Forms.DataGridView();
			this.tabCadastroVeic = new System.Windows.Forms.TabPage();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnVoltarCli = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.gbDadosVeiculo = new System.Windows.Forms.GroupBox();
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
			this.tabctrlVeiculo.SuspendLayout();
			this.tabConsultaVeic.SuspendLayout();
			this.gbFiltraVeiculo.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgVeiculo)).BeginInit();
			this.tabCadastroVeic.SuspendLayout();
			this.gbDadosVeiculo.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabctrlVeiculo
			// 
			this.tabctrlVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tabctrlVeiculo.Controls.Add(this.tabConsultaVeic);
			this.tabctrlVeiculo.Controls.Add(this.tabCadastroVeic);
			this.tabctrlVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabctrlVeiculo.Location = new System.Drawing.Point(82, 2);
			this.tabctrlVeiculo.Name = "tabctrlVeiculo";
			this.tabctrlVeiculo.SelectedIndex = 0;
			this.tabctrlVeiculo.Size = new System.Drawing.Size(995, 687);
			this.tabctrlVeiculo.TabIndex = 1;
			// 
			// tabConsultaVeic
			// 
			this.tabConsultaVeic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabConsultaVeic.Controls.Add(this.btnFechaFuncionario);
			this.tabConsultaVeic.Controls.Add(this.btnExcluir);
			this.tabConsultaVeic.Controls.Add(this.btnAlterar);
			this.tabConsultaVeic.Controls.Add(this.btnNovoVeiculo);
			this.tabConsultaVeic.Controls.Add(this.gbFiltraVeiculo);
			this.tabConsultaVeic.Controls.Add(this.dgVeiculo);
			this.tabConsultaVeic.Location = new System.Drawing.Point(4, 29);
			this.tabConsultaVeic.Name = "tabConsultaVeic";
			this.tabConsultaVeic.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaVeic.Size = new System.Drawing.Size(987, 654);
			this.tabConsultaVeic.TabIndex = 0;
			this.tabConsultaVeic.Text = "Consulta";
			// 
			// btnFechaFuncionario
			// 
			this.btnFechaFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnFechaFuncionario.FlatAppearance.BorderSize = 0;
			this.btnFechaFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnFechaFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFechaFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechaFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnFechaFuncionario.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_FecharTab;
			this.btnFechaFuncionario.Location = new System.Drawing.Point(652, 236);
			this.btnFechaFuncionario.Name = "btnFechaFuncionario";
			this.btnFechaFuncionario.Size = new System.Drawing.Size(139, 39);
			this.btnFechaFuncionario.TabIndex = 20;
			this.btnFechaFuncionario.Text = "Fechar";
			this.btnFechaFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechaFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechaFuncionario.UseVisualStyleBackColor = false;
			this.btnFechaFuncionario.Click += new System.EventHandler(this.btnFechaFuncionario_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnExcluir.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Excluir;
			this.btnExcluir.Location = new System.Drawing.Point(478, 236);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnExcluir.TabIndex = 19;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnAlterar.FlatAppearance.BorderSize = 0;
			this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAlterar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Alterar;
			this.btnAlterar.Location = new System.Drawing.Point(306, 236);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(139, 39);
			this.btnAlterar.TabIndex = 18;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnNovoVeiculo
			// 
			this.btnNovoVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnNovoVeiculo.FlatAppearance.BorderSize = 0;
			this.btnNovoVeiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnNovoVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnNovoVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovoVeiculo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNovoVeiculo.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Novo;
			this.btnNovoVeiculo.Location = new System.Drawing.Point(135, 236);
			this.btnNovoVeiculo.Name = "btnNovoVeiculo";
			this.btnNovoVeiculo.Size = new System.Drawing.Size(139, 39);
			this.btnNovoVeiculo.TabIndex = 17;
			this.btnNovoVeiculo.Text = "Novo";
			this.btnNovoVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovoVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovoVeiculo.UseVisualStyleBackColor = false;
			this.btnNovoVeiculo.Click += new System.EventHandler(this.btnNovoVeiculo_Click);
			// 
			// gbFiltraVeiculo
			// 
			this.gbFiltraVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbFiltraVeiculo.Controls.Add(this.panel3);
			this.gbFiltraVeiculo.Location = new System.Drawing.Point(38, 21);
			this.gbFiltraVeiculo.Name = "gbFiltraVeiculo";
			this.gbFiltraVeiculo.Size = new System.Drawing.Size(922, 187);
			this.gbFiltraVeiculo.TabIndex = 10;
			this.gbFiltraVeiculo.TabStop = false;
			this.gbFiltraVeiculo.Text = "Filtrar Veículos";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.cbMarcaPesquisa);
			this.panel3.Controls.Add(this.lblMarcaPesquisa);
			this.panel3.Controls.Add(this.btnPesquisarVeiculo);
			this.panel3.Controls.Add(this.lblModeloPesquisa);
			this.panel3.Controls.Add(this.txtModeloPesquisa);
			this.panel3.Location = new System.Drawing.Point(106, 28);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(652, 121);
			this.panel3.TabIndex = 9;
			// 
			// cbMarcaPesquisa
			// 
			this.cbMarcaPesquisa.CampoObrigatorio = false;
			this.cbMarcaPesquisa.FormattingEnabled = true;
			this.cbMarcaPesquisa.Location = new System.Drawing.Point(44, 46);
			this.cbMarcaPesquisa.MensagemCampoObrigatorio = null;
			this.cbMarcaPesquisa.Name = "cbMarcaPesquisa";
			this.cbMarcaPesquisa.Size = new System.Drawing.Size(174, 28);
			this.cbMarcaPesquisa.TabIndex = 9;
			// 
			// lblMarcaPesquisa
			// 
			this.lblMarcaPesquisa.AutoSize = true;
			this.lblMarcaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblMarcaPesquisa.Location = new System.Drawing.Point(40, 23);
			this.lblMarcaPesquisa.Name = "lblMarcaPesquisa";
			this.lblMarcaPesquisa.Size = new System.Drawing.Size(53, 20);
			this.lblMarcaPesquisa.TabIndex = 4;
			this.lblMarcaPesquisa.Text = "Marca";
			// 
			// btnPesquisarVeiculo
			// 
			this.btnPesquisarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnPesquisarVeiculo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.btnPesquisarVeiculo.FlatAppearance.BorderSize = 0;
			this.btnPesquisarVeiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnPesquisarVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnPesquisarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisarVeiculo.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_search;
			this.btnPesquisarVeiculo.Location = new System.Drawing.Point(479, 35);
			this.btnPesquisarVeiculo.Name = "btnPesquisarVeiculo";
			this.btnPesquisarVeiculo.Size = new System.Drawing.Size(139, 39);
			this.btnPesquisarVeiculo.TabIndex = 8;
			this.btnPesquisarVeiculo.Text = "Pesquisar";
			this.btnPesquisarVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPesquisarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisarVeiculo.UseVisualStyleBackColor = false;
			this.btnPesquisarVeiculo.Click += new System.EventHandler(this.btnPesquisarVeiculo_Click);
			// 
			// lblModeloPesquisa
			// 
			this.lblModeloPesquisa.AutoSize = true;
			this.lblModeloPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblModeloPesquisa.Location = new System.Drawing.Point(245, 23);
			this.lblModeloPesquisa.Name = "lblModeloPesquisa";
			this.lblModeloPesquisa.Size = new System.Drawing.Size(61, 20);
			this.lblModeloPesquisa.TabIndex = 5;
			this.lblModeloPesquisa.Text = "Modelo";
			// 
			// txtModeloPesquisa
			// 
			this.txtModeloPesquisa.CampoObrigatorio = false;
			this.txtModeloPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtModeloPesquisa.Location = new System.Drawing.Point(249, 46);
			this.txtModeloPesquisa.MaxLength = 18;
			this.txtModeloPesquisa.MensagemObrigatorio = "Informar o Modelo";
			this.txtModeloPesquisa.Multiline = true;
			this.txtModeloPesquisa.Name = "txtModeloPesquisa";
			this.txtModeloPesquisa.Size = new System.Drawing.Size(188, 28);
			this.txtModeloPesquisa.TabIndex = 7;
			this.txtModeloPesquisa.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// dgVeiculo
			// 
			this.dgVeiculo.AllowUserToAddRows = false;
			this.dgVeiculo.AllowUserToDeleteRows = false;
			this.dgVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgVeiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgVeiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgVeiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgVeiculo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			this.dgVeiculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgVeiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgVeiculo.ColumnHeadersHeight = 50;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgVeiculo.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgVeiculo.EnableHeadersVisualStyles = false;
			this.dgVeiculo.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgVeiculo.Location = new System.Drawing.Point(38, 294);
			this.dgVeiculo.Name = "dgVeiculo";
			this.dgVeiculo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgVeiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgVeiculo.RowHeadersWidth = 100;
			this.dgVeiculo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgVeiculo.Size = new System.Drawing.Size(922, 293);
			this.dgVeiculo.StandardTab = true;
			this.dgVeiculo.TabIndex = 1;
			this.dgVeiculo.DataSourceChanged += new System.EventHandler(this.DtVeiculo_DataSourceChanged);
			// 
			// tabCadastroVeic
			// 
			this.tabCadastroVeic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabCadastroVeic.Controls.Add(this.btnLimpar);
			this.tabCadastroVeic.Controls.Add(this.btnVoltarCli);
			this.tabCadastroVeic.Controls.Add(this.btnSalvar);
			this.tabCadastroVeic.Controls.Add(this.gbDadosVeiculo);
			this.tabCadastroVeic.Controls.Add(this.lblCodCli);
			this.tabCadastroVeic.Controls.Add(this.txtCodigoCli);
			this.tabCadastroVeic.Location = new System.Drawing.Point(4, 29);
			this.tabCadastroVeic.Name = "tabCadastroVeic";
			this.tabCadastroVeic.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroVeic.Size = new System.Drawing.Size(987, 654);
			this.tabCadastroVeic.TabIndex = 1;
			this.tabCadastroVeic.Text = "Cadastro";
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnLimpar.Location = new System.Drawing.Point(455, 505);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(139, 39);
			this.btnLimpar.TabIndex = 81;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpar.UseVisualStyleBackColor = false;
			// 
			// btnVoltarCli
			// 
			this.btnVoltarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnVoltarCli.FlatAppearance.BorderSize = 0;
			this.btnVoltarCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnVoltarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVoltarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltarCli.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_ReturnTab;
			this.btnVoltarCli.Location = new System.Drawing.Point(619, 505);
			this.btnVoltarCli.Name = "btnVoltarCli";
			this.btnVoltarCli.Size = new System.Drawing.Size(139, 39);
			this.btnVoltarCli.TabIndex = 80;
			this.btnVoltarCli.Text = "Voltar";
			this.btnVoltarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltarCli.UseVisualStyleBackColor = false;
			this.btnVoltarCli.Click += new System.EventHandler(this.btnVoltarCli_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnSalvar.FlatAppearance.BorderSize = 0;
			this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnSalvar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Salvar;
			this.btnSalvar.Location = new System.Drawing.Point(296, 505);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 77;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// gbDadosVeiculo
			// 
			this.gbDadosVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
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
			this.gbDadosVeiculo.Location = new System.Drawing.Point(42, 34);
			this.gbDadosVeiculo.Name = "gbDadosVeiculo";
			this.gbDadosVeiculo.Size = new System.Drawing.Size(875, 417);
			this.gbDadosVeiculo.TabIndex = 38;
			this.gbDadosVeiculo.TabStop = false;
			this.gbDadosVeiculo.Text = "Dados do Veículo";
			// 
			// txtAnoFab
			// 
			this.txtAnoFab.CampoObrigatorio = false;
			this.txtAnoFab.Location = new System.Drawing.Point(287, 134);
			this.txtAnoFab.MensagemObrigatorio = null;
			this.txtAnoFab.Name = "txtAnoFab";
			this.txtAnoFab.Size = new System.Drawing.Size(139, 26);
			this.txtAnoFab.TabIndex = 23;
			this.txtAnoFab.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// cbStatus
			// 
			this.cbStatus.CampoObrigatorio = true;
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Location = new System.Drawing.Point(526, 70);
			this.cbStatus.MensagemCampoObrigatorio = "Selecione o Status";
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(147, 28);
			this.cbStatus.TabIndex = 22;
			// 
			// cbMarca
			// 
			this.cbMarca.CampoObrigatorio = false;
			this.cbMarca.FormattingEnabled = true;
			this.cbMarca.Location = new System.Drawing.Point(31, 70);
			this.cbMarca.MensagemCampoObrigatorio = "Informar a Marca";
			this.cbMarca.Name = "cbMarca";
			this.cbMarca.Size = new System.Drawing.Size(217, 28);
			this.cbMarca.TabIndex = 21;
			this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
			// 
			// txtData
			// 
			this.txtData.Enabled = false;
			this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtData.Location = new System.Drawing.Point(706, 70);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(133, 26);
			this.txtData.TabIndex = 20;
			// 
			// txtDataUltRev
			// 
			this.txtDataUltRev.CampoObrigatorio = false;
			this.txtDataUltRev.Location = new System.Drawing.Point(526, 210);
			this.txtDataUltRev.MensagemObrigatorio = null;
			this.txtDataUltRev.Name = "txtDataUltRev";
			this.txtDataUltRev.Size = new System.Drawing.Size(133, 26);
			this.txtDataUltRev.TabIndex = 19;
			this.txtDataUltRev.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.data;
			// 
			// lblUltimaRevisao
			// 
			this.lblUltimaRevisao.AutoSize = true;
			this.lblUltimaRevisao.Location = new System.Drawing.Point(522, 185);
			this.lblUltimaRevisao.Name = "lblUltimaRevisao";
			this.lblUltimaRevisao.Size = new System.Drawing.Size(134, 20);
			this.lblUltimaRevisao.TabIndex = 18;
			this.lblUltimaRevisao.Text = "Ultima revisão em";
			// 
			// txtKmAtual
			// 
			this.txtKmAtual.CampoObrigatorio = false;
			this.txtKmAtual.Location = new System.Drawing.Point(31, 210);
			this.txtKmAtual.MensagemObrigatorio = null;
			this.txtKmAtual.Name = "txtKmAtual";
			this.txtKmAtual.Size = new System.Drawing.Size(217, 26);
			this.txtKmAtual.TabIndex = 17;
			this.txtKmAtual.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtKmPrev
			// 
			this.txtKmPrev.CampoObrigatorio = false;
			this.txtKmPrev.Location = new System.Drawing.Point(287, 210);
			this.txtKmPrev.MensagemObrigatorio = null;
			this.txtKmPrev.Name = "txtKmPrev";
			this.txtKmPrev.Size = new System.Drawing.Size(217, 26);
			this.txtKmPrev.TabIndex = 16;
			this.txtKmPrev.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(283, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(212, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Manutenção Preventiva (KM)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 20);
			this.label3.TabIndex = 14;
			this.label3.Text = "KM Atual";
			// 
			// lblAnoFab
			// 
			this.lblAnoFab.AutoSize = true;
			this.lblAnoFab.Location = new System.Drawing.Point(283, 109);
			this.lblAnoFab.Name = "lblAnoFab";
			this.lblAnoFab.Size = new System.Drawing.Size(143, 20);
			this.lblAnoFab.TabIndex = 11;
			this.lblAnoFab.Text = "Ano de Fabricação";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(702, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Data de aquisição";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(522, 47);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(56, 20);
			this.lblStatus.TabIndex = 6;
			this.lblStatus.Text = "Status";
			// 
			// lblRenavam
			// 
			this.lblRenavam.AutoSize = true;
			this.lblRenavam.Location = new System.Drawing.Point(27, 109);
			this.lblRenavam.Name = "lblRenavam";
			this.lblRenavam.Size = new System.Drawing.Size(77, 20);
			this.lblRenavam.TabIndex = 5;
			this.lblRenavam.Text = "Renavam";
			// 
			// txtRenavam
			// 
			this.txtRenavam.CampoObrigatorio = false;
			this.txtRenavam.Location = new System.Drawing.Point(31, 134);
			this.txtRenavam.MensagemObrigatorio = null;
			this.txtRenavam.Name = "txtRenavam";
			this.txtRenavam.Size = new System.Drawing.Size(217, 26);
			this.txtRenavam.TabIndex = 4;
			this.txtRenavam.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Marca";
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(283, 47);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(61, 20);
			this.lblModelo.TabIndex = 1;
			this.lblModelo.Text = "Modelo";
			// 
			// txtModelo
			// 
			this.txtModelo.CampoObrigatorio = false;
			this.txtModelo.Location = new System.Drawing.Point(287, 70);
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
			// frmVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.ClientSize = new System.Drawing.Size(1130, 735);
			this.Controls.Add(this.tabctrlVeiculo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmVeiculo";
			this.Text = "frmVeiculo";
			this.Load += new System.EventHandler(this.frmVeiculo_Load);
			this.tabctrlVeiculo.ResumeLayout(false);
			this.tabConsultaVeic.ResumeLayout(false);
			this.gbFiltraVeiculo.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgVeiculo)).EndInit();
			this.tabCadastroVeic.ResumeLayout(false);
			this.tabCadastroVeic.PerformLayout();
			this.gbDadosVeiculo.ResumeLayout(false);
			this.gbDadosVeiculo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabctrlVeiculo;
		private System.Windows.Forms.TabPage tabConsultaVeic;
		private System.Windows.Forms.DataGridView dgVeiculo;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblMarcaPesquisa;
		private System.Windows.Forms.Button btnPesquisarVeiculo;
		private System.Windows.Forms.Label lblModeloPesquisa;
		private UserControl.SuperTextbox txtModeloPesquisa;
		private System.Windows.Forms.TabPage tabCadastroVeic;
		private System.Windows.Forms.Label lblCodCli;
		private System.Windows.Forms.TextBox txtCodigoCli;
		private System.Windows.Forms.GroupBox gbFiltraVeiculo;
		private System.Windows.Forms.Button btnFechaFuncionario;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnNovoVeiculo;
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
		private System.Windows.Forms.Button btnVoltarCli;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.DateTimePicker txtData;
		private System.Windows.Forms.Button btnLimpar;
		private UserControl.SuperComboBox cbMarca;
		private UserControl.SuperComboBox cbMarcaPesquisa;
		private UserControl.SuperComboBox cbStatus;
		private UserControl.SuperTextbox txtAnoFab;
	}
}