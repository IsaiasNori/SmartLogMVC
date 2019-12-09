namespace SmartLog.WindowsForms
{
	partial class frmMensagem
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
			this.lblMensagem = new System.Windows.Forms.Label();
			this.panelMensagem = new System.Windows.Forms.Panel();
			this.btnIcon = new System.Windows.Forms.Button();
			this.toolStripTop = new System.Windows.Forms.ToolStrip();
			this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
			this.toolStripBelow = new System.Windows.Forms.ToolStrip();
			this.btnOK = new System.Windows.Forms.Button();
			this.panelMensagem.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblMensagem
			// 
			this.lblMensagem.AutoEllipsis = true;
			this.lblMensagem.AutoSize = true;
			this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensagem.ForeColor = System.Drawing.Color.Black;
			this.lblMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMensagem.Location = new System.Drawing.Point(85, 10);
			this.lblMensagem.Name = "lblMensagem";
			this.lblMensagem.Size = new System.Drawing.Size(267, 120);
			this.lblMensagem.TabIndex = 0;
			this.lblMensagem.Text = "Informar o nome\r\nInformar a Data de Nascimento\r\nInformar Rua \r\nInformar Estado\r\nI" +
    "nformar a Cidade\r\n";
			this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelMensagem
			// 
			this.panelMensagem.AutoScroll = true;
			this.panelMensagem.Controls.Add(this.btnIcon);
			this.panelMensagem.Controls.Add(this.lblMensagem);
			this.panelMensagem.Location = new System.Drawing.Point(20, 30);
			this.panelMensagem.Margin = new System.Windows.Forms.Padding(2);
			this.panelMensagem.Name = "panelMensagem";
			this.panelMensagem.Size = new System.Drawing.Size(602, 162);
			this.panelMensagem.TabIndex = 2;
			// 
			// btnIcon
			// 
			this.btnIcon.BackColor = System.Drawing.Color.Transparent;
			this.btnIcon.FlatAppearance.BorderSize = 0;
			this.btnIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnIcon.Image = global::SmartLog.WindowsForms.Properties.Resources.iconAlert;
			this.btnIcon.Location = new System.Drawing.Point(2, 2);
			this.btnIcon.Margin = new System.Windows.Forms.Padding(2);
			this.btnIcon.Name = "btnIcon";
			this.btnIcon.Size = new System.Drawing.Size(84, 42);
			this.btnIcon.TabIndex = 6;
			this.btnIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIcon.UseVisualStyleBackColor = false;
			// 
			// toolStripTop
			// 
			this.toolStripTop.BackColor = System.Drawing.Color.Goldenrod;
			this.toolStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStripTop.Location = new System.Drawing.Point(0, 0);
			this.toolStripTop.Name = "toolStripTop";
			this.toolStripTop.Size = new System.Drawing.Size(633, 25);
			this.toolStripTop.TabIndex = 3;
			this.toolStripTop.Text = "toolStrip1";
			this.toolStripTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripTop_ItemClicked);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(125, 22);
			this.lblTitulo.Text = "Titulo Formulário";
			// 
			// toolStripBelow
			// 
			this.toolStripBelow.BackColor = System.Drawing.Color.Goldenrod;
			this.toolStripBelow.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStripBelow.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStripBelow.Location = new System.Drawing.Point(0, 267);
			this.toolStripBelow.Name = "toolStripBelow";
			this.toolStripBelow.Size = new System.Drawing.Size(633, 25);
			this.toolStripBelow.TabIndex = 4;
			this.toolStripBelow.Text = "toolStrip2";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.btnOK.FlatAppearance.BorderSize = 0;
			this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
			this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(181)))));
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.btnOK.Location = new System.Drawing.Point(262, 210);
			this.btnOK.Margin = new System.Windows.Forms.Padding(2);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(122, 37);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmMensagem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.ClientSize = new System.Drawing.Size(633, 292);
			this.ControlBox = false;
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.toolStripBelow);
			this.Controls.Add(this.toolStripTop);
			this.Controls.Add(this.panelMensagem);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMensagem";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMensagem";
			this.Load += new System.EventHandler(this.frmMensagem_Load);
			this.panelMensagem.ResumeLayout(false);
			this.panelMensagem.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Panel panelMensagem;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripLabel lblTitulo;
        private System.Windows.Forms.ToolStrip toolStripBelow;
        private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnIcon;
	}
}