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
			this.tabCtrlCliente = new System.Windows.Forms.TabControl();
			this.tabConsultaCli = new System.Windows.Forms.TabPage();
			this.btnFechaCliente = new System.Windows.Forms.Button();
			this.btnGridExcluir = new System.Windows.Forms.Button();
			this.btnGridAlterar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.gbFiltrarCliente = new System.Windows.Forms.GroupBox();
			this.pnlFiltrarCliente = new System.Windows.Forms.Panel();
			this.lblNomePesquisa = new System.Windows.Forms.Label();
			this.btnPesquisarCli = new System.Windows.Forms.Button();
			this.lblCpfPesquisa = new System.Windows.Forms.Label();
			this.dgCliente = new System.Windows.Forms.DataGridView();
			this.tabCadastroCli = new System.Windows.Forms.TabPage();
			this.gbDadosCliente = new System.Windows.Forms.GroupBox();
			this.lblCep = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.cbCidade = new System.Windows.Forms.ComboBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.cbTipoCli = new System.Windows.Forms.ComboBox();
			this.lblTipoCli = new System.Windows.Forms.Label();
			this.lblCpfCnpjCli = new System.Windows.Forms.Label();
			this.lblDataNasc = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTelCli = new System.Windows.Forms.Label();
			this.lblNomeCli = new System.Windows.Forms.Label();
			this.btnVoltarCli = new System.Windows.Forms.Button();
			this.lblCodCli = new System.Windows.Forms.Label();
			this.txtCodigoCli = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
			this.dtDataCadastro = new System.Windows.Forms.DateTimePicker();
			this.lblDataCadastro = new System.Windows.Forms.Label();
			this.txtCpfPesquisar = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNomePesquisar = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtEmailCli = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCep = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNumero = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtBairro = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtLogra = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtTelCli = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNomeCli = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCpfCnpjCli = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.tabCtrlCliente.SuspendLayout();
			this.tabConsultaCli.SuspendLayout();
			this.gbFiltrarCliente.SuspendLayout();
			this.pnlFiltrarCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
			this.tabCadastroCli.SuspendLayout();
			this.gbDadosCliente.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCtrlCliente
			// 
			this.tabCtrlCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tabCtrlCliente.Controls.Add(this.tabConsultaCli);
			this.tabCtrlCliente.Controls.Add(this.tabCadastroCli);
			this.tabCtrlCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabCtrlCliente.Location = new System.Drawing.Point(63, 2);
			this.tabCtrlCliente.Name = "tabCtrlCliente";
			this.tabCtrlCliente.SelectedIndex = 0;
			this.tabCtrlCliente.Size = new System.Drawing.Size(1056, 609);
			this.tabCtrlCliente.TabIndex = 0;
			// 
			// tabConsultaCli
			// 
			this.tabConsultaCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabConsultaCli.Controls.Add(this.btnFechaCliente);
			this.tabConsultaCli.Controls.Add(this.btnGridExcluir);
			this.tabConsultaCli.Controls.Add(this.btnGridAlterar);
			this.tabConsultaCli.Controls.Add(this.btnNovo);
			this.tabConsultaCli.Controls.Add(this.gbFiltrarCliente);
			this.tabConsultaCli.Controls.Add(this.dgCliente);
			this.tabConsultaCli.Location = new System.Drawing.Point(4, 29);
			this.tabConsultaCli.Name = "tabConsultaCli";
			this.tabConsultaCli.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaCli.Size = new System.Drawing.Size(1048, 576);
			this.tabConsultaCli.TabIndex = 0;
			this.tabConsultaCli.Text = "Consulta";
			// 
			// btnFechaCliente
			// 
			this.btnFechaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnFechaCliente.FlatAppearance.BorderSize = 0;
			this.btnFechaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnFechaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFechaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnFechaCliente.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_FecharTab;
			this.btnFechaCliente.Location = new System.Drawing.Point(722, 222);
			this.btnFechaCliente.Name = "btnFechaCliente";
			this.btnFechaCliente.Size = new System.Drawing.Size(139, 39);
			this.btnFechaCliente.TabIndex = 20;
			this.btnFechaCliente.Text = "Fechar";
			this.btnFechaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechaCliente.UseVisualStyleBackColor = false;
			this.btnFechaCliente.Click += new System.EventHandler(this.btnFechaCliente_Click);
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
			this.btnGridExcluir.Location = new System.Drawing.Point(548, 222);
			this.btnGridExcluir.Name = "btnGridExcluir";
			this.btnGridExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnGridExcluir.TabIndex = 19;
			this.btnGridExcluir.Text = "Excluir";
			this.btnGridExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGridExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGridExcluir.UseVisualStyleBackColor = false;
			this.btnGridExcluir.Click += new System.EventHandler(this.btnGridExcluir_Click);
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
			this.btnGridAlterar.Location = new System.Drawing.Point(376, 222);
			this.btnGridAlterar.Name = "btnGridAlterar";
			this.btnGridAlterar.Size = new System.Drawing.Size(139, 39);
			this.btnGridAlterar.TabIndex = 18;
			this.btnGridAlterar.Text = "Alterar";
			this.btnGridAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGridAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGridAlterar.UseVisualStyleBackColor = false;
			this.btnGridAlterar.Click += new System.EventHandler(this.btnGridAlterar_Click);
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
			this.btnNovo.Location = new System.Drawing.Point(205, 222);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(139, 39);
			this.btnNovo.TabIndex = 17;
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// gbFiltrarCliente
			// 
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
			this.pnlFiltrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.pnlFiltrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			this.lblNomePesquisa.AutoSize = true;
			this.lblNomePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNomePesquisa.Location = new System.Drawing.Point(92, 15);
			this.lblNomePesquisa.Name = "lblNomePesquisa";
			this.lblNomePesquisa.Size = new System.Drawing.Size(58, 20);
			this.lblNomePesquisa.TabIndex = 4;
			this.lblNomePesquisa.Text = "Cliente";
			// 
			// btnPesquisarCli
			// 
			this.btnPesquisarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnPesquisarCli.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.btnPesquisarCli.FlatAppearance.BorderSize = 0;
			this.btnPesquisarCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnPesquisarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnPesquisarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisarCli.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_search;
			this.btnPesquisarCli.Location = new System.Drawing.Point(586, 41);
			this.btnPesquisarCli.Name = "btnPesquisarCli";
			this.btnPesquisarCli.Size = new System.Drawing.Size(139, 39);
			this.btnPesquisarCli.TabIndex = 8;
			this.btnPesquisarCli.Text = "Pesquisar";
			this.btnPesquisarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPesquisarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisarCli.UseVisualStyleBackColor = false;
			this.btnPesquisarCli.Click += new System.EventHandler(this.btnPesquisarCli_Click);
			// 
			// lblCpfPesquisa
			// 
			this.lblCpfPesquisa.AutoSize = true;
			this.lblCpfPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCpfPesquisa.Location = new System.Drawing.Point(366, 15);
			this.lblCpfPesquisa.Name = "lblCpfPesquisa";
			this.lblCpfPesquisa.Size = new System.Drawing.Size(40, 20);
			this.lblCpfPesquisa.TabIndex = 5;
			this.lblCpfPesquisa.Text = "CPF";
			// 
			// dgCliente
			// 
			this.dgCliente.AllowUserToAddRows = false;
			this.dgCliente.AllowUserToDeleteRows = false;
			this.dgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgCliente.ColumnHeadersHeight = 35;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgCliente.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgCliente.EnableHeadersVisualStyles = false;
			this.dgCliente.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgCliente.Location = new System.Drawing.Point(101, 267);
			this.dgCliente.Name = "dgCliente";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgCliente.Size = new System.Drawing.Size(859, 293);
			this.dgCliente.TabIndex = 1;
			this.dgCliente.DataSourceChanged += new System.EventHandler(this.dtCliente_DataSourceChanged);
			this.dgCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtCliente_MouseClick);
			// 
			// tabCadastroCli
			// 
			this.tabCadastroCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabCadastroCli.Controls.Add(this.btnLimpar);
			this.tabCadastroCli.Controls.Add(this.gbDadosCliente);
			this.tabCadastroCli.Controls.Add(this.btnVoltarCli);
			this.tabCadastroCli.Controls.Add(this.lblCodCli);
			this.tabCadastroCli.Controls.Add(this.txtCodigoCli);
			this.tabCadastroCli.Controls.Add(this.btnSalvar);
			this.tabCadastroCli.Controls.Add(this.btnExcluir);
			this.tabCadastroCli.Location = new System.Drawing.Point(4, 29);
			this.tabCadastroCli.Name = "tabCadastroCli";
			this.tabCadastroCli.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroCli.Size = new System.Drawing.Size(1048, 576);
			this.tabCadastroCli.TabIndex = 1;
			this.tabCadastroCli.Text = "Cadastro";
			// 
			// gbDadosCliente
			// 
			this.gbDadosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
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
			this.gbDadosCliente.Controls.Add(this.cbCidade);
			this.gbDadosCliente.Controls.Add(this.lblCidade);
			this.gbDadosCliente.Controls.Add(this.cbEstado);
			this.gbDadosCliente.Controls.Add(this.lblEstado);
			this.gbDadosCliente.Controls.Add(this.cbTipoCli);
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
			// lblCep
			// 
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
			this.lblBairro.AutoSize = true;
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblBairro.Location = new System.Drawing.Point(480, 316);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(51, 20);
			this.lblBairro.TabIndex = 88;
			this.lblBairro.Text = "Bairro";
			// 
			// lblNumero
			// 
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
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblLogradouro.Location = new System.Drawing.Point(98, 316);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
			this.lblLogradouro.TabIndex = 86;
			this.lblLogradouro.Text = "Logradouro";
			// 
			// cbCidade
			// 
			this.cbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbCidade.FormattingEnabled = true;
			this.cbCidade.Location = new System.Drawing.Point(484, 271);
			this.cbCidade.Name = "cbCidade";
			this.cbCidade.Size = new System.Drawing.Size(194, 26);
			this.cbCidade.TabIndex = 77;
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCidade.Location = new System.Drawing.Point(480, 249);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(59, 20);
			this.lblCidade.TabIndex = 85;
			this.lblCidade.Text = "Cidade";
			// 
			// cbEstado
			// 
			this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(369, 274);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(80, 26);
			this.cbEstado.TabIndex = 76;
			this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged_1);
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEstado.Location = new System.Drawing.Point(365, 249);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(86, 20);
			this.lblEstado.TabIndex = 84;
			this.lblEstado.Text = "Estado/UF";
			// 
			// cbTipoCli
			// 
			this.cbTipoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbTipoCli.FormattingEnabled = true;
			this.cbTipoCli.Location = new System.Drawing.Point(101, 150);
			this.cbTipoCli.Name = "cbTipoCli";
			this.cbTipoCli.Size = new System.Drawing.Size(168, 26);
			this.cbTipoCli.TabIndex = 73;
			// 
			// lblTipoCli
			// 
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
			this.lblNomeCli.AutoSize = true;
			this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeCli.Location = new System.Drawing.Point(97, 72);
			this.lblNomeCli.Name = "lblNomeCli";
			this.lblNomeCli.Size = new System.Drawing.Size(123, 20);
			this.lblNomeCli.TabIndex = 69;
			this.lblNomeCli.Text = "Nome Completo";
			// 
			// btnVoltarCli
			// 
			this.btnVoltarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnVoltarCli.FlatAppearance.BorderSize = 0;
			this.btnVoltarCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnVoltarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVoltarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltarCli.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_ReturnTab;
			this.btnVoltarCli.Location = new System.Drawing.Point(643, 484);
			this.btnVoltarCli.Name = "btnVoltarCli";
			this.btnVoltarCli.Size = new System.Drawing.Size(139, 39);
			this.btnVoltarCli.TabIndex = 68;
			this.btnVoltarCli.Text = "Voltar";
			this.btnVoltarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltarCli.UseVisualStyleBackColor = false;
			this.btnVoltarCli.Click += new System.EventHandler(this.btnVoltarCli_Click);
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
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnSalvar.FlatAppearance.BorderSize = 0;
			this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnSalvar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Salvar;
			this.btnSalvar.Location = new System.Drawing.Point(323, 484);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 56;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnExcluir.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Excluir;
			this.btnExcluir.Location = new System.Drawing.Point(485, 484);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnExcluir.TabIndex = 59;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// dtDataNasc
			// 
			this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataNasc.Location = new System.Drawing.Point(569, 95);
			this.dtDataNasc.Name = "dtDataNasc";
			this.dtDataNasc.Size = new System.Drawing.Size(148, 26);
			this.dtDataNasc.TabIndex = 91;
			// 
			// dtDataCadastro
			// 
			this.dtDataCadastro.Enabled = false;
			this.dtDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataCadastro.Location = new System.Drawing.Point(661, 35);
			this.dtDataCadastro.Name = "dtDataCadastro";
			this.dtDataCadastro.Size = new System.Drawing.Size(148, 26);
			this.dtDataCadastro.TabIndex = 100;
			// 
			// lblDataCadastro
			// 
			this.lblDataCadastro.AutoSize = true;
			this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDataCadastro.Location = new System.Drawing.Point(657, 12);
			this.lblDataCadastro.Name = "lblDataCadastro";
			this.lblDataCadastro.Size = new System.Drawing.Size(132, 20);
			this.lblDataCadastro.TabIndex = 99;
			this.lblDataCadastro.Text = "Data de cadastro";
			// 
			// txtCpfPesquisar
			// 
			this.txtCpfPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCpfPesquisar.Location = new System.Drawing.Point(370, 48);
			this.txtCpfPesquisar.MaxLength = 18;
			this.txtCpfPesquisar.Name = "txtCpfPesquisar";
			this.txtCpfPesquisar.Size = new System.Drawing.Size(188, 24);
			this.txtCpfPesquisar.TabIndex = 7;
			this.txtCpfPesquisar.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
			// 
			// txtNomePesquisar
			// 
			this.txtNomePesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNomePesquisar.Location = new System.Drawing.Point(96, 48);
			this.txtNomePesquisar.Name = "txtNomePesquisar";
			this.txtNomePesquisar.Size = new System.Drawing.Size(252, 24);
			this.txtNomePesquisar.TabIndex = 6;
			this.txtNomePesquisar.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtEmailCli
			// 
			this.txtEmailCli.Location = new System.Drawing.Point(371, 209);
			this.txtEmailCli.Name = "txtEmailCli";
			this.txtEmailCli.Size = new System.Drawing.Size(190, 26);
			this.txtEmailCli.TabIndex = 98;
			this.txtEmailCli.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtCep
			// 
			this.txtCep.Location = new System.Drawing.Point(101, 271);
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(168, 26);
			this.txtCep.TabIndex = 97;
			this.txtCep.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(370, 337);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(80, 26);
			this.txtNumero.TabIndex = 95;
			this.txtNumero.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(484, 337);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(194, 26);
			this.txtBairro.TabIndex = 96;
			this.txtBairro.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtLogra
			// 
			this.txtLogra.Location = new System.Drawing.Point(101, 339);
			this.txtLogra.Name = "txtLogra";
			this.txtLogra.Size = new System.Drawing.Size(249, 26);
			this.txtLogra.TabIndex = 94;
			this.txtLogra.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtTelCli
			// 
			this.txtTelCli.Location = new System.Drawing.Point(101, 209);
			this.txtTelCli.Name = "txtTelCli";
			this.txtTelCli.Size = new System.Drawing.Size(167, 26);
			this.txtTelCli.TabIndex = 93;
			this.txtTelCli.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtNomeCli
			// 
			this.txtNomeCli.Location = new System.Drawing.Point(102, 95);
			this.txtNomeCli.Name = "txtNomeCli";
			this.txtNomeCli.Size = new System.Drawing.Size(441, 26);
			this.txtNomeCli.TabIndex = 92;
			this.txtNomeCli.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtCpfCnpjCli
			// 
			this.txtCpfCnpjCli.Location = new System.Drawing.Point(371, 154);
			this.txtCpfCnpjCli.MaxLength = 18;
			this.txtCpfCnpjCli.Name = "txtCpfCnpjCli";
			this.txtCpfCnpjCli.Size = new System.Drawing.Size(190, 26);
			this.txtCpfCnpjCli.TabIndex = 90;
			this.txtCpfCnpjCli.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnLimpar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Salvar;
			this.btnLimpar.Location = new System.Drawing.Point(822, 484);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(139, 39);
			this.btnLimpar.TabIndex = 70;
			this.btnLimpar.Text = "LIMPAR";
			this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
			this.gbFiltrarCliente.ResumeLayout(false);
			this.pnlFiltrarCliente.ResumeLayout(false);
			this.pnlFiltrarCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
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
		private System.Windows.Forms.Button btnExcluir;
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
		private System.Windows.Forms.ComboBox cbCidade;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.ComboBox cbEstado;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.ComboBox cbTipoCli;
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
	}
}

