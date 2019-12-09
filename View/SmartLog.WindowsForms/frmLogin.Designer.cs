namespace SmartLog.WindowsForms
{
	partial class frmLogin
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
			this.linkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.panelCabecalho = new System.Windows.Forms.Panel();
			this.btnFechar = new System.Windows.Forms.Button();
			this.pnlLogin = new System.Windows.Forms.Panel();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.picLogoLogin = new System.Windows.Forms.PictureBox();
			this.panelRodape = new System.Windows.Forms.Panel();
			this.panelCabecalho.SuspendLayout();
			this.pnlLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).BeginInit();
			this.SuspendLayout();
			// 
			// linkEsqueceuSenha
			// 
			this.linkEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.linkEsqueceuSenha.AutoSize = true;
			this.linkEsqueceuSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkEsqueceuSenha.Location = new System.Drawing.Point(196, 118);
			this.linkEsqueceuSenha.Name = "linkEsqueceuSenha";
			this.linkEsqueceuSenha.Size = new System.Drawing.Size(129, 15);
			this.linkEsqueceuSenha.TabIndex = 3;
			this.linkEsqueceuSenha.TabStop = true;
			this.linkEsqueceuSenha.Text = "Esqueceu sua senha?";
			this.linkEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEsqueceuSenha_LinkClicked);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnLogin.Location = new System.Drawing.Point(96, 150);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(229, 35);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.ForeColor = System.Drawing.Color.Black;
			this.lblSenha.Location = new System.Drawing.Point(92, 66);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(61, 20);
			this.lblSenha.TabIndex = 5;
			this.lblSenha.Text = "Senha";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.Color.Black;
			this.lblUsuario.Location = new System.Drawing.Point(92, 17);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(71, 20);
			this.lblUsuario.TabIndex = 6;
			this.lblUsuario.Text = "Usuário";
			// 
			// panelCabecalho
			// 
			this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.panelCabecalho.Controls.Add(this.btnFechar);
			this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
			this.panelCabecalho.Name = "panelCabecalho";
			this.panelCabecalho.Size = new System.Drawing.Size(590, 45);
			this.panelCabecalho.TabIndex = 7;
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
			this.btnFechar.Location = new System.Drawing.Point(543, 3);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(35, 36);
			this.btnFechar.TabIndex = 0;
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// pnlLogin
			// 
			this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.pnlLogin.Controls.Add(this.txtSenha);
			this.pnlLogin.Controls.Add(this.txtUsuario);
			this.pnlLogin.Controls.Add(this.lblUsuario);
			this.pnlLogin.Controls.Add(this.lblSenha);
			this.pnlLogin.Controls.Add(this.linkEsqueceuSenha);
			this.pnlLogin.Controls.Add(this.btnLogin);
			this.pnlLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pnlLogin.Location = new System.Drawing.Point(78, 223);
			this.pnlLogin.Name = "pnlLogin";
			this.pnlLogin.Size = new System.Drawing.Size(426, 198);
			this.pnlLogin.TabIndex = 8;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(96, 89);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(229, 26);
			this.txtSenha.TabIndex = 2;
			this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
			this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(96, 40);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(229, 26);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
			this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
			// 
			// picLogoLogin
			// 
			this.picLogoLogin.BackColor = System.Drawing.Color.Transparent;
			this.picLogoLogin.Image = global::SmartLog.WindowsForms.Properties.Resources.Logo;
			this.picLogoLogin.Location = new System.Drawing.Point(157, 37);
			this.picLogoLogin.Name = "picLogoLogin";
			this.picLogoLogin.Size = new System.Drawing.Size(265, 211);
			this.picLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogoLogin.TabIndex = 9;
			this.picLogoLogin.TabStop = false;
			// 
			// panelRodape
			// 
			this.panelRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelRodape.ForeColor = System.Drawing.Color.White;
			this.panelRodape.Location = new System.Drawing.Point(0, 439);
			this.panelRodape.Name = "panelRodape";
			this.panelRodape.Size = new System.Drawing.Size(590, 35);
			this.panelRodape.TabIndex = 10;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
			this.ClientSize = new System.Drawing.Size(590, 474);
			this.Controls.Add(this.panelRodape);
			this.Controls.Add(this.pnlLogin);
			this.Controls.Add(this.panelCabecalho);
			this.Controls.Add(this.picLogoLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acesso";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.panelCabecalho.ResumeLayout(false);
			this.pnlLogin.ResumeLayout(false);
			this.pnlLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.LinkLabel linkEsqueceuSenha;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Panel panelCabecalho;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Panel pnlLogin;
		private System.Windows.Forms.PictureBox picLogoLogin;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Panel panelRodape;
	}
}