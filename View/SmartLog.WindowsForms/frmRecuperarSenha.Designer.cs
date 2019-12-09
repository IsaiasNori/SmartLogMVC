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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlRedefinirSenha = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloTela = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtSenhaConfirm = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtNovaSenha = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtDataNasc = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtCpf = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.txtEmail = new SmartLog.WindowsForms.UserControl.SuperTextbox();
            this.gbRecuperarSenha.SuspendLayout();
            this.pnlRedefinirSenha.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRecuperarSenha
            // 
            this.gbRecuperarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbRecuperarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.gbRecuperarSenha.Controls.Add(this.btnEnviar);
            this.gbRecuperarSenha.Controls.Add(this.pnlRedefinirSenha);
            this.gbRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecuperarSenha.Location = new System.Drawing.Point(76, 188);
            this.gbRecuperarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRecuperarSenha.Name = "gbRecuperarSenha";
            this.gbRecuperarSenha.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRecuperarSenha.Size = new System.Drawing.Size(717, 454);
            this.gbRecuperarSenha.TabIndex = 1;
            this.gbRecuperarSenha.TabStop = false;
            this.gbRecuperarSenha.Text = "Redefinir Senha";
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
            this.btnEnviar.Location = new System.Drawing.Point(248, 354);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(197, 48);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pnlRedefinirSenha
            // 
            this.pnlRedefinirSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlRedefinirSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
            this.pnlRedefinirSenha.Controls.Add(this.label1);
            this.pnlRedefinirSenha.Controls.Add(this.txtSenhaConfirm);
            this.pnlRedefinirSenha.Controls.Add(this.lblSenha);
            this.pnlRedefinirSenha.Controls.Add(this.txtNovaSenha);
            this.pnlRedefinirSenha.Controls.Add(this.lblDataNasc);
            this.pnlRedefinirSenha.Controls.Add(this.txtDataNasc);
            this.pnlRedefinirSenha.Controls.Add(this.lblCpf);
            this.pnlRedefinirSenha.Controls.Add(this.txtCpf);
            this.pnlRedefinirSenha.Controls.Add(this.lblEmail);
            this.pnlRedefinirSenha.Controls.Add(this.txtEmail);
            this.pnlRedefinirSenha.Location = new System.Drawing.Point(64, 31);
            this.pnlRedefinirSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRedefinirSenha.Name = "pnlRedefinirSenha";
            this.pnlRedefinirSenha.Size = new System.Drawing.Size(587, 302);
            this.pnlRedefinirSenha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(305, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Confirme sua senha";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Location = new System.Drawing.Point(25, 214);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(117, 25);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Nova senha";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNasc.Location = new System.Drawing.Point(25, 148);
            this.lblDataNasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(185, 25);
            this.lblDataNasc.TabIndex = 7;
            this.lblDataNasc.Text = "Data de nascimento";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Location = new System.Drawing.Point(25, 77);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(173, 25);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "Confirme seu CPF";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(25, 13);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(188, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Confirme seu E-mail";
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            this.panelCabecalho.Controls.Add(this.lblTituloTela);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(855, 43);
            this.panelCabecalho.TabIndex = 2;
            // 
            // lblTituloTela
            // 
            this.lblTituloTela.AutoSize = true;
            this.lblTituloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.lblTituloTela.Location = new System.Drawing.Point(16, 6);
            this.lblTituloTela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloTela.Name = "lblTituloTela";
            this.lblTituloTela.Size = new System.Drawing.Size(202, 29);
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
            this.btnFechar.Location = new System.Drawing.Point(807, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(44, 42);
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
            this.panelRodape.Location = new System.Drawing.Point(0, 650);
            this.panelRodape.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(855, 43);
            this.panelRodape.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::SmartLog.WindowsForms.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(324, 36);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(197, 183);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // txtSenhaConfirm
            // 
            this.txtSenhaConfirm.CampoObrigatorio = true;
            this.txtSenhaConfirm.Location = new System.Drawing.Point(311, 243);
            this.txtSenhaConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaConfirm.MaxLength = 12;
            this.txtSenhaConfirm.MensagemObrigatorio = "Confirme a senha";
            this.txtSenhaConfirm.Name = "txtSenhaConfirm";
            this.txtSenhaConfirm.PasswordChar = '*';
            this.txtSenhaConfirm.Size = new System.Drawing.Size(228, 30);
            this.txtSenhaConfirm.TabIndex = 10;
            this.txtSenhaConfirm.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.CampoObrigatorio = true;
            this.txtNovaSenha.Location = new System.Drawing.Point(31, 243);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtNovaSenha.MaxLength = 12;
            this.txtNovaSenha.MensagemObrigatorio = "Informe sua nova senha. Máximo 12 caracteres";
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(228, 30);
            this.txtNovaSenha.TabIndex = 8;
            this.txtNovaSenha.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.CampoObrigatorio = true;
            this.txtDataNasc.Location = new System.Drawing.Point(31, 176);
            this.txtDataNasc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataNasc.MaxLength = 10;
            this.txtDataNasc.MensagemObrigatorio = "Confirme sua data de nascimento";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(228, 30);
            this.txtDataNasc.TabIndex = 6;
            this.txtDataNasc.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.data;
            // 
            // txtCpf
            // 
            this.txtCpf.CampoObrigatorio = true;
            this.txtCpf.Location = new System.Drawing.Point(31, 105);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.MensagemObrigatorio = "Por favor, informe seu CPF";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(228, 30);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.cpf;
            // 
            // txtEmail
            // 
            this.txtEmail.CampoObrigatorio = true;
            this.txtEmail.Location = new System.Drawing.Point(31, 41);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MensagemObrigatorio = "É obrigatório informar seu e-mail, para recuperar o acesso ao sistema.";
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(397, 30);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.normal;
            // 
            // frmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(855, 693);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.gbRecuperarSenha);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecuperarSenha";
            this.gbRecuperarSenha.ResumeLayout(false);
            this.pnlRedefinirSenha.ResumeLayout(false);
            this.pnlRedefinirSenha.PerformLayout();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbRecuperarSenha;
		private System.Windows.Forms.Label lblEmail;
		private UserControl.SuperTextbox txtEmail;
		private System.Windows.Forms.Panel pnlRedefinirSenha;
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
		private System.Windows.Forms.PictureBox picLogo;
	}
}