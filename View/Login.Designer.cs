namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlCabeçalho = new System.Windows.Forms.Panel();
            this.ibMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ibLogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Movimento = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tmrSair = new System.Windows.Forms.Timer(this.components);
            this.lblEsqueciSenha = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnEsconder = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMostrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibCadeado = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnImage = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlCabeçalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibCadeado)).BeginInit();
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
            this.pnlCabeçalho.Controls.Add(this.ibMinimizar);
            this.pnlCabeçalho.Controls.Add(this.lblLogin);
            this.pnlCabeçalho.Controls.Add(this.ibLogin);
            this.pnlCabeçalho.Controls.Add(this.ibFechar);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Size = new System.Drawing.Size(577, 58);
            this.pnlCabeçalho.TabIndex = 25;
            // 
            // ibMinimizar
            // 
            this.ibMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.ibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibMinimizar.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Minimizar1;
            this.ibMinimizar.ImageActive = null;
            this.ibMinimizar.InitialImage = null;
            this.ibMinimizar.Location = new System.Drawing.Point(503, 14);
            this.ibMinimizar.Name = "ibMinimizar";
            this.ibMinimizar.Size = new System.Drawing.Size(28, 25);
            this.ibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibMinimizar.TabIndex = 3;
            this.ibMinimizar.TabStop = false;
            this.ibMinimizar.Zoom = 20;
            this.ibMinimizar.Click += new System.EventHandler(this.IbMinimizar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Enabled = false;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblLogin.Location = new System.Drawing.Point(78, 10);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(367, 38);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Espaço Da Beleza - Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibLogin
            // 
            this.ibLogin.BackColor = System.Drawing.Color.Transparent;
            this.ibLogin.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Login;
            this.ibLogin.ImageActive = null;
            this.ibLogin.Location = new System.Drawing.Point(3, 3);
            this.ibLogin.Name = "ibLogin";
            this.ibLogin.Size = new System.Drawing.Size(58, 52);
            this.ibLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibLogin.TabIndex = 1;
            this.ibLogin.TabStop = false;
            this.ibLogin.Zoom = 10;
            // 
            // ibFechar
            // 
            this.ibFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibFechar.BackColor = System.Drawing.Color.Transparent;
            this.ibFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibFechar.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Fechar;
            this.ibFechar.ImageActive = null;
            this.ibFechar.InitialImage = null;
            this.ibFechar.Location = new System.Drawing.Point(537, 14);
            this.ibFechar.Name = "ibFechar";
            this.ibFechar.Size = new System.Drawing.Size(28, 25);
            this.ibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibFechar.TabIndex = 0;
            this.ibFechar.TabStop = false;
            this.ibFechar.Zoom = 20;
            this.ibFechar.Click += new System.EventHandler(this.IbFechar_Click);
            // 
            // Movimento
            // 
            this.Movimento.Fixed = true;
            this.Movimento.Horizontal = true;
            this.Movimento.TargetControl = this.pnlCabeçalho;
            this.Movimento.Vertical = true;
            // 
            // tmrSair
            // 
            this.tmrSair.Interval = 5000;
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.AutoSize = true;
            this.lblEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueciSenha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEsqueciSenha.Location = new System.Drawing.Point(236, 397);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(108, 13);
            this.lblEsqueciSenha.TabIndex = 71;
            this.lblEsqueciSenha.Text = "Esqueci minha senha";
            this.lblEsqueciSenha.Click += new System.EventHandler(this.LblEsqueciSenha_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnLogin.Location = new System.Drawing.Point(210, 343);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 41);
            this.btnLogin.TabIndex = 72;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.DimGray;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(226, 298);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(167, 29);
            this.txbSenha.TabIndex = 73;
            this.txbSenha.UseSystemPasswordChar = true;
            this.txbSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSenha_KeyDown);
            // 
            // btnEsconder
            // 
            this.btnEsconder.BackColor = System.Drawing.Color.DimGray;
            this.btnEsconder.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Esconder;
            this.btnEsconder.ImageActive = null;
            this.btnEsconder.Location = new System.Drawing.Point(371, 303);
            this.btnEsconder.Name = "btnEsconder";
            this.btnEsconder.Size = new System.Drawing.Size(18, 19);
            this.btnEsconder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEsconder.TabIndex = 76;
            this.btnEsconder.TabStop = false;
            this.btnEsconder.Visible = false;
            this.btnEsconder.Zoom = 10;
            this.btnEsconder.Click += new System.EventHandler(this.BtnEsconder_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DimGray;
            this.btnMostrar.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Mostrar;
            this.btnMostrar.ImageActive = null;
            this.btnMostrar.Location = new System.Drawing.Point(371, 303);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(18, 19);
            this.btnMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMostrar.TabIndex = 75;
            this.btnMostrar.TabStop = false;
            this.btnMostrar.Zoom = 10;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // ibCadeado
            // 
            this.ibCadeado.BackColor = System.Drawing.Color.Gray;
            this.ibCadeado.Enabled = false;
            this.ibCadeado.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Cadeado1;
            this.ibCadeado.ImageActive = null;
            this.ibCadeado.Location = new System.Drawing.Point(185, 298);
            this.ibCadeado.Name = "ibCadeado";
            this.ibCadeado.Size = new System.Drawing.Size(35, 29);
            this.ibCadeado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibCadeado.TabIndex = 74;
            this.ibCadeado.TabStop = false;
            this.ibCadeado.Zoom = 10;
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
            this.btnImage.Location = new System.Drawing.Point(185, 93);
            this.btnImage.Margin = new System.Windows.Forms.Padding(6);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(208, 175);
            this.btnImage.TabIndex = 23;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.ibCadeado);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblEsqueciSenha);
            this.Controls.Add(this.pnlCabeçalho);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEsconder);
            this.Controls.Add(this.txbSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlCabeçalho.ResumeLayout(false);
            this.pnlCabeçalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibCadeado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private Bunifu.Framework.UI.BunifuTileButton btnImage;
        private System.Windows.Forms.Panel pnlCabeçalho;
        private Bunifu.Framework.UI.BunifuImageButton ibMinimizar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogin;
        private Bunifu.Framework.UI.BunifuImageButton ibLogin;
        private Bunifu.Framework.UI.BunifuImageButton ibFechar;
        private Bunifu.Framework.UI.BunifuDragControl Movimento;
        private System.Windows.Forms.Timer tmrSair;
        private System.Windows.Forms.Label lblEsqueciSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private Bunifu.Framework.UI.BunifuImageButton ibCadeado;
        private Bunifu.Framework.UI.BunifuImageButton btnEsconder;
        private Bunifu.Framework.UI.BunifuImageButton btnMostrar;
    }
}