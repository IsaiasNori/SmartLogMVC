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
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripBelow = new System.Windows.Forms.ToolStrip();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panelMensagem.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMensagem.Location = new System.Drawing.Point(34, 25);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(272, 100);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Informar o nome\r\nInformar a Data de Nascimento\r\nInformar Rua \r\nInformar Estado\r\nI" +
    "nformar a Cidade\r\n";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMensagem
            // 
            this.panelMensagem.AutoScroll = true;
            this.panelMensagem.Controls.Add(this.lblMensagem);
            this.panelMensagem.Location = new System.Drawing.Point(27, 37);
            this.panelMensagem.Name = "panelMensagem";
            this.panelMensagem.Size = new System.Drawing.Size(673, 200);
            this.panelMensagem.TabIndex = 2;
            // 
            // toolStripTop
            // 
            this.toolStripTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTitulo});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(724, 25);
            this.toolStripTop.TabIndex = 3;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // toolStripBelow
            // 
            this.toolStripBelow.BackColor = System.Drawing.Color.Red;
            this.toolStripBelow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripBelow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBelow.Location = new System.Drawing.Point(0, 334);
            this.toolStripBelow.Name = "toolStripBelow";
            this.toolStripBelow.Size = new System.Drawing.Size(724, 25);
            this.toolStripBelow.TabIndex = 4;
            this.toolStripBelow.Text = "toolStrip2";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 22);
            this.lblTitulo.Text = "Titulo Formulário";
            // 
            // btnOK
            // 
            this.btnOK.Image = global::SmartLog.WindowsForms.Properties.Resources.icon_sucess;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(241, 243);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(136, 76);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(724, 359);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.toolStripBelow);
            this.Controls.Add(this.toolStripTop);
            this.Controls.Add(this.panelMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMensagem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMensagem";
            this.Load += new System.EventHandler(this.frmMensagem_Load);
            this.panelMensagem.ResumeLayout(false);
            this.panelMensagem.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
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
    }
}