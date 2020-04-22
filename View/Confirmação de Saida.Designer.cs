namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmConfirmacaoDeSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmacaoDeSaida));
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlCabeçalho = new System.Windows.Forms.Panel();
            this.lblNumeros = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSaindo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tmrSair = new System.Windows.Forms.Timer(this.components);
            this.tmr4 = new System.Windows.Forms.Timer(this.components);
            this.tmr3 = new System.Windows.Forms.Timer(this.components);
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.tmr0 = new System.Windows.Forms.Timer(this.components);
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSair = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlCabeçalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // pnlCabeçalho
            // 
            this.pnlCabeçalho.BackColor = System.Drawing.Color.Purple;
            this.pnlCabeçalho.Controls.Add(this.lblNumeros);
            this.pnlCabeçalho.Controls.Add(this.lblSaindo);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Size = new System.Drawing.Size(279, 58);
            this.pnlCabeçalho.TabIndex = 26;
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeros.Enabled = false;
            this.lblNumeros.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblNumeros.Location = new System.Drawing.Point(193, 8);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(35, 43);
            this.lblNumeros.TabIndex = 3;
            this.lblNumeros.Text = "5";
            this.lblNumeros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaindo
            // 
            this.lblSaindo.AutoSize = true;
            this.lblSaindo.Enabled = false;
            this.lblSaindo.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaindo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblSaindo.Location = new System.Drawing.Point(12, 7);
            this.lblSaindo.Name = "lblSaindo";
            this.lblSaindo.Size = new System.Drawing.Size(190, 43);
            this.lblSaindo.TabIndex = 2;
            this.lblSaindo.Text = "Saindo em ...";
            this.lblSaindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSair
            // 
            this.tmrSair.Enabled = true;
            this.tmrSair.Interval = 5100;
            this.tmrSair.Tick += new System.EventHandler(this.TmrSair_Tick);
            // 
            // tmr4
            // 
            this.tmr4.Enabled = true;
            this.tmr4.Interval = 900;
            this.tmr4.Tick += new System.EventHandler(this.Tmr4_Tick);
            // 
            // tmr3
            // 
            this.tmr3.Interval = 900;
            this.tmr3.Tick += new System.EventHandler(this.Tmr3_Tick);
            // 
            // tmr2
            // 
            this.tmr2.Interval = 900;
            this.tmr2.Tick += new System.EventHandler(this.Tmr2_Tick);
            // 
            // tmr1
            // 
            this.tmr1.Interval = 900;
            this.tmr1.Tick += new System.EventHandler(this.Tmr1_Tick);
            // 
            // tmr0
            // 
            this.tmr0.Interval = 900;
            this.tmr0.Tick += new System.EventHandler(this.Tmr0_Tick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.Silver;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.White;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(52, 107);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 41);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.ActiveBorderThickness = 1;
            this.btnSair.ActiveCornerRadius = 20;
            this.btnSair.ActiveFillColor = System.Drawing.Color.DarkViolet;
            this.btnSair.ActiveForecolor = System.Drawing.Color.White;
            this.btnSair.ActiveLineColor = System.Drawing.Color.White;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.ButtonText = "Sair";
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.IdleBorderThickness = 1;
            this.btnSair.IdleCornerRadius = 20;
            this.btnSair.IdleFillColor = System.Drawing.Color.Silver;
            this.btnSair.IdleForecolor = System.Drawing.Color.White;
            this.btnSair.IdleLineColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(52, 66);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(181, 41);
            this.btnSair.TabIndex = 28;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Visible = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmConfirmacaoDeSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(279, 155);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlCabeçalho);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfirmacaoDeSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlCabeçalho.ResumeLayout(false);
            this.pnlCabeçalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private System.Windows.Forms.Panel pnlCabeçalho;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSaindo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNumeros;
        private System.Windows.Forms.Timer tmrSair;
        private System.Windows.Forms.Timer tmr4;
        private System.Windows.Forms.Timer tmr3;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Timer tmr0;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSair;
    }
}