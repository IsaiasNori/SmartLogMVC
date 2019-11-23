namespace SmartLog.WindowsForms
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabctrlFuncionario = new System.Windows.Forms.TabControl();
			this.tabConsultaFuncionario = new System.Windows.Forms.TabPage();
			this.gbFiltroFunc = new System.Windows.Forms.GroupBox();
			this.pnlFiltroFuncionario = new System.Windows.Forms.Panel();
			this.lblNomePesquisa = new System.Windows.Forms.Label();
			this.btnPesquisarFunc = new System.Windows.Forms.Button();
			this.lblCpfPesquisa = new System.Windows.Forms.Label();
			this.txtCpfPesquisar = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNomePesquisar = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.btnFechaFuncionario = new System.Windows.Forms.Button();
			this.btnGridExcluir = new System.Windows.Forms.Button();
			this.btnGridAlterar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.dtFuncionario = new System.Windows.Forms.DataGridView();
			this.tabCadastroFunc = new System.Windows.Forms.TabPage();
			this.btnVoltarCli = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.gbDadosFunc = new System.Windows.Forms.GroupBox();
			this.txtBairro = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNumero = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtLogra = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCep = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtTelFunc = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCpfFunc = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtData = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNomeFunc = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtEmail = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.label16 = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.cbCidade = new System.Windows.Forms.ComboBox();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cbCargo = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lblCargoFunc = new System.Windows.Forms.Label();
			this.lblDataNascFunc = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblNomeFunc = new System.Windows.Forms.Label();
			this.tabctrlFuncionario.SuspendLayout();
			this.tabConsultaFuncionario.SuspendLayout();
			this.gbFiltroFunc.SuspendLayout();
			this.pnlFiltroFuncionario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).BeginInit();
			this.tabCadastroFunc.SuspendLayout();
			this.gbDadosFunc.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabctrlFuncionario
			// 
			this.tabctrlFuncionario.Controls.Add(this.tabConsultaFuncionario);
			this.tabctrlFuncionario.Controls.Add(this.tabCadastroFunc);
			this.tabctrlFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabctrlFuncionario.Location = new System.Drawing.Point(63, 2);
			this.tabctrlFuncionario.Name = "tabctrlFuncionario";
			this.tabctrlFuncionario.SelectedIndex = 0;
			this.tabctrlFuncionario.Size = new System.Drawing.Size(990, 663);
			this.tabctrlFuncionario.TabIndex = 79;
			// 
			// tabConsultaFuncionario
			// 
			this.tabConsultaFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabConsultaFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabConsultaFuncionario.Controls.Add(this.gbFiltroFunc);
			this.tabConsultaFuncionario.Controls.Add(this.btnFechaFuncionario);
			this.tabConsultaFuncionario.Controls.Add(this.btnGridExcluir);
			this.tabConsultaFuncionario.Controls.Add(this.btnGridAlterar);
			this.tabConsultaFuncionario.Controls.Add(this.btnNovo);
			this.tabConsultaFuncionario.Controls.Add(this.dtFuncionario);
			this.tabConsultaFuncionario.Location = new System.Drawing.Point(4, 29);
			this.tabConsultaFuncionario.Name = "tabConsultaFuncionario";
			this.tabConsultaFuncionario.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaFuncionario.Size = new System.Drawing.Size(982, 630);
			this.tabConsultaFuncionario.TabIndex = 0;
			this.tabConsultaFuncionario.Text = "Consulta";
			// 
			// gbFiltroFunc
			// 
			this.gbFiltroFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbFiltroFunc.Controls.Add(this.pnlFiltroFuncionario);
			this.gbFiltroFunc.Location = new System.Drawing.Point(59, 37);
			this.gbFiltroFunc.Name = "gbFiltroFunc";
			this.gbFiltroFunc.Size = new System.Drawing.Size(861, 182);
			this.gbFiltroFunc.TabIndex = 17;
			this.gbFiltroFunc.TabStop = false;
			this.gbFiltroFunc.Text = "Filtrar funcionário";
			// 
			// pnlFiltroFuncionario
			// 
			this.pnlFiltroFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pnlFiltroFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.pnlFiltroFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlFiltroFuncionario.Controls.Add(this.lblNomePesquisa);
			this.pnlFiltroFuncionario.Controls.Add(this.btnPesquisarFunc);
			this.pnlFiltroFuncionario.Controls.Add(this.lblCpfPesquisa);
			this.pnlFiltroFuncionario.Controls.Add(this.txtCpfPesquisar);
			this.pnlFiltroFuncionario.Controls.Add(this.txtNomePesquisar);
			this.pnlFiltroFuncionario.Location = new System.Drawing.Point(40, 35);
			this.pnlFiltroFuncionario.Name = "pnlFiltroFuncionario";
			this.pnlFiltroFuncionario.Size = new System.Drawing.Size(780, 116);
			this.pnlFiltroFuncionario.TabIndex = 10;
			// 
			// lblNomePesquisa
			// 
			this.lblNomePesquisa.AutoSize = true;
			this.lblNomePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNomePesquisa.Location = new System.Drawing.Point(72, 27);
			this.lblNomePesquisa.Name = "lblNomePesquisa";
			this.lblNomePesquisa.Size = new System.Drawing.Size(92, 20);
			this.lblNomePesquisa.TabIndex = 4;
			this.lblNomePesquisa.Text = "Funcionário";
			// 
			// btnPesquisarFunc
			// 
			this.btnPesquisarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnPesquisarFunc.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.btnPesquisarFunc.FlatAppearance.BorderSize = 0;
			this.btnPesquisarFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnPesquisarFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnPesquisarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisarFunc.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_search;
			this.btnPesquisarFunc.Location = new System.Drawing.Point(593, 45);
			this.btnPesquisarFunc.Name = "btnPesquisarFunc";
			this.btnPesquisarFunc.Size = new System.Drawing.Size(139, 39);
			this.btnPesquisarFunc.TabIndex = 8;
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
			this.lblCpfPesquisa.Location = new System.Drawing.Point(366, 27);
			this.lblCpfPesquisa.Name = "lblCpfPesquisa";
			this.lblCpfPesquisa.Size = new System.Drawing.Size(40, 20);
			this.lblCpfPesquisa.TabIndex = 5;
			this.lblCpfPesquisa.Text = "CPF";
			// 
			// txtCpfPesquisar
			// 
			this.txtCpfPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCpfPesquisar.Location = new System.Drawing.Point(370, 60);
			this.txtCpfPesquisar.MaxLength = 18;
			this.txtCpfPesquisar.Name = "txtCpfPesquisar";
			this.txtCpfPesquisar.Size = new System.Drawing.Size(188, 24);
			this.txtCpfPesquisar.TabIndex = 7;
			this.txtCpfPesquisar.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
			// 
			// txtNomePesquisar
			// 
			this.txtNomePesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNomePesquisar.Location = new System.Drawing.Point(76, 60);
			this.txtNomePesquisar.Name = "txtNomePesquisar";
			this.txtNomePesquisar.Size = new System.Drawing.Size(252, 24);
			this.txtNomePesquisar.TabIndex = 6;
			this.txtNomePesquisar.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
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
			this.btnFechaFuncionario.Location = new System.Drawing.Point(693, 244);
			this.btnFechaFuncionario.Name = "btnFechaFuncionario";
			this.btnFechaFuncionario.Size = new System.Drawing.Size(139, 39);
			this.btnFechaFuncionario.TabIndex = 16;
			this.btnFechaFuncionario.Text = "Fechar";
			this.btnFechaFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechaFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechaFuncionario.UseVisualStyleBackColor = false;
			this.btnFechaFuncionario.Click += new System.EventHandler(this.btnFechaFuncionario_Click);
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
			this.btnGridExcluir.Location = new System.Drawing.Point(519, 244);
			this.btnGridExcluir.Name = "btnGridExcluir";
			this.btnGridExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnGridExcluir.TabIndex = 14;
			this.btnGridExcluir.Text = "Excluir";
			this.btnGridExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGridExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGridExcluir.UseVisualStyleBackColor = false;
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
			this.btnGridAlterar.Location = new System.Drawing.Point(347, 244);
			this.btnGridAlterar.Name = "btnGridAlterar";
			this.btnGridAlterar.Size = new System.Drawing.Size(139, 39);
			this.btnGridAlterar.TabIndex = 13;
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
			this.btnNovo.Location = new System.Drawing.Point(176, 244);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(139, 39);
			this.btnNovo.TabIndex = 12;
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// dtFuncionario
			// 
			this.dtFuncionario.AllowUserToAddRows = false;
			this.dtFuncionario.AllowUserToDeleteRows = false;
			this.dtFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dtFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.dtFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dtFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtFuncionario.ColumnHeadersHeight = 35;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtFuncionario.EnableHeadersVisualStyles = false;
			this.dtFuncionario.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dtFuncionario.Location = new System.Drawing.Point(59, 315);
			this.dtFuncionario.Name = "dtFuncionario";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dtFuncionario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dtFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtFuncionario.Size = new System.Drawing.Size(861, 272);
			this.dtFuncionario.TabIndex = 10;
			// 
			// tabCadastroFunc
			// 
			this.tabCadastroFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.tabCadastroFunc.Controls.Add(this.btnVoltarCli);
			this.tabCadastroFunc.Controls.Add(this.btnSalvar);
			this.tabCadastroFunc.Controls.Add(this.btnExcluir);
			this.tabCadastroFunc.Controls.Add(this.btnEditar);
			this.tabCadastroFunc.Controls.Add(this.gbDadosFunc);
			this.tabCadastroFunc.Location = new System.Drawing.Point(4, 29);
			this.tabCadastroFunc.Name = "tabCadastroFunc";
			this.tabCadastroFunc.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastroFunc.Size = new System.Drawing.Size(982, 630);
			this.tabCadastroFunc.TabIndex = 1;
			this.tabCadastroFunc.Text = "Cadastro";
			// 
			// btnVoltarCli
			// 
			this.btnVoltarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.btnVoltarCli.FlatAppearance.BorderSize = 0;
			this.btnVoltarCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnVoltarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVoltarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltarCli.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_ReturnTab;
			this.btnVoltarCli.Location = new System.Drawing.Point(679, 525);
			this.btnVoltarCli.Name = "btnVoltarCli";
			this.btnVoltarCli.Size = new System.Drawing.Size(139, 39);
			this.btnVoltarCli.TabIndex = 189;
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
			this.btnSalvar.Location = new System.Drawing.Point(202, 525);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 39);
			this.btnSalvar.TabIndex = 186;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
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
			this.btnExcluir.Location = new System.Drawing.Point(521, 525);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(139, 39);
			this.btnExcluir.TabIndex = 188;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcluir.UseVisualStyleBackColor = false;
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
			this.btnEditar.Location = new System.Drawing.Point(362, 525);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(139, 39);
			this.btnEditar.TabIndex = 187;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = false;
			// 
			// gbDadosFunc
			// 
			this.gbDadosFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.gbDadosFunc.Controls.Add(this.txtBairro);
			this.gbDadosFunc.Controls.Add(this.txtNumero);
			this.gbDadosFunc.Controls.Add(this.txtLogra);
			this.gbDadosFunc.Controls.Add(this.txtCep);
			this.gbDadosFunc.Controls.Add(this.txtTelFunc);
			this.gbDadosFunc.Controls.Add(this.txtCpfFunc);
			this.gbDadosFunc.Controls.Add(this.txtData);
			this.gbDadosFunc.Controls.Add(this.txtNomeFunc);
			this.gbDadosFunc.Controls.Add(this.txtEmail);
			this.gbDadosFunc.Controls.Add(this.label16);
			this.gbDadosFunc.Controls.Add(this.lblBairro);
			this.gbDadosFunc.Controls.Add(this.label13);
			this.gbDadosFunc.Controls.Add(this.lblNumero);
			this.gbDadosFunc.Controls.Add(this.cbCidade);
			this.gbDadosFunc.Controls.Add(this.cbEstado);
			this.gbDadosFunc.Controls.Add(this.lblCidade);
			this.gbDadosFunc.Controls.Add(this.label11);
			this.gbDadosFunc.Controls.Add(this.cbCargo);
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
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtBairro.Location = new System.Drawing.Point(530, 311);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(231, 24);
			this.txtBairro.TabIndex = 177;
			this.txtBairro.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNumero.Location = new System.Drawing.Point(356, 311);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 24);
			this.txtNumero.TabIndex = 176;
			this.txtNumero.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtLogra
			// 
			this.txtLogra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtLogra.Location = new System.Drawing.Point(59, 311);
			this.txtLogra.Name = "txtLogra";
			this.txtLogra.Size = new System.Drawing.Size(221, 24);
			this.txtLogra.TabIndex = 175;
			this.txtLogra.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtCep
			// 
			this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCep.Location = new System.Drawing.Point(59, 254);
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(221, 24);
			this.txtCep.TabIndex = 174;
			this.txtCep.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtTelFunc
			// 
			this.txtTelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtTelFunc.Location = new System.Drawing.Point(357, 191);
			this.txtTelFunc.Name = "txtTelFunc";
			this.txtTelFunc.Size = new System.Drawing.Size(124, 24);
			this.txtTelFunc.TabIndex = 173;
			this.txtTelFunc.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteNumero;
			// 
			// txtCpfFunc
			// 
			this.txtCpfFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtCpfFunc.Location = new System.Drawing.Point(60, 191);
			this.txtCpfFunc.Name = "txtCpfFunc";
			this.txtCpfFunc.Size = new System.Drawing.Size(221, 24);
			this.txtCpfFunc.TabIndex = 172;
			this.txtCpfFunc.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
			// 
			// txtData
			// 
			this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtData.Location = new System.Drawing.Point(530, 130);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(230, 24);
			this.txtData.TabIndex = 171;
			this.txtData.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.data;
			// 
			// txtNomeFunc
			// 
			this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNomeFunc.Location = new System.Drawing.Point(59, 130);
			this.txtNomeFunc.Name = "txtNomeFunc";
			this.txtNomeFunc.Size = new System.Drawing.Size(364, 24);
			this.txtNomeFunc.TabIndex = 170;
			this.txtNomeFunc.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtEmail.Location = new System.Drawing.Point(530, 190);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(230, 24);
			this.txtEmail.TabIndex = 169;
			this.txtEmail.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
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
			// cbCidade
			// 
			this.cbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbCidade.FormattingEnabled = true;
			this.cbCidade.Location = new System.Drawing.Point(529, 251);
			this.cbCidade.Name = "cbCidade";
			this.cbCidade.Size = new System.Drawing.Size(231, 26);
			this.cbCidade.TabIndex = 154;
			// 
			// cbEstado
			// 
			this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(356, 254);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(73, 26);
			this.cbEstado.TabIndex = 153;
			this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.CbEstado_SelectedIndexChanged);
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
			// cbCargo
			// 
			this.cbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbCargo.FormattingEnabled = true;
			this.cbCargo.Location = new System.Drawing.Point(58, 44);
			this.cbCargo.Name = "cbCargo";
			this.cbCargo.Size = new System.Drawing.Size(121, 26);
			this.cbCargo.TabIndex = 152;
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
			this.lblDataNascFunc.Location = new System.Drawing.Point(527, 108);
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
			// frmFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.ClientSize = new System.Drawing.Size(1095, 728);
			this.Controls.Add(this.tabctrlFuncionario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmFuncionario";
			this.Text = "Funcionario";
			this.Load += new System.EventHandler(this.FormFuncionario_Load);
			this.tabctrlFuncionario.ResumeLayout(false);
			this.tabConsultaFuncionario.ResumeLayout(false);
			this.gbFiltroFunc.ResumeLayout(false);
			this.pnlFiltroFuncionario.ResumeLayout(false);
			this.pnlFiltroFuncionario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).EndInit();
			this.tabCadastroFunc.ResumeLayout(false);
			this.gbDadosFunc.ResumeLayout(false);
			this.gbDadosFunc.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabctrlFuncionario;
		private System.Windows.Forms.TabPage tabConsultaFuncionario;
		private System.Windows.Forms.TabPage tabCadastroFunc;
		private System.Windows.Forms.DataGridView dtFuncionario;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnGridExcluir;
		private System.Windows.Forms.Button btnGridAlterar;
		private System.Windows.Forms.Button btnFechaFuncionario;
		private System.Windows.Forms.GroupBox gbFiltroFunc;
		private System.Windows.Forms.Panel pnlFiltroFuncionario;
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
		private UserControl.SuperTextbox txtData;
		private UserControl.SuperTextbox txtNomeFunc;
		private UserControl.SuperTextbox txtEmail;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.ComboBox cbCidade;
		private System.Windows.Forms.ComboBox cbEstado;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbCargo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblCargoFunc;
		private System.Windows.Forms.Label lblDataNascFunc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblNomeFunc;
		private System.Windows.Forms.Button btnVoltarCli;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnEditar;
	}
}