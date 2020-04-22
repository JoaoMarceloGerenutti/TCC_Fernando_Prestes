namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmEsqueciMinhaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEsqueciMinhaSenha));
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlCabeçalho = new System.Windows.Forms.Panel();
            this.lblEsqueciSenha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ibLogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTrocarSenha = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbSenhaNova = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.btnImage = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblNovaSenha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCodigo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ibMostrarSenha = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibMostrarCodigo = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibCodigo = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibNovaSenha = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ibEsconderCodigo = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibEsconderSenha = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlCabeçalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMostrarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMostrarCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibNovaSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibEsconderCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibEsconderSenha)).BeginInit();
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
            this.pnlCabeçalho.Controls.Add(this.lblEsqueciSenha);
            this.pnlCabeçalho.Controls.Add(this.ibLogin);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Size = new System.Drawing.Size(405, 58);
            this.pnlCabeçalho.TabIndex = 26;
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.AutoSize = true;
            this.lblEsqueciSenha.Enabled = false;
            this.lblEsqueciSenha.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueciSenha.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEsqueciSenha.Location = new System.Drawing.Point(67, 9);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(313, 38);
            this.lblEsqueciSenha.TabIndex = 2;
            this.lblEsqueciSenha.Text = "Esqueci Minha Senha";
            this.lblEsqueciSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibLogin
            // 
            this.ibLogin.BackColor = System.Drawing.Color.Transparent;
            this.ibLogin.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Exclamação;
            this.ibLogin.ImageActive = null;
            this.ibLogin.Location = new System.Drawing.Point(3, 3);
            this.ibLogin.Name = "ibLogin";
            this.ibLogin.Size = new System.Drawing.Size(58, 52);
            this.ibLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibLogin.TabIndex = 1;
            this.ibLogin.TabStop = false;
            this.ibLogin.Zoom = 10;
            // 
            // btnTrocarSenha
            // 
            this.btnTrocarSenha.ActiveBorderThickness = 1;
            this.btnTrocarSenha.ActiveCornerRadius = 20;
            this.btnTrocarSenha.ActiveFillColor = System.Drawing.Color.DarkViolet;
            this.btnTrocarSenha.ActiveForecolor = System.Drawing.Color.White;
            this.btnTrocarSenha.ActiveLineColor = System.Drawing.Color.White;
            this.btnTrocarSenha.BackColor = System.Drawing.Color.LightGray;
            this.btnTrocarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrocarSenha.BackgroundImage")));
            this.btnTrocarSenha.ButtonText = "Trocar senha";
            this.btnTrocarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrocarSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarSenha.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnTrocarSenha.IdleBorderThickness = 1;
            this.btnTrocarSenha.IdleCornerRadius = 20;
            this.btnTrocarSenha.IdleFillColor = System.Drawing.Color.Gray;
            this.btnTrocarSenha.IdleForecolor = System.Drawing.Color.Black;
            this.btnTrocarSenha.IdleLineColor = System.Drawing.Color.Black;
            this.btnTrocarSenha.Location = new System.Drawing.Point(14, 260);
            this.btnTrocarSenha.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrocarSenha.Name = "btnTrocarSenha";
            this.btnTrocarSenha.Size = new System.Drawing.Size(181, 41);
            this.btnTrocarSenha.TabIndex = 32;
            this.btnTrocarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrocarSenha.Click += new System.EventHandler(this.btnTrocarSenha_Click);
            // 
            // txbSenhaNova
            // 
            this.txbSenhaNova.BackColor = System.Drawing.Color.DimGray;
            this.txbSenhaNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaNova.Location = new System.Drawing.Point(74, 108);
            this.txbSenhaNova.Name = "txbSenhaNova";
            this.txbSenhaNova.Size = new System.Drawing.Size(167, 29);
            this.txbSenhaNova.TabIndex = 74;
            this.txbSenhaNova.UseSystemPasswordChar = true;
            // 
            // txbCodigo
            // 
            this.txbCodigo.BackColor = System.Drawing.Color.DimGray;
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(74, 190);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(167, 29);
            this.txbCodigo.TabIndex = 75;
            this.txbCodigo.UseSystemPasswordChar = true;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.DarkViolet;
            this.btnImage.color = System.Drawing.Color.DarkViolet;
            this.btnImage.colorActive = System.Drawing.Color.DarkViolet;
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.ImagePosition = 20;
            this.btnImage.ImageZoom = 50;
            this.btnImage.LabelPosition = 41;
            this.btnImage.LabelText = "Célia";
            this.btnImage.Location = new System.Drawing.Point(259, 67);
            this.btnImage.Margin = new System.Windows.Forms.Padding(6);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(131, 152);
            this.btnImage.TabIndex = 76;
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.BackColor = System.Drawing.Color.LightGray;
            this.lblNovaSenha.Enabled = false;
            this.lblNovaSenha.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.ForeColor = System.Drawing.Color.Purple;
            this.lblNovaSenha.Location = new System.Drawing.Point(67, 70);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(180, 38);
            this.lblNovaSenha.TabIndex = 3;
            this.lblNovaSenha.Text = "Nova senha";
            this.lblNovaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.LightGray;
            this.lblCodigo.Enabled = false;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Purple;
            this.lblCodigo.Location = new System.Drawing.Point(104, 149);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(118, 38);
            this.lblCodigo.TabIndex = 77;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibMostrarSenha
            // 
            this.ibMostrarSenha.BackColor = System.Drawing.Color.DimGray;
            this.ibMostrarSenha.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Mostrar;
            this.ibMostrarSenha.ImageActive = null;
            this.ibMostrarSenha.Location = new System.Drawing.Point(219, 113);
            this.ibMostrarSenha.Name = "ibMostrarSenha";
            this.ibMostrarSenha.Size = new System.Drawing.Size(18, 19);
            this.ibMostrarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibMostrarSenha.TabIndex = 78;
            this.ibMostrarSenha.TabStop = false;
            this.ibMostrarSenha.Zoom = 10;
            this.ibMostrarSenha.Click += new System.EventHandler(this.ibMostrarSenha_Click);
            // 
            // ibMostrarCodigo
            // 
            this.ibMostrarCodigo.BackColor = System.Drawing.Color.DimGray;
            this.ibMostrarCodigo.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Mostrar;
            this.ibMostrarCodigo.ImageActive = null;
            this.ibMostrarCodigo.Location = new System.Drawing.Point(219, 195);
            this.ibMostrarCodigo.Name = "ibMostrarCodigo";
            this.ibMostrarCodigo.Size = new System.Drawing.Size(18, 19);
            this.ibMostrarCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibMostrarCodigo.TabIndex = 79;
            this.ibMostrarCodigo.TabStop = false;
            this.ibMostrarCodigo.Zoom = 10;
            this.ibMostrarCodigo.Click += new System.EventHandler(this.ibMostrarCodigo_Click);
            // 
            // ibCodigo
            // 
            this.ibCodigo.BackColor = System.Drawing.Color.Gray;
            this.ibCodigo.Enabled = false;
            this.ibCodigo.Image = ((System.Drawing.Image)(resources.GetObject("ibCodigo.Image")));
            this.ibCodigo.ImageActive = null;
            this.ibCodigo.Location = new System.Drawing.Point(26, 190);
            this.ibCodigo.Name = "ibCodigo";
            this.ibCodigo.Size = new System.Drawing.Size(35, 29);
            this.ibCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibCodigo.TabIndex = 80;
            this.ibCodigo.TabStop = false;
            this.ibCodigo.Zoom = 10;
            // 
            // ibNovaSenha
            // 
            this.ibNovaSenha.BackColor = System.Drawing.Color.Gray;
            this.ibNovaSenha.Enabled = false;
            this.ibNovaSenha.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Cadeado1;
            this.ibNovaSenha.ImageActive = null;
            this.ibNovaSenha.Location = new System.Drawing.Point(26, 108);
            this.ibNovaSenha.Name = "ibNovaSenha";
            this.ibNovaSenha.Size = new System.Drawing.Size(35, 29);
            this.ibNovaSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibNovaSenha.TabIndex = 81;
            this.ibNovaSenha.TabStop = false;
            this.ibNovaSenha.Zoom = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.Gray;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.Black;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(209, 260);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 41);
            this.btnCancelar.TabIndex = 82;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ibEsconderCodigo
            // 
            this.ibEsconderCodigo.BackColor = System.Drawing.Color.DimGray;
            this.ibEsconderCodigo.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Esconder;
            this.ibEsconderCodigo.ImageActive = null;
            this.ibEsconderCodigo.Location = new System.Drawing.Point(219, 195);
            this.ibEsconderCodigo.Name = "ibEsconderCodigo";
            this.ibEsconderCodigo.Size = new System.Drawing.Size(18, 19);
            this.ibEsconderCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibEsconderCodigo.TabIndex = 83;
            this.ibEsconderCodigo.TabStop = false;
            this.ibEsconderCodigo.Visible = false;
            this.ibEsconderCodigo.Zoom = 10;
            this.ibEsconderCodigo.Click += new System.EventHandler(this.ibEsconderCodigo_Click);
            // 
            // ibEsconderSenha
            // 
            this.ibEsconderSenha.BackColor = System.Drawing.Color.DimGray;
            this.ibEsconderSenha.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Esconder;
            this.ibEsconderSenha.ImageActive = null;
            this.ibEsconderSenha.Location = new System.Drawing.Point(219, 113);
            this.ibEsconderSenha.Name = "ibEsconderSenha";
            this.ibEsconderSenha.Size = new System.Drawing.Size(18, 19);
            this.ibEsconderSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibEsconderSenha.TabIndex = 84;
            this.ibEsconderSenha.TabStop = false;
            this.ibEsconderSenha.Visible = false;
            this.ibEsconderSenha.Zoom = 10;
            this.ibEsconderSenha.Click += new System.EventHandler(this.ibEsconderSenha_Click);
            // 
            // FrmEsqueciMinhaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(405, 315);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.ibNovaSenha);
            this.Controls.Add(this.ibCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnTrocarSenha);
            this.Controls.Add(this.pnlCabeçalho);
            this.Controls.Add(this.ibMostrarSenha);
            this.Controls.Add(this.ibEsconderSenha);
            this.Controls.Add(this.ibMostrarCodigo);
            this.Controls.Add(this.ibEsconderCodigo);
            this.Controls.Add(this.txbSenhaNova);
            this.Controls.Add(this.txbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEsqueciMinhaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Esqueci minha senha";
            this.pnlCabeçalho.ResumeLayout(false);
            this.pnlCabeçalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMostrarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMostrarCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibNovaSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibEsconderCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibEsconderSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private System.Windows.Forms.Panel pnlCabeçalho;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEsqueciSenha;
        private Bunifu.Framework.UI.BunifuImageButton ibLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTrocarSenha;
        private System.Windows.Forms.TextBox txbSenhaNova;
        private System.Windows.Forms.TextBox txbCodigo;
        private Bunifu.Framework.UI.BunifuTileButton btnImage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNovaSenha;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCodigo;
        private Bunifu.Framework.UI.BunifuImageButton ibMostrarCodigo;
        private Bunifu.Framework.UI.BunifuImageButton ibMostrarSenha;
        private Bunifu.Framework.UI.BunifuImageButton ibNovaSenha;
        private Bunifu.Framework.UI.BunifuImageButton ibCodigo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuImageButton ibEsconderCodigo;
        private Bunifu.Framework.UI.BunifuImageButton ibEsconderSenha;
    }
}