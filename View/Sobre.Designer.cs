namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmSobre
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
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ibLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ptbTechnoTrab = new System.Windows.Forms.PictureBox();
            this.gbSobre = new System.Windows.Forms.GroupBox();
            this.txbSobre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbIntegrantes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ibLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTechnoTrab)).BeginInit();
            this.gbSobre.SuspendLayout();
            this.gbIntegrantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // ibLogo
            // 
            this.ibLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibLogo.BackColor = System.Drawing.Color.White;
            this.ibLogo.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Splash_Screen;
            this.ibLogo.ImageActive = null;
            this.ibLogo.Location = new System.Drawing.Point(0, 0);
            this.ibLogo.Name = "ibLogo";
            this.ibLogo.Size = new System.Drawing.Size(377, 607);
            this.ibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibLogo.TabIndex = 26;
            this.ibLogo.TabStop = false;
            this.ibLogo.Zoom = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Enabled = false;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(383, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(439, 46);
            this.lblLogin.TabIndex = 27;
            this.lblLogin.Text = "TechnoTrab Enterprise ©";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbTechnoTrab
            // 
            this.ptbTechnoTrab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbTechnoTrab.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.TechnoTrab;
            this.ptbTechnoTrab.Location = new System.Drawing.Point(6, 129);
            this.ptbTechnoTrab.Name = "ptbTechnoTrab";
            this.ptbTechnoTrab.Size = new System.Drawing.Size(456, 274);
            this.ptbTechnoTrab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTechnoTrab.TabIndex = 28;
            this.ptbTechnoTrab.TabStop = false;
            // 
            // gbSobre
            // 
            this.gbSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSobre.Controls.Add(this.txbSobre);
            this.gbSobre.Controls.Add(this.label2);
            this.gbSobre.Controls.Add(this.ptbTechnoTrab);
            this.gbSobre.Location = new System.Drawing.Point(377, 58);
            this.gbSobre.Name = "gbSobre";
            this.gbSobre.Size = new System.Drawing.Size(468, 409);
            this.gbSobre.TabIndex = 29;
            this.gbSobre.TabStop = false;
            this.gbSobre.Tag = "";
            this.gbSobre.Text = "Sobre";
            // 
            // txbSobre
            // 
            this.txbSobre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSobre.Location = new System.Drawing.Point(6, 19);
            this.txbSobre.Multiline = true;
            this.txbSobre.Name = "txbSobre";
            this.txbSobre.ReadOnly = true;
            this.txbSobre.Size = new System.Drawing.Size(456, 104);
            this.txbSobre.TabIndex = 10;
            this.txbSobre.Text = "Programa criado pelos alunos do 3º Informática Integrado ao Ensino Médio como TCC" +
    "(Trabalho de conclusão de curso) durante o ano de 2019.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Pedro Henrique Jacques";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Murilo Nogueira";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lucas Ferreira da Costa";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "João Marcelo Gerenutti";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "João Gabriel da Silva";
            // 
            // gbIntegrantes
            // 
            this.gbIntegrantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIntegrantes.Controls.Add(this.label1);
            this.gbIntegrantes.Controls.Add(this.label6);
            this.gbIntegrantes.Controls.Add(this.label9);
            this.gbIntegrantes.Controls.Add(this.label5);
            this.gbIntegrantes.Controls.Add(this.label8);
            this.gbIntegrantes.Controls.Add(this.label7);
            this.gbIntegrantes.Location = new System.Drawing.Point(655, 473);
            this.gbIntegrantes.Name = "gbIntegrantes";
            this.gbIntegrantes.Size = new System.Drawing.Size(190, 128);
            this.gbIntegrantes.TabIndex = 30;
            this.gbIntegrantes.TabStop = false;
            this.gbIntegrantes.Tag = "";
            this.gbIntegrantes.Text = "Integrantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 607);
            this.Controls.Add(this.gbIntegrantes);
            this.Controls.Add(this.gbSobre);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.ibLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSobre";
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.ibLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTechnoTrab)).EndInit();
            this.gbSobre.ResumeLayout(false);
            this.gbSobre.PerformLayout();
            this.gbIntegrantes.ResumeLayout(false);
            this.gbIntegrantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private Bunifu.Framework.UI.BunifuImageButton ibLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogin;
        private System.Windows.Forms.PictureBox ptbTechnoTrab;
        private System.Windows.Forms.GroupBox gbSobre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSobre;
        private System.Windows.Forms.GroupBox gbIntegrantes;
        private System.Windows.Forms.Label label1;
    }
}