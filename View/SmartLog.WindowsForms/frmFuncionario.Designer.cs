﻿namespace SmartLog.WindowsForms
{
	partial class frmFuncionario
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
			this.tabctrlFuncionario = new System.Windows.Forms.TabControl();
			this.tabConsultaFuncionario = new System.Windows.Forms.TabPage();
			this.btnFechaFuncionario = new System.Windows.Forms.Button();
			this.dgFuncionario = new System.Windows.Forms.DataGridView();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.gbFiltroFunc = new System.Windows.Forms.GroupBox();
			this.lblNomePesquisa = new System.Windows.Forms.Label();
			this.btnPesquisarFunc = new System.Windows.Forms.Button();
			this.lblCpfPesquisa = new System.Windows.Forms.Label();
			this.txtCpfPesquisar = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNomePesquisar = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.btnNovo = new System.Windows.Forms.Button();
			this.tabCadastroFunc = new System.Windows.Forms.TabPage();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.gbDadosFunc = new System.Windows.Forms.GroupBox();
			this.cbCargo = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbCidade = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbEstado = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
			this.txtBairro = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNumero = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtLogra = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCep = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtTelFunc = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCpfFunc = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNomeFunc = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtEmail = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.label16 = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblCargoFunc = new System.Windows.Forms.Label();
			this.lblDataNascFunc = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblNomeFunc = new System.Windows.Forms.Label();
			this.btnVoltarFunc = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabctrlFuncionario.SuspendLayout();
			this.tabConsultaFuncionario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgFuncionario)).BeginInit();
			this.gbFiltroFunc.SuspendLayout();
			this.tabCadastroFunc.SuspendLayout();
			this.gbDadosFunc.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabctrlFuncionario
			// 
			this.tabctrlFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabctrlFuncionario.Controls.Add(this.tabConsultaFuncionario);
			this.tabctrlFuncionario.Controls.Add(this.tabCadastroFunc);
			this.tabctrlFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabctrlFuncionario.Location = new System.Drawing.Point(62, 40);
			this.tabctrlFuncionario.Name = "tabctrlFuncionario";
			this.tabctrlFuncionario.Padding = new System.Drawing.Point(50, 5);
			this.tabctrlFuncionario.SelectedIndex = 0;
			this.tabctrlFuncionario.Size = new System.Drawing.Size(990, 663);
			this.tabctrlFuncionario.TabIndex = 79;
			// 
			// tabConsultaFuncionario
			// 
			this.tabConsultaFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.tabConsultaFuncionario.Controls.Add(this.btnFechaFuncionario);
			this.tabConsultaFuncionario.Controls.Add(this.dgFuncionario);
			this.tabConsultaFuncionario.Controls.Add(this.btnExcluir);
			this.tabConsultaFuncionario.Controls.Add(this.btnAlterar);
			this.tabConsultaFuncionario.Controls.Add(this.gbFiltroFunc);
			this.tabConsultaFuncionario.Controls.Add(this.btnNovo);
			this.tabConsultaFuncionario.Location = new System.Drawing.Point(4, 33);
			this.tabConsultaFuncionario.Name = "tabConsultaFuncionario";
			this.tabConsultaFuncionario.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaFuncionario.Size = new System.Drawing.Size(982, 626);
			this.tabConsultaFuncionario.TabIndex = 0;
			this.tabConsultaFuncionario.Text = "Consulta";
			// 
			// btnFechaFuncionario
			// 
			this.btnFechaFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnFechaFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnFechaFuncionario.FlatAppearance.BorderSize = 0;
			this.btnFechaFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnFechaFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFechaFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechaFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnFechaFuncionario.Image = global::SmartLog.WindowsForms.Properties.Resources.iconFechar;
			this.btnFechaFuncionario.Location = new System.Drawing.Point(679, 215);
			this.btnFechaFuncionario.Name = "btnFechaFuncionario";
			this.btnFechaFuncionario.Size = new System.Drawing.Size(139, 39);
			this.btnFechaFuncionario.TabIndex = 83;
			this.btnFechaFuncionario.Text = "Fechar";
			this.btnFechaFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechaFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechaFuncionario.UseVisualStyleBackColor = false;
			this.btnFechaFuncionario.Click += new System.EventHandler(this.btnFechaFuncionario_Click);
			// 
			// dgFuncionario
			// 
			this.dgFuncionario.AllowUserToAddRows = false;
			this.dgFuncionario.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgFuncionario.ColumnHeadersHeight = 35;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgFuncionario.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgFuncionario.EnableHeadersVisualStyles = false;
			this.dgFuncionario.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgFuncionario.Location = new System.Drawing.Point(59, 302);
			this.dgFuncionario.Name = "dgFuncionario";
			this.dgFuncionario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Menu;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgFuncionario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgFuncionario.Size = new System.Drawing.Size(863, 293);
			this.dgFuncionario.TabIndex = 11;
			this.dgFuncionario.DataSourceChanged += new System.EventHandler(this.dgFuncionario_DataSourceChanged);
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
			this.btnExcluir.Location = new System.Drawing.Point(505, 215);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnExcluir.TabIndex = 82;
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
			this.btnAlterar.Location = new System.Drawing.Point(333, 215);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(139, 39);
			this.btnAlterar.TabIndex = 81;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// gbFiltroFunc
			// 
			this.gbFiltroFunc.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gbFiltroFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.gbFiltroFunc.Controls.Add(this.lblNomePesquisa);
			this.gbFiltroFunc.Controls.Add(this.btnPesquisarFunc);
			this.gbFiltroFunc.Controls.Add(this.txtNomePesquisar);
			this.gbFiltroFunc.Controls.Add(this.lblCpfPesquisa);
			this.gbFiltroFunc.Controls.Add(this.txtCpfPesquisar);
			this.gbFiltroFunc.Location = new System.Drawing.Point(59, 37);
			this.gbFiltroFunc.Name = "gbFiltroFunc";
			this.gbFiltroFunc.Size = new System.Drawing.Size(861, 143);
			this.gbFiltroFunc.TabIndex = 17;
			this.gbFiltroFunc.TabStop = false;
			this.gbFiltroFunc.Text = "Filtrar funcionário";
			// 
			// lblNomePesquisa
			// 
			this.lblNomePesquisa.AutoSize = true;
			this.lblNomePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNomePesquisa.Location = new System.Drawing.Point(81, 47);
			this.lblNomePesquisa.Name = "lblNomePesquisa";
			this.lblNomePesquisa.Size = new System.Drawing.Size(92, 20);
			this.lblNomePesquisa.TabIndex = 4;
			this.lblNomePesquisa.Text = "Funcionário";
			// 
			// btnPesquisarFunc
			// 
			this.btnPesquisarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnPesquisarFunc.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.btnPesquisarFunc.FlatAppearance.BorderSize = 0;
			this.btnPesquisarFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnPesquisarFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnPesquisarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisarFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnPesquisarFunc.Image = global::SmartLog.WindowsForms.Properties.Resources.icoSearch_fw;
			this.btnPesquisarFunc.Location = new System.Drawing.Point(594, 63);
			this.btnPesquisarFunc.Name = "btnPesquisarFunc";
			this.btnPesquisarFunc.Size = new System.Drawing.Size(199, 39);
			this.btnPesquisarFunc.TabIndex = 3;
			this.btnPesquisarFunc.Text = "Pesquisar";
			this.btnPesquisarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPesquisarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisarFunc.UseVisualStyleBackColor = false;
			this.btnPesquisarFunc.Click += new System.EventHandler(this.btnPesquisarFunc_Click);
			// 
			// lblCpfPesquisa
			// 
			this.lblCpfPesquisa.AutoSize = true;
			this.lblCpfPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCpfPesquisa.Location = new System.Drawing.Point(373, 47);
			this.lblCpfPesquisa.Name = "lblCpfPesquisa";
			this.lblCpfPesquisa.Size = new System.Drawing.Size(40, 20);
			this.lblCpfPesquisa.TabIndex = 5;
			this.lblCpfPesquisa.Text = "CPF";
			// 
			// txtCpfPesquisar
			// 
			this.txtCpfPesquisar.CampoObrigatorio = false;
			this.txtCpfPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCpfPesquisar.Location = new System.Drawing.Point(377, 70);
			this.txtCpfPesquisar.MaxLength = 18;
			this.txtCpfPesquisar.MensagemObrigatorio = null;
			this.txtCpfPesquisar.Name = "txtCpfPesquisar";
			this.txtCpfPesquisar.Size = new System.Drawing.Size(188, 24);
			this.txtCpfPesquisar.TabIndex = 2;
			this.txtCpfPesquisar.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
			// 
			// txtNomePesquisar
			// 
			this.txtNomePesquisar.CampoObrigatorio = false;
			this.txtNomePesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNomePesquisar.Location = new System.Drawing.Point(85, 70);
			this.txtNomePesquisar.MensagemObrigatorio = null;
			this.txtNomePesquisar.Name = "txtNomePesquisar";
			this.txtNomePesquisar.Size = new System.Drawing.Size(252, 24);
			this.txtNomePesquisar.TabIndex = 1;
			this.txtNomePesquisar.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
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
			this.btnNovo.Location = new System.Drawing.Point(162, 215);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(139, 39);
			this.btnNovo.TabIndex = 80;
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// tabCadastroFunc
			// 
			this.tabCadastroFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.tabCadastroFunc.Controls.Add(this.btnLimpar);
			this.tabCadastroFunc.Controls.Add(this.gbDadosFunc);
			this.tabCadastroFunc.Controls.Add(this.btnVoltarFunc);
			this.tabCadastroFunc.Controls.Add(this.btnSalvar);
			this.tabCadastroFunc.Location = new System.Drawing.Point(4, 33);
			this.tabCadastroFunc.Name = "tabCadastroFunc";
			this.tabCadastroFunc.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroFunc.Size = new System.Drawing.Size(982, 626);
			this.tabCadastroFunc.TabIndex = 1;
			this.tabCadastroFunc.Text = "Cadastro";
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
			this.btnLimpar.Location = new System.Drawing.Point(423, 463);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(139, 39);
			this.btnLimpar.TabIndex = 170;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// gbDadosFunc
			// 
			this.gbDadosFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.gbDadosFunc.Controls.Add(this.cbCargo);
			this.gbDadosFunc.Controls.Add(this.cbCidade);
			this.gbDadosFunc.Controls.Add(this.cbEstado);
			this.gbDadosFunc.Controls.Add(this.dtDataNasc);
			this.gbDadosFunc.Controls.Add(this.txtBairro);
			this.gbDadosFunc.Controls.Add(this.txtNumero);
			this.gbDadosFunc.Controls.Add(this.txtLogra);
			this.gbDadosFunc.Controls.Add(this.txtCep);
			this.gbDadosFunc.Controls.Add(this.txtTelFunc);
			this.gbDadosFunc.Controls.Add(this.txtCpfFunc);
			this.gbDadosFunc.Controls.Add(this.txtNomeFunc);
			this.gbDadosFunc.Controls.Add(this.txtEmail);
			this.gbDadosFunc.Controls.Add(this.label16);
			this.gbDadosFunc.Controls.Add(this.lblBairro);
			this.gbDadosFunc.Controls.Add(this.label13);
			this.gbDadosFunc.Controls.Add(this.lblNumero);
			this.gbDadosFunc.Controls.Add(this.lblCidade);
			this.gbDadosFunc.Controls.Add(this.label11);
			this.gbDadosFunc.Controls.Add(this.label9);
			this.gbDadosFunc.Controls.Add(this.lblCargoFunc);
			this.gbDadosFunc.Controls.Add(this.lblDataNascFunc);
			this.gbDadosFunc.Controls.Add(this.label7);
			this.gbDadosFunc.Controls.Add(this.label6);
			this.gbDadosFunc.Controls.Add(this.lblNomeFunc);
			this.gbDadosFunc.Location = new System.Drawing.Point(96, 66);
			this.gbDadosFunc.Name = "gbDadosFunc";
			this.gbDadosFunc.Size = new System.Drawing.Size(817, 359);
			this.gbDadosFunc.TabIndex = 85;
			this.gbDadosFunc.TabStop = false;
			this.gbDadosFunc.Text = "Dados do Funcionário";
			// 
			// cbCargo
			// 
			this.cbCargo.CampoObrigatorio = true;
			this.cbCargo.FormattingEnabled = true;
			this.cbCargo.Location = new System.Drawing.Point(59, 46);
			this.cbCargo.MensagemCampoObrigatorio = "Selecionar o cargo";
			this.cbCargo.Name = "cbCargo";
			this.cbCargo.Size = new System.Drawing.Size(158, 28);
			this.cbCargo.TabIndex = 1;
			this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
			// 
			// cbCidade
			// 
			this.cbCidade.CampoObrigatorio = true;
			this.cbCidade.FormattingEnabled = true;
			this.cbCidade.Location = new System.Drawing.Point(530, 250);
			this.cbCidade.MensagemCampoObrigatorio = "Selecionar a cidade";
			this.cbCidade.Name = "cbCidade";
			this.cbCidade.Size = new System.Drawing.Size(231, 28);
			this.cbCidade.TabIndex = 9;
			// 
			// cbEstado
			// 
			this.cbEstado.CampoObrigatorio = true;
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(356, 251);
			this.cbEstado.MensagemCampoObrigatorio = "Seleionar o estado";
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(125, 28);
			this.cbEstado.TabIndex = 8;
			this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.CbEstado_SelectedIndexChanged);
			// 
			// dtDataNasc
			// 
			this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataNasc.Location = new System.Drawing.Point(529, 131);
			this.dtDataNasc.Name = "dtDataNasc";
			this.dtDataNasc.Size = new System.Drawing.Size(200, 26);
			this.dtDataNasc.TabIndex = 3;
			// 
			// txtBairro
			// 
			this.txtBairro.CampoObrigatorio = false;
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtBairro.Location = new System.Drawing.Point(530, 311);
			this.txtBairro.MensagemObrigatorio = null;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(231, 24);
			this.txtBairro.TabIndex = 12;
			this.txtBairro.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtNumero
			// 
			this.txtNumero.CampoObrigatorio = false;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNumero.Location = new System.Drawing.Point(356, 311);
			this.txtNumero.MensagemObrigatorio = null;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(125, 24);
			this.txtNumero.TabIndex = 11;
			this.txtNumero.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtLogra
			// 
			this.txtLogra.CampoObrigatorio = false;
			this.txtLogra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtLogra.Location = new System.Drawing.Point(59, 311);
			this.txtLogra.MensagemObrigatorio = null;
			this.txtLogra.Name = "txtLogra";
			this.txtLogra.Size = new System.Drawing.Size(221, 24);
			this.txtLogra.TabIndex = 10;
			this.txtLogra.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtCep
			// 
			this.txtCep.CampoObrigatorio = false;
			this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCep.Location = new System.Drawing.Point(59, 254);
			this.txtCep.MensagemObrigatorio = null;
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(221, 24);
			this.txtCep.TabIndex = 7;
			this.txtCep.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtTelFunc
			// 
			this.txtTelFunc.CampoObrigatorio = false;
			this.txtTelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtTelFunc.Location = new System.Drawing.Point(357, 191);
			this.txtTelFunc.MensagemObrigatorio = null;
			this.txtTelFunc.Name = "txtTelFunc";
			this.txtTelFunc.Size = new System.Drawing.Size(124, 24);
			this.txtTelFunc.TabIndex = 5;
			this.txtTelFunc.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtCpfFunc
			// 
			this.txtCpfFunc.CampoObrigatorio = true;
			this.txtCpfFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCpfFunc.Location = new System.Drawing.Point(60, 191);
			this.txtCpfFunc.MensagemObrigatorio = "Informar CPF";
			this.txtCpfFunc.Name = "txtCpfFunc";
			this.txtCpfFunc.Size = new System.Drawing.Size(221, 24);
			this.txtCpfFunc.TabIndex = 4;
			this.txtCpfFunc.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
			// 
			// txtNomeFunc
			// 
			this.txtNomeFunc.CampoObrigatorio = true;
			this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNomeFunc.Location = new System.Drawing.Point(59, 130);
			this.txtNomeFunc.MensagemObrigatorio = "Informar o nome";
			this.txtNomeFunc.Name = "txtNomeFunc";
			this.txtNomeFunc.Size = new System.Drawing.Size(364, 24);
			this.txtNomeFunc.TabIndex = 2;
			this.txtNomeFunc.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtEmail
			// 
			this.txtEmail.CampoObrigatorio = true;
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtEmail.Location = new System.Drawing.Point(530, 190);
			this.txtEmail.MensagemObrigatorio = "Informar o Email";
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(230, 24);
			this.txtEmail.TabIndex = 6;
			this.txtEmail.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label16.Location = new System.Drawing.Point(55, 231);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 20);
			this.label16.TabIndex = 168;
			this.label16.Text = "CEP";
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblBairro.Location = new System.Drawing.Point(525, 290);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(51, 20);
			this.lblBairro.TabIndex = 167;
			this.lblBairro.Text = "Bairro";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label13.Location = new System.Drawing.Point(57, 288);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(91, 20);
			this.label13.TabIndex = 165;
			this.label13.Text = "Logradouro";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNumero.Location = new System.Drawing.Point(352, 291);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(26, 20);
			this.lblNumero.TabIndex = 166;
			this.lblNumero.Text = "Nº";
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCidade.Location = new System.Drawing.Point(525, 228);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(59, 20);
			this.lblCidade.TabIndex = 164;
			this.lblCidade.Text = "Cidade";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label11.Location = new System.Drawing.Point(352, 230);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(86, 20);
			this.label11.TabIndex = 163;
			this.label11.Text = "Estado/UF";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label9.Location = new System.Drawing.Point(57, 168);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 20);
			this.label9.TabIndex = 161;
			this.label9.Text = "CPF";
			// 
			// lblCargoFunc
			// 
			this.lblCargoFunc.AutoSize = true;
			this.lblCargoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCargoFunc.Location = new System.Drawing.Point(55, 22);
			this.lblCargoFunc.Name = "lblCargoFunc";
			this.lblCargoFunc.Size = new System.Drawing.Size(52, 20);
			this.lblCargoFunc.TabIndex = 162;
			this.lblCargoFunc.Text = "Cargo";
			// 
			// lblDataNascFunc
			// 
			this.lblDataNascFunc.AutoSize = true;
			this.lblDataNascFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDataNascFunc.Location = new System.Drawing.Point(526, 108);
			this.lblDataNascFunc.Name = "lblDataNascFunc";
			this.lblDataNascFunc.Size = new System.Drawing.Size(152, 20);
			this.lblDataNascFunc.TabIndex = 160;
			this.lblDataNascFunc.Text = "Data de nascimento";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label7.Location = new System.Drawing.Point(525, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 20);
			this.label7.TabIndex = 159;
			this.label7.Text = "E-mail";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label6.Location = new System.Drawing.Point(353, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 20);
			this.label6.TabIndex = 158;
			this.label6.Text = "Telefone";
			// 
			// lblNomeFunc
			// 
			this.lblNomeFunc.AutoSize = true;
			this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNomeFunc.Location = new System.Drawing.Point(55, 108);
			this.lblNomeFunc.Name = "lblNomeFunc";
			this.lblNomeFunc.Size = new System.Drawing.Size(123, 20);
			this.lblNomeFunc.TabIndex = 157;
			this.lblNomeFunc.Text = "Nome Completo";
			// 
			// btnVoltarFunc
			// 
			this.btnVoltarFunc.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnVoltarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnVoltarFunc.FlatAppearance.BorderSize = 0;
			this.btnVoltarFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnVoltarFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVoltarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltarFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnVoltarFunc.Image = global::SmartLog.WindowsForms.Properties.Resources.iconVoltar_fw;
			this.btnVoltarFunc.Location = new System.Drawing.Point(585, 463);
			this.btnVoltarFunc.Name = "btnVoltarFunc";
			this.btnVoltarFunc.Size = new System.Drawing.Size(139, 39);
			this.btnVoltarFunc.TabIndex = 171;
			this.btnVoltarFunc.Text = "Voltar";
			this.btnVoltarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltarFunc.UseVisualStyleBackColor = false;
			this.btnVoltarFunc.Click += new System.EventHandler(this.btnVoltarFunc_Click);
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
			this.btnSalvar.Location = new System.Drawing.Point(264, 463);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 169;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
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
			this.button1.Size = new System.Drawing.Size(1115, 34);
			this.button1.TabIndex = 80;
			this.button1.Text = "Funcionários";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// frmFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
			this.ClientSize = new System.Drawing.Size(1115, 682);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabctrlFuncionario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmFuncionario";
			this.Text = "Funcionario";
			this.Load += new System.EventHandler(this.FormFuncionario_Load);
			this.tabctrlFuncionario.ResumeLayout(false);
			this.tabConsultaFuncionario.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgFuncionario)).EndInit();
			this.gbFiltroFunc.ResumeLayout(false);
			this.gbFiltroFunc.PerformLayout();
			this.tabCadastroFunc.ResumeLayout(false);
			this.gbDadosFunc.ResumeLayout(false);
			this.gbDadosFunc.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabctrlFuncionario;
		private System.Windows.Forms.TabPage tabConsultaFuncionario;
		private System.Windows.Forms.TabPage tabCadastroFunc;
		private System.Windows.Forms.GroupBox gbFiltroFunc;
		private System.Windows.Forms.Label lblNomePesquisa;
		private System.Windows.Forms.Button btnPesquisarFunc;
		private System.Windows.Forms.Label lblCpfPesquisa;
		private UserControl.SuperTextbox txtCpfPesquisar;
		private UserControl.SuperTextbox txtNomePesquisar;
		private System.Windows.Forms.GroupBox gbDadosFunc;
		private UserControl.SuperTextbox txtBairro;
		private UserControl.SuperTextbox txtNumero;
		private UserControl.SuperTextbox txtLogra;
		private UserControl.SuperTextbox txtCep;
		private UserControl.SuperTextbox txtTelFunc;
		private UserControl.SuperTextbox txtCpfFunc;
		private UserControl.SuperTextbox txtNomeFunc;
		private UserControl.SuperTextbox txtEmail;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblCargoFunc;
		private System.Windows.Forms.Label lblDataNascFunc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblNomeFunc;
		private System.Windows.Forms.DateTimePicker dtDataNasc;
		private UserControl.SuperComboBox cbCidade;
		private UserControl.SuperComboBox cbEstado;
		private UserControl.SuperComboBox cbCargo;
		private System.Windows.Forms.DataGridView dgFuncionario;
		private System.Windows.Forms.Button btnFechaFuncionario;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnVoltarFunc;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button button1;
	}
}