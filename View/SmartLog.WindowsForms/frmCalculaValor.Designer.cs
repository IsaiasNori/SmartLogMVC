namespace SmartLog.WindowsForms
{
    partial class frmCalculaValor
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
			this.gbRecuperarSenha = new System.Windows.Forms.GroupBox();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtTotal = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtValorKM = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDistancia = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCombustivel = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.lblValorPedagio = new System.Windows.Forms.Label();
			this.txtPedagio = new SmartLog.WindowsForms.UserControl.SuperTextbox();
			this.panelCabecalho = new System.Windows.Forms.Panel();
			this.btnFechar = new System.Windows.Forms.Button();
			this.lblTituloTela = new System.Windows.Forms.Label();
			this.panelRodape = new System.Windows.Forms.Panel();
			this.toolTipCalculaViagem = new System.Windows.Forms.ToolTip(this.components);
			this.gbRecuperarSenha.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelCabecalho.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbRecuperarSenha
			// 
			this.gbRecuperarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gbRecuperarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.gbRecuperarSenha.Controls.Add(this.btnEnviar);
			this.gbRecuperarSenha.Controls.Add(this.panel1);
			this.gbRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRecuperarSenha.Location = new System.Drawing.Point(31, 56);
			this.gbRecuperarSenha.Name = "gbRecuperarSenha";
			this.gbRecuperarSenha.Size = new System.Drawing.Size(461, 338);
			this.gbRecuperarSenha.TabIndex = 1;
			this.gbRecuperarSenha.TabStop = false;
			this.gbRecuperarSenha.Text = "Calcular valor da viagem";
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
			this.btnEnviar.Location = new System.Drawing.Point(159, 293);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(148, 39);
			this.btnEnviar.TabIndex = 4;
			this.btnEnviar.Text = "Calcular";
			this.toolTipCalculaViagem.SetToolTip(this.btnEnviar, "Clique aqui, para calcular o valor da viagem.");
			this.btnEnviar.UseVisualStyleBackColor = false;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(219)))));
			this.panel1.Controls.Add(this.txtTotal);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtValorKM);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtDistancia);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtCombustivel);
			this.panel1.Controls.Add(this.lblValorPedagio);
			this.panel1.Controls.Add(this.txtPedagio);
			this.panel1.Location = new System.Drawing.Point(28, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 245);
			this.panel1.TabIndex = 4;
			this.toolTipCalculaViagem.SetToolTip(this.panel1, "Informe os valores para calcular o valor da viagem.");
			// 
			// txtTotal
			// 
			this.txtTotal.CampoObrigatorio = false;
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(243, 182);
			this.txtTotal.MensagemObrigatorio = "Calcular o Total";
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(154, 26);
			this.txtTotal.TabIndex = 9;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtTotal.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.numerosDecimais;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(239, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Total";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(20, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Valor por KM";
			// 
			// txtValorKM
			// 
			this.txtValorKM.CampoObrigatorio = true;
			this.txtValorKM.Location = new System.Drawing.Point(23, 182);
			this.txtValorKM.MensagemObrigatorio = "Informe o valor a ser cobrado por cada KM.";
			this.txtValorKM.Name = "txtValorKM";
			this.txtValorKM.Size = new System.Drawing.Size(155, 26);
			this.txtValorKM.TabIndex = 7;
			this.txtValorKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtValorKM.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.numerosDecimais;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(21, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Distância";
			// 
			// txtDistancia
			// 
			this.txtDistancia.CampoObrigatorio = true;
			this.txtDistancia.Location = new System.Drawing.Point(25, 132);
			this.txtDistancia.MensagemObrigatorio = "Informe a distância da viagem.  (em km)";
			this.txtDistancia.Name = "txtDistancia";
			this.txtDistancia.Size = new System.Drawing.Size(154, 26);
			this.txtDistancia.TabIndex = 3;
			this.txtDistancia.Text = "0";
			this.txtDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtDistancia.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.numerosInteiros;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(20, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Valor Combustível";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtCombustivel
			// 
			this.txtCombustivel.CampoObrigatorio = false;
			this.txtCombustivel.Location = new System.Drawing.Point(24, 80);
			this.txtCombustivel.MensagemObrigatorio = "Informe o valor do combustível.";
			this.txtCombustivel.Name = "txtCombustivel";
			this.txtCombustivel.Size = new System.Drawing.Size(154, 26);
			this.txtCombustivel.TabIndex = 2;
			this.txtCombustivel.Text = "0,00";
			this.txtCombustivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtCombustivel.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.numerosDecimais;
			// 
			// lblValorPedagio
			// 
			this.lblValorPedagio.AutoSize = true;
			this.lblValorPedagio.BackColor = System.Drawing.Color.Transparent;
			this.lblValorPedagio.Location = new System.Drawing.Point(19, 7);
			this.lblValorPedagio.Name = "lblValorPedagio";
			this.lblValorPedagio.Size = new System.Drawing.Size(108, 20);
			this.lblValorPedagio.TabIndex = 1;
			this.lblValorPedagio.Text = "Valor Pedágio";
			// 
			// txtPedagio
			// 
			this.txtPedagio.CampoObrigatorio = false;
			this.txtPedagio.Location = new System.Drawing.Point(23, 30);
			this.txtPedagio.MensagemObrigatorio = "Informe o Valor do pedágio.";
			this.txtPedagio.Name = "txtPedagio";
			this.txtPedagio.Size = new System.Drawing.Size(155, 26);
			this.txtPedagio.TabIndex = 1;
			this.txtPedagio.Text = "0,00";
			this.txtPedagio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtPedagio.tipoTextbox = SmartLog.WindowsForms.UserControl.etipoTextbox.numerosDecimais;
			// 
			// panelCabecalho
			// 
			this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.panelCabecalho.Controls.Add(this.btnFechar);
			this.panelCabecalho.Controls.Add(this.lblTituloTela);
			this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
			this.panelCabecalho.Name = "panelCabecalho";
			this.panelCabecalho.Size = new System.Drawing.Size(527, 35);
			this.panelCabecalho.TabIndex = 2;
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
			this.btnFechar.Location = new System.Drawing.Point(491, 0);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(33, 34);
			this.btnFechar.TabIndex = 6;
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTipCalculaViagem.SetToolTip(this.btnFechar, "Fechar esta janela.");
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
			// 
			// lblTituloTela
			// 
			this.lblTituloTela.AutoSize = true;
			this.lblTituloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
			this.lblTituloTela.Location = new System.Drawing.Point(12, 9);
			this.lblTituloTela.Name = "lblTituloTela";
			this.lblTituloTela.Size = new System.Drawing.Size(170, 24);
			this.lblTituloTela.TabIndex = 5;
			this.lblTituloTela.Text = "Cálculo de Viagem";
			// 
			// panelRodape
			// 
			this.panelRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
			this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelRodape.ForeColor = System.Drawing.Color.White;
			this.panelRodape.Location = new System.Drawing.Point(0, 400);
			this.panelRodape.Name = "panelRodape";
			this.panelRodape.Size = new System.Drawing.Size(527, 35);
			this.panelRodape.TabIndex = 3;
			// 
			// toolTipCalculaViagem
			// 
			this.toolTipCalculaViagem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// frmCalculaValor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(146)))), ((int)(((byte)(208)))));
			this.ClientSize = new System.Drawing.Size(527, 435);
			this.Controls.Add(this.panelRodape);
			this.Controls.Add(this.panelCabecalho);
			this.Controls.Add(this.gbRecuperarSenha);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCalculaValor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmRecuperarSenha";
			this.gbRecuperarSenha.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelCabecalho.ResumeLayout(false);
			this.panelCabecalho.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRecuperarSenha;
        private System.Windows.Forms.Label lblValorPedagio;
        private UserControl.SuperTextbox txtPedagio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label lblTituloTela;
        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Label label1;
        private UserControl.SuperTextbox txtCombustivel;
        private System.Windows.Forms.Label label2;
        private UserControl.SuperTextbox txtDistancia;
        private System.Windows.Forms.Label label3;
        private UserControl.SuperTextbox txtValorKM;
        private UserControl.SuperTextbox txtTotal;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.ToolTip toolTipCalculaViagem;
	}
}