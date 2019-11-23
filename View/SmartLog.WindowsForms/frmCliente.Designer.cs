namespace SmartLog.WindowsForms.DeskTopPresentation
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnFechaCliente = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblNomePesquisa = new System.Windows.Forms.Label();
			this.btnPesquisarCli = new System.Windows.Forms.Button();
			this.lblCpfPesquisa = new System.Windows.Forms.Label();
			this.dtCliente = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.gbDadosCliente = new System.Windows.Forms.GroupBox();
			this.lblCep = new System.Windows.Forms.Label();
			this.txtCep = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.lblBairro = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtLogra = new System.Windows.Forms.TextBox();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.cbCidade = new System.Windows.Forms.ComboBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.cbTipoCli = new System.Windows.Forms.ComboBox();
			this.lblTipoCli = new System.Windows.Forms.Label();
			this.lblCpfCnpjCli = new System.Windows.Forms.Label();
			this.txtData = new System.Windows.Forms.TextBox();
			this.lblDataNasc = new System.Windows.Forms.Label();
			this.txtEmailCli = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTelCli = new System.Windows.Forms.TextBox();
			this.lblTelCli = new System.Windows.Forms.Label();
			this.txtNomeCli = new System.Windows.Forms.TextBox();
			this.lblNomeCli = new System.Windows.Forms.Label();
			this.btnVoltarCli = new System.Windows.Forms.Button();
			this.lblCodCli = new System.Windows.Forms.Label();
			this.txtCodigoCli = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.txtCpfPesquisar = new SmartLog.WindowsForms.DeskTopPresentation.UserControl.SuperTextbox();
			this.txtCliPesquisar = new SmartLog.WindowsForms.DeskTopPresentation.UserControl.SuperTextbox();
			this.txtCpfCnpjCli = new SmartLog.WindowsForms.DeskTopPresentation.UserControl.SuperTextbox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtCliente)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.gbDadosCliente.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(63, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1056, 609);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabPage1.Controls.Add(this.btnFechaCliente);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.dtCliente);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1048, 576);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Consulta";
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
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button3.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Excluir;
			this.button3.Location = new System.Drawing.Point(548, 222);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(139, 39);
			this.button3.TabIndex = 19;
			this.button3.Text = "Excluir";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button2.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Alterar;
			this.button2.Location = new System.Drawing.Point(376, 222);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(139, 39);
			this.button2.TabIndex = 18;
			this.button2.Text = "Alterar";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Novo;
			this.button1.Location = new System.Drawing.Point(205, 222);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 39);
			this.button1.TabIndex = 17;
			this.button1.Text = "Novo";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Location = new System.Drawing.Point(101, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(859, 172);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtrar Cliente";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.lblNomePesquisa);
			this.panel3.Controls.Add(this.btnPesquisarCli);
			this.panel3.Controls.Add(this.lblCpfPesquisa);
			this.panel3.Controls.Add(this.txtCpfPesquisar);
			this.panel3.Controls.Add(this.txtCliPesquisar);
			this.panel3.Location = new System.Drawing.Point(33, 35);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(799, 116);
			this.panel3.TabIndex = 9;
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
			// dtCliente
			// 
			this.dtCliente.AllowUserToAddRows = false;
			this.dtCliente.AllowUserToDeleteRows = false;
			this.dtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dtCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dtCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dtCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtCliente.ColumnHeadersHeight = 35;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtCliente.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtCliente.EnableHeadersVisualStyles = false;
			this.dtCliente.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dtCliente.Location = new System.Drawing.Point(101, 267);
			this.dtCliente.Name = "dtCliente";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dtCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dtCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtCliente.Size = new System.Drawing.Size(859, 293);
			this.dtCliente.TabIndex = 1;
			this.dtCliente.DataSourceChanged += new System.EventHandler(this.dtCliente_DataSourceChanged);
			this.dtCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtCliente_MouseClick);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabPage2.Controls.Add(this.gbDadosCliente);
			this.tabPage2.Controls.Add(this.btnVoltarCli);
			this.tabPage2.Controls.Add(this.lblCodCli);
			this.tabPage2.Controls.Add(this.txtCodigoCli);
			this.tabPage2.Controls.Add(this.btnSalvar);
			this.tabPage2.Controls.Add(this.btnEditar);
			this.tabPage2.Controls.Add(this.btnExcluir);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1048, 576);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Cadastro";
			// 
			// gbDadosCliente
			// 
			this.gbDadosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbDadosCliente.Controls.Add(this.txtCpfCnpjCli);
			this.gbDadosCliente.Controls.Add(this.lblCep);
			this.gbDadosCliente.Controls.Add(this.txtCep);
			this.gbDadosCliente.Controls.Add(this.txtBairro);
			this.gbDadosCliente.Controls.Add(this.lblBairro);
			this.gbDadosCliente.Controls.Add(this.txtNumero);
			this.gbDadosCliente.Controls.Add(this.lblNumero);
			this.gbDadosCliente.Controls.Add(this.txtLogra);
			this.gbDadosCliente.Controls.Add(this.lblLogradouro);
			this.gbDadosCliente.Controls.Add(this.cbCidade);
			this.gbDadosCliente.Controls.Add(this.lblCidade);
			this.gbDadosCliente.Controls.Add(this.cbEstado);
			this.gbDadosCliente.Controls.Add(this.lblEstado);
			this.gbDadosCliente.Controls.Add(this.cbTipoCli);
			this.gbDadosCliente.Controls.Add(this.lblTipoCli);
			this.gbDadosCliente.Controls.Add(this.lblCpfCnpjCli);
			this.gbDadosCliente.Controls.Add(this.txtData);
			this.gbDadosCliente.Controls.Add(this.lblDataNasc);
			this.gbDadosCliente.Controls.Add(this.txtEmailCli);
			this.gbDadosCliente.Controls.Add(this.label1);
			this.gbDadosCliente.Controls.Add(this.txtTelCli);
			this.gbDadosCliente.Controls.Add(this.lblTelCli);
			this.gbDadosCliente.Controls.Add(this.txtNomeCli);
			this.gbDadosCliente.Controls.Add(this.lblNomeCli);
			this.gbDadosCliente.Location = new System.Drawing.Point(131, 57);
			this.gbDadosCliente.Name = "gbDadosCliente";
			this.gbDadosCliente.Size = new System.Drawing.Size(815, 354);
			this.gbDadosCliente.TabIndex = 69;
			this.gbDadosCliente.TabStop = false;
			this.gbDadosCliente.Text = "Dados do Cliente";
			// 
			// lblCep
			// 
			this.lblCep.AutoSize = true;
			this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCep.Location = new System.Drawing.Point(98, 209);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(41, 20);
			this.lblCep.TabIndex = 89;
			this.lblCep.Text = "CEP";
			// 
			// txtCep
			// 
			this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCep.Location = new System.Drawing.Point(102, 233);
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(167, 24);
			this.txtCep.TabIndex = 75;
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtBairro.Location = new System.Drawing.Point(484, 299);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(194, 24);
			this.txtBairro.TabIndex = 78;
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblBairro.Location = new System.Drawing.Point(480, 276);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(51, 20);
			this.lblBairro.TabIndex = 88;
			this.lblBairro.Text = "Bairro";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNumero.Location = new System.Drawing.Point(369, 298);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(80, 24);
			this.txtNumero.TabIndex = 81;
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNumero.Location = new System.Drawing.Point(366, 276);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(26, 20);
			this.lblNumero.TabIndex = 87;
			this.lblNumero.Text = "Nº";
			// 
			// txtLogra
			// 
			this.txtLogra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtLogra.Location = new System.Drawing.Point(101, 299);
			this.txtLogra.Name = "txtLogra";
			this.txtLogra.Size = new System.Drawing.Size(249, 24);
			this.txtLogra.TabIndex = 80;
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblLogradouro.Location = new System.Drawing.Point(98, 276);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
			this.lblLogradouro.TabIndex = 86;
			this.lblLogradouro.Text = "Logradouro";
			// 
			// cbCidade
			// 
			this.cbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbCidade.FormattingEnabled = true;
			this.cbCidade.Location = new System.Drawing.Point(484, 231);
			this.cbCidade.Name = "cbCidade";
			this.cbCidade.Size = new System.Drawing.Size(194, 26);
			this.cbCidade.TabIndex = 77;
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCidade.Location = new System.Drawing.Point(480, 209);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(59, 20);
			this.lblCidade.TabIndex = 85;
			this.lblCidade.Text = "Cidade";
			// 
			// cbEstado
			// 
			this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(369, 234);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(80, 26);
			this.cbEstado.TabIndex = 76;
			this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged_1);
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEstado.Location = new System.Drawing.Point(365, 209);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(86, 20);
			this.lblEstado.TabIndex = 84;
			this.lblEstado.Text = "Estado/UF";
			// 
			// cbTipoCli
			// 
			this.cbTipoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbTipoCli.FormattingEnabled = true;
			this.cbTipoCli.Location = new System.Drawing.Point(101, 110);
			this.cbTipoCli.Name = "cbTipoCli";
			this.cbTipoCli.Size = new System.Drawing.Size(168, 26);
			this.cbTipoCli.TabIndex = 73;
			// 
			// lblTipoCli
			// 
			this.lblTipoCli.AutoSize = true;
			this.lblTipoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblTipoCli.Location = new System.Drawing.Point(97, 87);
			this.lblTipoCli.Name = "lblTipoCli";
			this.lblTipoCli.Size = new System.Drawing.Size(114, 20);
			this.lblTipoCli.TabIndex = 83;
			this.lblTipoCli.Text = "Tipo de Cliente";
			// 
			// lblCpfCnpjCli
			// 
			this.lblCpfCnpjCli.AutoSize = true;
			this.lblCpfCnpjCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCpfCnpjCli.Location = new System.Drawing.Point(364, 87);
			this.lblCpfCnpjCli.Name = "lblCpfCnpjCli";
			this.lblCpfCnpjCli.Size = new System.Drawing.Size(84, 20);
			this.lblCpfCnpjCli.TabIndex = 82;
			this.lblCpfCnpjCli.Text = "CPF/CNPJ";
			// 
			// txtData
			// 
			this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtData.Location = new System.Drawing.Point(569, 55);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(148, 24);
			this.txtData.TabIndex = 68;
			// 
			// lblDataNasc
			// 
			this.lblDataNasc.AutoSize = true;
			this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDataNasc.Location = new System.Drawing.Point(565, 32);
			this.lblDataNasc.Name = "lblDataNasc";
			this.lblDataNasc.Size = new System.Drawing.Size(152, 20);
			this.lblDataNasc.TabIndex = 79;
			this.lblDataNasc.Text = "Data de nascimento";
			// 
			// txtEmailCli
			// 
			this.txtEmailCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtEmailCli.Location = new System.Drawing.Point(370, 169);
			this.txtEmailCli.Name = "txtEmailCli";
			this.txtEmailCli.Size = new System.Drawing.Size(191, 24);
			this.txtEmailCli.TabIndex = 71;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(367, 146);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 20);
			this.label1.TabIndex = 74;
			this.label1.Text = "E-mail";
			// 
			// txtTelCli
			// 
			this.txtTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtTelCli.Location = new System.Drawing.Point(102, 169);
			this.txtTelCli.Name = "txtTelCli";
			this.txtTelCli.Size = new System.Drawing.Size(167, 24);
			this.txtTelCli.TabIndex = 70;
			// 
			// lblTelCli
			// 
			this.lblTelCli.AutoSize = true;
			this.lblTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblTelCli.Location = new System.Drawing.Point(98, 146);
			this.lblTelCli.Name = "lblTelCli";
			this.lblTelCli.Size = new System.Drawing.Size(71, 20);
			this.lblTelCli.TabIndex = 72;
			this.lblTelCli.Text = "Telefone";
			// 
			// txtNomeCli
			// 
			this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNomeCli.Location = new System.Drawing.Point(100, 55);
			this.txtNomeCli.Name = "txtNomeCli";
			this.txtNomeCli.Size = new System.Drawing.Size(442, 24);
			this.txtNomeCli.TabIndex = 67;
			// 
			// lblNomeCli
			// 
			this.lblNomeCli.AutoSize = true;
			this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeCli.Location = new System.Drawing.Point(97, 32);
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
			this.btnVoltarCli.Location = new System.Drawing.Point(720, 472);
			this.btnVoltarCli.Name = "btnVoltarCli";
			this.btnVoltarCli.Size = new System.Drawing.Size(139, 39);
			this.btnVoltarCli.TabIndex = 68;
			this.btnVoltarCli.Text = "Voltar";
			this.btnVoltarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltarCli.UseVisualStyleBackColor = false;
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
			this.btnSalvar.Location = new System.Drawing.Point(243, 472);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 56;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnEditar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Alterar;
			this.btnEditar.Location = new System.Drawing.Point(403, 472);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(139, 39);
			this.btnEditar.TabIndex = 57;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = false;
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
			this.btnExcluir.Location = new System.Drawing.Point(562, 472);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnExcluir.TabIndex = 59;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// txtCpfPesquisar
			// 
			this.txtCpfPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCpfPesquisar.Location = new System.Drawing.Point(370, 48);
			this.txtCpfPesquisar.MaxLength = 18;
			this.txtCpfPesquisar.Name = "txtCpfPesquisar";
			this.txtCpfPesquisar.Size = new System.Drawing.Size(188, 24);
			this.txtCpfPesquisar.TabIndex = 7;
			this.txtCpfPesquisar.tipoTextbox = SmartLog.WindowsForms.DeskTopPresentation.UserControl.etipoTextbox.cpf;
			// 
			// txtCliPesquisar
			// 
			this.txtCliPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCliPesquisar.Location = new System.Drawing.Point(96, 48);
			this.txtCliPesquisar.Name = "txtCliPesquisar";
			this.txtCliPesquisar.Size = new System.Drawing.Size(252, 24);
			this.txtCliPesquisar.TabIndex = 6;
			this.txtCliPesquisar.tipoTextbox = SmartLog.WindowsForms.DeskTopPresentation.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtCpfCnpjCli
			// 
			this.txtCpfCnpjCli.Location = new System.Drawing.Point(371, 114);
			this.txtCpfCnpjCli.MaxLength = 18;
			this.txtCpfCnpjCli.Name = "txtCpfCnpjCli";
			this.txtCpfCnpjCli.Size = new System.Drawing.Size(190, 26);
			this.txtCpfCnpjCli.TabIndex = 90;
			this.txtCpfCnpjCli.tipoTextbox = SmartLog.WindowsForms.DeskTopPresentation.UserControl.etipoTextbox.cpf;
			// 
			// frmCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.ClientSize = new System.Drawing.Size(1172, 667);
			this.Controls.Add(this.tabControl1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCliente";
			this.Text = "Cliente";
			this.Load += new System.EventHandler(this.FormCliente_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtCliente)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.gbDadosCliente.ResumeLayout(false);
			this.gbDadosCliente.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label lblCodCli;
		private System.Windows.Forms.TextBox txtCodigoCli;
		private System.Windows.Forms.DataGridView dtCliente;
		private System.Windows.Forms.Label lblCpfPesquisa;
		private System.Windows.Forms.Label lblNomePesquisa;
		private UserControl.SuperTextbox txtCpfPesquisar;
		private UserControl.SuperTextbox txtCliPesquisar;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnPesquisarCli;
		private System.Windows.Forms.Button btnVoltarCli;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnFechaCliente;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox gbDadosCliente;
		private UserControl.SuperTextbox txtCpfCnpjCli;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.TextBox txtCep;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtLogra;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.ComboBox cbCidade;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.ComboBox cbEstado;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.ComboBox cbTipoCli;
		private System.Windows.Forms.Label lblTipoCli;
		private System.Windows.Forms.Label lblCpfCnpjCli;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Label lblDataNasc;
		private System.Windows.Forms.TextBox txtEmailCli;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTelCli;
		private System.Windows.Forms.Label lblTelCli;
		private System.Windows.Forms.TextBox txtNomeCli;
		private System.Windows.Forms.Label lblNomeCli;
	}
}

