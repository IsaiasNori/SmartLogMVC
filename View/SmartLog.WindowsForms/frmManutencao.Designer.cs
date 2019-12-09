namespace SmartLog.WindowsForms
{
	partial class frmManutencao
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
            this.tabCtrlManutencao = new System.Windows.Forms.TabControl();
            this.tabConsultaManu = new System.Windows.Forms.TabPage();
            this.btnFechaManu = new System.Windows.Forms.Button();
            this.btnGridExcluir = new System.Windows.Forms.Button();
            this.btnGridAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgManutencao = new System.Windows.Forms.DataGridView();
            this.gbFiltroManu = new System.Windows.Forms.GroupBox();
            this.btnPesquisarManu = new System.Windows.Forms.Button();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.chkFiltroPerido = new System.Windows.Forms.CheckBox();
            this.lblSaidaAte = new System.Windows.Forms.Label();
            this.lblSaidaDe = new System.Windows.Forms.Label();
            this.dtSaidaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtSaidaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblEntradaAte = new System.Windows.Forms.Label();
            this.lbEntradaDe = new System.Windows.Forms.Label();
            this.dtEntradaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtEntradaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDescServicoPesquisa = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.lblDescServico = new System.Windows.Forms.Label();
            this.tabCadastroManu = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbDadosManu = new System.Windows.Forms.GroupBox();
            this.comboStatus = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSaidaCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblSaida = new System.Windows.Forms.Label();
            this.dtDataEntradaCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntradaCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescServico = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.cbVeiculo = new SmartLog.WindowsForms.UserControl.SuperComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabCtrlManutencao.SuspendLayout();
            this.tabConsultaManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgManutencao)).BeginInit();
            this.gbFiltroManu.SuspendLayout();
            this.tabCadastroManu.SuspendLayout();
            this.gbDadosManu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlManutencao
            // 
            this.tabCtrlManutencao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlManutencao.Controls.Add(this.tabConsultaManu);
            this.tabCtrlManutencao.Controls.Add(this.tabCadastroManu);
            this.tabCtrlManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlManutencao.Location = new System.Drawing.Point(87, 49);
            this.tabCtrlManutencao.Margin = new System.Windows.Forms.Padding(4);
            this.tabCtrlManutencao.Name = "tabCtrlManutencao";
            this.tabCtrlManutencao.Padding = new System.Drawing.Point(50, 5);
            this.tabCtrlManutencao.SelectedIndex = 0;
            this.tabCtrlManutencao.Size = new System.Drawing.Size(1111, 782);
            this.tabCtrlManutencao.TabIndex = 0;
            // 
            // tabConsultaManu
            // 
            this.tabConsultaManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
            this.tabConsultaManu.Controls.Add(this.btnFechaManu);
            this.tabConsultaManu.Controls.Add(this.btnGridExcluir);
            this.tabConsultaManu.Controls.Add(this.btnGridAlterar);
            this.tabConsultaManu.Controls.Add(this.btnNovo);
            this.tabConsultaManu.Controls.Add(this.dgManutencao);
            this.tabConsultaManu.Controls.Add(this.gbFiltroManu);
            this.tabConsultaManu.Location = new System.Drawing.Point(4, 38);
            this.tabConsultaManu.Margin = new System.Windows.Forms.Padding(4);
            this.tabConsultaManu.Name = "tabConsultaManu";
            this.tabConsultaManu.Padding = new System.Windows.Forms.Padding(4);
            this.tabConsultaManu.Size = new System.Drawing.Size(1103, 740);
            this.tabConsultaManu.TabIndex = 0;
            this.tabConsultaManu.Text = "Consulta";
            // 
            // btnFechaManu
            // 
            this.btnFechaManu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFechaManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            this.btnFechaManu.FlatAppearance.BorderSize = 0;
            this.btnFechaManu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnFechaManu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.btnFechaManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaManu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.btnFechaManu.Image = global::SmartLog.WindowsForms.Properties.Resources.iconFechar;
            this.btnFechaManu.Location = new System.Drawing.Point(829, 346);
            this.btnFechaManu.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechaManu.Name = "btnFechaManu";
            this.btnFechaManu.Size = new System.Drawing.Size(185, 48);
            this.btnFechaManu.TabIndex = 11;
            this.btnFechaManu.Text = "Fechar";
            this.btnFechaManu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechaManu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechaManu.UseVisualStyleBackColor = false;
            this.btnFechaManu.Click += new System.EventHandler(this.btnFechaCliente_Click);
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
            this.btnGridExcluir.Location = new System.Drawing.Point(617, 346);
            this.btnGridExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnGridExcluir.Name = "btnGridExcluir";
            this.btnGridExcluir.Size = new System.Drawing.Size(185, 48);
            this.btnGridExcluir.TabIndex = 10;
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
            this.btnGridAlterar.Location = new System.Drawing.Point(399, 346);
            this.btnGridAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGridAlterar.Name = "btnGridAlterar";
            this.btnGridAlterar.Size = new System.Drawing.Size(185, 48);
            this.btnGridAlterar.TabIndex = 9;
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
            this.btnNovo.Location = new System.Drawing.Point(92, 346);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(269, 48);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Nova Manutenção";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgManutencao
            // 
            this.dgManutencao.AllowUserToAddRows = false;
            this.dgManutencao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.dgManutencao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgManutencao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgManutencao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgManutencao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgManutencao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.dgManutencao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgManutencao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgManutencao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgManutencao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgManutencao.ColumnHeadersHeight = 35;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgManutencao.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgManutencao.EnableHeadersVisualStyles = false;
            this.dgManutencao.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgManutencao.Location = new System.Drawing.Point(92, 430);
            this.dgManutencao.Margin = new System.Windows.Forms.Padding(4);
            this.dgManutencao.Name = "dgManutencao";
            this.dgManutencao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgManutencao.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgManutencao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgManutencao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgManutencao.Size = new System.Drawing.Size(923, 281);
            this.dgManutencao.TabIndex = 2;
            this.dgManutencao.DataSourceChanged += new System.EventHandler(this.dgManutencao_DataSourceChanged);
            // 
            // gbFiltroManu
            // 
            this.gbFiltroManu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbFiltroManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.gbFiltroManu.Controls.Add(this.btnPesquisarManu);
            this.gbFiltroManu.Controls.Add(this.lblDataSaida);
            this.gbFiltroManu.Controls.Add(this.lblDataEntrada);
            this.gbFiltroManu.Controls.Add(this.chkFiltroPerido);
            this.gbFiltroManu.Controls.Add(this.lblSaidaAte);
            this.gbFiltroManu.Controls.Add(this.lblSaidaDe);
            this.gbFiltroManu.Controls.Add(this.dtSaidaFinal);
            this.gbFiltroManu.Controls.Add(this.dtSaidaInicio);
            this.gbFiltroManu.Controls.Add(this.lblEntradaAte);
            this.gbFiltroManu.Controls.Add(this.lbEntradaDe);
            this.gbFiltroManu.Controls.Add(this.dtEntradaFinal);
            this.gbFiltroManu.Controls.Add(this.dtEntradaInicio);
            this.gbFiltroManu.Controls.Add(this.txtDescServicoPesquisa);
            this.gbFiltroManu.Controls.Add(this.lblDescServico);
            this.gbFiltroManu.Location = new System.Drawing.Point(92, 7);
            this.gbFiltroManu.Margin = new System.Windows.Forms.Padding(4);
            this.gbFiltroManu.Name = "gbFiltroManu";
            this.gbFiltroManu.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiltroManu.Size = new System.Drawing.Size(923, 306);
            this.gbFiltroManu.TabIndex = 0;
            this.gbFiltroManu.TabStop = false;
            this.gbFiltroManu.Text = "Filtrar manutenções";
            // 
            // btnPesquisarManu
            // 
            this.btnPesquisarManu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesquisarManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            this.btnPesquisarManu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnPesquisarManu.FlatAppearance.BorderSize = 0;
            this.btnPesquisarManu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.btnPesquisarManu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
            this.btnPesquisarManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarManu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.btnPesquisarManu.Image = global::SmartLog.WindowsForms.Properties.Resources.icoSearch_fw;
            this.btnPesquisarManu.Location = new System.Drawing.Point(603, 63);
            this.btnPesquisarManu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarManu.Name = "btnPesquisarManu";
            this.btnPesquisarManu.Size = new System.Drawing.Size(236, 48);
            this.btnPesquisarManu.TabIndex = 13;
            this.btnPesquisarManu.Text = "Pesquisar";
            this.btnPesquisarManu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarManu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarManu.UseVisualStyleBackColor = false;
            this.btnPesquisarManu.Click += new System.EventHandler(this.btnPesquisarManu_Click);
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.BackColor = System.Drawing.Color.Transparent;
            this.lblDataSaida.Location = new System.Drawing.Point(36, 238);
            this.lblDataSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(177, 25);
            this.lblDataSaida.TabIndex = 12;
            this.lblDataSaida.Text = "Por Data de Saída:";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEntrada.Location = new System.Drawing.Point(36, 149);
            this.lblDataEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(194, 25);
            this.lblDataEntrada.TabIndex = 11;
            this.lblDataEntrada.Text = "Por Data de Entrada:";
            // 
            // chkFiltroPerido
            // 
            this.chkFiltroPerido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkFiltroPerido.AutoSize = true;
            this.chkFiltroPerido.BackColor = System.Drawing.Color.White;
            this.chkFiltroPerido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkFiltroPerido.FlatAppearance.BorderSize = 5;
            this.chkFiltroPerido.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkFiltroPerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroPerido.ForeColor = System.Drawing.Color.Black;
            this.helpProvider1.SetHelpString(this.chkFiltroPerido, "Marque esta opção se deseja filtrar manutenções por data de entrada ou saída.");
            this.chkFiltroPerido.Location = new System.Drawing.Point(64, 112);
            this.chkFiltroPerido.Margin = new System.Windows.Forms.Padding(4);
            this.chkFiltroPerido.Name = "chkFiltroPerido";
            this.helpProvider1.SetShowHelp(this.chkFiltroPerido, true);
            this.chkFiltroPerido.Size = new System.Drawing.Size(206, 29);
            this.chkFiltroPerido.TabIndex = 10;
            this.chkFiltroPerido.Text = "Filtrar por Período";
            this.chkFiltroPerido.UseVisualStyleBackColor = false;
            this.chkFiltroPerido.CheckedChanged += new System.EventHandler(this.chkFiltroPerido_CheckedChanged);
            // 
            // lblSaidaAte
            // 
            this.lblSaidaAte.AutoSize = true;
            this.lblSaidaAte.BackColor = System.Drawing.Color.Transparent;
            this.lblSaidaAte.Location = new System.Drawing.Point(277, 272);
            this.lblSaidaAte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaidaAte.Name = "lblSaidaAte";
            this.lblSaidaAte.Size = new System.Drawing.Size(48, 25);
            this.lblSaidaAte.TabIndex = 9;
            this.lblSaidaAte.Text = "Até:";
            // 
            // lblSaidaDe
            // 
            this.lblSaidaDe.AutoSize = true;
            this.lblSaidaDe.BackColor = System.Drawing.Color.Transparent;
            this.lblSaidaDe.Location = new System.Drawing.Point(36, 273);
            this.lblSaidaDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaidaDe.Name = "lblSaidaDe";
            this.lblSaidaDe.Size = new System.Drawing.Size(43, 25);
            this.lblSaidaDe.TabIndex = 8;
            this.lblSaidaDe.Text = "De:";
            // 
            // dtSaidaFinal
            // 
            this.dtSaidaFinal.Enabled = false;
            this.dtSaidaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSaidaFinal.Location = new System.Drawing.Point(331, 266);
            this.dtSaidaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtSaidaFinal.Name = "dtSaidaFinal";
            this.dtSaidaFinal.Size = new System.Drawing.Size(173, 30);
            this.dtSaidaFinal.TabIndex = 7;
            // 
            // dtSaidaInicio
            // 
            this.dtSaidaInicio.Enabled = false;
            this.dtSaidaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSaidaInicio.Location = new System.Drawing.Point(89, 266);
            this.dtSaidaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtSaidaInicio.Name = "dtSaidaInicio";
            this.dtSaidaInicio.Size = new System.Drawing.Size(173, 30);
            this.dtSaidaInicio.TabIndex = 6;
            // 
            // lblEntradaAte
            // 
            this.lblEntradaAte.AutoSize = true;
            this.lblEntradaAte.BackColor = System.Drawing.Color.Transparent;
            this.lblEntradaAte.Location = new System.Drawing.Point(277, 182);
            this.lblEntradaAte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntradaAte.Name = "lblEntradaAte";
            this.lblEntradaAte.Size = new System.Drawing.Size(48, 25);
            this.lblEntradaAte.TabIndex = 5;
            this.lblEntradaAte.Text = "Até:";
            // 
            // lbEntradaDe
            // 
            this.lbEntradaDe.AutoSize = true;
            this.lbEntradaDe.BackColor = System.Drawing.Color.Transparent;
            this.lbEntradaDe.Location = new System.Drawing.Point(36, 183);
            this.lbEntradaDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEntradaDe.Name = "lbEntradaDe";
            this.lbEntradaDe.Size = new System.Drawing.Size(43, 25);
            this.lbEntradaDe.TabIndex = 4;
            this.lbEntradaDe.Text = "De:";
            // 
            // dtEntradaFinal
            // 
            this.dtEntradaFinal.Enabled = false;
            this.dtEntradaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntradaFinal.Location = new System.Drawing.Point(331, 176);
            this.dtEntradaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtEntradaFinal.Name = "dtEntradaFinal";
            this.dtEntradaFinal.Size = new System.Drawing.Size(173, 30);
            this.dtEntradaFinal.TabIndex = 3;
            // 
            // dtEntradaInicio
            // 
            this.dtEntradaInicio.Enabled = false;
            this.dtEntradaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntradaInicio.Location = new System.Drawing.Point(89, 177);
            this.dtEntradaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtEntradaInicio.Name = "dtEntradaInicio";
            this.dtEntradaInicio.Size = new System.Drawing.Size(173, 30);
            this.dtEntradaInicio.TabIndex = 2;
            // 
            // txtDescServicoPesquisa
            // 
            this.txtDescServicoPesquisa.CampoObrigatorio = false;
            this.txtDescServicoPesquisa.Location = new System.Drawing.Point(40, 70);
            this.txtDescServicoPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescServicoPesquisa.MensagemObrigatorio = null;
            this.txtDescServicoPesquisa.Name = "txtDescServicoPesquisa";
            this.txtDescServicoPesquisa.Size = new System.Drawing.Size(529, 30);
            this.txtDescServicoPesquisa.TabIndex = 1;
            this.txtDescServicoPesquisa.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
            // 
            // lblDescServico
            // 
            this.lblDescServico.AutoSize = true;
            this.lblDescServico.BackColor = System.Drawing.Color.Transparent;
            this.lblDescServico.Location = new System.Drawing.Point(35, 42);
            this.lblDescServico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescServico.Name = "lblDescServico";
            this.lblDescServico.Size = new System.Drawing.Size(193, 25);
            this.lblDescServico.TabIndex = 0;
            this.lblDescServico.Text = "Descrição do serviço";
            // 
            // tabCadastroManu
            // 
            this.tabCadastroManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
            this.tabCadastroManu.Controls.Add(this.btnLimpar);
            this.tabCadastroManu.Controls.Add(this.btnVoltar);
            this.tabCadastroManu.Controls.Add(this.btnSalvar);
            this.tabCadastroManu.Controls.Add(this.gbDadosManu);
            this.tabCadastroManu.Location = new System.Drawing.Point(4, 38);
            this.tabCadastroManu.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastroManu.Name = "tabCadastroManu";
            this.tabCadastroManu.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastroManu.Size = new System.Drawing.Size(1103, 740);
            this.tabCadastroManu.TabIndex = 1;
            this.tabCadastroManu.Text = "Cadastro";
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
            this.btnLimpar.Location = new System.Drawing.Point(447, 474);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(185, 48);
            this.btnLimpar.TabIndex = 43;
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
            this.btnVoltar.Location = new System.Drawing.Point(640, 474);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(185, 48);
            this.btnVoltar.TabIndex = 44;
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
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.btnSalvar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Salvar_png;
            this.btnSalvar.Location = new System.Drawing.Point(254, 474);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(185, 48);
            this.btnSalvar.TabIndex = 42;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbDadosManu
            // 
            this.gbDadosManu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.gbDadosManu.Controls.Add(this.comboStatus);
            this.gbDadosManu.Controls.Add(this.label2);
            this.gbDadosManu.Controls.Add(this.dtSaidaCadastro);
            this.gbDadosManu.Controls.Add(this.lblSaida);
            this.gbDadosManu.Controls.Add(this.dtDataEntradaCadastro);
            this.gbDadosManu.Controls.Add(this.lblDataEntradaCadastro);
            this.gbDadosManu.Controls.Add(this.label1);
            this.gbDadosManu.Controls.Add(this.txtDescServico);
            this.gbDadosManu.Controls.Add(this.lblVeiculo);
            this.gbDadosManu.Controls.Add(this.cbVeiculo);
            this.gbDadosManu.Location = new System.Drawing.Point(96, 44);
            this.gbDadosManu.Margin = new System.Windows.Forms.Padding(4);
            this.gbDadosManu.Name = "gbDadosManu";
            this.gbDadosManu.Padding = new System.Windows.Forms.Padding(4);
            this.gbDadosManu.Size = new System.Drawing.Size(905, 384);
            this.gbDadosManu.TabIndex = 0;
            this.gbDadosManu.TabStop = false;
            this.gbDadosManu.Text = "Dados da Manutenção";
            // 
            // comboStatus
            // 
            this.comboStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboStatus.CampoObrigatorio = true;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(557, 77);
            this.comboStatus.MensagemCampoObrigatorio = "Informar o Status";
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(194, 33);
            this.comboStatus.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // dtSaidaCadastro
            // 
            this.dtSaidaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtSaidaCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSaidaCadastro.Location = new System.Drawing.Point(351, 75);
            this.dtSaidaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.dtSaidaCadastro.Name = "dtSaidaCadastro";
            this.dtSaidaCadastro.Size = new System.Drawing.Size(168, 30);
            this.dtSaidaCadastro.TabIndex = 7;
            // 
            // lblSaida
            // 
            this.lblSaida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(346, 46);
            this.lblSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(177, 25);
            this.lblSaida.TabIndex = 6;
            this.lblSaida.Text = "Previsão de Saída:";
            // 
            // dtDataEntradaCadastro
            // 
            this.dtDataEntradaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtDataEntradaCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEntradaCadastro.Location = new System.Drawing.Point(65, 75);
            this.dtDataEntradaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataEntradaCadastro.Name = "dtDataEntradaCadastro";
            this.dtDataEntradaCadastro.Size = new System.Drawing.Size(168, 30);
            this.dtDataEntradaCadastro.TabIndex = 5;
            // 
            // lblDataEntradaCadastro
            // 
            this.lblDataEntradaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataEntradaCadastro.AutoSize = true;
            this.lblDataEntradaCadastro.Location = new System.Drawing.Point(60, 46);
            this.lblDataEntradaCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntradaCadastro.Name = "lblDataEntradaCadastro";
            this.lblDataEntradaCadastro.Size = new System.Drawing.Size(159, 25);
            this.lblDataEntradaCadastro.TabIndex = 4;
            this.lblDataEntradaCadastro.Text = "Data de Entrada:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(60, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição do serviço:";
            // 
            // txtDescServico
            // 
            this.txtDescServico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescServico.CampoObrigatorio = true;
            this.txtDescServico.Location = new System.Drawing.Point(65, 240);
            this.txtDescServico.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescServico.MensagemObrigatorio = "Informe o serviço realizado.";
            this.txtDescServico.Multiline = true;
            this.txtDescServico.Name = "txtDescServico";
            this.txtDescServico.Size = new System.Drawing.Size(757, 136);
            this.txtDescServico.TabIndex = 2;
            this.txtDescServico.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(60, 145);
            this.lblVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(83, 25);
            this.lblVeiculo.TabIndex = 1;
            this.lblVeiculo.Text = "Veículo:";
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbVeiculo.CampoObrigatorio = true;
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(65, 174);
            this.cbVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cbVeiculo.MensagemCampoObrigatorio = "Selecione um véiculo.";
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(293, 33);
            this.cbVeiculo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1253, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Manutenções";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1252, 846);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabCtrlManutencao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManutencao";
            this.Text = "frmManutencao";
            this.Load += new System.EventHandler(this.frmManutencao_Load);
            this.tabCtrlManutencao.ResumeLayout(false);
            this.tabConsultaManu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgManutencao)).EndInit();
            this.gbFiltroManu.ResumeLayout(false);
            this.gbFiltroManu.PerformLayout();
            this.tabCadastroManu.ResumeLayout(false);
            this.gbDadosManu.ResumeLayout(false);
            this.gbDadosManu.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtrlManutencao;
		private System.Windows.Forms.TabPage tabConsultaManu;
		private System.Windows.Forms.TabPage tabCadastroManu;
		private System.Windows.Forms.GroupBox gbFiltroManu;
		private System.Windows.Forms.Label lblDataSaida;
		private System.Windows.Forms.Label lblDataEntrada;
		private System.Windows.Forms.CheckBox chkFiltroPerido;
		private System.Windows.Forms.Label lblSaidaAte;
		private System.Windows.Forms.Label lblSaidaDe;
		private System.Windows.Forms.DateTimePicker dtSaidaFinal;
		private System.Windows.Forms.DateTimePicker dtSaidaInicio;
		private System.Windows.Forms.Label lblEntradaAte;
		private System.Windows.Forms.Label lbEntradaDe;
		private System.Windows.Forms.DateTimePicker dtEntradaFinal;
		private System.Windows.Forms.DateTimePicker dtEntradaInicio;
		private UserControl.SuperTextbox txtDescServicoPesquisa;
		private System.Windows.Forms.Label lblDescServico;
		private System.Windows.Forms.DataGridView dgManutencao;
		private System.Windows.Forms.Button btnFechaManu;
		private System.Windows.Forms.Button btnGridExcluir;
		private System.Windows.Forms.Button btnGridAlterar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnPesquisarManu;
		private System.Windows.Forms.GroupBox gbDadosManu;
		private System.Windows.Forms.DateTimePicker dtSaidaCadastro;
		private System.Windows.Forms.Label lblSaida;
		private System.Windows.Forms.DateTimePicker dtDataEntradaCadastro;
		private System.Windows.Forms.Label lblDataEntradaCadastro;
		private System.Windows.Forms.Label label1;
		private UserControl.SuperTextbox txtDescServico;
		private System.Windows.Forms.Label lblVeiculo;
		private UserControl.SuperComboBox cbVeiculo;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.HelpProvider helpProvider1;
        private UserControl.SuperComboBox comboStatus;
        private System.Windows.Forms.Label label2;
    }
}