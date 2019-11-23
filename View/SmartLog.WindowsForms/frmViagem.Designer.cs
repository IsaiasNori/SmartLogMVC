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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabCtrlViagem = new System.Windows.Forms.TabControl();
			this.tabConsultaViagem = new System.Windows.Forms.TabPage();
			this.gbFiltraViagem = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.superTextbox2 = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblClientePesquisar = new System.Windows.Forms.Label();
			this.superTextbox1 = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblMotoristaPesquisar = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPesquisarViagem = new System.Windows.Forms.Button();
			this.btnFechaViagem = new System.Windows.Forms.Button();
			this.btnGridExcluir = new System.Windows.Forms.Button();
			this.dtCliente = new System.Windows.Forms.DataGridView();
			this.btnGridAlterar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.tabCadastroViagem = new System.Windows.Forms.TabPage();
			this.btnVoltarFunc = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.gbDadosDestinoViagem = new System.Windows.Forms.GroupBox();
			this.txtBairroDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtLograDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNumeroDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCepDestino = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbEstadoDestino = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbCidadeDestino = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblCepDestino = new System.Windows.Forms.Label();
			this.gbDadosOrigemviagem = new System.Windows.Forms.GroupBox();
			this.txtCepOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtBairroOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtLograOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNumeroOrigem = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.cbEstadoOrigem = new System.Windows.Forms.ComboBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.cbCidadeOrigem = new System.Windows.Forms.ComboBox();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblCepOrigem = new System.Windows.Forms.Label();
			this.gbDadosViagem1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lblDataViagem = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.superTextbox5 = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.cbMotoristaViagem = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.superTextbox4 = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.cbClienteViagem = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.cbAtendente = new System.Windows.Forms.ComboBox();
			this.cbVeiculo = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.lblCodCli = new System.Windows.Forms.Label();
			this.txtCodigoCli = new System.Windows.Forms.TextBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.tabCtrlViagem.SuspendLayout();
			this.tabConsultaViagem.SuspendLayout();
			this.gbFiltraViagem.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtCliente)).BeginInit();
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
			this.tabConsultaViagem.Controls.Add(this.dtCliente);
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
			this.gbFiltraViagem.Controls.Add(this.panel3);
			this.gbFiltraViagem.Location = new System.Drawing.Point(64, 40);
			this.gbFiltraViagem.Name = "gbFiltraViagem";
			this.gbFiltraViagem.Size = new System.Drawing.Size(859, 212);
			this.gbFiltraViagem.TabIndex = 21;
			this.gbFiltraViagem.TabStop = false;
			this.gbFiltraViagem.Text = "Filtrar viagem";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.dateTimePicker3);
			this.panel3.Controls.Add(this.dateTimePicker2);
			this.panel3.Controls.Add(this.btnPesquisarViagem);
			this.panel3.Controls.Add(this.superTextbox2);
			this.panel3.Controls.Add(this.lblClientePesquisar);
			this.panel3.Controls.Add(this.superTextbox1);
			this.panel3.Controls.Add(this.lblMotoristaPesquisar);
			this.panel3.Location = new System.Drawing.Point(42, 25);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(775, 160);
			this.panel3.TabIndex = 9;
			// 
			// superTextbox2
			// 
			this.superTextbox2.Location = new System.Drawing.Point(230, 47);
			this.superTextbox2.Name = "superTextbox2";
			this.superTextbox2.Size = new System.Drawing.Size(200, 26);
			this.superTextbox2.TabIndex = 15;
			this.superTextbox2.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// lblClientePesquisar
			// 
			this.lblClientePesquisar.AutoSize = true;
			this.lblClientePesquisar.Location = new System.Drawing.Point(227, 24);
			this.lblClientePesquisar.Name = "lblClientePesquisar";
			this.lblClientePesquisar.Size = new System.Drawing.Size(58, 20);
			this.lblClientePesquisar.TabIndex = 14;
			this.lblClientePesquisar.Text = "Cliente";
			// 
			// superTextbox1
			// 
			this.superTextbox1.Location = new System.Drawing.Point(24, 48);
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(442, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Por data:";
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(738, 428);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "De";
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
			// dtCliente
			// 
			this.dtCliente.AllowUserToAddRows = false;
			this.dtCliente.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.dtCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dtCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dtCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dtCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtCliente.ColumnHeadersHeight = 35;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtCliente.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtCliente.EnableHeadersVisualStyles = false;
			this.dtCliente.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dtCliente.Location = new System.Drawing.Point(64, 363);
			this.dtCliente.Name = "dtCliente";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dtCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dtCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtCliente.Size = new System.Drawing.Size(859, 293);
			this.dtCliente.TabIndex = 1;
			this.dtCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtCliente_CellContentClick);
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
			// tabCadastroViagem
			// 
			this.tabCadastroViagem.AutoScroll = true;
			this.tabCadastroViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabCadastroViagem.Controls.Add(this.btnVoltarFunc);
			this.tabCadastroViagem.Controls.Add(this.btnSalvar);
			this.tabCadastroViagem.Controls.Add(this.btnEditar);
			this.tabCadastroViagem.Controls.Add(this.btnExcluir);
			this.tabCadastroViagem.Controls.Add(this.gbDadosDestinoViagem);
			this.tabCadastroViagem.Controls.Add(this.gbDadosOrigemviagem);
			this.tabCadastroViagem.Controls.Add(this.gbDadosViagem1);
			this.tabCadastroViagem.Controls.Add(this.lblCodCli);
			this.tabCadastroViagem.Controls.Add(this.txtCodigoCli);
			this.tabCadastroViagem.Location = new System.Drawing.Point(4, 29);
			this.tabCadastroViagem.Name = "tabCadastroViagem";
			this.tabCadastroViagem.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroViagem.Size = new System.Drawing.Size(985, 658);
			this.tabCadastroViagem.TabIndex = 1;
			this.tabCadastroViagem.Text = "Cadastro";
			// 
			// btnVoltarFunc
			// 
			this.btnVoltarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnVoltarFunc.FlatAppearance.BorderSize = 0;
			this.btnVoltarFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnVoltarFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVoltarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltarFunc.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_ReturnTab;
			this.btnVoltarFunc.Location = new System.Drawing.Point(699, 602);
			this.btnVoltarFunc.Name = "btnVoltarFunc";
			this.btnVoltarFunc.Size = new System.Drawing.Size(139, 39);
			this.btnVoltarFunc.TabIndex = 101;
			this.btnVoltarFunc.Text = "Voltar";
			this.btnVoltarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltarFunc.UseVisualStyleBackColor = false;
			this.btnVoltarFunc.Click += new System.EventHandler(this.BtnVoltarFunc_Click);
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
			this.btnSalvar.Location = new System.Drawing.Point(222, 602);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 98;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
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
			this.btnEditar.Location = new System.Drawing.Point(382, 602);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(139, 39);
			this.btnEditar.TabIndex = 99;
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
			this.btnExcluir.Location = new System.Drawing.Point(541, 602);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnExcluir.TabIndex = 100;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// gbDadosDestinoViagem
			// 
			this.gbDadosDestinoViagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbDadosDestinoViagem.Controls.Add(this.txtBairroDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.txtLograDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.txtNumeroDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.txtCepDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.label7);
			this.gbDadosDestinoViagem.Controls.Add(this.cbEstadoDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.label8);
			this.gbDadosDestinoViagem.Controls.Add(this.cbCidadeDestino);
			this.gbDadosDestinoViagem.Controls.Add(this.label9);
			this.gbDadosDestinoViagem.Controls.Add(this.label10);
			this.gbDadosDestinoViagem.Controls.Add(this.label11);
			this.gbDadosDestinoViagem.Controls.Add(this.lblCepDestino);
			this.gbDadosDestinoViagem.Location = new System.Drawing.Point(125, 416);
			this.gbDadosDestinoViagem.Name = "gbDadosDestinoViagem";
			this.gbDadosDestinoViagem.Size = new System.Drawing.Size(792, 170);
			this.gbDadosDestinoViagem.TabIndex = 96;
			this.gbDadosDestinoViagem.TabStop = false;
			this.gbDadosDestinoViagem.Text = "Destino da Viagem";
			// 
			// txtBairroDestino
			// 
			this.txtBairroDestino.Location = new System.Drawing.Point(430, 124);
			this.txtBairroDestino.Name = "txtBairroDestino";
			this.txtBairroDestino.Size = new System.Drawing.Size(194, 26);
			this.txtBairroDestino.TabIndex = 82;
			this.txtBairroDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtLograDestino
			// 
			this.txtLograDestino.Location = new System.Drawing.Point(40, 124);
			this.txtLograDestino.Name = "txtLograDestino";
			this.txtLograDestino.Size = new System.Drawing.Size(248, 26);
			this.txtLograDestino.TabIndex = 81;
			this.txtLograDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtNumeroDestino
			// 
			this.txtNumeroDestino.Location = new System.Drawing.Point(329, 124);
			this.txtNumeroDestino.Name = "txtNumeroDestino";
			this.txtNumeroDestino.Size = new System.Drawing.Size(80, 26);
			this.txtNumeroDestino.TabIndex = 80;
			this.txtNumeroDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtCepDestino
			// 
			this.txtCepDestino.Location = new System.Drawing.Point(40, 59);
			this.txtCepDestino.Name = "txtCepDestino";
			this.txtCepDestino.Size = new System.Drawing.Size(168, 26);
			this.txtCepDestino.TabIndex = 79;
			this.txtCepDestino.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label7.Location = new System.Drawing.Point(324, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 20);
			this.label7.TabIndex = 72;
			this.label7.Text = "Estado/UF";
			// 
			// cbEstadoDestino
			// 
			this.cbEstadoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbEstadoDestino.FormattingEnabled = true;
			this.cbEstadoDestino.Location = new System.Drawing.Point(328, 59);
			this.cbEstadoDestino.Name = "cbEstadoDestino";
			this.cbEstadoDestino.Size = new System.Drawing.Size(80, 26);
			this.cbEstadoDestino.TabIndex = 67;
			this.cbEstadoDestino.SelectedIndexChanged += new System.EventHandler(this.CbEstadoDestino_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label8.Location = new System.Drawing.Point(426, 34);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 20);
			this.label8.TabIndex = 73;
			this.label8.Text = "Cidade";
			// 
			// cbCidadeDestino
			// 
			this.cbCidadeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbCidadeDestino.FormattingEnabled = true;
			this.cbCidadeDestino.Location = new System.Drawing.Point(430, 56);
			this.cbCidadeDestino.Name = "cbCidadeDestino";
			this.cbCidadeDestino.Size = new System.Drawing.Size(194, 26);
			this.cbCidadeDestino.TabIndex = 68;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label9.Location = new System.Drawing.Point(37, 101);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 20);
			this.label9.TabIndex = 74;
			this.label9.Text = "Logradouro";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label10.Location = new System.Drawing.Point(324, 101);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(26, 20);
			this.label10.TabIndex = 75;
			this.label10.Text = "Nº";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label11.Location = new System.Drawing.Point(426, 101);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(51, 20);
			this.label11.TabIndex = 76;
			this.label11.Text = "Bairro";
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
			this.gbDadosOrigemviagem.Controls.Add(this.txtCepOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.txtBairroOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.txtLograOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.txtNumeroOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.lblEstado);
			this.gbDadosOrigemviagem.Controls.Add(this.cbEstadoOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.lblCidade);
			this.gbDadosOrigemviagem.Controls.Add(this.cbCidadeOrigem);
			this.gbDadosOrigemviagem.Controls.Add(this.lblLogradouro);
			this.gbDadosOrigemviagem.Controls.Add(this.lblNumero);
			this.gbDadosOrigemviagem.Controls.Add(this.lblBairro);
			this.gbDadosOrigemviagem.Controls.Add(this.lblCepOrigem);
			this.gbDadosOrigemviagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbDadosOrigemviagem.Location = new System.Drawing.Point(125, 239);
			this.gbDadosOrigemviagem.Name = "gbDadosOrigemviagem";
			this.gbDadosOrigemviagem.Size = new System.Drawing.Size(792, 171);
			this.gbDadosOrigemviagem.TabIndex = 69;
			this.gbDadosOrigemviagem.TabStop = false;
			this.gbDadosOrigemviagem.Text = "Origem da Viagem";
			// 
			// txtCepOrigem
			// 
			this.txtCepOrigem.Location = new System.Drawing.Point(40, 57);
			this.txtCepOrigem.Name = "txtCepOrigem";
			this.txtCepOrigem.Size = new System.Drawing.Size(168, 26);
			this.txtCepOrigem.TabIndex = 82;
			this.txtCepOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtBairroOrigem
			// 
			this.txtBairroOrigem.Location = new System.Drawing.Point(430, 123);
			this.txtBairroOrigem.Name = "txtBairroOrigem";
			this.txtBairroOrigem.Size = new System.Drawing.Size(194, 26);
			this.txtBairroOrigem.TabIndex = 81;
			this.txtBairroOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtLograOrigem
			// 
			this.txtLograOrigem.Location = new System.Drawing.Point(41, 123);
			this.txtLograOrigem.Name = "txtLograOrigem";
			this.txtLograOrigem.Size = new System.Drawing.Size(248, 26);
			this.txtLograOrigem.TabIndex = 80;
			this.txtLograOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtNumeroOrigem
			// 
			this.txtNumeroOrigem.Location = new System.Drawing.Point(328, 121);
			this.txtNumeroOrigem.Name = "txtNumeroOrigem";
			this.txtNumeroOrigem.Size = new System.Drawing.Size(80, 26);
			this.txtNumeroOrigem.TabIndex = 79;
			this.txtNumeroOrigem.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEstado.Location = new System.Drawing.Point(324, 33);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(86, 20);
			this.lblEstado.TabIndex = 72;
			this.lblEstado.Text = "Estado/UF";
			// 
			// cbEstadoOrigem
			// 
			this.cbEstadoOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbEstadoOrigem.FormattingEnabled = true;
			this.cbEstadoOrigem.Location = new System.Drawing.Point(328, 58);
			this.cbEstadoOrigem.Name = "cbEstadoOrigem";
			this.cbEstadoOrigem.Size = new System.Drawing.Size(80, 26);
			this.cbEstadoOrigem.TabIndex = 67;
			this.cbEstadoOrigem.SelectedIndexChanged += new System.EventHandler(this.CbEstado_SelectedIndexChanged);
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCidade.Location = new System.Drawing.Point(426, 33);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(59, 20);
			this.lblCidade.TabIndex = 73;
			this.lblCidade.Text = "Cidade";
			// 
			// cbCidadeOrigem
			// 
			this.cbCidadeOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbCidadeOrigem.FormattingEnabled = true;
			this.cbCidadeOrigem.Location = new System.Drawing.Point(430, 55);
			this.cbCidadeOrigem.Name = "cbCidadeOrigem";
			this.cbCidadeOrigem.Size = new System.Drawing.Size(194, 26);
			this.cbCidadeOrigem.TabIndex = 68;
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblLogradouro.Location = new System.Drawing.Point(38, 100);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
			this.lblLogradouro.TabIndex = 74;
			this.lblLogradouro.Text = "Logradouro";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNumero.Location = new System.Drawing.Point(324, 100);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(26, 20);
			this.lblNumero.TabIndex = 75;
			this.lblNumero.Text = "Nº";
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblBairro.Location = new System.Drawing.Point(426, 100);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(51, 20);
			this.lblBairro.TabIndex = 76;
			this.lblBairro.Text = "Bairro";
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
			this.gbDadosViagem1.Controls.Add(this.dateTimePicker1);
			this.gbDadosViagem1.Controls.Add(this.lblDataViagem);
			this.gbDadosViagem1.Controls.Add(this.label1);
			this.gbDadosViagem1.Controls.Add(this.superTextbox5);
			this.gbDadosViagem1.Controls.Add(this.cbMotoristaViagem);
			this.gbDadosViagem1.Controls.Add(this.label16);
			this.gbDadosViagem1.Controls.Add(this.label6);
			this.gbDadosViagem1.Controls.Add(this.superTextbox4);
			this.gbDadosViagem1.Controls.Add(this.cbClienteViagem);
			this.gbDadosViagem1.Controls.Add(this.label15);
			this.gbDadosViagem1.Controls.Add(this.label13);
			this.gbDadosViagem1.Controls.Add(this.cbAtendente);
			this.gbDadosViagem1.Controls.Add(this.cbVeiculo);
			this.gbDadosViagem1.Controls.Add(this.label14);
			this.gbDadosViagem1.Location = new System.Drawing.Point(125, 16);
			this.gbDadosViagem1.Name = "gbDadosViagem1";
			this.gbDadosViagem1.Size = new System.Drawing.Size(792, 217);
			this.gbDadosViagem1.TabIndex = 97;
			this.gbDadosViagem1.TabStop = false;
			this.gbDadosViagem1.Text = "Dados da Viagem";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(41, 55);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(138, 26);
			this.dateTimePicker1.TabIndex = 92;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 20);
			this.label1.TabIndex = 68;
			this.label1.Text = "Motorista";
			// 
			// superTextbox5
			// 
			this.superTextbox5.Location = new System.Drawing.Point(535, 167);
			this.superTextbox5.Name = "superTextbox5";
			this.superTextbox5.Size = new System.Drawing.Size(138, 26);
			this.superTextbox5.TabIndex = 91;
			this.superTextbox5.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// cbMotoristaViagem
			// 
			this.cbMotoristaViagem.FormattingEnabled = true;
			this.cbMotoristaViagem.Location = new System.Drawing.Point(41, 111);
			this.cbMotoristaViagem.Name = "cbMotoristaViagem";
			this.cbMotoristaViagem.Size = new System.Drawing.Size(265, 28);
			this.cbMotoristaViagem.TabIndex = 69;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label16.Location = new System.Drawing.Point(531, 144);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(128, 20);
			this.label16.TabIndex = 90;
			this.label16.Text = "Distancia em KM";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(37, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 20);
			this.label6.TabIndex = 70;
			this.label6.Text = "Cliente";
			// 
			// superTextbox4
			// 
			this.superTextbox4.Location = new System.Drawing.Point(328, 167);
			this.superTextbox4.Name = "superTextbox4";
			this.superTextbox4.Size = new System.Drawing.Size(138, 26);
			this.superTextbox4.TabIndex = 89;
			this.superTextbox4.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// cbClienteViagem
			// 
			this.cbClienteViagem.FormattingEnabled = true;
			this.cbClienteViagem.Location = new System.Drawing.Point(41, 165);
			this.cbClienteViagem.Name = "cbClienteViagem";
			this.cbClienteViagem.Size = new System.Drawing.Size(265, 28);
			this.cbClienteViagem.TabIndex = 71;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label15.Location = new System.Drawing.Point(324, 144);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(46, 20);
			this.label15.TabIndex = 88;
			this.label15.Text = "Valor";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(324, 88);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(61, 20);
			this.label13.TabIndex = 84;
			this.label13.Text = "Veiculo";
			// 
			// cbAtendente
			// 
			this.cbAtendente.FormattingEnabled = true;
			this.cbAtendente.Location = new System.Drawing.Point(535, 111);
			this.cbAtendente.Name = "cbAtendente";
			this.cbAtendente.Size = new System.Drawing.Size(191, 28);
			this.cbAtendente.TabIndex = 87;
			// 
			// cbVeiculo
			// 
			this.cbVeiculo.FormattingEnabled = true;
			this.cbVeiculo.Location = new System.Drawing.Point(327, 110);
			this.cbVeiculo.Name = "cbVeiculo";
			this.cbVeiculo.Size = new System.Drawing.Size(191, 28);
			this.cbVeiculo.TabIndex = 85;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(532, 88);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(84, 20);
			this.label14.TabIndex = 86;
			this.label14.Text = "Atendente";
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
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(446, 45);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(139, 26);
			this.dateTimePicker2.TabIndex = 16;
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker3.Location = new System.Drawing.Point(615, 44);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(139, 26);
			this.dateTimePicker3.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(591, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 20);
			this.label4.TabIndex = 18;
			this.label4.Text = "à";
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
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtCliente)).EndInit();
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
		private System.Windows.Forms.DataGridView dtCliente;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnPesquisarViagem;
		private System.Windows.Forms.TabPage tabCadastroViagem;
		private System.Windows.Forms.Label lblDataViagem;
		private System.Windows.Forms.Label lblCodCli;
		private System.Windows.Forms.TextBox txtCodigoCli;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private UserControl.SuperTextbox superTextbox2;
		private System.Windows.Forms.Label lblClientePesquisar;
		private UserControl.SuperTextbox superTextbox1;
		private System.Windows.Forms.Label lblMotoristaPesquisar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbClienteViagem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbMotoristaViagem;
		private System.Windows.Forms.Label label1;
		private UserControl.SuperTextbox superTextbox5;
		private System.Windows.Forms.Label label16;
		private UserControl.SuperTextbox superTextbox4;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cbAtendente;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cbVeiculo;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnFechaViagem;
		private System.Windows.Forms.Button btnGridExcluir;
		private System.Windows.Forms.Button btnGridAlterar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.GroupBox gbFiltraViagem;
		private System.Windows.Forms.GroupBox gbDadosDestinoViagem;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbEstadoDestino;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbCidadeDestino;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblCepDestino;
		private System.Windows.Forms.GroupBox gbDadosOrigemviagem;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.ComboBox cbEstadoOrigem;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.ComboBox cbCidadeOrigem;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label lblCepOrigem;
		private System.Windows.Forms.GroupBox gbDadosViagem1;
		private UserControl.SuperTextbox txtCepDestino;
		private UserControl.SuperTextbox txtBairroDestino;
		private UserControl.SuperTextbox txtLograDestino;
		private UserControl.SuperTextbox txtNumeroDestino;
		private UserControl.SuperTextbox txtBairroOrigem;
		private UserControl.SuperTextbox txtLograOrigem;
		private UserControl.SuperTextbox txtNumeroOrigem;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button btnVoltarFunc;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
		private UserControl.SuperTextbox txtCepOrigem;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
	}
}