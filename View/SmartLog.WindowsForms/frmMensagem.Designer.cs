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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMensagem
			// 
			this.lblMensagem.AutoSize = true;
			this.lblMensagem.Location = new System.Drawing.Point(272, 68);
			this.lblMensagem.Name = "lblMensagem";
			this.lblMensagem.Size = new System.Drawing.Size(35, 13);
			this.lblMensagem.TabIndex = 0;
			this.lblMensagem.Text = "label1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.InitialImage = global::SmartLog.WindowsForms.Properties.Resources.icon_alert;
			this.pictureBox1.Location = new System.Drawing.Point(154, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// frmMensagem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 157);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblMensagem);
			this.Name = "frmMensagem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMensagem";
			this.Load += new System.EventHandler(this.frmMensagem_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMensagem;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}