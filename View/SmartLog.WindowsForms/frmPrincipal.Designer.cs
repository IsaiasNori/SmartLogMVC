namespace SmartLog.WindowsForms
{
	partial class frmPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnAjuda = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnManutencao = new System.Windows.Forms.Button();
			this.btnViagem = new System.Windows.Forms.Button();
			this.btnVeiculo = new System.Windows.Forms.Button();
			this.btnFuncionario = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.panelCabecalho = new System.Windows.Forms.Panel();
			this.lblTituloTela = new System.Windows.Forms.Label();
			this.btnMinimizar = new System.Windows.Forms.Button();
			this.btnTituloTela = new System.Windows.Forms.Button();
			this.btnRestaurar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.panelRodape = new System.Windows.Forms.Panel();
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.lblData = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.Relogio = new System.Windows.Forms.Timer(this.components);
			this.panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelCabecalho.SuspendLayout();
			this.panelRodape.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.panelMenu.Controls.Add(this.btnSair);
			this.panelMenu.Controls.Add(this.btnAjuda);
			this.panelMenu.Controls.Add(this.pictureBox1);
			this.panelMenu.Controls.Add(this.btnManutencao);
			this.panelMenu.Controls.Add(this.btnViagem);
			this.panelMenu.Controls.Add(this.btnVeiculo);
			this.panelMenu.Controls.Add(this.btnFuncionario);
			this.panelMenu.Controls.Add(this.btnCliente);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 35);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(190, 665);
			this.panelMenu.TabIndex = 0;
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Transparent;
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnSair.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_Logout;
			this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnSair.Location = new System.Drawing.Point(3, 484);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(187, 51);
			this.btnSair.TabIndex = 6;
			this.btnSair.Text = " Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnAjuda
			// 
			this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
			this.btnAjuda.FlatAppearance.BorderSize = 0;
			this.btnAjuda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.btnAjuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnAjuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnAjuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnAjuda.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_MenuAjuda;
			this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnAjuda.Location = new System.Drawing.Point(3, 430);
			this.btnAjuda.Name = "btnAjuda";
			this.btnAjuda.Size = new System.Drawing.Size(187, 51);
			this.btnAjuda.TabIndex = 5;
			this.btnAjuda.Text = "  Ajuda";
			this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAjuda.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::SmartLog.WindowsForms.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(3, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(190, 164);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnManutencao
			// 
			this.btnManutencao.BackColor = System.Drawing.Color.Transparent;
			this.btnManutencao.FlatAppearance.BorderSize = 0;
			this.btnManutencao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.btnManutencao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnManutencao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnManutencao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnManutencao.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_MenuManutencao;
			this.btnManutencao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnManutencao.Location = new System.Drawing.Point(3, 376);
			this.btnManutencao.Name = "btnManutencao";
			this.btnManutencao.Size = new System.Drawing.Size(187, 51);
			this.btnManutencao.TabIndex = 4;
			this.btnManutencao.Text = "  Manutenção";
			this.btnManutencao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnManutencao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnManutencao.UseVisualStyleBackColor = false;
			// 
			// btnViagem
			// 
			this.btnViagem.BackColor = System.Drawing.Color.Transparent;
			this.btnViagem.FlatAppearance.BorderSize = 0;
			this.btnViagem.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.btnViagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnViagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnViagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnViagem.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_MenuViagem;
			this.btnViagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnViagem.Location = new System.Drawing.Point(3, 216);
			this.btnViagem.Name = "btnViagem";
			this.btnViagem.Size = new System.Drawing.Size(187, 51);
			this.btnViagem.TabIndex = 3;
			this.btnViagem.Text = "  Viagem";
			this.btnViagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnViagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnViagem.UseVisualStyleBackColor = false;
			this.btnViagem.Click += new System.EventHandler(this.btnViagem_Click);
			// 
			// btnVeiculo
			// 
			this.btnVeiculo.BackColor = System.Drawing.Color.Transparent;
			this.btnVeiculo.FlatAppearance.BorderSize = 0;
			this.btnVeiculo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.btnVeiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnVeiculo.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_MenuVeiculo;
			this.btnVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVeiculo.Location = new System.Drawing.Point(3, 269);
			this.btnVeiculo.Name = "btnVeiculo";
			this.btnVeiculo.Size = new System.Drawing.Size(187, 51);
			this.btnVeiculo.TabIndex = 2;
			this.btnVeiculo.Text = "  Veículos";
			this.btnVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnVeiculo.UseVisualStyleBackColor = false;
			this.btnVeiculo.Click += new System.EventHandler(this.btnVeiculo_Click);
			// 
			// btnFuncionario
			// 
			this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
			this.btnFuncionario.FlatAppearance.BorderSize = 0;
			this.btnFuncionario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.btnFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnFuncionario.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_MenuFuncionario;
			this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnFuncionario.Location = new System.Drawing.Point(3, 323);
			this.btnFuncionario.Name = "btnFuncionario";
			this.btnFuncionario.Size = new System.Drawing.Size(187, 51);
			this.btnFuncionario.TabIndex = 1;
			this.btnFuncionario.Text = "  Funcionários";
			this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFuncionario.UseVisualStyleBackColor = false;
			this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
			// 
			// btnCliente
			// 
			this.btnCliente.BackColor = System.Drawing.Color.Transparent;
			this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnCliente.FlatAppearance.BorderSize = 0;
			this.btnCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnCliente.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_MenuCliente;
			this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCliente.Location = new System.Drawing.Point(3, 159);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(187, 51);
			this.btnCliente.TabIndex = 0;
			this.btnCliente.Text = "  Clientes";
			this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCliente.UseVisualStyleBackColor = false;
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
			// 
			// panelCabecalho
			// 
			this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.panelCabecalho.Controls.Add(this.lblTituloTela);
			this.panelCabecalho.Controls.Add(this.btnMinimizar);
			this.panelCabecalho.Controls.Add(this.btnTituloTela);
			this.panelCabecalho.Controls.Add(this.btnRestaurar);
			this.panelCabecalho.Controls.Add(this.btnFechar);
			this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
			this.panelCabecalho.Name = "panelCabecalho";
			this.panelCabecalho.Size = new System.Drawing.Size(873, 35);
			this.panelCabecalho.TabIndex = 0;
			this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
			this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
			this.panelCabecalho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseUp);
			// 
			// lblTituloTela
			// 
			this.lblTituloTela.AutoSize = true;
			this.lblTituloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.lblTituloTela.Location = new System.Drawing.Point(52, 5);
			this.lblTituloTela.Name = "lblTituloTela";
			this.lblTituloTela.Size = new System.Drawing.Size(90, 24);
			this.lblTituloTela.TabIndex = 5;
			this.lblTituloTela.Text = "SmartLog";
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimizar.FlatAppearance.BorderSize = 0;
			this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimizar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_MinimizarApp;
			this.btnMinimizar.Location = new System.Drawing.Point(765, 3);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(37, 32);
			this.btnMinimizar.TabIndex = 3;
			this.btnMinimizar.UseVisualStyleBackColor = false;
			this.btnMinimizar.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// btnTituloTela
			// 
			this.btnTituloTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnTituloTela.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
			this.btnTituloTela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnTituloTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTituloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTituloTela.Location = new System.Drawing.Point(191, 5);
			this.btnTituloTela.Name = "btnTituloTela";
			this.btnTituloTela.Size = new System.Drawing.Size(115, 30);
			this.btnTituloTela.TabIndex = 4;
			this.btnTituloTela.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTituloTela.UseVisualStyleBackColor = false;
			this.btnTituloTela.Visible = false;
			// 
			// btnRestaurar
			// 
			this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
			this.btnRestaurar.FlatAppearance.BorderSize = 0;
			this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestaurar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_MAxWhite;
			this.btnRestaurar.Location = new System.Drawing.Point(800, 1);
			this.btnRestaurar.Name = "btnRestaurar";
			this.btnRestaurar.Size = new System.Drawing.Size(37, 34);
			this.btnRestaurar.TabIndex = 2;
			this.btnRestaurar.UseVisualStyleBackColor = false;
			this.btnRestaurar.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.BackColor = System.Drawing.Color.Transparent;
			this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnFechar.FlatAppearance.BorderSize = 0;
			this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.ForeColor = System.Drawing.Color.White;
			this.btnFechar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_CloseApp2;
			this.btnFechar.Location = new System.Drawing.Point(837, 1);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(33, 34);
			this.btnFechar.TabIndex = 0;
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panelRodape
			// 
			this.panelRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.panelRodape.Controls.Add(this.lblNomeUsuario);
			this.panelRodape.Controls.Add(this.lblData);
			this.panelRodape.Controls.Add(this.lblUsuario);
			this.panelRodape.ForeColor = System.Drawing.Color.White;
			this.panelRodape.Location = new System.Drawing.Point(187, 669);
			this.panelRodape.Name = "panelRodape";
			this.panelRodape.Size = new System.Drawing.Size(686, 35);
			this.panelRodape.TabIndex = 2;
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblNomeUsuario.AutoSize = true;
			this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeUsuario.Location = new System.Drawing.Point(392, 6);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(0, 16);
			this.lblNomeUsuario.TabIndex = 3;
			// 
			// lblData
			// 
			this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblData.AutoSize = true;
			this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblData.Location = new System.Drawing.Point(539, 6);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(82, 16);
			this.lblData.TabIndex = 2;
			this.lblData.Text = "17/11/2019";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(320, 6);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(66, 16);
			this.lblUsuario.TabIndex = 1;
			this.lblUsuario.Text = "Usuário:";
			// 
			// Relogio
			// 
			this.Relogio.Interval = 1000;
			this.Relogio.Tick += new System.EventHandler(this.Relogio_Tick);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.ClientSize = new System.Drawing.Size(873, 700);
			this.Controls.Add(this.panelMenu);
			this.Controls.Add(this.panelRodape);
			this.Controls.Add(this.panelCabecalho);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTeste";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Shown += new System.EventHandler(this.FrmPrincipal_Shown);
			this.panelMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelCabecalho.ResumeLayout(false);
			this.panelCabecalho.PerformLayout();
			this.panelRodape.ResumeLayout(false);
			this.panelRodape.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelCabecalho;
		private System.Windows.Forms.Button btnVeiculo;
		private System.Windows.Forms.Button btnFuncionario;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Button btnManutencao;
		private System.Windows.Forms.Button btnViagem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Button btnRestaurar;
		private System.Windows.Forms.Button btnMinimizar;
		private System.Windows.Forms.Panel panelRodape;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Timer Relogio;
		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.Button btnAjuda;
		private System.Windows.Forms.Button btnTituloTela;
		private System.Windows.Forms.Label lblTituloTela;
		private System.Windows.Forms.Button btnSair;
	}
}