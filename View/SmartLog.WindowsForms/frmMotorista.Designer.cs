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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabCtrlMotorista = new System.Windows.Forms.TabControl();
			this.tabConsultaMotorista = new System.Windows.Forms.TabPage();
			this.btnFechaMotorista = new System.Windows.Forms.Button();
			this.btnGridExcluir = new System.Windows.Forms.Button();
			this.btnGridAlterar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.dgMotorista = new System.Windows.Forms.DataGridView();
			this.gbFiltrarMotorista = new System.Windows.Forms.GroupBox();
			this.chkVencimentoCnh = new System.Windows.Forms.CheckBox();
			this.txtMotoristaPesquisa = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblMotoristaPesquisa = new System.Windows.Forms.Label();
			this.dtCnhVencPesquisa = new System.Windows.Forms.DateTimePicker();
			this.btnPesquisarMotorista = new System.Windows.Forms.Button();
			this.lblIntervaloData = new System.Windows.Forms.Label();
			this.dtCnhVencFinal = new System.Windows.Forms.DateTimePicker();
			this.tabCadastroMotorista = new System.Windows.Forms.TabPage();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
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
			this.btnSalvar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
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
			this.tabCtrlMotorista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabCtrlMotorista.Controls.Add(this.tabConsultaMotorista);
			this.tabCtrlMotorista.Controls.Add(this.tabCadastroMotorista);
			this.tabCtrlMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tabCtrlMotorista.Location = new System.Drawing.Point(62, 40);
			this.tabCtrlMotorista.Name = "tabCtrlMotorista";
			this.tabCtrlMotorista.Padding = new System.Drawing.Point(50, 5);
			this.tabCtrlMotorista.SelectedIndex = 0;
			this.tabCtrlMotorista.Size = new System.Drawing.Size(853, 622);
			this.tabCtrlMotorista.TabIndex = 0;
			// 
			// tabConsultaMotorista
			// 
			this.tabConsultaMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.tabConsultaMotorista.Controls.Add(this.btnFechaMotorista);
			this.tabConsultaMotorista.Controls.Add(this.btnGridExcluir);
			this.tabConsultaMotorista.Controls.Add(this.btnGridAlterar);
			this.tabConsultaMotorista.Controls.Add(this.btnNovo);
			this.tabConsultaMotorista.Controls.Add(this.dgMotorista);
			this.tabConsultaMotorista.Controls.Add(this.gbFiltrarMotorista);
			this.tabConsultaMotorista.Location = new System.Drawing.Point(4, 33);
			this.tabConsultaMotorista.Name = "tabConsultaMotorista";
			this.tabConsultaMotorista.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaMotorista.Size = new System.Drawing.Size(845, 585);
			this.tabConsultaMotorista.TabIndex = 0;
			this.tabConsultaMotorista.Text = "Consulta";
			// 
			// btnFechaMotorista
			// 
			this.btnFechaMotorista.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnFechaMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnFechaMotorista.FlatAppearance.BorderSize = 0;
			this.btnFechaMotorista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnFechaMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFechaMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechaMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechaMotorista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnFechaMotorista.Image = global::SmartLog.WindowsForms.Properties.Resources.iconFechar;
			this.btnFechaMotorista.Location = new System.Drawing.Point(610, 243);
			this.btnFechaMotorista.Name = "btnFechaMotorista";
			this.btnFechaMotorista.Size = new System.Drawing.Size(139, 39);
			this.btnFechaMotorista.TabIndex = 11;
			this.btnFechaMotorista.Text = "Fechar";
			this.btnFechaMotorista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechaMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechaMotorista.UseVisualStyleBackColor = false;
			this.btnFechaMotorista.Click += new System.EventHandler(this.btnFechaMotorista_Click);
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
			this.btnGridExcluir.Location = new System.Drawing.Point(436, 243);
			this.btnGridExcluir.Name = "btnGridExcluir";
			this.btnGridExcluir.Size = new System.Drawing.Size(139, 39);
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
			this.btnGridAlterar.Location = new System.Drawing.Point(264, 243);
			this.btnGridAlterar.Name = "btnGridAlterar";
			this.btnGridAlterar.Size = new System.Drawing.Size(139, 39);
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
			this.btnNovo.Location = new System.Drawing.Point(93, 243);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(139, 39);
			this.btnNovo.TabIndex = 8;
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// dgMotorista
			// 
			this.dgMotorista.AllowUserToAddRows = false;
			this.dgMotorista.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgMotorista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgMotorista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgMotorista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgMotorista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgMotorista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dgMotorista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgMotorista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgMotorista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgMotorista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgMotorista.ColumnHeadersHeight = 35;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgMotorista.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgMotorista.EnableHeadersVisualStyles = false;
			this.dgMotorista.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgMotorista.Location = new System.Drawing.Point(76, 314);
			this.dgMotorista.Name = "dgMotorista";
			this.dgMotorista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgMotorista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgMotorista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgMotorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgMotorista.Size = new System.Drawing.Size(693, 257);
			this.dgMotorista.TabIndex = 6;
			this.dgMotorista.DataSourceChanged += new System.EventHandler(this.dgMotorista_DataSourceChanged);
			// 
			// gbFiltrarMotorista
			// 
			this.gbFiltrarMotorista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbFiltrarMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.gbFiltrarMotorista.Controls.Add(this.chkVencimentoCnh);
			this.gbFiltrarMotorista.Controls.Add(this.txtMotoristaPesquisa);
			this.gbFiltrarMotorista.Controls.Add(this.lblMotoristaPesquisa);
			this.gbFiltrarMotorista.Controls.Add(this.dtCnhVencPesquisa);
			this.gbFiltrarMotorista.Controls.Add(this.btnPesquisarMotorista);
			this.gbFiltrarMotorista.Controls.Add(this.lblIntervaloData);
			this.gbFiltrarMotorista.Controls.Add(this.dtCnhVencFinal);
			this.gbFiltrarMotorista.Location = new System.Drawing.Point(76, 29);
			this.gbFiltrarMotorista.Name = "gbFiltrarMotorista";
			this.gbFiltrarMotorista.Size = new System.Drawing.Size(693, 192);
			this.gbFiltrarMotorista.TabIndex = 0;
			this.gbFiltrarMotorista.TabStop = false;
			this.gbFiltrarMotorista.Text = "Filtros";
			// 
			// chkVencimentoCnh
			// 
			this.chkVencimentoCnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.chkVencimentoCnh.AutoSize = true;
			this.chkVencimentoCnh.Location = new System.Drawing.Point(375, 44);
			this.chkVencimentoCnh.Name = "chkVencimentoCnh";
			this.chkVencimentoCnh.Size = new System.Drawing.Size(222, 24);
			this.chkVencimentoCnh.TabIndex = 2;
			this.chkVencimentoCnh.Text = "Filtrar por Vencimento CNH";
			this.chkVencimentoCnh.UseVisualStyleBackColor = true;
			this.chkVencimentoCnh.CheckedChanged += new System.EventHandler(this.chkVencimentoCnh_CheckedChanged);
			// 
			// txtMotoristaPesquisa
			// 
			this.txtMotoristaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtMotoristaPesquisa.CampoObrigatorio = false;
			this.txtMotoristaPesquisa.Location = new System.Drawing.Point(53, 77);
			this.txtMotoristaPesquisa.MensagemObrigatorio = null;
			this.txtMotoristaPesquisa.Name = "txtMotoristaPesquisa";
			this.txtMotoristaPesquisa.Size = new System.Drawing.Size(292, 26);
			this.txtMotoristaPesquisa.TabIndex = 1;
			this.txtMotoristaPesquisa.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// lblMotoristaPesquisa
			// 
			this.lblMotoristaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblMotoristaPesquisa.AutoSize = true;
			this.lblMotoristaPesquisa.Location = new System.Drawing.Point(49, 48);
			this.lblMotoristaPesquisa.Name = "lblMotoristaPesquisa";
			this.lblMotoristaPesquisa.Size = new System.Drawing.Size(75, 20);
			this.lblMotoristaPesquisa.TabIndex = 0;
			this.lblMotoristaPesquisa.Text = "Motorista";
			// 
			// dtCnhVencPesquisa
			// 
			this.dtCnhVencPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dtCnhVencPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCnhVencPesquisa.Location = new System.Drawing.Point(375, 74);
			this.dtCnhVencPesquisa.Name = "dtCnhVencPesquisa";
			this.dtCnhVencPesquisa.Size = new System.Drawing.Size(128, 26);
			this.dtCnhVencPesquisa.TabIndex = 3;
			// 
			// btnPesquisarMotorista
			// 
			this.btnPesquisarMotorista.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnPesquisarMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnPesquisarMotorista.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.btnPesquisarMotorista.FlatAppearance.BorderSize = 0;
			this.btnPesquisarMotorista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnPesquisarMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnPesquisarMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisarMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisarMotorista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnPesquisarMotorista.Image = global::SmartLog.WindowsForms.Properties.Resources.icoSearch_fw;
			this.btnPesquisarMotorista.Location = new System.Drawing.Point(239, 130);
			this.btnPesquisarMotorista.Name = "btnPesquisarMotorista";
			this.btnPesquisarMotorista.Size = new System.Drawing.Size(207, 39);
			this.btnPesquisarMotorista.TabIndex = 5;
			this.btnPesquisarMotorista.Text = "Pesquisar";
			this.btnPesquisarMotorista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPesquisarMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisarMotorista.UseVisualStyleBackColor = false;
			this.btnPesquisarMotorista.Click += new System.EventHandler(this.btnPesquisarMotorista_Click);
			// 
			// lblIntervaloData
			// 
			this.lblIntervaloData.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblIntervaloData.AutoSize = true;
			this.lblIntervaloData.Location = new System.Drawing.Point(509, 80);
			this.lblIntervaloData.Name = "lblIntervaloData";
			this.lblIntervaloData.Size = new System.Drawing.Size(18, 20);
			this.lblIntervaloData.TabIndex = 3;
			this.lblIntervaloData.Text = "à";
			// 
			// dtCnhVencFinal
			// 
			this.dtCnhVencFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dtCnhVencFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCnhVencFinal.Location = new System.Drawing.Point(533, 74);
			this.dtCnhVencFinal.Name = "dtCnhVencFinal";
			this.dtCnhVencFinal.Size = new System.Drawing.Size(131, 26);
			this.dtCnhVencFinal.TabIndex = 4;
			// 
			// tabCadastroMotorista
			// 
			this.tabCadastroMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.tabCadastroMotorista.Controls.Add(this.btnLimpar);
			this.tabCadastroMotorista.Controls.Add(this.btnVoltar);
			this.tabCadastroMotorista.Controls.Add(this.gbDadosMotorista);
			this.tabCadastroMotorista.Controls.Add(this.btnSalvar);
			this.tabCadastroMotorista.Location = new System.Drawing.Point(4, 33);
			this.tabCadastroMotorista.Name = "tabCadastroMotorista";
			this.tabCadastroMotorista.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroMotorista.Size = new System.Drawing.Size(845, 585);
			this.tabCadastroMotorista.TabIndex = 1;
			this.tabCadastroMotorista.Text = "Cadastro";
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
			this.btnLimpar.Location = new System.Drawing.Point(357, 471);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(139, 39);
			this.btnLimpar.TabIndex = 107;
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
			this.btnVoltar.Location = new System.Drawing.Point(519, 471);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(139, 39);
			this.btnVoltar.TabIndex = 108;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// gbDadosMotorista
			// 
			this.gbDadosMotorista.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gbDadosMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
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
			this.cbCnhCategoria.Location = new System.Drawing.Point(355, 232);
			this.cbCnhCategoria.MensagemCampoObrigatorio = "É obrigatório informar a categoria da CNH.";
			this.cbCnhCategoria.Name = "cbCnhCategoria";
			this.cbCnhCategoria.Size = new System.Drawing.Size(116, 28);
			this.cbCnhCategoria.TabIndex = 7;
			// 
			// cbCidade
			// 
			this.cbCidade.CampoObrigatorio = true;
			this.cbCidade.FormattingEnabled = true;
			this.cbCidade.Location = new System.Drawing.Point(544, 288);
			this.cbCidade.MensagemCampoObrigatorio = "Informar cidade em que reside";
			this.cbCidade.Name = "cbCidade";
			this.cbCidade.Size = new System.Drawing.Size(194, 28);
			this.cbCidade.TabIndex = 11;
			// 
			// cbEstado
			// 
			this.cbEstado.CampoObrigatorio = true;
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(355, 288);
			this.cbEstado.MensagemCampoObrigatorio = "Informar Estado  em que reside";
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(116, 28);
			this.cbEstado.TabIndex = 10;
			this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
			// 
			// cbStatus
			// 
			this.cbStatus.CampoObrigatorio = true;
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Location = new System.Drawing.Point(78, 55);
			this.cbStatus.MensagemCampoObrigatorio = "Informar Status.";
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(137, 28);
			this.cbStatus.TabIndex = 1;
			// 
			// txtEmail
			// 
			this.txtEmail.CampoObrigatorio = true;
			this.txtEmail.Location = new System.Drawing.Point(543, 169);
			this.txtEmail.MensagemObrigatorio = "Informar o Email.";
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(194, 26);
			this.txtEmail.TabIndex = 5;
			this.txtEmail.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEmail.Location = new System.Drawing.Point(540, 146);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(48, 20);
			this.lblEmail.TabIndex = 105;
			this.lblEmail.Text = "Email";
			// 
			// lblCnhCat
			// 
			this.lblCnhCat.AutoSize = true;
			this.lblCnhCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCnhCat.Location = new System.Drawing.Point(351, 203);
			this.lblCnhCat.Name = "lblCnhCat";
			this.lblCnhCat.Size = new System.Drawing.Size(120, 20);
			this.lblCnhCat.TabIndex = 103;
			this.lblCnhCat.Text = "Categoria CNH ";
			// 
			// dtCnhVenc
			// 
			this.dtCnhVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCnhVenc.Location = new System.Drawing.Point(543, 226);
			this.dtCnhVenc.Name = "dtCnhVenc";
			this.dtCnhVenc.Size = new System.Drawing.Size(194, 26);
			this.dtCnhVenc.TabIndex = 8;
			// 
			// lblCnhVenc
			// 
			this.lblCnhVenc.AutoSize = true;
			this.lblCnhVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCnhVenc.Location = new System.Drawing.Point(539, 203);
			this.lblCnhVenc.Name = "lblCnhVenc";
			this.lblCnhVenc.Size = new System.Drawing.Size(132, 20);
			this.lblCnhVenc.TabIndex = 101;
			this.lblCnhVenc.Text = "Vencimento CNH";
			// 
			// txtCep
			// 
			this.txtCep.CampoObrigatorio = true;
			this.txtCep.Location = new System.Drawing.Point(77, 290);
			this.txtCep.MensagemObrigatorio = "Informar o Cep do endereço";
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(168, 26);
			this.txtCep.TabIndex = 9;
			this.txtCep.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtNumero
			// 
			this.txtNumero.CampoObrigatorio = true;
			this.txtNumero.Location = new System.Drawing.Point(355, 358);
			this.txtNumero.MensagemObrigatorio = "Informar o numero da residência.";
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(107, 26);
			this.txtNumero.TabIndex = 13;
			this.txtNumero.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtBairro
			// 
			this.txtBairro.CampoObrigatorio = true;
			this.txtBairro.Location = new System.Drawing.Point(543, 358);
			this.txtBairro.MensagemObrigatorio = "Informar o bairro.";
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(194, 26);
			this.txtBairro.TabIndex = 14;
			this.txtBairro.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtLogra
			// 
			this.txtLogra.CampoObrigatorio = true;
			this.txtLogra.Location = new System.Drawing.Point(77, 358);
			this.txtLogra.MensagemObrigatorio = "Informar a rua em que reside";
			this.txtLogra.Name = "txtLogra";
			this.txtLogra.Size = new System.Drawing.Size(249, 26);
			this.txtLogra.TabIndex = 12;
			this.txtLogra.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtTelMoto
			// 
			this.txtTelMoto.CampoObrigatorio = true;
			this.txtTelMoto.Location = new System.Drawing.Point(355, 169);
			this.txtTelMoto.MensagemObrigatorio = "Informar o telefone para contato.";
			this.txtTelMoto.Name = "txtTelMoto";
			this.txtTelMoto.Size = new System.Drawing.Size(167, 26);
			this.txtTelMoto.TabIndex = 4;
			this.txtTelMoto.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtNomeMoto
			// 
			this.txtNomeMoto.CampoObrigatorio = true;
			this.txtNomeMoto.Location = new System.Drawing.Point(78, 114);
			this.txtNomeMoto.MensagemObrigatorio = "Informar o nome";
			this.txtNomeMoto.Name = "txtNomeMoto";
			this.txtNomeMoto.Size = new System.Drawing.Size(459, 26);
			this.txtNomeMoto.TabIndex = 2;
			this.txtNomeMoto.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// dtDataNasc
			// 
			this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDataNasc.Location = new System.Drawing.Point(78, 169);
			this.dtDataNasc.Name = "dtDataNasc";
			this.dtDataNasc.Size = new System.Drawing.Size(148, 26);
			this.dtDataNasc.TabIndex = 3;
			// 
			// txtCnhNum
			// 
			this.txtCnhNum.CampoObrigatorio = true;
			this.txtCnhNum.Location = new System.Drawing.Point(77, 228);
			this.txtCnhNum.MaxLength = 11;
			this.txtCnhNum.MensagemObrigatorio = "É obrigatório informar o número da CNH.";
			this.txtCnhNum.Name = "txtCnhNum";
			this.txtCnhNum.Size = new System.Drawing.Size(190, 26);
			this.txtCnhNum.TabIndex = 6;
			this.txtCnhNum.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// lblCep
			// 
			this.lblCep.AutoSize = true;
			this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCep.Location = new System.Drawing.Point(74, 268);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(41, 20);
			this.lblCep.TabIndex = 89;
			this.lblCep.Text = "CEP";
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblBairro.Location = new System.Drawing.Point(540, 335);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(51, 20);
			this.lblBairro.TabIndex = 88;
			this.lblBairro.Text = "Bairro";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNumero.Location = new System.Drawing.Point(351, 335);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(26, 20);
			this.lblNumero.TabIndex = 87;
			this.lblNumero.Text = "Nº";
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblLogradouro.Location = new System.Drawing.Point(74, 335);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
			this.lblLogradouro.TabIndex = 86;
			this.lblLogradouro.Text = "Logradouro";
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCidade.Location = new System.Drawing.Point(540, 268);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(59, 20);
			this.lblCidade.TabIndex = 85;
			this.lblCidade.Text = "Cidade";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEstado.Location = new System.Drawing.Point(352, 268);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(86, 20);
			this.lblEstado.TabIndex = 84;
			this.lblEstado.Text = "Estado/UF";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblStatus.Location = new System.Drawing.Point(74, 31);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(56, 20);
			this.lblStatus.TabIndex = 83;
			this.lblStatus.Text = "Status";
			// 
			// lblCnhNum
			// 
			this.lblCnhNum.AutoSize = true;
			this.lblCnhNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCnhNum.Location = new System.Drawing.Point(73, 203);
			this.lblCnhNum.Name = "lblCnhNum";
			this.lblCnhNum.Size = new System.Drawing.Size(64, 20);
			this.lblCnhNum.TabIndex = 82;
			this.lblCnhNum.Text = "Nº CNH";
			// 
			// lblDataNasc
			// 
			this.lblDataNasc.AutoSize = true;
			this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDataNasc.Location = new System.Drawing.Point(74, 146);
			this.lblDataNasc.Name = "lblDataNasc";
			this.lblDataNasc.Size = new System.Drawing.Size(152, 20);
			this.lblDataNasc.TabIndex = 79;
			this.lblDataNasc.Text = "Data de nascimento";
			// 
			// lblTelMoto
			// 
			this.lblTelMoto.AutoSize = true;
			this.lblTelMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblTelMoto.Location = new System.Drawing.Point(352, 146);
			this.lblTelMoto.Name = "lblTelMoto";
			this.lblTelMoto.Size = new System.Drawing.Size(71, 20);
			this.lblTelMoto.TabIndex = 72;
			this.lblTelMoto.Text = "Telefone";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(73, 91);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(123, 20);
			this.lblNome.TabIndex = 69;
			this.lblNome.Text = "Nome Completo";
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
			this.btnSalvar.Location = new System.Drawing.Point(198, 471);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 106;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
			this.button1.Size = new System.Drawing.Size(976, 34);
			this.button1.TabIndex = 81;
			this.button1.Text = "Motoristas";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// frmMotorista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
			this.ClientSize = new System.Drawing.Size(976, 645);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabCtrlMotorista);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMotorista";
			this.Text = "frmMotorista";
			this.Load += new System.EventHandler(this.frmMotorista_Load);
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
		private System.Windows.Forms.GroupBox gbFiltrarMotorista;
		private System.Windows.Forms.DateTimePicker dtCnhVencFinal;
		private System.Windows.Forms.DateTimePicker dtCnhVencPesquisa;
		private System.Windows.Forms.Label lblIntervaloData;
		private UserControl.SuperTextbox txtMotoristaPesquisa;
		private System.Windows.Forms.Label lblMotoristaPesquisa;
		private System.Windows.Forms.Button btnPesquisarMotorista;
		private System.Windows.Forms.CheckBox chkVencimentoCnh;
		private UserControl.SuperComboBox cbCnhCategoria;
		private UserControl.SuperComboBox cbCidade;
		private UserControl.SuperComboBox cbEstado;
		private UserControl.SuperComboBox cbStatus;
		private System.Windows.Forms.DataGridView dgMotorista;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnFechaMotorista;
		private System.Windows.Forms.Button btnGridExcluir;
		private System.Windows.Forms.Button btnGridAlterar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button button1;
	}
}