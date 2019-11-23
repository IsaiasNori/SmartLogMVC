namespace SmartLog.WindowsForms.DeskTopPresentation
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
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.panelCabecalho = new System.Windows.Forms.Panel();
			this.btnMinimizar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelCabecalho.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(114, 116);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(129, 15);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Esqueceu sua senha?";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.Black;
			this.btnLogin.Location = new System.Drawing.Point(66, 143);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(177, 30);
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
			this.lblSenha.Location = new System.Drawing.Point(63, 67);
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
			this.lblUsuario.Location = new System.Drawing.Point(63, 15);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(53, 20);
			this.lblUsuario.TabIndex = 6;
			this.lblUsuario.Text = "Email";
			// 
			// panelCabecalho
			// 
			this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.panelCabecalho.Controls.Add(this.btnMinimizar);
			this.panelCabecalho.Controls.Add(this.btnFechar);
			this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
			this.panelCabecalho.Name = "panelCabecalho";
			this.panelCabecalho.Size = new System.Drawing.Size(590, 45);
			this.panelCabecalho.TabIndex = 7;
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimizar.FlatAppearance.BorderSize = 0;
			this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
			this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimizar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_MinApplication;
			this.btnMinimizar.Location = new System.Drawing.Point(506, 7);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(31, 32);
			this.btnMinimizar.TabIndex = 3;
			this.btnMinimizar.UseVisualStyleBackColor = false;
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.BackColor = System.Drawing.Color.Transparent;
			this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnFechar.FlatAppearance.BorderSize = 0;
			this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.ForeColor = System.Drawing.Color.White;
			this.btnFechar.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_CloseApplication;
			this.btnFechar.Location = new System.Drawing.Point(543, 3);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(35, 36);
			this.btnFechar.TabIndex = 0;
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtSenha);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.lblUsuario);
			this.panel1.Controls.Add(this.lblSenha);
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel1.Location = new System.Drawing.Point(137, 197);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(312, 198);
			this.panel1.TabIndex = 8;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(66, 87);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(177, 26);
			this.txtSenha.TabIndex = 2;
			this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
			this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(66, 38);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(177, 26);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
			this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::SmartLog.WindowsForms.Properties.Resources.LogoV11_fw;
			this.pictureBox1.Location = new System.Drawing.Point(221, 63);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(141, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 432);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelCabecalho);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acesso";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.panelCabecalho.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Panel panelCabecalho;
		private System.Windows.Forms.Button btnMinimizar;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtUsuario;
	}
}