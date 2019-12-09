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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabCtrlViagem = new System.Windows.Forms.TabControl();
            this.tabConsultaViagem = new System.Windows.Forms.TabPage();
            this.btnFechaViagem = new System.Windows.Forms.Button();
            this.btnGridExcluir = new System.Windows.Forms.Button();
            this.btnGridAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgViagem = new System.Windows.Forms.DataGridView();
            this.gbFiltraViagem = new System.Windows.Forms.GroupBox();
            this.chkData = new System.Windows.Forms.CheckBox();
            this.btnPesquisarViagem = new System.Windows.Forms.Button();
            this.dtDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblIntervaloData = new System.Windows.Forms.Label();
            this.lblMotoristaPesquisar = new System.Windows.Forms.Label();
            this.lblMotoCliPesquisar = new System.Windows.Forms.Label();
            this.tabCadastroViagem = new System.Windows.Forms.TabPage();
            this.pnDadosViagem = new System.Windows.Forms.Panel();
            this.gbDadosViagem1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtDataViagem = new System.Windows.Forms.DateTimePicker();
            this.lblDataViagem = new System.Windows.Forms.Label();
            this.lblMotorista = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblAtendente = new System.Windows.Forms.Label();
            this.gbDadosOrigemviagem = new System.Windows.Forms.GroupBox();
            this.lblCompleOrigem = new System.Windows.Forms.Label();
            this.lblCidadeOrigem = new System.Windows.Forms.Label();
            this.lblLograOrigem = new System.Windows.Forms.Label();
            this.lblNumOrigem = new System.Windows.Forms.Label();
            this.lblBairroOrigem = new System.Windows.Forms.Label();
            this.lblUfOrigem = new System.Windows.Forms.Label();
            this.lblCepOrigem = new System.Windows.Forms.Label();
            this.gbDadosDestinoViagem = new System.Windows.Forms.GroupBox();
            this.lblCompleDestino = new System.Windows.Forms.Label();
            this.lblUfDestino = new System.Windows.Forms.Label();
            this.lblCidadeDestino = new System.Windows.Forms.Label();
            this.lblLograDestino = new System.Windows.Forms.Label();
            this.lblNumDestino = new System.Windows.Forms.Label();
            this.lblBairroDestino = new System.Windows.Forms.Label();
            this.lblCepDestino = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.txtCodigoCli = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTipViagem = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbClientePesquisa = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.cbMotoristaPesquisar = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.cbStatus = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.cbAtendente = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.cbVeiculo = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.cbCliente = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.cbMotoristaViagem = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.txtDistancia = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtValor = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtCompleOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.cbCidadeOrigem = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.txtCepOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtBairroOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.cbEstadoOrigem = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.txtLograOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtNumeroOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtCompleDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.cbCidadeDestino = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.cbEstadoDestino = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.txtBairroDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtLograDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtNumeroDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtCepDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.tabCtrlViagem.SuspendLayout();
            this.tabConsultaViagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViagem)).BeginInit();
            this.gbFiltraViagem.SuspendLayout();
            this.tabCadastroViagem.SuspendLayout();
            this.pnDadosViagem.SuspendLayout();
            this.gbDadosViagem1.SuspendLayout();
            this.gbDadosOrigemviagem.SuspendLayout();
            this.gbDadosDestinoViagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlViagem
            // 
            this.tabCtrlViagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlViagem.Controls.Add(this.tabConsultaViagem);
            this.tabCtrlViagem.Controls.Add(this.tabCadastroViagem);
            this.tabCtrlViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlViagem.HotTrack = true;
            this.tabCtrlViagem.Location = new System.Drawing.Point(83, 49);
            this.tabCtrlViagem.Margin = new System.Windows.Forms.Padding(4, 615, 4, 4);
            this.tabCtrlViagem.Multiline = true;
            this.tabCtrlViagem.Name = "tabCtrlViagem";
            this.tabCtrlViagem.Padding = new System.Drawing.Point(100, 5);
            this.tabCtrlViagem.SelectedIndex = 0;
            this.tabCtrlViagem.Size = new System.Drawing.Size(1324, 828);
            this.tabCtrlViagem.TabIndex = 1;
            this.toolTipViagem.SetToolTip(this.tabCtrlViagem, "Consulta de Viagens. Aqui você buscar , alterar e excluir todas viagens cadastrad" +
        "as. ");
            // 
            // tabConsultaViagem
            // 
            this.tabConsultaViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
            this.tabConsultaViagem.Controls.Add(this.btnFechaViagem);
            this.tabConsultaViagem.Controls.Add(this.btnGridExcluir);
            this.tabConsultaViagem.Controls.Add(this.btnGridAlterar);
            this.tabConsultaViagem.Controls.Add(this.btnNovo);
            this.tabConsultaViagem.Controls.Add(this.dgViagem);
            this.tabConsultaViagem.Controls.Add(this.gbFiltraViagem);
            this.tabConsultaViagem.Location = new System.Drawing.Point(4, 38);
            this.tabConsultaViagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabConsultaViagem.Name = "tabConsultaViagem";
            this.tabConsultaViagem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabConsultaViagem.Size = new System.Drawing.Size(1316, 786);
            this.tabConsultaViagem.TabIndex = 0;
            this.tabConsultaViagem.Text = "Consulta";
            // 
            // btnFechaViagem
            // 
            this.btnFechaViagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFechaViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            this.btnFechaViagem.FlatAppearance.BorderSize = 0;
            this.btnFechaViagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnFechaViagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.btnFechaViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaViagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.btnFechaViagem.Image = global::SmartLog.WindowsForms.Properties.Resources.iconFechar;
            this.btnFechaViagem.Location = new System.Drawing.Point(911, 336);
            this.btnFechaViagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFechaViagem.Name = "btnFechaViagem";
            this.btnFechaViagem.Size = new System.Drawing.Size(185, 48);
            this.btnFechaViagem.TabIndex = 25;
            this.btnFechaViagem.Text = "Fechar";
            this.btnFechaViagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechaViagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipViagem.SetToolTip(this.btnFechaViagem, "Fechar tela de Viagens.");
            this.btnFechaViagem.UseVisualStyleBackColor = false;
            this.btnFechaViagem.Click += new System.EventHandler(this.btnFechaViagem_Click);
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
            this.btnGridExcluir.Location = new System.Drawing.Point(679, 336);
            this.btnGridExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGridExcluir.Name = "btnGridExcluir";
            this.btnGridExcluir.Size = new System.Drawing.Size(185, 48);
            this.btnGridExcluir.TabIndex = 24;
            this.btnGridExcluir.Text = "Excluir";
            this.btnGridExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGridExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipViagem.SetToolTip(this.btnGridExcluir, "Clique aqui, para excluir uma Viagem.");
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
            this.btnGridAlterar.Location = new System.Drawing.Point(449, 336);
            this.btnGridAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGridAlterar.Name = "btnGridAlterar";
            this.btnGridAlterar.Size = new System.Drawing.Size(185, 48);
            this.btnGridAlterar.TabIndex = 23;
            this.btnGridAlterar.Text = "Alterar";
            this.btnGridAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGridAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipViagem.SetToolTip(this.btnGridAlterar, "Clique aqui se desejar alterar alguma Viagem.");
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
            this.btnNovo.Location = new System.Drawing.Point(221, 336);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(185, 48);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipViagem.SetToolTip(this.btnNovo, "Incluir nova Viagem");
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // dgViagem
            // 
            this.dgViagem.AllowUserToAddRows = false;
            this.dgViagem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.dgViagem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgViagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgViagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgViagem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgViagem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.dgViagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgViagem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgViagem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgViagem.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgViagem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgViagem.EnableHeadersVisualStyles = false;
            this.dgViagem.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgViagem.Location = new System.Drawing.Point(85, 409);
            this.dgViagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgViagem.Name = "dgViagem";
            this.dgViagem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViagem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgViagem.RowHeadersWidth = 51;
            this.dgViagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViagem.Size = new System.Drawing.Size(1145, 361);
            this.dgViagem.TabIndex = 10;
            this.toolTipViagem.SetToolTip(this.dgViagem, "Vizualização de registros.");
            this.dgViagem.DataSourceChanged += new System.EventHandler(this.dgViagem_DataSourceChanged);
            // 
            // gbFiltraViagem
            // 
            this.gbFiltraViagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltraViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.gbFiltraViagem.Controls.Add(this.chkData);
            this.gbFiltraViagem.Controls.Add(this.btnPesquisarViagem);
            this.gbFiltraViagem.Controls.Add(this.dtDataFim);
            this.gbFiltraViagem.Controls.Add(this.dtDataInicio);
            this.gbFiltraViagem.Controls.Add(this.cbClientePesquisa);
            this.gbFiltraViagem.Controls.Add(this.lblIntervaloData);
            this.gbFiltraViagem.Controls.Add(this.lblMotoristaPesquisar);
            this.gbFiltraViagem.Controls.Add(this.cbMotoristaPesquisar);
            this.gbFiltraViagem.Controls.Add(this.lblMotoCliPesquisar);
            this.gbFiltraViagem.Location = new System.Drawing.Point(85, 49);
            this.gbFiltraViagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFiltraViagem.Name = "gbFiltraViagem";
            this.gbFiltraViagem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFiltraViagem.Size = new System.Drawing.Size(1145, 261);
            this.gbFiltraViagem.TabIndex = 21;
            this.gbFiltraViagem.TabStop = false;
            this.gbFiltraViagem.Text = "Filtrar viagem";
            // 
            // chkData
            // 
            this.chkData.AutoSize = true;
            this.chkData.Location = new System.Drawing.Point(185, 114);
            this.chkData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(113, 29);
            this.chkData.TabIndex = 19;
            this.chkData.Text = "Por data:";
            this.toolTipViagem.SetToolTip(this.chkData, "Marque esta opção para Filtrar Viagens por um intervalo de período.");
            this.chkData.UseVisualStyleBackColor = true;
            this.chkData.CheckedChanged += new System.EventHandler(this.chkData_CheckedChanged);
            // 
            // btnPesquisarViagem
            // 
            this.btnPesquisarViagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesquisarViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            this.btnPesquisarViagem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnPesquisarViagem.FlatAppearance.BorderSize = 0;
            this.btnPesquisarViagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnPesquisarViagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.btnPesquisarViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarViagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.btnPesquisarViagem.Image = global::SmartLog.WindowsForms.Properties.Resources.icoSearch_fw;
            this.btnPesquisarViagem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarViagem.Location = new System.Drawing.Point(496, 206);
            this.btnPesquisarViagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisarViagem.Name = "btnPesquisarViagem";
            this.btnPesquisarViagem.Size = new System.Drawing.Size(265, 48);
            this.btnPesquisarViagem.TabIndex = 5;
            this.btnPesquisarViagem.Text = "Pesquisar";
            this.btnPesquisarViagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipViagem.SetToolTip(this.btnPesquisarViagem, "Busca todos registros de viagens cadastradas no sistema, de acordo com sua opção " +
        "de filtro.");
            this.btnPesquisarViagem.UseVisualStyleBackColor = false;
            this.btnPesquisarViagem.Click += new System.EventHandler(this.btnPesquisarViagem_Click);
            // 
            // dtDataFim
            // 
            this.dtDataFim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFim.Location = new System.Drawing.Point(408, 145);
            this.dtDataFim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDataFim.Name = "dtDataFim";
            this.dtDataFim.Size = new System.Drawing.Size(184, 30);
            this.dtDataFim.TabIndex = 4;
            // 
            // dtDataInicio
            // 
            this.dtDataInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicio.Location = new System.Drawing.Point(185, 145);
            this.dtDataInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDataInicio.Name = "dtDataInicio";
            this.dtDataInicio.Size = new System.Drawing.Size(184, 30);
            this.dtDataInicio.TabIndex = 3;
            // 
            // lblIntervaloData
            // 
            this.lblIntervaloData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIntervaloData.AutoSize = true;
            this.lblIntervaloData.BackColor = System.Drawing.Color.Transparent;
            this.lblIntervaloData.Location = new System.Drawing.Point(376, 151);
            this.lblIntervaloData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntervaloData.Name = "lblIntervaloData";
            this.lblIntervaloData.Size = new System.Drawing.Size(23, 25);
            this.lblIntervaloData.TabIndex = 18;
            this.lblIntervaloData.Text = "à";
            // 
            // lblMotoristaPesquisar
            // 
            this.lblMotoristaPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMotoristaPesquisar.AutoSize = true;
            this.lblMotoristaPesquisar.Location = new System.Drawing.Point(180, 37);
            this.lblMotoristaPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotoristaPesquisar.Name = "lblMotoristaPesquisar";
            this.lblMotoristaPesquisar.Size = new System.Drawing.Size(92, 25);
            this.lblMotoristaPesquisar.TabIndex = 12;
            this.lblMotoristaPesquisar.Text = "Motorista";
            // 
            // lblMotoCliPesquisar
            // 
            this.lblMotoCliPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMotoCliPesquisar.AutoSize = true;
            this.lblMotoCliPesquisar.Location = new System.Drawing.Point(628, 32);
            this.lblMotoCliPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotoCliPesquisar.Name = "lblMotoCliPesquisar";
            this.lblMotoCliPesquisar.Size = new System.Drawing.Size(73, 25);
            this.lblMotoCliPesquisar.TabIndex = 14;
            this.lblMotoCliPesquisar.Text = "Cliente";
            // 
            // tabCadastroViagem
            // 
            this.tabCadastroViagem.AutoScroll = true;
            this.tabCadastroViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
            this.tabCadastroViagem.Controls.Add(this.pnDadosViagem);
            this.tabCadastroViagem.Controls.Add(this.btnLimpar);
            this.tabCadastroViagem.Controls.Add(this.btnVoltar);
            this.tabCadastroViagem.Controls.Add(this.btnSalvar);
            this.tabCadastroViagem.Controls.Add(this.lblCodCli);
            this.tabCadastroViagem.Controls.Add(this.txtCodigoCli);
            this.tabCadastroViagem.Location = new System.Drawing.Point(4, 38);
            this.tabCadastroViagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCadastroViagem.Name = "tabCadastroViagem";
            this.tabCadastroViagem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCadastroViagem.Size = new System.Drawing.Size(1316, 786);
            this.tabCadastroViagem.TabIndex = 1;
            this.tabCadastroViagem.Text = "Cadastro";
            // 
            // pnDadosViagem
            // 
            this.pnDadosViagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnDadosViagem.AutoScroll = true;
            this.pnDadosViagem.Controls.Add(this.gbDadosViagem1);
            this.pnDadosViagem.Controls.Add(this.gbDadosOrigemviagem);
            this.pnDadosViagem.Controls.Add(this.gbDadosDestinoViagem);
            this.pnDadosViagem.Location = new System.Drawing.Point(41, 25);
            this.pnDadosViagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnDadosViagem.Name = "pnDadosViagem";
            this.pnDadosViagem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnDadosViagem.Size = new System.Drawing.Size(1229, 644);
            this.pnDadosViagem.TabIndex = 101;
            this.toolTipViagem.SetToolTip(this.pnDadosViagem, "Role para baixo para visualizar o restante do formulario.");
            // 
            // gbDadosViagem1
            // 
            this.gbDadosViagem1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDadosViagem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.gbDadosViagem1.Controls.Add(this.btnCalcular);
            this.gbDadosViagem1.Controls.Add(this.lblStatus);
            this.gbDadosViagem1.Controls.Add(this.cbStatus);
            this.gbDadosViagem1.Controls.Add(this.cbAtendente);
            this.gbDadosViagem1.Controls.Add(this.cbVeiculo);
            this.gbDadosViagem1.Controls.Add(this.cbCliente);
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
            this.gbDadosViagem1.Location = new System.Drawing.Point(-23, 4);
            this.gbDadosViagem1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDadosViagem1.Name = "gbDadosViagem1";
            this.gbDadosViagem1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDadosViagem1.Size = new System.Drawing.Size(1204, 267);
            this.gbDadosViagem1.TabIndex = 97;
            this.gbDadosViagem1.TabStop = false;
            this.gbDadosViagem1.Text = "Dados da Viagem";
            this.toolTipViagem.SetToolTip(this.gbDadosViagem1, "Preencha aqui, os dados da Viagem.");
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(513, 39);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 25);
            this.lblStatus.TabIndex = 98;
            this.lblStatus.Text = "Status";
            // 
            // dtDataViagem
            // 
            this.dtDataViagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtDataViagem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataViagem.Location = new System.Drawing.Point(55, 68);
            this.dtDataViagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDataViagem.Name = "dtDataViagem";
            this.dtDataViagem.Size = new System.Drawing.Size(183, 30);
            this.dtDataViagem.TabIndex = 1;
            // 
            // lblDataViagem
            // 
            this.lblDataViagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataViagem.AutoSize = true;
            this.lblDataViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataViagem.Location = new System.Drawing.Point(49, 39);
            this.lblDataViagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataViagem.Name = "lblDataViagem";
            this.lblDataViagem.Size = new System.Drawing.Size(53, 25);
            this.lblDataViagem.TabIndex = 52;
            this.lblDataViagem.Text = "Data";
            // 
            // lblMotorista
            // 
            this.lblMotorista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMotorista.AutoSize = true;
            this.lblMotorista.Location = new System.Drawing.Point(51, 108);
            this.lblMotorista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotorista.Name = "lblMotorista";
            this.lblMotorista.Size = new System.Drawing.Size(92, 25);
            this.lblMotorista.TabIndex = 68;
            this.lblMotorista.Text = "Motorista";
            // 
            // lblDistancia
            // 
            this.lblDistancia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDistancia.Location = new System.Drawing.Point(892, 182);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(160, 25);
            this.lblDistancia.TabIndex = 90;
            this.lblDistancia.Text = "Distancia em KM";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(51, 182);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 25);
            this.lblCliente.TabIndex = 70;
            this.lblCliente.Text = "Cliente";
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValor.Location = new System.Drawing.Point(512, 182);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(58, 25);
            this.lblValor.TabIndex = 88;
            this.lblValor.Text = "Valor";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(513, 108);
            this.lblVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(77, 25);
            this.lblVeiculo.TabIndex = 84;
            this.lblVeiculo.Text = "Veiculo";
            // 
            // lblAtendente
            // 
            this.lblAtendente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAtendente.AutoSize = true;
            this.lblAtendente.Location = new System.Drawing.Point(892, 108);
            this.lblAtendente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtendente.Name = "lblAtendente";
            this.lblAtendente.Size = new System.Drawing.Size(102, 25);
            this.lblAtendente.TabIndex = 86;
            this.lblAtendente.Text = "Atendente";
            // 
            // gbDadosOrigemviagem
            // 
            this.gbDadosOrigemviagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDadosOrigemviagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.gbDadosOrigemviagem.Controls.Add(this.txtCompleOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.lblCompleOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.cbCidadeOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.txtCepOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.txtBairroOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.cbEstadoOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.lblCidadeOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.txtLograOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.txtNumeroOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.lblLograOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.lblNumOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.lblBairroOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.lblUfOrigem);
            this.gbDadosOrigemviagem.Controls.Add(this.lblCepOrigem);
            this.gbDadosOrigemviagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDadosOrigemviagem.Location = new System.Drawing.Point(-23, 278);
            this.gbDadosOrigemviagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDadosOrigemviagem.Name = "gbDadosOrigemviagem";
            this.gbDadosOrigemviagem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDadosOrigemviagem.Size = new System.Drawing.Size(1204, 210);
            this.gbDadosOrigemviagem.TabIndex = 69;
            this.gbDadosOrigemviagem.TabStop = false;
            this.gbDadosOrigemviagem.Text = "Origem da Viagem";
            this.toolTipViagem.SetToolTip(this.gbDadosOrigemviagem, "Preencha aqui o endereço de origem da viagem.");
            // 
            // lblCompleOrigem
            // 
            this.lblCompleOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompleOrigem.AutoSize = true;
            this.lblCompleOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCompleOrigem.Location = new System.Drawing.Point(780, 44);
            this.lblCompleOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompleOrigem.Name = "lblCompleOrigem";
            this.lblCompleOrigem.Size = new System.Drawing.Size(134, 25);
            this.lblCompleOrigem.TabIndex = 85;
            this.lblCompleOrigem.Text = "Complemento";
            // 
            // lblCidadeOrigem
            // 
            this.lblCidadeOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidadeOrigem.AutoSize = true;
            this.lblCidadeOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCidadeOrigem.Location = new System.Drawing.Point(300, 119);
            this.lblCidadeOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidadeOrigem.Name = "lblCidadeOrigem";
            this.lblCidadeOrigem.Size = new System.Drawing.Size(75, 25);
            this.lblCidadeOrigem.TabIndex = 73;
            this.lblCidadeOrigem.Text = "Cidade";
            // 
            // lblLograOrigem
            // 
            this.lblLograOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLograOrigem.AutoSize = true;
            this.lblLograOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLograOrigem.Location = new System.Drawing.Point(300, 44);
            this.lblLograOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLograOrigem.Name = "lblLograOrigem";
            this.lblLograOrigem.Size = new System.Drawing.Size(112, 25);
            this.lblLograOrigem.TabIndex = 74;
            this.lblLograOrigem.Text = "Logradouro";
            // 
            // lblNumOrigem
            // 
            this.lblNumOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumOrigem.AutoSize = true;
            this.lblNumOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumOrigem.Location = new System.Drawing.Point(639, 44);
            this.lblNumOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOrigem.Name = "lblNumOrigem";
            this.lblNumOrigem.Size = new System.Drawing.Size(33, 25);
            this.lblNumOrigem.TabIndex = 75;
            this.lblNumOrigem.Text = "Nº";
            // 
            // lblBairroOrigem
            // 
            this.lblBairroOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBairroOrigem.AutoSize = true;
            this.lblBairroOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBairroOrigem.Location = new System.Drawing.Point(780, 118);
            this.lblBairroOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairroOrigem.Name = "lblBairroOrigem";
            this.lblBairroOrigem.Size = new System.Drawing.Size(63, 25);
            this.lblBairroOrigem.TabIndex = 76;
            this.lblBairroOrigem.Text = "Bairro";
            // 
            // lblUfOrigem
            // 
            this.lblUfOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUfOrigem.AutoSize = true;
            this.lblUfOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUfOrigem.Location = new System.Drawing.Point(51, 119);
            this.lblUfOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUfOrigem.Name = "lblUfOrigem";
            this.lblUfOrigem.Size = new System.Drawing.Size(105, 25);
            this.lblUfOrigem.TabIndex = 72;
            this.lblUfOrigem.Text = "Estado/UF";
            // 
            // lblCepOrigem
            // 
            this.lblCepOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCepOrigem.AutoSize = true;
            this.lblCepOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCepOrigem.Location = new System.Drawing.Point(51, 41);
            this.lblCepOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCepOrigem.Name = "lblCepOrigem";
            this.lblCepOrigem.Size = new System.Drawing.Size(53, 25);
            this.lblCepOrigem.TabIndex = 77;
            this.lblCepOrigem.Text = "CEP";
            // 
            // gbDadosDestinoViagem
            // 
            this.gbDadosDestinoViagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDadosDestinoViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.gbDadosDestinoViagem.Controls.Add(this.txtCompleDestino);
            this.gbDadosDestinoViagem.Controls.Add(this.lblCompleDestino);
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
            this.gbDadosDestinoViagem.Location = new System.Drawing.Point(-23, 496);
            this.gbDadosDestinoViagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDadosDestinoViagem.Name = "gbDadosDestinoViagem";
            this.gbDadosDestinoViagem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDadosDestinoViagem.Size = new System.Drawing.Size(1204, 209);
            this.gbDadosDestinoViagem.TabIndex = 96;
            this.gbDadosDestinoViagem.TabStop = false;
            this.gbDadosDestinoViagem.Text = "Destino da Viagem";
            this.toolTipViagem.SetToolTip(this.gbDadosDestinoViagem, "Preencha aqui, o Endereço de Destino da Viagem.");
            // 
            // lblCompleDestino
            // 
            this.lblCompleDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompleDestino.AutoSize = true;
            this.lblCompleDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCompleDestino.Location = new System.Drawing.Point(780, 42);
            this.lblCompleDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompleDestino.Name = "lblCompleDestino";
            this.lblCompleDestino.Size = new System.Drawing.Size(134, 25);
            this.lblCompleDestino.TabIndex = 87;
            this.lblCompleDestino.Text = "Complemento";
            // 
            // lblUfDestino
            // 
            this.lblUfDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUfDestino.AutoSize = true;
            this.lblUfDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUfDestino.Location = new System.Drawing.Point(49, 122);
            this.lblUfDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUfDestino.Name = "lblUfDestino";
            this.lblUfDestino.Size = new System.Drawing.Size(105, 25);
            this.lblUfDestino.TabIndex = 72;
            this.lblUfDestino.Text = "Estado/UF";
            // 
            // lblCidadeDestino
            // 
            this.lblCidadeDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidadeDestino.AutoSize = true;
            this.lblCidadeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCidadeDestino.Location = new System.Drawing.Point(300, 124);
            this.lblCidadeDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidadeDestino.Name = "lblCidadeDestino";
            this.lblCidadeDestino.Size = new System.Drawing.Size(75, 25);
            this.lblCidadeDestino.TabIndex = 73;
            this.lblCidadeDestino.Text = "Cidade";
            // 
            // lblLograDestino
            // 
            this.lblLograDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLograDestino.AutoSize = true;
            this.lblLograDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLograDestino.Location = new System.Drawing.Point(301, 44);
            this.lblLograDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLograDestino.Name = "lblLograDestino";
            this.lblLograDestino.Size = new System.Drawing.Size(112, 25);
            this.lblLograDestino.TabIndex = 74;
            this.lblLograDestino.Text = "Logradouro";
            // 
            // lblNumDestino
            // 
            this.lblNumDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumDestino.AutoSize = true;
            this.lblNumDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumDestino.Location = new System.Drawing.Point(639, 44);
            this.lblNumDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDestino.Name = "lblNumDestino";
            this.lblNumDestino.Size = new System.Drawing.Size(33, 25);
            this.lblNumDestino.TabIndex = 75;
            this.lblNumDestino.Text = "Nº";
            // 
            // lblBairroDestino
            // 
            this.lblBairroDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBairroDestino.AutoSize = true;
            this.lblBairroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBairroDestino.Location = new System.Drawing.Point(780, 127);
            this.lblBairroDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairroDestino.Name = "lblBairroDestino";
            this.lblBairroDestino.Size = new System.Drawing.Size(63, 25);
            this.lblBairroDestino.TabIndex = 76;
            this.lblBairroDestino.Text = "Bairro";
            // 
            // lblCepDestino
            // 
            this.lblCepDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCepDestino.AutoSize = true;
            this.lblCepDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCepDestino.Location = new System.Drawing.Point(49, 42);
            this.lblCepDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCepDestino.Name = "lblCepDestino";
            this.lblCepDestino.Size = new System.Drawing.Size(53, 25);
            this.lblCepDestino.TabIndex = 77;
            this.lblCepDestino.Text = "CEP";
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
            this.btnLimpar.Location = new System.Drawing.Point(560, 704);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(185, 48);
            this.btnLimpar.TabIndex = 99;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipViagem.SetToolTip(this.btnLimpar, "Limpa todos os campos do formulário.");
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
            this.btnVoltar.Location = new System.Drawing.Point(776, 704);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(185, 48);
            this.btnVoltar.TabIndex = 100;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipViagem.SetToolTip(this.btnVoltar, "Redireciona para a tela anterior > Consulta de Viagens.");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
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
            this.btnSalvar.Location = new System.Drawing.Point(348, 704);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(185, 48);
            this.btnSalvar.TabIndex = 98;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipViagem.SetToolTip(this.btnSalvar, "Cadastra uma viagem.");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(-40, -39);
            this.lblCodCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(75, 25);
            this.lblCodCli.TabIndex = 37;
            this.lblCodCli.Text = "Código";
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.Enabled = false;
            this.txtCodigoCli.Location = new System.Drawing.Point(21, -48);
            this.txtCodigoCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.Size = new System.Drawing.Size(132, 30);
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
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1525, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Viagens";
            this.toolTipViagem.SetToolTip(this.button1, "Você está em tela de Viagens.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTipViagem
            // 
            this.toolTipViagem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.btnCalcular.Location = new System.Drawing.Point(758, 210);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 33);
            this.btnCalcular.TabIndex = 99;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipViagem.SetToolTip(this.btnCalcular, "Fechar tela de Viagens.");
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // cbClientePesquisa
            // 
            this.cbClientePesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbClientePesquisa.CampoObrigatorio = false;
            this.cbClientePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientePesquisa.FormattingEnabled = true;
            this.cbClientePesquisa.Location = new System.Drawing.Point(633, 65);
            this.cbClientePesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.cbClientePesquisa.MensagemCampoObrigatorio = null;
            this.cbClientePesquisa.Name = "cbClientePesquisa";
            this.cbClientePesquisa.Size = new System.Drawing.Size(409, 33);
            this.cbClientePesquisa.TabIndex = 2;
            this.toolTipViagem.SetToolTip(this.cbClientePesquisa, "Selecione um cliente, para filtrar todas Viagens solicitadas por este.");
            // 
            // cbMotoristaPesquisar
            // 
            this.cbMotoristaPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMotoristaPesquisar.CampoObrigatorio = false;
            this.cbMotoristaPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotoristaPesquisar.FormattingEnabled = true;
            this.cbMotoristaPesquisar.Location = new System.Drawing.Point(183, 65);
            this.cbMotoristaPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.cbMotoristaPesquisar.MensagemCampoObrigatorio = null;
            this.cbMotoristaPesquisar.Name = "cbMotoristaPesquisar";
            this.cbMotoristaPesquisar.Size = new System.Drawing.Size(409, 33);
            this.cbMotoristaPesquisar.TabIndex = 1;
            this.toolTipViagem.SetToolTip(this.cbMotoristaPesquisar, "Selecione um Motorista, se deseja filtrar todas Viagens realizadas por este.");
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbStatus.CampoObrigatorio = true;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(519, 68);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.MensagemCampoObrigatorio = "Informar o Status da Viagem";
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(275, 33);
            this.cbStatus.TabIndex = 97;
            // 
            // cbAtendente
            // 
            this.cbAtendente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAtendente.CampoObrigatorio = false;
            this.cbAtendente.Enabled = false;
            this.cbAtendente.FormattingEnabled = true;
            this.cbAtendente.Location = new System.Drawing.Point(896, 137);
            this.cbAtendente.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtendente.MensagemCampoObrigatorio = "Informar o Atendente";
            this.cbAtendente.Name = "cbAtendente";
            this.cbAtendente.Size = new System.Drawing.Size(273, 33);
            this.cbAtendente.TabIndex = 96;
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbVeiculo.CampoObrigatorio = true;
            this.cbVeiculo.CausesValidation = false;
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(519, 139);
            this.cbVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cbVeiculo.MensagemCampoObrigatorio = "Informar Veículo";
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(275, 33);
            this.cbVeiculo.TabIndex = 3;
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCliente.CampoObrigatorio = true;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(53, 210);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbCliente.MensagemCampoObrigatorio = "Informar Cliente";
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(351, 33);
            this.cbCliente.TabIndex = 4;
            // 
            // cbMotoristaViagem
            // 
            this.cbMotoristaViagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMotoristaViagem.CampoObrigatorio = true;
            this.cbMotoristaViagem.FormattingEnabled = true;
            this.cbMotoristaViagem.Location = new System.Drawing.Point(53, 137);
            this.cbMotoristaViagem.Margin = new System.Windows.Forms.Padding(4);
            this.cbMotoristaViagem.MensagemCampoObrigatorio = "Informar Motorista";
            this.cbMotoristaViagem.Name = "cbMotoristaViagem";
            this.cbMotoristaViagem.Size = new System.Drawing.Size(351, 33);
            this.cbMotoristaViagem.TabIndex = 2;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDistancia.CampoObrigatorio = true;
            this.txtDistancia.Enabled = false;
            this.txtDistancia.Location = new System.Drawing.Point(897, 213);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistancia.MensagemObrigatorio = "Informar Distancia ";
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(272, 30);
            this.txtDistancia.TabIndex = 6;
            this.txtDistancia.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValor.CampoObrigatorio = true;
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(519, 213);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MensagemObrigatorio = "Informar Valor";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(231, 30);
            this.txtValor.TabIndex = 5;
            this.txtValor.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.numerosDecimais;
            // 
            // txtCompleOrigem
            // 
            this.txtCompleOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCompleOrigem.CampoObrigatorio = false;
            this.txtCompleOrigem.Location = new System.Drawing.Point(785, 73);
            this.txtCompleOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompleOrigem.MensagemObrigatorio = "Informar Complemento de Origem";
            this.txtCompleOrigem.Name = "txtCompleOrigem";
            this.txtCompleOrigem.Size = new System.Drawing.Size(384, 30);
            this.txtCompleOrigem.TabIndex = 10;
            this.txtCompleOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
            // 
            // cbCidadeOrigem
            // 
            this.cbCidadeOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCidadeOrigem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCidadeOrigem.CampoObrigatorio = true;
            this.cbCidadeOrigem.FormattingEnabled = true;
            this.cbCidadeOrigem.Location = new System.Drawing.Point(305, 149);
            this.cbCidadeOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.cbCidadeOrigem.MensagemCampoObrigatorio = "Informar Cidade de Origem";
            this.cbCidadeOrigem.Name = "cbCidadeOrigem";
            this.cbCidadeOrigem.Size = new System.Drawing.Size(329, 33);
            this.cbCidadeOrigem.TabIndex = 12;
            // 
            // txtCepOrigem
            // 
            this.txtCepOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCepOrigem.CampoObrigatorio = true;
            this.txtCepOrigem.Location = new System.Drawing.Point(53, 70);
            this.txtCepOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtCepOrigem.MaxLength = 9;
            this.txtCepOrigem.MensagemObrigatorio = "Informar o Cep de Origem";
            this.txtCepOrigem.Name = "txtCepOrigem";
            this.txtCepOrigem.Size = new System.Drawing.Size(223, 30);
            this.txtCepOrigem.TabIndex = 7;
            this.txtCepOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
            // 
            // txtBairroOrigem
            // 
            this.txtBairroOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairroOrigem.CampoObrigatorio = true;
            this.txtBairroOrigem.Location = new System.Drawing.Point(785, 146);
            this.txtBairroOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairroOrigem.MensagemObrigatorio = "Informar Bairro de Origem";
            this.txtBairroOrigem.Name = "txtBairroOrigem";
            this.txtBairroOrigem.Size = new System.Drawing.Size(257, 30);
            this.txtBairroOrigem.TabIndex = 13;
            this.txtBairroOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
            // 
            // cbEstadoOrigem
            // 
            this.cbEstadoOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEstadoOrigem.CampoObrigatorio = true;
            this.cbEstadoOrigem.FormattingEnabled = true;
            this.cbEstadoOrigem.Location = new System.Drawing.Point(55, 146);
            this.cbEstadoOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstadoOrigem.MensagemCampoObrigatorio = "Informar Estado de Origem";
            this.cbEstadoOrigem.Name = "cbEstadoOrigem";
            this.cbEstadoOrigem.Size = new System.Drawing.Size(144, 33);
            this.cbEstadoOrigem.TabIndex = 11;
            this.cbEstadoOrigem.SelectedIndexChanged += new System.EventHandler(this.cbEstadoOrigem_SelectedIndexChanged);
            // 
            // txtLograOrigem
            // 
            this.txtLograOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLograOrigem.CampoObrigatorio = true;
            this.txtLograOrigem.Location = new System.Drawing.Point(305, 70);
            this.txtLograOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtLograOrigem.MensagemObrigatorio = "Informar Logradouro de Origem";
            this.txtLograOrigem.Name = "txtLograOrigem";
            this.txtLograOrigem.Size = new System.Drawing.Size(329, 30);
            this.txtLograOrigem.TabIndex = 8;
            this.txtLograOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
            // 
            // txtNumeroOrigem
            // 
            this.txtNumeroOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroOrigem.CampoObrigatorio = true;
            this.txtNumeroOrigem.Location = new System.Drawing.Point(644, 70);
            this.txtNumeroOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroOrigem.MensagemObrigatorio = "Informar Numero de Origem";
            this.txtNumeroOrigem.Name = "txtNumeroOrigem";
            this.txtNumeroOrigem.Size = new System.Drawing.Size(105, 30);
            this.txtNumeroOrigem.TabIndex = 9;
            this.txtNumeroOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
            // 
            // txtCompleDestino
            // 
            this.txtCompleDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCompleDestino.CampoObrigatorio = false;
            this.txtCompleDestino.Location = new System.Drawing.Point(785, 70);
            this.txtCompleDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompleDestino.MensagemObrigatorio = "nformar o Complemento de Destino";
            this.txtCompleDestino.Name = "txtCompleDestino";
            this.txtCompleDestino.Size = new System.Drawing.Size(384, 30);
            this.txtCompleDestino.TabIndex = 17;
            this.txtCompleDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
            // 
            // cbCidadeDestino
            // 
            this.cbCidadeDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCidadeDestino.CampoObrigatorio = true;
            this.cbCidadeDestino.FormattingEnabled = true;
            this.cbCidadeDestino.Location = new System.Drawing.Point(305, 153);
            this.cbCidadeDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbCidadeDestino.MensagemCampoObrigatorio = "nformar Cidade de Destino";
            this.cbCidadeDestino.Name = "cbCidadeDestino";
            this.cbCidadeDestino.Size = new System.Drawing.Size(329, 33);
            this.cbCidadeDestino.TabIndex = 19;
            // 
            // cbEstadoDestino
            // 
            this.cbEstadoDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEstadoDestino.CampoObrigatorio = true;
            this.cbEstadoDestino.FormattingEnabled = true;
            this.cbEstadoDestino.Location = new System.Drawing.Point(53, 150);
            this.cbEstadoDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstadoDestino.MensagemCampoObrigatorio = "nformar o UF de Destino";
            this.cbEstadoDestino.Name = "cbEstadoDestino";
            this.cbEstadoDestino.Size = new System.Drawing.Size(145, 33);
            this.cbEstadoDestino.TabIndex = 18;
            this.cbEstadoDestino.SelectedIndexChanged += new System.EventHandler(this.cbEstadoDestino_SelectedIndexChanged_1);
            // 
            // txtBairroDestino
            // 
            this.txtBairroDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairroDestino.CampoObrigatorio = true;
            this.txtBairroDestino.Location = new System.Drawing.Point(785, 155);
            this.txtBairroDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairroDestino.MensagemObrigatorio = "nformar o Bairro de Destino";
            this.txtBairroDestino.Name = "txtBairroDestino";
            this.txtBairroDestino.Size = new System.Drawing.Size(257, 30);
            this.txtBairroDestino.TabIndex = 21;
            this.txtBairroDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
            // 
            // txtLograDestino
            // 
            this.txtLograDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLograDestino.CampoObrigatorio = true;
            this.txtLograDestino.Location = new System.Drawing.Point(305, 73);
            this.txtLograDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtLograDestino.MensagemObrigatorio = "nformar Logradouro de Destino";
            this.txtLograDestino.Name = "txtLograDestino";
            this.txtLograDestino.Size = new System.Drawing.Size(329, 30);
            this.txtLograDestino.TabIndex = 15;
            this.txtLograDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
            // 
            // txtNumeroDestino
            // 
            this.txtNumeroDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroDestino.CampoObrigatorio = true;
            this.txtNumeroDestino.Location = new System.Drawing.Point(644, 73);
            this.txtNumeroDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroDestino.MensagemObrigatorio = "nformar o Nº de Destino";
            this.txtNumeroDestino.Name = "txtNumeroDestino";
            this.txtNumeroDestino.Size = new System.Drawing.Size(105, 30);
            this.txtNumeroDestino.TabIndex = 16;
            this.txtNumeroDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
            // 
            // txtCepDestino
            // 
            this.txtCepDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCepDestino.CampoObrigatorio = true;
            this.txtCepDestino.Location = new System.Drawing.Point(53, 73);
            this.txtCepDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtCepDestino.MaxLength = 8;
            this.txtCepDestino.MensagemObrigatorio = "Informar o Cep de Destino";
            this.txtCepDestino.Name = "txtCepDestino";
            this.txtCepDestino.Size = new System.Drawing.Size(223, 30);
            this.txtCepDestino.TabIndex = 14;
            this.txtCepDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
            // 
            // frmViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1525, 910);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabCtrlViagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmViagem";
            this.Text = "frmViagem";
            this.Load += new System.EventHandler(this.FrmViagem_Load);
            this.tabCtrlViagem.ResumeLayout(false);
            this.tabConsultaViagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViagem)).EndInit();
            this.gbFiltraViagem.ResumeLayout(false);
            this.gbFiltraViagem.PerformLayout();
            this.tabCadastroViagem.ResumeLayout(false);
            this.tabCadastroViagem.PerformLayout();
            this.pnDadosViagem.ResumeLayout(false);
            this.gbDadosViagem1.ResumeLayout(false);
            this.gbDadosViagem1.PerformLayout();
            this.gbDadosOrigemviagem.ResumeLayout(false);
            this.gbDadosOrigemviagem.PerformLayout();
            this.gbDadosDestinoViagem.ResumeLayout(false);
            this.gbDadosDestinoViagem.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtrlViagem;
		private System.Windows.Forms.TabPage tabConsultaViagem;
		private System.Windows.Forms.Button btnPesquisarViagem;
		private System.Windows.Forms.TabPage tabCadastroViagem;
		private System.Windows.Forms.Label lblDataViagem;
		private System.Windows.Forms.Label lblCodCli;
		private System.Windows.Forms.TextBox txtCodigoCli;
		private System.Windows.Forms.Label lblMotoCliPesquisar;
		private System.Windows.Forms.Label lblMotoristaPesquisar;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblMotorista;
		private UserControl.SuperTextbox txtDistancia;
		private System.Windows.Forms.Label lblDistancia;
		private UserControl.SuperTextbox txtValor;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblAtendente;
		private System.Windows.Forms.Label lblVeiculo;
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
		private UserControl.SuperTextbox txtCepOrigem;
		private System.Windows.Forms.Label lblIntervaloData;
		private System.Windows.Forms.DateTimePicker dtDataFim;
		private System.Windows.Forms.DateTimePicker dtDataInicio;
		private UserControl.SuperComboBox cbCidadeDestino;
		private UserControl.SuperComboBox cbEstadoDestino;
		private UserControl.SuperComboBox cbCidadeOrigem;
		private UserControl.SuperComboBox cbEstadoOrigem;
		private UserControl.SuperComboBox cbAtendente;
		private UserControl.SuperComboBox cbVeiculo;
		private UserControl.SuperComboBox cbCliente;
		private UserControl.SuperComboBox cbMotoristaViagem;
		private UserControl.SuperTextbox txtCompleDestino;
		private System.Windows.Forms.Label lblCompleDestino;
		private UserControl.SuperTextbox txtCompleOrigem;
		private System.Windows.Forms.Label lblCompleOrigem;
		private UserControl.SuperComboBox cbClientePesquisa;
		private UserControl.SuperComboBox cbMotoristaPesquisar;
		private System.Windows.Forms.Label lblStatus;
		private UserControl.SuperComboBox cbStatus;
		private System.Windows.Forms.DataGridView dgViagem;
		private System.Windows.Forms.CheckBox chkData;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnFechaViagem;
		private System.Windows.Forms.Button btnGridExcluir;
		private System.Windows.Forms.Button btnGridAlterar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel pnDadosViagem;
		private System.Windows.Forms.ToolTip toolTipViagem;
        private System.Windows.Forms.Button btnCalcular;
    }
}