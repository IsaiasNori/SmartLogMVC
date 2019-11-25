namespace SmartLog.WindowsForms
{
	partial class frmViagem
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabCtrlViagem = new System.Windows.Forms.TabControl();
			this.tabConsultaViagem = new System.Windows.Forms.TabPage();
			this.gbFiltraViagem = new System.Windows.Forms.GroupBox();
			this.pblFiltroViagem = new System.Windows.Forms.Panel();
			this.lblIntervaloData = new System.Windows.Forms.Label();
			this.lblData = new System.Windows.Forms.Label();
			this.dtDataFim = new System.Windows.Forms.DateTimePicker();
			this.dtDataInicio = new System.Windows.Forms.DateTimePicker();
			this.btnPesquisarViagem = new System.Windows.Forms.Button();
			this.superTextbox2 = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblMotoCliPesquisar = new System.Windows.Forms.Label();
			this.superTextbox1 = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblMotoristaPesquisar = new System.Windows.Forms.Label();
			this.btnFechaViagem = new System.Windows.Forms.Button();
			this.btnGridExcluir = new System.Windows.Forms.Button();
			this.dgViagem = new System.Windows.Forms.DataGridView();
			this.btnGridAlterar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabCadastroViagem = new System.Windows.Forms.TabPage();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.gbDadosDestinoViagem = new System.Windows.Forms.GroupBox();
			this.cbCidadeDestino = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbEstadoDestino = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.txtBairroDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtLograDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNumeroDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCepDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblUfDestino = new System.Windows.Forms.Label();
			this.lblCidadeDestino = new System.Windows.Forms.Label();
			this.lblLograDestino = new System.Windows.Forms.Label();
			this.lblNumDestino = new System.Windows.Forms.Label();
			this.lblBairroDestino = new System.Windows.Forms.Label();
			this.lblCepDestino = new System.Windows.Forms.Label();
			this.gbDadosOrigemviagem = new System.Windows.Forms.GroupBox();
			this.cbCidadeOrigem = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbEstadoOrigem = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.txtCepOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtBairroOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtLograOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNumeroOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblUfOrigem = new System.Windows.Forms.Label();
			this.lblCidadeOrigem = new System.Windows.Forms.Label();
			this.lblLograOrigem = new System.Windows.Forms.Label();
			this.lblNumOrigem = new System.Windows.Forms.Label();
			this.lblBairroOrigem = new System.Windows.Forms.Label();
			this.lblCepOrigem = new System.Windows.Forms.Label();
			this.gbDadosViagem1 = new System.Windows.Forms.GroupBox();
			this.cbAtendente = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbVeiculo = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.superComboBox1 = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbMotoristaViagem = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.dtDataViagem = new System.Windows.Forms.DateTimePicker();
			this.lblDataViagem = new System.Windows.Forms.Label();
			this.lblMotorista = new System.Windows.Forms.Label();
			this.txtDistancia = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblDistancia = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.txtValor = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblValor = new System.Windows.Forms.Label();
			this.lblVeiculo = new System.Windows.Forms.Label();
			this.lblAtendente = new System.Windows.Forms.Label();
			this.lblCodCli = new System.Windows.Forms.Label();
			this.txtCodigoCli = new System.Windows.Forms.TextBox();
			this.btnVoltarViagem = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.tabCtrlViagem.SuspendLayout();
			this.tabConsultaViagem.SuspendLayout();
			this.gbFiltraViagem.SuspendLayout();
			this.pblFiltroViagem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgViagem)).BeginInit();
			this.tabCadastroViagem.SuspendLayout();
			this.gbDadosDestinoViagem.SuspendLayout();
			this.gbDadosOrigemviagem.SuspendLayout();
			this.gbDadosViagem1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCtrlViagem
			// 
			this.tabCtrlViagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tabCtrlViagem.Controls.Add(this.tabConsultaViagem);
			this.tabCtrlViagem.Controls.Add(this.tabCadastroViagem);
			this.tabCtrlViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabCtrlViagem.Location = new System.Drawing.Point(63, 2);
			this.tabCtrlViagem.Name = "tabCtrlViagem";
			this.tabCtrlViagem.SelectedIndex = 0;
			this.tabCtrlViagem.Size = new System.Drawing.Size(993, 691);
			this.tabCtrlViagem.TabIndex = 1;
			// 
			// tabConsultaViagem
			// 
			this.tabConsultaViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabConsultaViagem.Controls.Add(this.gbFiltraViagem);
			this.tabConsultaViagem.Controls.Add(this.btnFechaViagem);
			this.tabConsultaViagem.Controls.Add(this.btnGridExcluir);
			this.tabConsultaViagem.Controls.Add(this.dgViagem);
			this.tabConsultaViagem.Controls.Add(this.btnGridAlterar);
			this.tabConsultaViagem.Controls.Add(this.btnNovo);
			this.tabConsultaViagem.Controls.Add(this.label2);
			this.tabConsultaViagem.Controls.Add(this.label3);
			this.tabConsultaViagem.Location = new System.Drawing.Point(4, 29);
			this.tabConsultaViagem.Name = "tabConsultaViagem";
			this.tabConsultaViagem.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaViagem.Size = new System.Drawing.Size(985, 658);
			this.tabConsultaViagem.TabIndex = 0;
			this.tabConsultaViagem.Text = "Consulta";
			// 
			// gbFiltraViagem
			// 
			this.gbFiltraViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbFiltraViagem.Controls.Add(this.pblFiltroViagem);
			this.gbFiltraViagem.Location = new System.Drawing.Point(64, 40);
			this.gbFiltraViagem.Name = "gbFiltraViagem";
			this.gbFiltraViagem.Size = new System.Drawing.Size(859, 212);
			this.gbFiltraViagem.TabIndex = 21;
			this.gbFiltraViagem.TabStop = false;
			this.gbFiltraViagem.Text = "Filtrar viagem";
			// 
			// pblFiltroViagem
			// 
			this.pblFiltroViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.pblFiltroViagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pblFiltroViagem.Controls.Add(this.lblIntervaloData);
			this.pblFiltroViagem.Controls.Add(this.lblData);
			this.pblFiltroViagem.Controls.Add(this.dtDataFim);
			this.pblFiltroViagem.Controls.Add(this.dtDataInicio);
			this.pblFiltroViagem.Controls.Add(this.btnPesquisarViagem);
			this.pblFiltroViagem.Controls.Add(this.superTextbox2);
			this.pblFiltroViagem.Controls.Add(this.lblMotoCliPesquisar);
			this.pblFiltroViagem.Controls.Add(this.superTextbox1);
			this.pblFiltroViagem.Controls.Add(this.lblMotoristaPesquisar);
			this.pblFiltroViagem.Location = new System.Drawing.Point(42, 25);
			this.pblFiltroViagem.Name = "pblFiltroViagem";
			this.pblFiltroViagem.Size = new System.Drawing.Size(775, 160);
			this.pblFiltroViagem.TabIndex = 9;
			// 
			// lblIntervaloData
			// 
			this.lblIntervaloData.AutoSize = true;
			this.lblIntervaloData.Location = new System.Drawing.Point(591, 50);
			this.lblIntervaloData.Name = "lblIntervaloData";
			this.lblIntervaloData.Size = new System.Drawing.Size(18, 20);
			this.lblIntervaloData.TabIndex = 18;
			this.lblIntervaloData.Text = "à";
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Location = new System.Drawing.Point(442, 21);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(73, 20);
			this.lblData.TabIndex = 11;
			this.lblData.Text = "Por data:";
			// 
			// dtDataFim
			// 
			this.dtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataFim.Location = new System.Drawing.Point(615, 44);
			this.dtDataFim.Name = "dtDataFim";
			this.dtDataFim.Size = new System.Drawing.Size(139, 26);
			this.dtDataFim.TabIndex = 17;
			// 
			// dtDataInicio
			// 
			this.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataInicio.Location = new System.Drawing.Point(446, 45);
			this.dtDataInicio.Name = "dtDataInicio";
			this.dtDataInicio.Size = new System.Drawing.Size(139, 26);
			this.dtDataInicio.TabIndex = 16;
			// 
			// btnPesquisarViagem
			// 
			this.btnPesquisarViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnPesquisarViagem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.btnPesquisarViagem.FlatAppearance.BorderSize = 0;
			this.btnPesquisarViagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnPesquisarViagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnPesquisarViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisarViagem.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_search;
			this.btnPesquisarViagem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPesquisarViagem.Location = new System.Drawing.Point(306, 103);
			this.btnPesquisarViagem.Name = "btnPesquisarViagem";
			this.btnPesquisarViagem.Size = new System.Drawing.Size(199, 39);
			this.btnPesquisarViagem.TabIndex = 8;
			this.btnPesquisarViagem.Text = "Pesquisar";
			this.btnPesquisarViagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisarViagem.UseVisualStyleBackColor = false;
			// 
			// superTextbox2
			// 
			this.superTextbox2.CampoObrigatorio = false;
			this.superTextbox2.Location = new System.Drawing.Point(230, 47);
			this.superTextbox2.MensagemObrigatorio = null;
			this.superTextbox2.Name = "superTextbox2";
			this.superTextbox2.Size = new System.Drawing.Size(200, 26);
			this.superTextbox2.TabIndex = 15;
			this.superTextbox2.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// lblMotoCliPesquisar
			// 
			this.lblMotoCliPesquisar.AutoSize = true;
			this.lblMotoCliPesquisar.Location = new System.Drawing.Point(227, 24);
			this.lblMotoCliPesquisar.Name = "lblMotoCliPesquisar";
			this.lblMotoCliPesquisar.Size = new System.Drawing.Size(58, 20);
			this.lblMotoCliPesquisar.TabIndex = 14;
			this.lblMotoCliPesquisar.Text = "Cliente";
			// 
			// superTextbox1
			// 
			this.superTextbox1.CampoObrigatorio = false;
			this.superTextbox1.Location = new System.Drawing.Point(24, 48);
			this.superTextbox1.MensagemObrigatorio = null;
			this.superTextbox1.Name = "superTextbox1";
			this.superTextbox1.Size = new System.Drawing.Size(200, 26);
			this.superTextbox1.TabIndex = 13;
			this.superTextbox1.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// lblMotoristaPesquisar
			// 
			this.lblMotoristaPesquisar.AutoSize = true;
			this.lblMotoristaPesquisar.Location = new System.Drawing.Point(21, 25);
			this.lblMotoristaPesquisar.Name = "lblMotoristaPesquisar";
			this.lblMotoristaPesquisar.Size = new System.Drawing.Size(75, 20);
			this.lblMotoristaPesquisar.TabIndex = 12;
			this.lblMotoristaPesquisar.Text = "Motorista";
			// 
			// btnFechaViagem
			// 
			this.btnFechaViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnFechaViagem.FlatAppearance.BorderSize = 0;
			this.btnFechaViagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnFechaViagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFechaViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechaViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechaViagem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnFechaViagem.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_FecharTab;
			this.btnFechaViagem.Location = new System.Drawing.Point(700, 271);
			this.btnFechaViagem.Name = "btnFechaViagem";
			this.btnFechaViagem.Size = new System.Drawing.Size(139, 39);
			this.btnFechaViagem.TabIndex = 20;
			this.btnFechaViagem.Text = "Fechar";
			this.btnFechaViagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechaViagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechaViagem.UseVisualStyleBackColor = false;
			this.btnFechaViagem.Click += new System.EventHandler(this.btnFechaViagem_Click);
			// 
			// btnGridExcluir
			// 
			this.btnGridExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnGridExcluir.FlatAppearance.BorderSize = 0;
			this.btnGridExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnGridExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnGridExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGridExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGridExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnGridExcluir.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Excluir;
			this.btnGridExcluir.Location = new System.Drawing.Point(526, 271);
			this.btnGridExcluir.Name = "btnGridExcluir";
			this.btnGridExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnGridExcluir.TabIndex = 19;
			this.btnGridExcluir.Text = "Excluir";
			this.btnGridExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGridExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGridExcluir.UseVisualStyleBackColor = false;
			// 
			// dgViagem
			// 
			this.dgViagem.AllowUserToAddRows = false;
			this.dgViagem.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.dgViagem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgViagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgViagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgViagem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgViagem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgViagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgViagem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgViagem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgViagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgViagem.ColumnHeadersHeight = 35;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgViagem.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgViagem.EnableHeadersVisualStyles = false;
			this.dgViagem.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgViagem.Location = new System.Drawing.Point(64, 363);
			this.dgViagem.Name = "dgViagem";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgViagem.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgViagem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgViagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgViagem.Size = new System.Drawing.Size(859, 293);
			this.dgViagem.TabIndex = 1;
			this.dgViagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtCliente_CellContentClick);
			// 
			// btnGridAlterar
			// 
			this.btnGridAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnGridAlterar.FlatAppearance.BorderSize = 0;
			this.btnGridAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnGridAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnGridAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGridAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGridAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnGridAlterar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Alterar;
			this.btnGridAlterar.Location = new System.Drawing.Point(354, 271);
			this.btnGridAlterar.Name = "btnGridAlterar";
			this.btnGridAlterar.Size = new System.Drawing.Size(139, 39);
			this.btnGridAlterar.TabIndex = 18;
			this.btnGridAlterar.Text = "Alterar";
			this.btnGridAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGridAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGridAlterar.UseVisualStyleBackColor = false;
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnNovo.FlatAppearance.BorderSize = 0;
			this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNovo.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Novo;
			this.btnNovo.Location = new System.Drawing.Point(183, 271);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(139, 39);
			this.btnNovo.TabIndex = 17;
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(738, 428);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "De";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(808, 405);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Até";
			// 
			// tabCadastroViagem
			// 
			this.tabCadastroViagem.AutoScroll = true;
			this.tabCadastroViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabCadastroViagem.Controls.Add(this.btnLimpar);
			this.tabCadastroViagem.Controls.Add(this.gbDadosDestinoViagem);
			this.tabCadastroViagem.Controls.Add(this.gbDadosOrigemviagem);
			this.tabCadastroViagem.Controls.Add(this.gbDadosViagem1);
			this.tabCadastroViagem.Controls.Add(this.lblCodCli);
			this.tabCadastroViagem.Controls.Add(this.txtCodigoCli);
			this.tabCadastroViagem.Controls.Add(this.btnVoltarViagem);
			this.tabCadastroViagem.Controls.Add(this.btnSalvar);
			this.tabCadastroViagem.Location = new System.Drawing.Point(4, 29);
			this.tabCadastroViagem.Name = "tabCadastroViagem";
			this.tabCadastroViagem.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroViagem.Size = new System.Drawing.Size(985, 658);
			this.tabCadastroViagem.TabIndex = 1;
			this.tabCadastroViagem.Text = "Cadastro";
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnLimpar.Location = new System.Drawing.Point(463, 603);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(139, 39);
			this.btnLimpar.TabIndex = 102;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpar.UseVisualStyleBackColor = false;
			// 
			// gbDadosDestinoViagem
			// 
			this.gbDadosDestinoViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbDadosDestinoViagem.Controls.Add(this.cbCidadeDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.cbEstadoDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.txtBairroDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.txtLograDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.txtNumeroDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.txtCepDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.lblUfDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.lblCidadeDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.lblLograDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.lblNumDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.lblBairroDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.lblCepDestino);
			this.gbDadosDestinoViagem.Location = new System.Drawing.Point(125, 416);
			this.gbDadosDestinoViagem.Name = "gbDadosDestinoViagem";
			this.gbDadosDestinoViagem.Size = new System.Drawing.Size(792, 170);
			this.gbDadosDestinoViagem.TabIndex = 96;
			this.gbDadosDestinoViagem.TabStop = false;
			this.gbDadosDestinoViagem.Text = "Destino da Viagem";
			// 
			// cbCidadeDestino
			// 
			this.cbCidadeDestino.CampoObrigatorio = true;
			this.cbCidadeDestino.FormattingEnabled = true;
			this.cbCidadeDestino.Location = new System.Drawing.Point(430, 59);
			this.cbCidadeDestino.MensagemCampoObrigatorio = null;
			this.cbCidadeDestino.Name = "cbCidadeDestino";
			this.cbCidadeDestino.Size = new System.Drawing.Size(194, 28);
			this.cbCidadeDestino.TabIndex = 85;
			// 
			// cbEstadoDestino
			// 
			this.cbEstadoDestino.CampoObrigatorio = true;
			this.cbEstadoDestino.FormattingEnabled = true;
			this.cbEstadoDestino.Location = new System.Drawing.Point(327, 57);
			this.cbEstadoDestino.MensagemCampoObrigatorio = null;
			this.cbEstadoDestino.Name = "cbEstadoDestino";
			this.cbEstadoDestino.Size = new System.Drawing.Size(80, 28);
			this.cbEstadoDestino.TabIndex = 84;
			this.cbEstadoDestino.SelectedIndexChanged += new System.EventHandler(this.cbEstadoDestino_SelectedIndexChanged_1);
			// 
			// txtBairroDestino
			// 
			this.txtBairroDestino.CampoObrigatorio = false;
			this.txtBairroDestino.Location = new System.Drawing.Point(430, 124);
			this.txtBairroDestino.MensagemObrigatorio = null;
			this.txtBairroDestino.Name = "txtBairroDestino";
			this.txtBairroDestino.Size = new System.Drawing.Size(194, 26);
			this.txtBairroDestino.TabIndex = 82;
			this.txtBairroDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtLograDestino
			// 
			this.txtLograDestino.CampoObrigatorio = false;
			this.txtLograDestino.Location = new System.Drawing.Point(40, 124);
			this.txtLograDestino.MensagemObrigatorio = null;
			this.txtLograDestino.Name = "txtLograDestino";
			this.txtLograDestino.Size = new System.Drawing.Size(248, 26);
			this.txtLograDestino.TabIndex = 81;
			this.txtLograDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtNumeroDestino
			// 
			this.txtNumeroDestino.CampoObrigatorio = false;
			this.txtNumeroDestino.Location = new System.Drawing.Point(327, 124);
			this.txtNumeroDestino.MensagemObrigatorio = null;
			this.txtNumeroDestino.Name = "txtNumeroDestino";
			this.txtNumeroDestino.Size = new System.Drawing.Size(80, 26);
			this.txtNumeroDestino.TabIndex = 80;
			this.txtNumeroDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtCepDestino
			// 
			this.txtCepDestino.CampoObrigatorio = false;
			this.txtCepDestino.Location = new System.Drawing.Point(40, 59);
			this.txtCepDestino.MensagemObrigatorio = null;
			this.txtCepDestino.Name = "txtCepDestino";
			this.txtCepDestino.Size = new System.Drawing.Size(168, 26);
			this.txtCepDestino.TabIndex = 79;
			this.txtCepDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// lblUfDestino
			// 
			this.lblUfDestino.AutoSize = true;
			this.lblUfDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblUfDestino.Location = new System.Drawing.Point(324, 34);
			this.lblUfDestino.Name = "lblUfDestino";
			this.lblUfDestino.Size = new System.Drawing.Size(86, 20);
			this.lblUfDestino.TabIndex = 72;
			this.lblUfDestino.Text = "Estado/UF";
			// 
			// lblCidadeDestino
			// 
			this.lblCidadeDestino.AutoSize = true;
			this.lblCidadeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCidadeDestino.Location = new System.Drawing.Point(426, 34);
			this.lblCidadeDestino.Name = "lblCidadeDestino";
			this.lblCidadeDestino.Size = new System.Drawing.Size(59, 20);
			this.lblCidadeDestino.TabIndex = 73;
			this.lblCidadeDestino.Text = "Cidade";
			// 
			// lblLograDestino
			// 
			this.lblLograDestino.AutoSize = true;
			this.lblLograDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblLograDestino.Location = new System.Drawing.Point(37, 101);
			this.lblLograDestino.Name = "lblLograDestino";
			this.lblLograDestino.Size = new System.Drawing.Size(91, 20);
			this.lblLograDestino.TabIndex = 74;
			this.lblLograDestino.Text = "Logradouro";
			// 
			// lblNumDestino
			// 
			this.lblNumDestino.AutoSize = true;
			this.lblNumDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNumDestino.Location = new System.Drawing.Point(324, 101);
			this.lblNumDestino.Name = "lblNumDestino";
			this.lblNumDestino.Size = new System.Drawing.Size(26, 20);
			this.lblNumDestino.TabIndex = 75;
			this.lblNumDestino.Text = "Nº";
			// 
			// lblBairroDestino
			// 
			this.lblBairroDestino.AutoSize = true;
			this.lblBairroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblBairroDestino.Location = new System.Drawing.Point(426, 101);
			this.lblBairroDestino.Name = "lblBairroDestino";
			this.lblBairroDestino.Size = new System.Drawing.Size(51, 20);
			this.lblBairroDestino.TabIndex = 76;
			this.lblBairroDestino.Text = "Bairro";
			// 
			// lblCepDestino
			// 
			this.lblCepDestino.AutoSize = true;
			this.lblCepDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCepDestino.Location = new System.Drawing.Point(37, 34);
			this.lblCepDestino.Name = "lblCepDestino";
			this.lblCepDestino.Size = new System.Drawing.Size(41, 20);
			this.lblCepDestino.TabIndex = 77;
			this.lblCepDestino.Text = "CEP";
			// 
			// gbDadosOrigemviagem
			// 
			this.gbDadosOrigemviagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbDadosOrigemviagem.Controls.Add(this.cbCidadeOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.cbEstadoOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.txtCepOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.txtBairroOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.txtLograOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.txtNumeroOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.lblUfOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.lblCidadeOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.lblLograOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.lblNumOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.lblBairroOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.lblCepOrigem);
			this.gbDadosOrigemviagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbDadosOrigemviagem.Location = new System.Drawing.Point(125, 239);
			this.gbDadosOrigemviagem.Name = "gbDadosOrigemviagem";
			this.gbDadosOrigemviagem.Size = new System.Drawing.Size(792, 171);
			this.gbDadosOrigemviagem.TabIndex = 69;
			this.gbDadosOrigemviagem.TabStop = false;
			this.gbDadosOrigemviagem.Text = "Origem da Viagem";
			// 
			// cbCidadeOrigem
			// 
			this.cbCidadeOrigem.CampoObrigatorio = true;
			this.cbCidadeOrigem.FormattingEnabled = true;
			this.cbCidadeOrigem.Location = new System.Drawing.Point(430, 57);
			this.cbCidadeOrigem.MensagemCampoObrigatorio = null;
			this.cbCidadeOrigem.Name = "cbCidadeOrigem";
			this.cbCidadeOrigem.Size = new System.Drawing.Size(194, 28);
			this.cbCidadeOrigem.TabIndex = 84;
			// 
			// cbEstadoOrigem
			// 
			this.cbEstadoOrigem.CampoObrigatorio = true;
			this.cbEstadoOrigem.FormattingEnabled = true;
			this.cbEstadoOrigem.Location = new System.Drawing.Point(327, 55);
			this.cbEstadoOrigem.MensagemCampoObrigatorio = null;
			this.cbEstadoOrigem.Name = "cbEstadoOrigem";
			this.cbEstadoOrigem.Size = new System.Drawing.Size(80, 28);
			this.cbEstadoOrigem.TabIndex = 83;
			this.cbEstadoOrigem.SelectedIndexChanged += new System.EventHandler(this.cbEstadoOrigem_SelectedIndexChanged);
			// 
			// txtCepOrigem
			// 
			this.txtCepOrigem.CampoObrigatorio = false;
			this.txtCepOrigem.Location = new System.Drawing.Point(40, 57);
			this.txtCepOrigem.MensagemObrigatorio = null;
			this.txtCepOrigem.Name = "txtCepOrigem";
			this.txtCepOrigem.Size = new System.Drawing.Size(168, 26);
			this.txtCepOrigem.TabIndex = 82;
			this.txtCepOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtBairroOrigem
			// 
			this.txtBairroOrigem.CampoObrigatorio = false;
			this.txtBairroOrigem.Location = new System.Drawing.Point(430, 123);
			this.txtBairroOrigem.MensagemObrigatorio = null;
			this.txtBairroOrigem.Name = "txtBairroOrigem";
			this.txtBairroOrigem.Size = new System.Drawing.Size(194, 26);
			this.txtBairroOrigem.TabIndex = 81;
			this.txtBairroOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtLograOrigem
			// 
			this.txtLograOrigem.CampoObrigatorio = false;
			this.txtLograOrigem.Location = new System.Drawing.Point(41, 123);
			this.txtLograOrigem.MensagemObrigatorio = null;
			this.txtLograOrigem.Name = "txtLograOrigem";
			this.txtLograOrigem.Size = new System.Drawing.Size(248, 26);
			this.txtLograOrigem.TabIndex = 80;
			this.txtLograOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtNumeroOrigem
			// 
			this.txtNumeroOrigem.CampoObrigatorio = false;
			this.txtNumeroOrigem.Location = new System.Drawing.Point(328, 121);
			this.txtNumeroOrigem.MensagemObrigatorio = null;
			this.txtNumeroOrigem.Name = "txtNumeroOrigem";
			this.txtNumeroOrigem.Size = new System.Drawing.Size(80, 26);
			this.txtNumeroOrigem.TabIndex = 79;
			this.txtNumeroOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// lblUfOrigem
			// 
			this.lblUfOrigem.AutoSize = true;
			this.lblUfOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblUfOrigem.Location = new System.Drawing.Point(324, 33);
			this.lblUfOrigem.Name = "lblUfOrigem";
			this.lblUfOrigem.Size = new System.Drawing.Size(86, 20);
			this.lblUfOrigem.TabIndex = 72;
			this.lblUfOrigem.Text = "Estado/UF";
			// 
			// lblCidadeOrigem
			// 
			this.lblCidadeOrigem.AutoSize = true;
			this.lblCidadeOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCidadeOrigem.Location = new System.Drawing.Point(426, 33);
			this.lblCidadeOrigem.Name = "lblCidadeOrigem";
			this.lblCidadeOrigem.Size = new System.Drawing.Size(59, 20);
			this.lblCidadeOrigem.TabIndex = 73;
			this.lblCidadeOrigem.Text = "Cidade";
			// 
			// lblLograOrigem
			// 
			this.lblLograOrigem.AutoSize = true;
			this.lblLograOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblLograOrigem.Location = new System.Drawing.Point(38, 100);
			this.lblLograOrigem.Name = "lblLograOrigem";
			this.lblLograOrigem.Size = new System.Drawing.Size(91, 20);
			this.lblLograOrigem.TabIndex = 74;
			this.lblLograOrigem.Text = "Logradouro";
			// 
			// lblNumOrigem
			// 
			this.lblNumOrigem.AutoSize = true;
			this.lblNumOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNumOrigem.Location = new System.Drawing.Point(324, 100);
			this.lblNumOrigem.Name = "lblNumOrigem";
			this.lblNumOrigem.Size = new System.Drawing.Size(26, 20);
			this.lblNumOrigem.TabIndex = 75;
			this.lblNumOrigem.Text = "Nº";
			// 
			// lblBairroOrigem
			// 
			this.lblBairroOrigem.AutoSize = true;
			this.lblBairroOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblBairroOrigem.Location = new System.Drawing.Point(426, 100);
			this.lblBairroOrigem.Name = "lblBairroOrigem";
			this.lblBairroOrigem.Size = new System.Drawing.Size(51, 20);
			this.lblBairroOrigem.TabIndex = 76;
			this.lblBairroOrigem.Text = "Bairro";
			// 
			// lblCepOrigem
			// 
			this.lblCepOrigem.AutoSize = true;
			this.lblCepOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCepOrigem.Location = new System.Drawing.Point(38, 33);
			this.lblCepOrigem.Name = "lblCepOrigem";
			this.lblCepOrigem.Size = new System.Drawing.Size(41, 20);
			this.lblCepOrigem.TabIndex = 77;
			this.lblCepOrigem.Text = "CEP";
			// 
			// gbDadosViagem1
			// 
			this.gbDadosViagem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbDadosViagem1.Controls.Add(this.cbAtendente);
			this.gbDadosViagem1.Controls.Add(this.cbVeiculo);
			this.gbDadosViagem1.Controls.Add(this.superComboBox1);
			this.gbDadosViagem1.Controls.Add(this.cbMotoristaViagem);
			this.gbDadosViagem1.Controls.Add(this.dtDataViagem);
			this.gbDadosViagem1.Controls.Add(this.lblDataViagem);
			this.gbDadosViagem1.Controls.Add(this.lblMotorista);
			this.gbDadosViagem1.Controls.Add(this.txtDistancia);
			this.gbDadosViagem1.Controls.Add(this.lblDistancia);
			this.gbDadosViagem1.Controls.Add(this.lblCliente);
			this.gbDadosViagem1.Controls.Add(this.txtValor);
			this.gbDadosViagem1.Controls.Add(this.lblValor);
			this.gbDadosViagem1.Controls.Add(this.lblVeiculo);
			this.gbDadosViagem1.Controls.Add(this.lblAtendente);
			this.gbDadosViagem1.Location = new System.Drawing.Point(125, 16);
			this.gbDadosViagem1.Name = "gbDadosViagem1";
			this.gbDadosViagem1.Size = new System.Drawing.Size(792, 217);
			this.gbDadosViagem1.TabIndex = 97;
			this.gbDadosViagem1.TabStop = false;
			this.gbDadosViagem1.Text = "Dados da Viagem";
			// 
			// cbAtendente
			// 
			this.cbAtendente.CampoObrigatorio = true;
			this.cbAtendente.FormattingEnabled = true;
			this.cbAtendente.Location = new System.Drawing.Point(589, 113);
			this.cbAtendente.MensagemCampoObrigatorio = "Informar o Atendente";
			this.cbAtendente.Name = "cbAtendente";
			this.cbAtendente.Size = new System.Drawing.Size(175, 28);
			this.cbAtendente.TabIndex = 96;
			// 
			// cbVeiculo
			// 
			this.cbVeiculo.CampoObrigatorio = true;
			this.cbVeiculo.CausesValidation = false;
			this.cbVeiculo.FormattingEnabled = true;
			this.cbVeiculo.Location = new System.Drawing.Point(328, 113);
			this.cbVeiculo.MensagemCampoObrigatorio = null;
			this.cbVeiculo.Name = "cbVeiculo";
			this.cbVeiculo.Size = new System.Drawing.Size(207, 28);
			this.cbVeiculo.TabIndex = 95;
			// 
			// superComboBox1
			// 
			this.superComboBox1.CampoObrigatorio = true;
			this.superComboBox1.FormattingEnabled = true;
			this.superComboBox1.Location = new System.Drawing.Point(40, 171);
			this.superComboBox1.MensagemCampoObrigatorio = null;
			this.superComboBox1.Name = "superComboBox1";
			this.superComboBox1.Size = new System.Drawing.Size(264, 28);
			this.superComboBox1.TabIndex = 94;
			// 
			// cbMotoristaViagem
			// 
			this.cbMotoristaViagem.CampoObrigatorio = true;
			this.cbMotoristaViagem.FormattingEnabled = true;
			this.cbMotoristaViagem.Location = new System.Drawing.Point(40, 111);
			this.cbMotoristaViagem.MensagemCampoObrigatorio = null;
			this.cbMotoristaViagem.Name = "cbMotoristaViagem";
			this.cbMotoristaViagem.Size = new System.Drawing.Size(264, 28);
			this.cbMotoristaViagem.TabIndex = 93;
			// 
			// dtDataViagem
			// 
			this.dtDataViagem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataViagem.Location = new System.Drawing.Point(41, 55);
			this.dtDataViagem.Name = "dtDataViagem";
			this.dtDataViagem.Size = new System.Drawing.Size(138, 26);
			this.dtDataViagem.TabIndex = 92;
			// 
			// lblDataViagem
			// 
			this.lblDataViagem.AutoSize = true;
			this.lblDataViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDataViagem.Location = new System.Drawing.Point(37, 32);
			this.lblDataViagem.Name = "lblDataViagem";
			this.lblDataViagem.Size = new System.Drawing.Size(44, 20);
			this.lblDataViagem.TabIndex = 52;
			this.lblDataViagem.Text = "Data";
			// 
			// lblMotorista
			// 
			this.lblMotorista.AutoSize = true;
			this.lblMotorista.Location = new System.Drawing.Point(38, 88);
			this.lblMotorista.Name = "lblMotorista";
			this.lblMotorista.Size = new System.Drawing.Size(75, 20);
			this.lblMotorista.TabIndex = 68;
			this.lblMotorista.Text = "Motorista";
			// 
			// txtDistancia
			// 
			this.txtDistancia.CampoObrigatorio = false;
			this.txtDistancia.Location = new System.Drawing.Point(590, 173);
			this.txtDistancia.MensagemObrigatorio = null;
			this.txtDistancia.Name = "txtDistancia";
			this.txtDistancia.Size = new System.Drawing.Size(138, 26);
			this.txtDistancia.TabIndex = 91;
			this.txtDistancia.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// lblDistancia
			// 
			this.lblDistancia.AutoSize = true;
			this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDistancia.Location = new System.Drawing.Point(586, 148);
			this.lblDistancia.Name = "lblDistancia";
			this.lblDistancia.Size = new System.Drawing.Size(128, 20);
			this.lblDistancia.TabIndex = 90;
			this.lblDistancia.Text = "Distancia em KM";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(38, 148);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(58, 20);
			this.lblCliente.TabIndex = 70;
			this.lblCliente.Text = "Cliente";
			// 
			// txtValor
			// 
			this.txtValor.CampoObrigatorio = false;
			this.txtValor.Location = new System.Drawing.Point(328, 173);
			this.txtValor.MensagemObrigatorio = null;
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(207, 26);
			this.txtValor.TabIndex = 89;
			this.txtValor.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblValor.Location = new System.Drawing.Point(323, 148);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(46, 20);
			this.lblValor.TabIndex = 88;
			this.lblValor.Text = "Valor";
			// 
			// lblVeiculo
			// 
			this.lblVeiculo.AutoSize = true;
			this.lblVeiculo.Location = new System.Drawing.Point(324, 88);
			this.lblVeiculo.Name = "lblVeiculo";
			this.lblVeiculo.Size = new System.Drawing.Size(61, 20);
			this.lblVeiculo.TabIndex = 84;
			this.lblVeiculo.Text = "Veiculo";
			// 
			// lblAtendente
			// 
			this.lblAtendente.AutoSize = true;
			this.lblAtendente.Location = new System.Drawing.Point(586, 90);
			this.lblAtendente.Name = "lblAtendente";
			this.lblAtendente.Size = new System.Drawing.Size(84, 20);
			this.lblAtendente.TabIndex = 86;
			this.lblAtendente.Text = "Atendente";
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
			// btnVoltarViagem
			// 
			this.btnVoltarViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnVoltarViagem.FlatAppearance.BorderSize = 0;
			this.btnVoltarViagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnVoltarViagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVoltarViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltarViagem.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_ReturnTab;
			this.btnVoltarViagem.Location = new System.Drawing.Point(622, 603);
			this.btnVoltarViagem.Name = "btnVoltarViagem";
			this.btnVoltarViagem.Size = new System.Drawing.Size(139, 39);
			this.btnVoltarViagem.TabIndex = 101;
			this.btnVoltarViagem.Text = "Voltar";
			this.btnVoltarViagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltarViagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltarViagem.UseVisualStyleBackColor = false;
			this.btnVoltarViagem.Click += new System.EventHandler(this.BtnVoltarFunc_Click);
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
			this.btnSalvar.Location = new System.Drawing.Point(300, 603);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 98;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
			// 
			// frmViagem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.ClientSize = new System.Drawing.Size(1144, 739);
			this.Controls.Add(this.tabCtrlViagem);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmViagem";
			this.Text = "frmViagem";
			this.Load += new System.EventHandler(this.FrmViagem_Load);
			this.tabCtrlViagem.ResumeLayout(false);
			this.tabConsultaViagem.ResumeLayout(false);
			this.tabConsultaViagem.PerformLayout();
			this.gbFiltraViagem.ResumeLayout(false);
			this.pblFiltroViagem.ResumeLayout(false);
			this.pblFiltroViagem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgViagem)).EndInit();
			this.tabCadastroViagem.ResumeLayout(false);
			this.tabCadastroViagem.PerformLayout();
			this.gbDadosDestinoViagem.ResumeLayout(false);
			this.gbDadosDestinoViagem.PerformLayout();
			this.gbDadosOrigemviagem.ResumeLayout(false);
			this.gbDadosOrigemviagem.PerformLayout();
			this.gbDadosViagem1.ResumeLayout(false);
			this.gbDadosViagem1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtrlViagem;
		private System.Windows.Forms.TabPage tabConsultaViagem;
		private System.Windows.Forms.DataGridView dgViagem;
		private System.Windows.Forms.Panel pblFiltroViagem;
		private System.Windows.Forms.Button btnPesquisarViagem;
		private System.Windows.Forms.TabPage tabCadastroViagem;
		private System.Windows.Forms.Label lblDataViagem;
		private System.Windows.Forms.Label lblCodCli;
		private System.Windows.Forms.TextBox txtCodigoCli;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private UserControl.SuperTextbox superTextbox2;
		private System.Windows.Forms.Label lblMotoCliPesquisar;
		private UserControl.SuperTextbox superTextbox1;
		private System.Windows.Forms.Label lblMotoristaPesquisar;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblMotorista;
		private UserControl.SuperTextbox txtDistancia;
		private System.Windows.Forms.Label lblDistancia;
		private UserControl.SuperTextbox txtValor;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblAtendente;
		private System.Windows.Forms.Label lblVeiculo;
		private System.Windows.Forms.Button btnFechaViagem;
		private System.Windows.Forms.Button btnGridExcluir;
		private System.Windows.Forms.Button btnGridAlterar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.GroupBox gbFiltraViagem;
		private System.Windows.Forms.GroupBox gbDadosDestinoViagem;
		private System.Windows.Forms.Label lblUfDestino;
		private System.Windows.Forms.Label lblCidadeDestino;
		private System.Windows.Forms.Label lblLograDestino;
		private System.Windows.Forms.Label lblNumDestino;
		private System.Windows.Forms.Label lblBairroDestino;
		private System.Windows.Forms.Label lblCepDestino;
		private System.Windows.Forms.GroupBox gbDadosOrigemviagem;
		private System.Windows.Forms.Label lblUfOrigem;
		private System.Windows.Forms.Label lblCidadeOrigem;
		private System.Windows.Forms.Label lblLograOrigem;
		private System.Windows.Forms.Label lblNumOrigem;
		private System.Windows.Forms.Label lblBairroOrigem;
		private System.Windows.Forms.Label lblCepOrigem;
		private System.Windows.Forms.GroupBox gbDadosViagem1;
		private UserControl.SuperTextbox txtCepDestino;
		private UserControl.SuperTextbox txtBairroDestino;
		private UserControl.SuperTextbox txtLograDestino;
		private UserControl.SuperTextbox txtNumeroDestino;
		private UserControl.SuperTextbox txtBairroOrigem;
		private UserControl.SuperTextbox txtLograOrigem;
		private UserControl.SuperTextbox txtNumeroOrigem;
		private System.Windows.Forms.DateTimePicker dtDataViagem;
		private System.Windows.Forms.Button btnVoltarViagem;
		private System.Windows.Forms.Button btnSalvar;
		private UserControl.SuperTextbox txtCepOrigem;
		private System.Windows.Forms.Label lblIntervaloData;
		private System.Windows.Forms.DateTimePicker dtDataFim;
		private System.Windows.Forms.DateTimePicker dtDataInicio;
		private System.Windows.Forms.Button btnLimpar;
		private UserControl.SuperComboBox cbCidadeDestino;
		private UserControl.SuperComboBox cbEstadoDestino;
		private UserControl.SuperComboBox cbCidadeOrigem;
		private UserControl.SuperComboBox cbEstadoOrigem;
		private UserControl.SuperComboBox cbAtendente;
		private UserControl.SuperComboBox cbVeiculo;
		private UserControl.SuperComboBox superComboBox1;
		private UserControl.SuperComboBox cbMotoristaViagem;
	}
}