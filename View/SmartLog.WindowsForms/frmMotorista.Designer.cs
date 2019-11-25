namespace SmartLog.WindowsForms
{
	partial class frmMotorista
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
			this.tabCtrlMotorista = new System.Windows.Forms.TabControl();
			this.tabConsultaMotorista = new System.Windows.Forms.TabPage();
			this.dgMotorista = new System.Windows.Forms.DataGridView();
			this.gbFiltrarMotorista = new System.Windows.Forms.GroupBox();
			this.chkVencimentoCnh = new System.Windows.Forms.CheckBox();
			this.btnPesquisarMotorista = new System.Windows.Forms.Button();
			this.dtCnhVencFinal = new System.Windows.Forms.DateTimePicker();
			this.dtCnhVencPesquisa = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMotoristaPesquisa = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblMotoristaPesquisa = new System.Windows.Forms.Label();
			this.btnFechaMotorista = new System.Windows.Forms.Button();
			this.btnGridExcluir = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnGridAlterar = new System.Windows.Forms.Button();
			this.tabCadastroMotorista = new System.Windows.Forms.TabPage();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.gbDadosMotorista = new System.Windows.Forms.GroupBox();
			this.cbCnhCategoria = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbCidade = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbEstado = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.cbStatus = new SmartLog.WindowsForms.UserControl.SuperComboBox();
			this.txtEmail = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblCnhCat = new System.Windows.Forms.Label();
			this.dtCnhVenc = new System.Windows.Forms.DateTimePicker();
			this.lblCnhVenc = new System.Windows.Forms.Label();
			this.txtCep = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNumero = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtBairro = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtLogra = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtTelMoto = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNomeMoto = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
			this.txtCnhNum = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblCep = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblCnhNum = new System.Windows.Forms.Label();
			this.lblDataNasc = new System.Windows.Forms.Label();
			this.lblTelMoto = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.tabCtrlMotorista.SuspendLayout();
			this.tabConsultaMotorista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgMotorista)).BeginInit();
			this.gbFiltrarMotorista.SuspendLayout();
			this.tabCadastroMotorista.SuspendLayout();
			this.gbDadosMotorista.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCtrlMotorista
			// 
			this.tabCtrlMotorista.Controls.Add(this.tabConsultaMotorista);
			this.tabCtrlMotorista.Controls.Add(this.tabCadastroMotorista);
			this.tabCtrlMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tabCtrlMotorista.Location = new System.Drawing.Point(62, 2);
			this.tabCtrlMotorista.Name = "tabCtrlMotorista";
			this.tabCtrlMotorista.SelectedIndex = 0;
			this.tabCtrlMotorista.Size = new System.Drawing.Size(853, 622);
			this.tabCtrlMotorista.TabIndex = 0;
			// 
			// tabConsultaMotorista
			// 
			this.tabConsultaMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabConsultaMotorista.Controls.Add(this.dgMotorista);
			this.tabConsultaMotorista.Controls.Add(this.gbFiltrarMotorista);
			this.tabConsultaMotorista.Controls.Add(this.btnFechaMotorista);
			this.tabConsultaMotorista.Controls.Add(this.btnGridExcluir);
			this.tabConsultaMotorista.Controls.Add(this.btnNovo);
			this.tabConsultaMotorista.Controls.Add(this.btnGridAlterar);
			this.tabConsultaMotorista.Location = new System.Drawing.Point(4, 29);
			this.tabConsultaMotorista.Name = "tabConsultaMotorista";
			this.tabConsultaMotorista.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaMotorista.Size = new System.Drawing.Size(845, 589);
			this.tabConsultaMotorista.TabIndex = 0;
			this.tabConsultaMotorista.Text = "Consulta";
			// 
			// dgMotorista
			// 
			this.dgMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMotorista.Location = new System.Drawing.Point(76, 316);
			this.dgMotorista.Name = "dgMotorista";
			this.dgMotorista.Size = new System.Drawing.Size(693, 250);
			this.dgMotorista.TabIndex = 26;
			this.dgMotorista.DataSourceChanged += new System.EventHandler(this.dgMotorista_DataSourceChanged);
			// 
			// gbFiltrarMotorista
			// 
			this.gbFiltrarMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.gbFiltrarMotorista.Controls.Add(this.chkVencimentoCnh);
			this.gbFiltrarMotorista.Controls.Add(this.btnPesquisarMotorista);
			this.gbFiltrarMotorista.Controls.Add(this.dtCnhVencFinal);
			this.gbFiltrarMotorista.Controls.Add(this.dtCnhVencPesquisa);
			this.gbFiltrarMotorista.Controls.Add(this.label1);
			this.gbFiltrarMotorista.Controls.Add(this.txtMotoristaPesquisa);
			this.gbFiltrarMotorista.Controls.Add(this.lblMotoristaPesquisa);
			this.gbFiltrarMotorista.Location = new System.Drawing.Point(76, 29);
			this.gbFiltrarMotorista.Name = "gbFiltrarMotorista";
			this.gbFiltrarMotorista.Size = new System.Drawing.Size(693, 192);
			this.gbFiltrarMotorista.TabIndex = 0;
			this.gbFiltrarMotorista.TabStop = false;
			this.gbFiltrarMotorista.Text = "Filtros";
			// 
			// chkVencimentoCnh
			// 
			this.chkVencimentoCnh.AutoSize = true;
			this.chkVencimentoCnh.Location = new System.Drawing.Point(297, 35);
			this.chkVencimentoCnh.Name = "chkVencimentoCnh";
			this.chkVencimentoCnh.Size = new System.Drawing.Size(222, 24);
			this.chkVencimentoCnh.TabIndex = 22;
			this.chkVencimentoCnh.Text = "Filtrar por Vencimento CNH";
			this.chkVencimentoCnh.UseVisualStyleBackColor = true;
			this.chkVencimentoCnh.CheckedChanged += new System.EventHandler(this.chkVencimentoCnh_CheckedChanged);
			// 
			// btnPesquisarMotorista
			// 
			this.btnPesquisarMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnPesquisarMotorista.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.btnPesquisarMotorista.FlatAppearance.BorderSize = 0;
			this.btnPesquisarMotorista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnPesquisarMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnPesquisarMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisarMotorista.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_search;
			this.btnPesquisarMotorista.Location = new System.Drawing.Point(246, 123);
			this.btnPesquisarMotorista.Name = "btnPesquisarMotorista";
			this.btnPesquisarMotorista.Size = new System.Drawing.Size(207, 39);
			this.btnPesquisarMotorista.TabIndex = 21;
			this.btnPesquisarMotorista.Text = "Pesquisar";
			this.btnPesquisarMotorista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPesquisarMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisarMotorista.UseVisualStyleBackColor = false;
			this.btnPesquisarMotorista.Click += new System.EventHandler(this.btnPesquisarMotorista_Click);
			// 
			// dtCnhVencFinal
			// 
			this.dtCnhVencFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCnhVencFinal.Location = new System.Drawing.Point(455, 65);
			this.dtCnhVencFinal.Name = "dtCnhVencFinal";
			this.dtCnhVencFinal.Size = new System.Drawing.Size(131, 26);
			this.dtCnhVencFinal.TabIndex = 5;
			// 
			// dtCnhVencPesquisa
			// 
			this.dtCnhVencPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCnhVencPesquisa.Location = new System.Drawing.Point(297, 65);
			this.dtCnhVencPesquisa.Name = "dtCnhVencPesquisa";
			this.dtCnhVencPesquisa.Size = new System.Drawing.Size(128, 26);
			this.dtCnhVencPesquisa.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(431, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "à";
			// 
			// txtMotoristaPesquisa
			// 
			this.txtMotoristaPesquisa.CampoObrigatorio = false;
			this.txtMotoristaPesquisa.Location = new System.Drawing.Point(33, 65);
			this.txtMotoristaPesquisa.MensagemObrigatorio = null;
			this.txtMotoristaPesquisa.Name = "txtMotoristaPesquisa";
			this.txtMotoristaPesquisa.Size = new System.Drawing.Size(233, 26);
			this.txtMotoristaPesquisa.TabIndex = 1;
			this.txtMotoristaPesquisa.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// lblMotoristaPesquisa
			// 
			this.lblMotoristaPesquisa.AutoSize = true;
			this.lblMotoristaPesquisa.Location = new System.Drawing.Point(29, 42);
			this.lblMotoristaPesquisa.Name = "lblMotoristaPesquisa";
			this.lblMotoristaPesquisa.Size = new System.Drawing.Size(75, 20);
			this.lblMotoristaPesquisa.TabIndex = 0;
			this.lblMotoristaPesquisa.Text = "Motorista";
			// 
			// btnFechaMotorista
			// 
			this.btnFechaMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnFechaMotorista.FlatAppearance.BorderSize = 0;
			this.btnFechaMotorista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnFechaMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFechaMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechaMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechaMotorista.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnFechaMotorista.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_FecharTab;
			this.btnFechaMotorista.Location = new System.Drawing.Point(616, 248);
			this.btnFechaMotorista.Name = "btnFechaMotorista";
			this.btnFechaMotorista.Size = new System.Drawing.Size(139, 39);
			this.btnFechaMotorista.TabIndex = 25;
			this.btnFechaMotorista.Text = "Fechar";
			this.btnFechaMotorista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechaMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechaMotorista.UseVisualStyleBackColor = false;
			this.btnFechaMotorista.Click += new System.EventHandler(this.btnFechaMotorista_Click);
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
			this.btnGridExcluir.Location = new System.Drawing.Point(442, 248);
			this.btnGridExcluir.Name = "btnGridExcluir";
			this.btnGridExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnGridExcluir.TabIndex = 24;
			this.btnGridExcluir.Text = "Excluir";
			this.btnGridExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGridExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGridExcluir.UseVisualStyleBackColor = false;
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
			this.btnNovo.Location = new System.Drawing.Point(99, 248);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(139, 39);
			this.btnNovo.TabIndex = 22;
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
			this.btnGridAlterar.Location = new System.Drawing.Point(270, 248);
			this.btnGridAlterar.Name = "btnGridAlterar";
			this.btnGridAlterar.Size = new System.Drawing.Size(139, 39);
			this.btnGridAlterar.TabIndex = 23;
			this.btnGridAlterar.Text = "Alterar";
			this.btnGridAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGridAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGridAlterar.UseVisualStyleBackColor = false;
			this.btnGridAlterar.Click += new System.EventHandler(this.btnGridAlterar_Click);
			// 
			// tabCadastroMotorista
			// 
			this.tabCadastroMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabCadastroMotorista.Controls.Add(this.btnLimpar);
			this.tabCadastroMotorista.Controls.Add(this.gbDadosMotorista);
			this.tabCadastroMotorista.Controls.Add(this.btnVoltar);
			this.tabCadastroMotorista.Controls.Add(this.btnSalvar);
			this.tabCadastroMotorista.Location = new System.Drawing.Point(4, 29);
			this.tabCadastroMotorista.Name = "tabCadastroMotorista";
			this.tabCadastroMotorista.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroMotorista.Size = new System.Drawing.Size(845, 589);
			this.tabCadastroMotorista.TabIndex = 1;
			this.tabCadastroMotorista.Text = "Cadastro";
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnLimpar.Location = new System.Drawing.Point(359, 435);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(139, 39);
			this.btnLimpar.TabIndex = 75;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// gbDadosMotorista
			// 
			this.gbDadosMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbDadosMotorista.Controls.Add(this.cbCnhCategoria);
			this.gbDadosMotorista.Controls.Add(this.cbCidade);
			this.gbDadosMotorista.Controls.Add(this.cbEstado);
			this.gbDadosMotorista.Controls.Add(this.cbStatus);
			this.gbDadosMotorista.Controls.Add(this.txtEmail);
			this.gbDadosMotorista.Controls.Add(this.lblEmail);
			this.gbDadosMotorista.Controls.Add(this.lblCnhCat);
			this.gbDadosMotorista.Controls.Add(this.dtCnhVenc);
			this.gbDadosMotorista.Controls.Add(this.lblCnhVenc);
			this.gbDadosMotorista.Controls.Add(this.txtCep);
			this.gbDadosMotorista.Controls.Add(this.txtNumero);
			this.gbDadosMotorista.Controls.Add(this.txtBairro);
			this.gbDadosMotorista.Controls.Add(this.txtLogra);
			this.gbDadosMotorista.Controls.Add(this.txtTelMoto);
			this.gbDadosMotorista.Controls.Add(this.txtNomeMoto);
			this.gbDadosMotorista.Controls.Add(this.dtDataNasc);
			this.gbDadosMotorista.Controls.Add(this.txtCnhNum);
			this.gbDadosMotorista.Controls.Add(this.lblCep);
			this.gbDadosMotorista.Controls.Add(this.lblBairro);
			this.gbDadosMotorista.Controls.Add(this.lblNumero);
			this.gbDadosMotorista.Controls.Add(this.lblLogradouro);
			this.gbDadosMotorista.Controls.Add(this.lblCidade);
			this.gbDadosMotorista.Controls.Add(this.lblEstado);
			this.gbDadosMotorista.Controls.Add(this.lblStatus);
			this.gbDadosMotorista.Controls.Add(this.lblCnhNum);
			this.gbDadosMotorista.Controls.Add(this.lblDataNasc);
			this.gbDadosMotorista.Controls.Add(this.lblTelMoto);
			this.gbDadosMotorista.Controls.Add(this.lblNome);
			this.gbDadosMotorista.Location = new System.Drawing.Point(15, 20);
			this.gbDadosMotorista.Name = "gbDadosMotorista";
			this.gbDadosMotorista.Size = new System.Drawing.Size(815, 409);
			this.gbDadosMotorista.TabIndex = 74;
			this.gbDadosMotorista.TabStop = false;
			this.gbDadosMotorista.Text = "Dados do Motorista";
			// 
			// cbCnhCategoria
			// 
			this.cbCnhCategoria.CampoObrigatorio = true;
			this.cbCnhCategoria.FormattingEnabled = true;
			this.cbCnhCategoria.Location = new System.Drawing.Point(376, 235);
			this.cbCnhCategoria.MensagemCampoObrigatorio = null;
			this.cbCnhCategoria.Name = "cbCnhCategoria";
			this.cbCnhCategoria.Size = new System.Drawing.Size(95, 28);
			this.cbCnhCategoria.TabIndex = 110;
			// 
			// cbCidade
			// 
			this.cbCidade.CampoObrigatorio = false;
			this.cbCidade.FormattingEnabled = true;
			this.cbCidade.Location = new System.Drawing.Point(565, 291);
			this.cbCidade.MensagemCampoObrigatorio = null;
			this.cbCidade.Name = "cbCidade";
			this.cbCidade.Size = new System.Drawing.Size(194, 28);
			this.cbCidade.TabIndex = 109;
			// 
			// cbEstado
			// 
			this.cbEstado.CampoObrigatorio = false;
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(376, 291);
			this.cbEstado.MensagemCampoObrigatorio = null;
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(79, 28);
			this.cbEstado.TabIndex = 108;
			// 
			// cbStatus
			// 
			this.cbStatus.CampoObrigatorio = true;
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Location = new System.Drawing.Point(99, 58);
			this.cbStatus.MensagemCampoObrigatorio = null;
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(137, 28);
			this.cbStatus.TabIndex = 107;
			// 
			// txtEmail
			// 
			this.txtEmail.CampoObrigatorio = false;
			this.txtEmail.Location = new System.Drawing.Point(564, 172);
			this.txtEmail.MensagemObrigatorio = null;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(194, 26);
			this.txtEmail.TabIndex = 106;
			this.txtEmail.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEmail.Location = new System.Drawing.Point(561, 149);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(48, 20);
			this.lblEmail.TabIndex = 105;
			this.lblEmail.Text = "Email";
			// 
			// lblCnhCat
			// 
			this.lblCnhCat.AutoSize = true;
			this.lblCnhCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCnhCat.Location = new System.Drawing.Point(372, 206);
			this.lblCnhCat.Name = "lblCnhCat";
			this.lblCnhCat.Size = new System.Drawing.Size(120, 20);
			this.lblCnhCat.TabIndex = 103;
			this.lblCnhCat.Text = "Categoria CNH ";
			// 
			// dtCnhVenc
			// 
			this.dtCnhVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCnhVenc.Location = new System.Drawing.Point(564, 229);
			this.dtCnhVenc.Name = "dtCnhVenc";
			this.dtCnhVenc.Size = new System.Drawing.Size(194, 26);
			this.dtCnhVenc.TabIndex = 102;
			// 
			// lblCnhVenc
			// 
			this.lblCnhVenc.AutoSize = true;
			this.lblCnhVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCnhVenc.Location = new System.Drawing.Point(560, 206);
			this.lblCnhVenc.Name = "lblCnhVenc";
			this.lblCnhVenc.Size = new System.Drawing.Size(132, 20);
			this.lblCnhVenc.TabIndex = 101;
			this.lblCnhVenc.Text = "Vencimento CNH";
			// 
			// txtCep
			// 
			this.txtCep.CampoObrigatorio = false;
			this.txtCep.Location = new System.Drawing.Point(98, 293);
			this.txtCep.MensagemObrigatorio = null;
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(168, 26);
			this.txtCep.TabIndex = 97;
			this.txtCep.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtNumero
			// 
			this.txtNumero.CampoObrigatorio = false;
			this.txtNumero.Location = new System.Drawing.Point(376, 361);
			this.txtNumero.MensagemObrigatorio = null;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(80, 26);
			this.txtNumero.TabIndex = 95;
			this.txtNumero.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtBairro
			// 
			this.txtBairro.CampoObrigatorio = false;
			this.txtBairro.Location = new System.Drawing.Point(564, 361);
			this.txtBairro.MensagemObrigatorio = null;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(194, 26);
			this.txtBairro.TabIndex = 96;
			this.txtBairro.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtLogra
			// 
			this.txtLogra.CampoObrigatorio = false;
			this.txtLogra.Location = new System.Drawing.Point(98, 361);
			this.txtLogra.MensagemObrigatorio = null;
			this.txtLogra.Name = "txtLogra";
			this.txtLogra.Size = new System.Drawing.Size(249, 26);
			this.txtLogra.TabIndex = 94;
			this.txtLogra.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtTelMoto
			// 
			this.txtTelMoto.CampoObrigatorio = false;
			this.txtTelMoto.Location = new System.Drawing.Point(376, 172);
			this.txtTelMoto.MensagemObrigatorio = null;
			this.txtTelMoto.Name = "txtTelMoto";
			this.txtTelMoto.Size = new System.Drawing.Size(167, 26);
			this.txtTelMoto.TabIndex = 93;
			this.txtTelMoto.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtNomeMoto
			// 
			this.txtNomeMoto.CampoObrigatorio = true;
			this.txtNomeMoto.Location = new System.Drawing.Point(99, 117);
			this.txtNomeMoto.MensagemObrigatorio = "Informar o nome";
			this.txtNomeMoto.Name = "txtNomeMoto";
			this.txtNomeMoto.Size = new System.Drawing.Size(459, 26);
			this.txtNomeMoto.TabIndex = 92;
			this.txtNomeMoto.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// dtDataNasc
			// 
			this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataNasc.Location = new System.Drawing.Point(99, 172);
			this.dtDataNasc.Name = "dtDataNasc";
			this.dtDataNasc.Size = new System.Drawing.Size(148, 26);
			this.dtDataNasc.TabIndex = 91;
			// 
			// txtCnhNum
			// 
			this.txtCnhNum.CampoObrigatorio = false;
			this.txtCnhNum.Location = new System.Drawing.Point(98, 231);
			this.txtCnhNum.MaxLength = 18;
			this.txtCnhNum.MensagemObrigatorio = null;
			this.txtCnhNum.Name = "txtCnhNum";
			this.txtCnhNum.Size = new System.Drawing.Size(190, 26);
			this.txtCnhNum.TabIndex = 90;
			this.txtCnhNum.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// lblCep
			// 
			this.lblCep.AutoSize = true;
			this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCep.Location = new System.Drawing.Point(95, 271);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(41, 20);
			this.lblCep.TabIndex = 89;
			this.lblCep.Text = "CEP";
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblBairro.Location = new System.Drawing.Point(561, 338);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(51, 20);
			this.lblBairro.TabIndex = 88;
			this.lblBairro.Text = "Bairro";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNumero.Location = new System.Drawing.Point(372, 338);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(26, 20);
			this.lblNumero.TabIndex = 87;
			this.lblNumero.Text = "Nº";
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblLogradouro.Location = new System.Drawing.Point(95, 338);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
			this.lblLogradouro.TabIndex = 86;
			this.lblLogradouro.Text = "Logradouro";
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCidade.Location = new System.Drawing.Point(561, 271);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(59, 20);
			this.lblCidade.TabIndex = 85;
			this.lblCidade.Text = "Cidade";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEstado.Location = new System.Drawing.Point(373, 271);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(86, 20);
			this.lblEstado.TabIndex = 84;
			this.lblEstado.Text = "Estado/UF";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblStatus.Location = new System.Drawing.Point(95, 34);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(56, 20);
			this.lblStatus.TabIndex = 83;
			this.lblStatus.Text = "Status";
			// 
			// lblCnhNum
			// 
			this.lblCnhNum.AutoSize = true;
			this.lblCnhNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCnhNum.Location = new System.Drawing.Point(94, 206);
			this.lblCnhNum.Name = "lblCnhNum";
			this.lblCnhNum.Size = new System.Drawing.Size(64, 20);
			this.lblCnhNum.TabIndex = 82;
			this.lblCnhNum.Text = "Nº CNH";
			// 
			// lblDataNasc
			// 
			this.lblDataNasc.AutoSize = true;
			this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDataNasc.Location = new System.Drawing.Point(95, 149);
			this.lblDataNasc.Name = "lblDataNasc";
			this.lblDataNasc.Size = new System.Drawing.Size(152, 20);
			this.lblDataNasc.TabIndex = 79;
			this.lblDataNasc.Text = "Data de nascimento";
			// 
			// lblTelMoto
			// 
			this.lblTelMoto.AutoSize = true;
			this.lblTelMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblTelMoto.Location = new System.Drawing.Point(373, 149);
			this.lblTelMoto.Name = "lblTelMoto";
			this.lblTelMoto.Size = new System.Drawing.Size(71, 20);
			this.lblTelMoto.TabIndex = 72;
			this.lblTelMoto.Text = "Telefone";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(94, 94);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(123, 20);
			this.lblNome.TabIndex = 69;
			this.lblNome.Text = "Nome Completo";
			// 
			// btnVoltar
			// 
			this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnVoltar.FlatAppearance.BorderSize = 0;
			this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_ReturnTab;
			this.btnVoltar.Location = new System.Drawing.Point(521, 435);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(139, 39);
			this.btnVoltar.TabIndex = 73;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
			this.btnSalvar.Location = new System.Drawing.Point(200, 435);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 71;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// frmMotorista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.ClientSize = new System.Drawing.Size(976, 645);
			this.Controls.Add(this.tabCtrlMotorista);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMotorista";
			this.Text = "frmMotorista";
			this.tabCtrlMotorista.ResumeLayout(false);
			this.tabConsultaMotorista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgMotorista)).EndInit();
			this.gbFiltrarMotorista.ResumeLayout(false);
			this.gbFiltrarMotorista.PerformLayout();
			this.tabCadastroMotorista.ResumeLayout(false);
			this.gbDadosMotorista.ResumeLayout(false);
			this.gbDadosMotorista.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtrlMotorista;
		private System.Windows.Forms.TabPage tabConsultaMotorista;
		private System.Windows.Forms.TabPage tabCadastroMotorista;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.GroupBox gbDadosMotorista;
		private UserControl.SuperTextbox txtEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblCnhCat;
		private System.Windows.Forms.DateTimePicker dtCnhVenc;
		private System.Windows.Forms.Label lblCnhVenc;
		private UserControl.SuperTextbox txtCep;
		private UserControl.SuperTextbox txtNumero;
		private UserControl.SuperTextbox txtBairro;
		private UserControl.SuperTextbox txtLogra;
		private UserControl.SuperTextbox txtTelMoto;
		private UserControl.SuperTextbox txtNomeMoto;
		private System.Windows.Forms.DateTimePicker dtDataNasc;
		private UserControl.SuperTextbox txtCnhNum;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblCnhNum;
		private System.Windows.Forms.Label lblDataNasc;
		private System.Windows.Forms.Label lblTelMoto;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.GroupBox gbFiltrarMotorista;
		private System.Windows.Forms.DateTimePicker dtCnhVencFinal;
		private System.Windows.Forms.DateTimePicker dtCnhVencPesquisa;
		private System.Windows.Forms.Label label1;
		private UserControl.SuperTextbox txtMotoristaPesquisa;
		private System.Windows.Forms.Label lblMotoristaPesquisa;
		private System.Windows.Forms.DataGridView dgMotorista;
		private System.Windows.Forms.Button btnPesquisarMotorista;
		private System.Windows.Forms.Button btnFechaMotorista;
		private System.Windows.Forms.Button btnGridExcluir;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnGridAlterar;
		private System.Windows.Forms.CheckBox chkVencimentoCnh;
		private UserControl.SuperComboBox cbCnhCategoria;
		private UserControl.SuperComboBox cbCidade;
		private UserControl.SuperComboBox cbEstado;
		private UserControl.SuperComboBox cbStatus;
	}
}