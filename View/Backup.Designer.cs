namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Movimento = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlCabeçalho = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ibBackup = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblBackup = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ibFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.rbBackup = new System.Windows.Forms.RadioButton();
            this.btnCarregarGerar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLocalArquivo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rbCarregar = new System.Windows.Forms.RadioButton();
            this.pnlCabeçalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // Movimento
            // 
            this.Movimento.Fixed = true;
            this.Movimento.Horizontal = true;
            this.Movimento.TargetControl = this.pnlCabeçalho;
            this.Movimento.Vertical = true;
            // 
            // pnlCabeçalho
            // 
            this.pnlCabeçalho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCabeçalho.BackgroundImage")));
            this.pnlCabeçalho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCabeçalho.Controls.Add(this.ibBackup);
            this.pnlCabeçalho.Controls.Add(this.lblBackup);
            this.pnlCabeçalho.Controls.Add(this.ibFechar);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.GradientBottomLeft = System.Drawing.Color.Purple;
            this.pnlCabeçalho.GradientBottomRight = System.Drawing.Color.Purple;
            this.pnlCabeçalho.GradientTopLeft = System.Drawing.Color.White;
            this.pnlCabeçalho.GradientTopRight = System.Drawing.Color.Purple;
            this.pnlCabeçalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Quality = 10;
            this.pnlCabeçalho.Size = new System.Drawing.Size(217, 31);
            this.pnlCabeçalho.TabIndex = 39;
            // 
            // ibBackup
            // 
            this.ibBackup.BackColor = System.Drawing.Color.Transparent;
            this.ibBackup.Enabled = false;
            this.ibBackup.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Backup;
            this.ibBackup.ImageActive = null;
            this.ibBackup.Location = new System.Drawing.Point(11, 1);
            this.ibBackup.Name = "ibBackup";
            this.ibBackup.Size = new System.Drawing.Size(30, 28);
            this.ibBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibBackup.TabIndex = 51;
            this.ibBackup.TabStop = false;
            this.ibBackup.Zoom = 10;
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.BackColor = System.Drawing.Color.Transparent;
            this.lblBackup.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackup.ForeColor = System.Drawing.Color.Black;
            this.lblBackup.Location = new System.Drawing.Point(47, 1);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(85, 28);
            this.lblBackup.TabIndex = 36;
            this.lblBackup.Text = "Backup";
            this.lblBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibFechar
            // 
            this.ibFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibFechar.BackColor = System.Drawing.Color.Transparent;
            this.ibFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibFechar.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Fechar;
            this.ibFechar.ImageActive = null;
            this.ibFechar.InitialImage = null;
            this.ibFechar.Location = new System.Drawing.Point(185, 3);
            this.ibFechar.Name = "ibFechar";
            this.ibFechar.Size = new System.Drawing.Size(24, 25);
            this.ibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibFechar.TabIndex = 33;
            this.ibFechar.TabStop = false;
            this.ibFechar.Zoom = 20;
            this.ibFechar.Click += new System.EventHandler(this.IbFechar_Click);
            // 
            // rbBackup
            // 
            this.rbBackup.AutoSize = true;
            this.rbBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBackup.Location = new System.Drawing.Point(38, 53);
            this.rbBackup.Name = "rbBackup";
            this.rbBackup.Size = new System.Drawing.Size(126, 24);
            this.rbBackup.TabIndex = 90;
            this.rbBackup.Text = "Gerar Backup";
            this.rbBackup.UseVisualStyleBackColor = true;
            this.rbBackup.CheckedChanged += new System.EventHandler(this.RbBackup_CheckedChanged);
            // 
            // btnCarregarGerar
            // 
            this.btnCarregarGerar.Activecolor = System.Drawing.Color.Silver;
            this.btnCarregarGerar.BackColor = System.Drawing.Color.White;
            this.btnCarregarGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregarGerar.BorderRadius = 7;
            this.btnCarregarGerar.ButtonText = "Selecione uma Opção";
            this.btnCarregarGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarGerar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCarregarGerar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCarregarGerar.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.BackupPadrão;
            this.btnCarregarGerar.Iconimage_right = null;
            this.btnCarregarGerar.Iconimage_right_Selected = null;
            this.btnCarregarGerar.Iconimage_Selected = null;
            this.btnCarregarGerar.IconMarginLeft = 0;
            this.btnCarregarGerar.IconMarginRight = 0;
            this.btnCarregarGerar.IconRightVisible = true;
            this.btnCarregarGerar.IconRightZoom = 0D;
            this.btnCarregarGerar.IconVisible = true;
            this.btnCarregarGerar.IconZoom = 90D;
            this.btnCarregarGerar.IsTab = true;
            this.btnCarregarGerar.Location = new System.Drawing.Point(14, 177);
            this.btnCarregarGerar.Name = "btnCarregarGerar";
            this.btnCarregarGerar.Normalcolor = System.Drawing.Color.White;
            this.btnCarregarGerar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnCarregarGerar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCarregarGerar.selected = false;
            this.btnCarregarGerar.Size = new System.Drawing.Size(190, 43);
            this.btnCarregarGerar.TabIndex = 93;
            this.btnCarregarGerar.Text = "Selecione uma Opção";
            this.btnCarregarGerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCarregarGerar.Textcolor = System.Drawing.Color.Black;
            this.btnCarregarGerar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarGerar.Click += new System.EventHandler(this.btnCarregarGerar_Click);
            // 
            // btnLocalArquivo
            // 
            this.btnLocalArquivo.Activecolor = System.Drawing.Color.Silver;
            this.btnLocalArquivo.BackColor = System.Drawing.Color.White;
            this.btnLocalArquivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalArquivo.BorderRadius = 7;
            this.btnLocalArquivo.ButtonText = "Pasta             ";
            this.btnLocalArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalArquivo.DisabledColor = System.Drawing.Color.Red;
            this.btnLocalArquivo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLocalArquivo.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Icone;
            this.btnLocalArquivo.Iconimage_right = null;
            this.btnLocalArquivo.Iconimage_right_Selected = null;
            this.btnLocalArquivo.Iconimage_Selected = null;
            this.btnLocalArquivo.IconMarginLeft = 0;
            this.btnLocalArquivo.IconMarginRight = 0;
            this.btnLocalArquivo.IconRightVisible = true;
            this.btnLocalArquivo.IconRightZoom = 0D;
            this.btnLocalArquivo.IconVisible = true;
            this.btnLocalArquivo.IconZoom = 90D;
            this.btnLocalArquivo.IsTab = true;
            this.btnLocalArquivo.Location = new System.Drawing.Point(14, 128);
            this.btnLocalArquivo.Name = "btnLocalArquivo";
            this.btnLocalArquivo.Normalcolor = System.Drawing.Color.White;
            this.btnLocalArquivo.OnHovercolor = System.Drawing.Color.Silver;
            this.btnLocalArquivo.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnLocalArquivo.selected = false;
            this.btnLocalArquivo.Size = new System.Drawing.Size(190, 43);
            this.btnLocalArquivo.TabIndex = 87;
            this.btnLocalArquivo.Text = "Pasta             ";
            this.btnLocalArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLocalArquivo.Textcolor = System.Drawing.Color.Black;
            this.btnLocalArquivo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // rbCarregar
            // 
            this.rbCarregar.AutoSize = true;
            this.rbCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCarregar.Location = new System.Drawing.Point(38, 83);
            this.rbCarregar.Name = "rbCarregar";
            this.rbCarregar.Size = new System.Drawing.Size(146, 24);
            this.rbCarregar.TabIndex = 95;
            this.rbCarregar.Text = "Carregar Arquivo";
            this.rbCarregar.UseVisualStyleBackColor = true;
            this.rbCarregar.CheckedChanged += new System.EventHandler(this.RbCarregar_CheckedChanged);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(217, 230);
            this.Controls.Add(this.rbCarregar);
            this.Controls.Add(this.btnCarregarGerar);
            this.Controls.Add(this.rbBackup);
            this.Controls.Add(this.btnLocalArquivo);
            this.Controls.Add(this.pnlCabeçalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.pnlCabeçalho.ResumeLayout(false);
            this.pnlCabeçalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private Bunifu.Framework.UI.BunifuDragControl Movimento;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlCabeçalho;
        private Bunifu.Framework.UI.BunifuImageButton ibBackup;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBackup;
        private Bunifu.Framework.UI.BunifuImageButton ibFechar;
        private Bunifu.Framework.UI.BunifuFlatButton btnLocalArquivo;
        private System.Windows.Forms.RadioButton rbBackup;
        private Bunifu.Framework.UI.BunifuFlatButton btnCarregarGerar;
        private System.Windows.Forms.RadioButton rbCarregar;
    }
}