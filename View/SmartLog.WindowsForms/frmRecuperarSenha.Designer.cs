namespace SmartLog.WindowsForms
{
	partial class frmRecuperarSenha
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
			this.gbRecuperarSenha = new System.Windows.Forms.GroupBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.panelCabecalho = new System.Windows.Forms.Panel();
			this.lblTituloTela = new System.Windows.Forms.Label();
			this.btnFechar = new System.Windows.Forms.Button();
			this.panelRodape = new System.Windows.Forms.Panel();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblDataNasc = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtSenhaConfirm = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNovaSenha = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtDataNasc = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtCpf = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtNome = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.txtEmail = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.gbRecuperarSenha.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelCabecalho.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbRecuperarSenha
			// 
			this.gbRecuperarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gbRecuperarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.gbRecuperarSenha.Controls.Add(this.btnEnviar);
			this.gbRecuperarSenha.Controls.Add(this.panel1);
			this.gbRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRecuperarSenha.Location = new System.Drawing.Point(51, 131);
			this.gbRecuperarSenha.Name = "gbRecuperarSenha";
			this.gbRecuperarSenha.Size = new System.Drawing.Size(538, 364);
			this.gbRecuperarSenha.TabIndex = 1;
			this.gbRecuperarSenha.TabStop = false;
			this.gbRecuperarSenha.Text = "Redefinir Senha";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.BackColor = System.Drawing.Color.Transparent;
			this.lblNome.Location = new System.Drawing.Point(19, 7);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(51, 20);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Nome";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.BackColor = System.Drawing.Color.Transparent;
			this.lblEmail.Location = new System.Drawing.Point(19, 59);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(151, 20);
			this.lblEmail.TabIndex = 3;
			this.lblEmail.Text = "Confirme seu E-mail";
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtSenhaConfirm);
			this.panel1.Controls.Add(this.lblSenha);
			this.panel1.Controls.Add(this.txtNovaSenha);
			this.panel1.Controls.Add(this.lblDataNasc);
			this.panel1.Controls.Add(this.txtDataNasc);
			this.panel1.Controls.Add(this.lblCpf);
			this.panel1.Controls.Add(this.txtCpf);
			this.panel1.Controls.Add(this.lblNome);
			this.panel1.Controls.Add(this.lblEmail);
			this.panel1.Controls.Add(this.txtNome);
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Location = new System.Drawing.Point(53, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 288);
			this.panel1.TabIndex = 4;
			// 
			// btnEnviar
			// 
			this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnEnviar.FlatAppearance.BorderSize = 0;
			this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnEnviar.Location = new System.Drawing.Point(194, 319);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(148, 39);
			this.btnEnviar.TabIndex = 5;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.UseVisualStyleBackColor = false;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// panelCabecalho
			// 
			this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.panelCabecalho.Controls.Add(this.lblTituloTela);
			this.panelCabecalho.Controls.Add(this.btnFechar);
			this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
			this.panelCabecalho.Name = "panelCabecalho";
			this.panelCabecalho.Size = new System.Drawing.Size(641, 35);
			this.panelCabecalho.TabIndex = 2;
			// 
			// lblTituloTela
			// 
			this.lblTituloTela.AutoSize = true;
			this.lblTituloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.lblTituloTela.Location = new System.Drawing.Point(12, 5);
			this.lblTituloTela.Name = "lblTituloTela";
			this.lblTituloTela.Size = new System.Drawing.Size(158, 24);
			this.lblTituloTela.TabIndex = 5;
			this.lblTituloTela.Text = "Acesso SmartLog";
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
			this.btnFechar.Location = new System.Drawing.Point(605, 1);
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
			this.panelRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelRodape.ForeColor = System.Drawing.Color.White;
			this.panelRodape.Location = new System.Drawing.Point(0, 528);
			this.panelRodape.Name = "panelRodape";
			this.panelRodape.Size = new System.Drawing.Size(641, 35);
			this.panelRodape.TabIndex = 3;
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.BackColor = System.Drawing.Color.Transparent;
			this.lblCpf.Location = new System.Drawing.Point(19, 111);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(138, 20);
			this.lblCpf.TabIndex = 5;
			this.lblCpf.Text = "Confirme seu CPF";
			// 
			// lblDataNasc
			// 
			this.lblDataNasc.AutoSize = true;
			this.lblDataNasc.BackColor = System.Drawing.Color.Transparent;
			this.lblDataNasc.Location = new System.Drawing.Point(19, 169);
			this.lblDataNasc.Name = "lblDataNasc";
			this.lblDataNasc.Size = new System.Drawing.Size(152, 20);
			this.lblDataNasc.TabIndex = 7;
			this.lblDataNasc.Text = "Data de nascimento";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(229, 223);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Confirme sua senha";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.BackColor = System.Drawing.Color.Transparent;
			this.lblSenha.Location = new System.Drawing.Point(19, 223);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(93, 20);
			this.lblSenha.TabIndex = 9;
			this.lblSenha.Text = "Nova senha";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = global::SmartLog.WindowsForms.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(641, 98);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// txtSenhaConfirm
			// 
			this.txtSenhaConfirm.CampoObrigatorio = true;
			this.txtSenhaConfirm.Location = new System.Drawing.Point(233, 246);
			this.txtSenhaConfirm.MaxLength = 12;
			this.txtSenhaConfirm.MensagemObrigatorio = "Confirme a senha";
			this.txtSenhaConfirm.Name = "txtSenhaConfirm";
			this.txtSenhaConfirm.PasswordChar = '*';
			this.txtSenhaConfirm.Size = new System.Drawing.Size(172, 26);
			this.txtSenhaConfirm.TabIndex = 10;
			this.txtSenhaConfirm.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtNovaSenha
			// 
			this.txtNovaSenha.CampoObrigatorio = true;
			this.txtNovaSenha.Location = new System.Drawing.Point(23, 246);
			this.txtNovaSenha.MaxLength = 12;
			this.txtNovaSenha.MensagemObrigatorio = "Informe sua nova senha. Máximo 12 caracteres";
			this.txtNovaSenha.Name = "txtNovaSenha";
			this.txtNovaSenha.PasswordChar = '*';
			this.txtNovaSenha.Size = new System.Drawing.Size(172, 26);
			this.txtNovaSenha.TabIndex = 8;
			this.txtNovaSenha.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// txtDataNasc
			// 
			this.txtDataNasc.CampoObrigatorio = true;
			this.txtDataNasc.Location = new System.Drawing.Point(23, 192);
			this.txtDataNasc.MensagemObrigatorio = "Confirme sua data de nascimento";
			this.txtDataNasc.Name = "txtDataNasc";
			this.txtDataNasc.Size = new System.Drawing.Size(172, 26);
			this.txtDataNasc.TabIndex = 6;
			this.txtDataNasc.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.data;
			// 
			// txtCpf
			// 
			this.txtCpf.CampoObrigatorio = true;
			this.txtCpf.Location = new System.Drawing.Point(23, 134);
			this.txtCpf.MensagemObrigatorio = "Por favor, informe seu CPF";
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(172, 26);
			this.txtCpf.TabIndex = 3;
			this.txtCpf.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
			// 
			// txtNome
			// 
			this.txtNome.CampoObrigatorio = true;
			this.txtNome.Location = new System.Drawing.Point(23, 30);
			this.txtNome.MensagemObrigatorio = "Por favor, informe seu nome.";
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(299, 26);
			this.txtNome.TabIndex = 1;
			this.txtNome.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.somenteLetra;
			// 
			// txtEmail
			// 
			this.txtEmail.CampoObrigatorio = true;
			this.txtEmail.Location = new System.Drawing.Point(23, 82);
			this.txtEmail.MensagemObrigatorio = "É obrigatório informar seu e-mail, para recuperar o acesso ao sistema.";
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(299, 26);
			this.txtEmail.TabIndex = 2;
			this.txtEmail.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
			// 
			// frmRecuperarSenha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.ClientSize = new System.Drawing.Size(641, 563);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panelRodape);
			this.Controls.Add(this.panelCabecalho);
			this.Controls.Add(this.gbRecuperarSenha);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmRecuperarSenha";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmRecuperarSenha";
			this.gbRecuperarSenha.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelCabecalho.ResumeLayout(false);
			this.panelCabecalho.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbRecuperarSenha;
		private System.Windows.Forms.Label lblEmail;
		private UserControl.SuperTextbox txtEmail;
		private System.Windows.Forms.Label lblNome;
		private UserControl.SuperTextbox txtNome;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.Panel panelCabecalho;
		private System.Windows.Forms.Label lblTituloTela;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Panel panelRodape;
		private System.Windows.Forms.Label lblCpf;
		private UserControl.SuperTextbox txtCpf;
		private System.Windows.Forms.Label label1;
		private UserControl.SuperTextbox txtSenhaConfirm;
		private System.Windows.Forms.Label lblSenha;
		private UserControl.SuperTextbox txtNovaSenha;
		private System.Windows.Forms.Label lblDataNasc;
		private UserControl.SuperTextbox txtDataNasc;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}