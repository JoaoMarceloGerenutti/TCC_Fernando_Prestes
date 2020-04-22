namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.tmrProgresso = new System.Windows.Forms.Timer(this.components);
            this.lblTechnoTrab = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ptbTechnoTrab = new System.Windows.Forms.PictureBox();
            this.ptbSplashScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTechnoTrab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(12, 286);
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(599, 23);
            this.pgbSplash.TabIndex = 5;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Enabled = true;
            this.tmrLoading.Interval = 4650;
            this.tmrLoading.Tick += new System.EventHandler(this.Loading_Tick);
            // 
            // tmrProgresso
            // 
            this.tmrProgresso.Enabled = true;
            this.tmrProgresso.Interval = 400;
            this.tmrProgresso.Tick += new System.EventHandler(this.tmrProgresso_Tick);
            // 
            // lblTechnoTrab
            // 
            this.lblTechnoTrab.AutoSize = true;
            this.lblTechnoTrab.BackColor = System.Drawing.Color.Gray;
            this.lblTechnoTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnoTrab.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTechnoTrab.Location = new System.Drawing.Point(23, 3);
            this.lblTechnoTrab.Name = "lblTechnoTrab";
            this.lblTechnoTrab.Size = new System.Drawing.Size(564, 55);
            this.lblTechnoTrab.TabIndex = 4;
            this.lblTechnoTrab.Text = "TechnoTrab Enterprise ©";
            // 
            // ptbTechnoTrab
            // 
            this.ptbTechnoTrab.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.TechnoTrab;
            this.ptbTechnoTrab.Location = new System.Drawing.Point(231, 202);
            this.ptbTechnoTrab.Name = "ptbTechnoTrab";
            this.ptbTechnoTrab.Size = new System.Drawing.Size(159, 97);
            this.ptbTechnoTrab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTechnoTrab.TabIndex = 7;
            this.ptbTechnoTrab.TabStop = false;
            // 
            // ptbSplashScreen
            // 
            this.ptbSplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbSplashScreen.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Splash_Screen;
            this.ptbSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.ptbSplashScreen.Name = "ptbSplashScreen";
            this.ptbSplashScreen.Size = new System.Drawing.Size(623, 329);
            this.ptbSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSplashScreen.TabIndex = 6;
            this.ptbSplashScreen.TabStop = false;
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(623, 329);
            this.Controls.Add(this.pgbSplash);
            this.Controls.Add(this.ptbTechnoTrab);
            this.Controls.Add(this.lblTechnoTrab);
            this.Controls.Add(this.ptbSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTechnoTrab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSplashScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Timer tmrLoading;
        private System.Windows.Forms.Timer tmrProgresso;
        private System.Windows.Forms.PictureBox ptbSplashScreen;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTechnoTrab;
        private System.Windows.Forms.PictureBox ptbTechnoTrab;
    }
}