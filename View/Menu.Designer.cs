namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmMenu
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnlCabeçalho = new System.Windows.Forms.Panel();
            this.ibMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblEspaço_da_beleza = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ibEspaçoDaBeleza = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibConfiguracao = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBackup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnRelatorio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnEstoque = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnAgendamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnImage = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblHora_Atual = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ibMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlConfiguracao = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnAjuda = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSobre = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.ibLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.Movimento = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Animação_Menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btrLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Hora_Atual = new System.Windows.Forms.Timer(this.components);
            this.pnlCabeçalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibEspaçoDaBeleza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibConfiguracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMenu)).BeginInit();
            this.pnlConfiguracao.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabeçalho
            // 
            this.pnlCabeçalho.BackColor = System.Drawing.Color.Purple;
            this.pnlCabeçalho.Controls.Add(this.ibMaximizar);
            this.pnlCabeçalho.Controls.Add(this.ibMinimizar);
            this.pnlCabeçalho.Controls.Add(this.lblEspaço_da_beleza);
            this.pnlCabeçalho.Controls.Add(this.ibEspaçoDaBeleza);
            this.pnlCabeçalho.Controls.Add(this.ibFechar);
            this.btrLogo.SetDecoration(this.pnlCabeçalho, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.pnlCabeçalho, BunifuAnimatorNS.DecorationType.None);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Size = new System.Drawing.Size(1240, 58);
            this.pnlCabeçalho.TabIndex = 0;
            // 
            // ibMaximizar
            // 
            this.ibMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.ibMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.ibMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.ibMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.ibMaximizar.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Maximizar;
            this.ibMaximizar.ImageActive = null;
            this.ibMaximizar.InitialImage = null;
            this.ibMaximizar.Location = new System.Drawing.Point(1166, 14);
            this.ibMaximizar.Name = "ibMaximizar";
            this.ibMaximizar.Size = new System.Drawing.Size(28, 25);
            this.ibMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibMaximizar.TabIndex = 4;
            this.ibMaximizar.TabStop = false;
            this.ibMaximizar.Zoom = 20;
            this.ibMaximizar.Click += new System.EventHandler(this.IbMaximizar_Click);
            // 
            // ibMinimizar
            // 
            this.ibMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.ibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.ibMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.ibMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.ibMinimizar.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Minimizar1;
            this.ibMinimizar.ImageActive = null;
            this.ibMinimizar.InitialImage = null;
            this.ibMinimizar.Location = new System.Drawing.Point(1132, 14);
            this.ibMinimizar.Name = "ibMinimizar";
            this.ibMinimizar.Size = new System.Drawing.Size(28, 25);
            this.ibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibMinimizar.TabIndex = 3;
            this.ibMinimizar.TabStop = false;
            this.ibMinimizar.Zoom = 20;
            this.ibMinimizar.Click += new System.EventHandler(this.IbMinimizar_Click);
            // 
            // lblEspaço_da_beleza
            // 
            this.lblEspaço_da_beleza.AutoSize = true;
            this.Animação_Menu.SetDecoration(this.lblEspaço_da_beleza, BunifuAnimatorNS.DecorationType.None);
            this.btrLogo.SetDecoration(this.lblEspaço_da_beleza, BunifuAnimatorNS.DecorationType.None);
            this.lblEspaço_da_beleza.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspaço_da_beleza.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEspaço_da_beleza.Location = new System.Drawing.Point(78, 10);
            this.lblEspaço_da_beleza.Name = "lblEspaço_da_beleza";
            this.lblEspaço_da_beleza.Size = new System.Drawing.Size(258, 38);
            this.lblEspaço_da_beleza.TabIndex = 2;
            this.lblEspaço_da_beleza.Text = "Espaço Da Beleza";
            this.lblEspaço_da_beleza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibEspaçoDaBeleza
            // 
            this.ibEspaçoDaBeleza.BackColor = System.Drawing.Color.Transparent;
            this.btrLogo.SetDecoration(this.ibEspaçoDaBeleza, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.ibEspaçoDaBeleza, BunifuAnimatorNS.DecorationType.None);
            this.ibEspaçoDaBeleza.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.App_Icon;
            this.ibEspaçoDaBeleza.ImageActive = null;
            this.ibEspaçoDaBeleza.Location = new System.Drawing.Point(3, 3);
            this.ibEspaçoDaBeleza.Name = "ibEspaçoDaBeleza";
            this.ibEspaçoDaBeleza.Size = new System.Drawing.Size(58, 52);
            this.ibEspaçoDaBeleza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibEspaçoDaBeleza.TabIndex = 1;
            this.ibEspaçoDaBeleza.TabStop = false;
            this.ibEspaçoDaBeleza.Zoom = 10;
            // 
            // ibFechar
            // 
            this.ibFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibFechar.BackColor = System.Drawing.Color.Transparent;
            this.ibFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.ibFechar, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.ibFechar, BunifuAnimatorNS.DecorationType.None);
            this.ibFechar.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Fechar;
            this.ibFechar.ImageActive = null;
            this.ibFechar.InitialImage = null;
            this.ibFechar.Location = new System.Drawing.Point(1200, 14);
            this.ibFechar.Name = "ibFechar";
            this.ibFechar.Size = new System.Drawing.Size(28, 25);
            this.ibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibFechar.TabIndex = 0;
            this.ibFechar.TabStop = false;
            this.ibFechar.Zoom = 20;
            this.ibFechar.Click += new System.EventHandler(this.IbFechar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.ibConfiguracao);
            this.pnlMenu.Controls.Add(this.btnBackup);
            this.pnlMenu.Controls.Add(this.bunifuSeparator5);
            this.pnlMenu.Controls.Add(this.btnRelatorio);
            this.pnlMenu.Controls.Add(this.bunifuSeparator4);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.bunifuSeparator3);
            this.pnlMenu.Controls.Add(this.btnEstoque);
            this.pnlMenu.Controls.Add(this.bunifuSeparator2);
            this.pnlMenu.Controls.Add(this.btnAgendamento);
            this.pnlMenu.Controls.Add(this.bunifuSeparator1);
            this.pnlMenu.Controls.Add(this.btnImage);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.lblHora_Atual);
            this.pnlMenu.Controls.Add(this.ibMenu);
            this.pnlMenu.Controls.Add(this.pnlConfiguracao);
            this.btrLogo.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(961, 58);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(279, 697);
            this.pnlMenu.TabIndex = 1;
            // 
            // ibConfiguracao
            // 
            this.ibConfiguracao.BackColor = System.Drawing.Color.Purple;
            this.ibConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.ibConfiguracao, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.ibConfiguracao, BunifuAnimatorNS.DecorationType.None);
            this.ibConfiguracao.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Configuração;
            this.ibConfiguracao.ImageActive = null;
            this.ibConfiguracao.Location = new System.Drawing.Point(199, 114);
            this.ibConfiguracao.Name = "ibConfiguracao";
            this.ibConfiguracao.Size = new System.Drawing.Size(28, 25);
            this.ibConfiguracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibConfiguracao.TabIndex = 31;
            this.ibConfiguracao.TabStop = false;
            this.ibConfiguracao.Zoom = 10;
            this.ibConfiguracao.Click += new System.EventHandler(this.IbConfiguracao_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Activecolor = System.Drawing.Color.Purple;
            this.btnBackup.BackColor = System.Drawing.Color.Gray;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.BorderRadius = 0;
            this.btnBackup.ButtonText = "Backup";
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.btnBackup, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.btnBackup, BunifuAnimatorNS.DecorationType.None);
            this.btnBackup.DisabledColor = System.Drawing.Color.Gray;
            this.btnBackup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBackup.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Reporte;
            this.btnBackup.Iconimage_right = null;
            this.btnBackup.Iconimage_right_Selected = null;
            this.btnBackup.Iconimage_Selected = null;
            this.btnBackup.IconMarginLeft = 0;
            this.btnBackup.IconMarginRight = 0;
            this.btnBackup.IconRightVisible = true;
            this.btnBackup.IconRightZoom = 0D;
            this.btnBackup.IconVisible = true;
            this.btnBackup.IconZoom = 90D;
            this.btnBackup.IsTab = true;
            this.btnBackup.Location = new System.Drawing.Point(-4, 544);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Normalcolor = System.Drawing.Color.Gray;
            this.btnBackup.OnHovercolor = System.Drawing.Color.Purple;
            this.btnBackup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackup.selected = false;
            this.btnBackup.Size = new System.Drawing.Size(283, 63);
            this.btnBackup.TabIndex = 24;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBackup.Textcolor = System.Drawing.Color.White;
            this.btnBackup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.btrLogo.SetDecoration(this.bunifuSeparator5, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.bunifuSeparator5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(-2, 592);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(283, 35);
            this.bunifuSeparator5.TabIndex = 30;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Activecolor = System.Drawing.Color.Purple;
            this.btnRelatorio.BackColor = System.Drawing.Color.Gray;
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorio.BorderRadius = 0;
            this.btnRelatorio.ButtonText = "Relatório";
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.btnRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.btnRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.btnRelatorio.DisabledColor = System.Drawing.Color.Gray;
            this.btnRelatorio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRelatorio.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Backup;
            this.btnRelatorio.Iconimage_right = null;
            this.btnRelatorio.Iconimage_right_Selected = null;
            this.btnRelatorio.Iconimage_Selected = null;
            this.btnRelatorio.IconMarginLeft = 0;
            this.btnRelatorio.IconMarginRight = 0;
            this.btnRelatorio.IconRightVisible = true;
            this.btnRelatorio.IconRightZoom = 0D;
            this.btnRelatorio.IconVisible = true;
            this.btnRelatorio.IconZoom = 90D;
            this.btnRelatorio.IsTab = true;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 475);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Normalcolor = System.Drawing.Color.Gray;
            this.btnRelatorio.OnHovercolor = System.Drawing.Color.Purple;
            this.btnRelatorio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRelatorio.selected = false;
            this.btnRelatorio.Size = new System.Drawing.Size(283, 63);
            this.btnRelatorio.TabIndex = 23;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRelatorio.Textcolor = System.Drawing.Color.White;
            this.btnRelatorio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.btrLogo.SetDecoration(this.bunifuSeparator4, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.bunifuSeparator4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(-2, 523);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(283, 35);
            this.bunifuSeparator4.TabIndex = 29;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.Purple;
            this.btnClientes.BackColor = System.Drawing.Color.Gray;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Clientes;
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 90D;
            this.btnClientes.IsTab = true;
            this.btnClientes.Location = new System.Drawing.Point(-4, 406);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.Gray;
            this.btnClientes.OnHovercolor = System.Drawing.Color.Purple;
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(283, 63);
            this.btnClientes.TabIndex = 22;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.btrLogo.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-2, 454);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(283, 35);
            this.bunifuSeparator3.TabIndex = 28;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Activecolor = System.Drawing.Color.Purple;
            this.btnEstoque.BackColor = System.Drawing.Color.Gray;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstoque.BorderRadius = 0;
            this.btnEstoque.ButtonText = "Estoque";
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.btnEstoque, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.btnEstoque, BunifuAnimatorNS.DecorationType.None);
            this.btnEstoque.DisabledColor = System.Drawing.Color.Gray;
            this.btnEstoque.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEstoque.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Produtos1;
            this.btnEstoque.Iconimage_right = null;
            this.btnEstoque.Iconimage_right_Selected = null;
            this.btnEstoque.Iconimage_Selected = null;
            this.btnEstoque.IconMarginLeft = 0;
            this.btnEstoque.IconMarginRight = 0;
            this.btnEstoque.IconRightVisible = true;
            this.btnEstoque.IconRightZoom = 0D;
            this.btnEstoque.IconVisible = true;
            this.btnEstoque.IconZoom = 90D;
            this.btnEstoque.IsTab = true;
            this.btnEstoque.Location = new System.Drawing.Point(0, 337);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Normalcolor = System.Drawing.Color.Gray;
            this.btnEstoque.OnHovercolor = System.Drawing.Color.Purple;
            this.btnEstoque.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEstoque.selected = false;
            this.btnEstoque.Size = new System.Drawing.Size(283, 63);
            this.btnEstoque.TabIndex = 7;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEstoque.Textcolor = System.Drawing.Color.White;
            this.btnEstoque.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.btrLogo.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-2, 385);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(283, 35);
            this.bunifuSeparator2.TabIndex = 27;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.Activecolor = System.Drawing.Color.Purple;
            this.btnAgendamento.BackColor = System.Drawing.Color.Gray;
            this.btnAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgendamento.BorderRadius = 0;
            this.btnAgendamento.ButtonText = "Agendamento";
            this.btnAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.btnAgendamento, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.btnAgendamento, BunifuAnimatorNS.DecorationType.None);
            this.btnAgendamento.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgendamento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgendamento.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Agendamento1;
            this.btnAgendamento.Iconimage_right = null;
            this.btnAgendamento.Iconimage_right_Selected = null;
            this.btnAgendamento.Iconimage_Selected = null;
            this.btnAgendamento.IconMarginLeft = 0;
            this.btnAgendamento.IconMarginRight = 0;
            this.btnAgendamento.IconRightVisible = true;
            this.btnAgendamento.IconRightZoom = 0D;
            this.btnAgendamento.IconVisible = true;
            this.btnAgendamento.IconZoom = 90D;
            this.btnAgendamento.IsTab = true;
            this.btnAgendamento.Location = new System.Drawing.Point(0, 268);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Normalcolor = System.Drawing.Color.Gray;
            this.btnAgendamento.OnHovercolor = System.Drawing.Color.Purple;
            this.btnAgendamento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgendamento.selected = false;
            this.btnAgendamento.Size = new System.Drawing.Size(283, 63);
            this.btnAgendamento.TabIndex = 5;
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgendamento.Textcolor = System.Drawing.Color.White;
            this.btnAgendamento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.Click += new System.EventHandler(this.BtnAgendamento_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.btrLogo.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 316);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(283, 35);
            this.bunifuSeparator1.TabIndex = 26;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.BackColor = System.Drawing.Color.Transparent;
            this.btnImage.BackgroundImage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Circulo_Menu;
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImage.color = System.Drawing.Color.Transparent;
            this.btnImage.colorActive = System.Drawing.Color.Transparent;
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.btnImage, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.btnImage, BunifuAnimatorNS.DecorationType.None);
            this.btnImage.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.ImagePosition = 20;
            this.btnImage.ImageZoom = 50;
            this.btnImage.LabelPosition = 41;
            this.btnImage.LabelText = "Célia";
            this.btnImage.Location = new System.Drawing.Point(81, 20);
            this.btnImage.Margin = new System.Windows.Forms.Padding(6);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(126, 119);
            this.btnImage.TabIndex = 25;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveBorderThickness = 1;
            this.btnLogout.ActiveCornerRadius = 20;
            this.btnLogout.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnLogout.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogout.ActiveLineColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleCornerRadius = 20;
            this.btnLogout.IdleFillColor = System.Drawing.Color.Black;
            this.btnLogout.IdleForecolor = System.Drawing.Color.White;
            this.btnLogout.IdleLineColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(52, 146);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(177, 41);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // lblHora_Atual
            // 
            this.lblHora_Atual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora_Atual.AutoSize = true;
            this.lblHora_Atual.BackColor = System.Drawing.Color.Transparent;
            this.Animação_Menu.SetDecoration(this.lblHora_Atual, BunifuAnimatorNS.DecorationType.None);
            this.btrLogo.SetDecoration(this.lblHora_Atual, BunifuAnimatorNS.DecorationType.None);
            this.lblHora_Atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora_Atual.ForeColor = System.Drawing.Color.Transparent;
            this.lblHora_Atual.Location = new System.Drawing.Point(68, 642);
            this.lblHora_Atual.Name = "lblHora_Atual";
            this.lblHora_Atual.Size = new System.Drawing.Size(159, 39);
            this.lblHora_Atual.TabIndex = 17;
            this.lblHora_Atual.Text = "00:00:00";
            // 
            // ibMenu
            // 
            this.ibMenu.BackColor = System.Drawing.Color.Transparent;
            this.ibMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.ibMenu, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.ibMenu, BunifuAnimatorNS.DecorationType.None);
            this.ibMenu.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Menu;
            this.ibMenu.ImageActive = null;
            this.ibMenu.Location = new System.Drawing.Point(17, 20);
            this.ibMenu.Name = "ibMenu";
            this.ibMenu.Size = new System.Drawing.Size(28, 25);
            this.ibMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibMenu.TabIndex = 3;
            this.ibMenu.TabStop = false;
            this.ibMenu.Zoom = 10;
            this.ibMenu.Click += new System.EventHandler(this.IbMenu_Click);
            // 
            // pnlConfiguracao
            // 
            this.pnlConfiguracao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConfiguracao.BackgroundImage")));
            this.pnlConfiguracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlConfiguracao.Controls.Add(this.btnAjuda);
            this.pnlConfiguracao.Controls.Add(this.btnSobre);
            this.btrLogo.SetDecoration(this.pnlConfiguracao, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.pnlConfiguracao, BunifuAnimatorNS.DecorationType.None);
            this.pnlConfiguracao.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnlConfiguracao.GradientBottomRight = System.Drawing.Color.Black;
            this.pnlConfiguracao.GradientTopLeft = System.Drawing.Color.Black;
            this.pnlConfiguracao.GradientTopRight = System.Drawing.Color.Black;
            this.pnlConfiguracao.Location = new System.Drawing.Point(49, 182);
            this.pnlConfiguracao.Name = "pnlConfiguracao";
            this.pnlConfiguracao.Quality = 10;
            this.pnlConfiguracao.Size = new System.Drawing.Size(187, 82);
            this.pnlConfiguracao.TabIndex = 26;
            this.pnlConfiguracao.Visible = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.ActiveBorderThickness = 1;
            this.btnAjuda.ActiveCornerRadius = 20;
            this.btnAjuda.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnAjuda.ActiveForecolor = System.Drawing.Color.White;
            this.btnAjuda.ActiveLineColor = System.Drawing.Color.White;
            this.btnAjuda.BackColor = System.Drawing.Color.Black;
            this.btnAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjuda.BackgroundImage")));
            this.btnAjuda.ButtonText = "Ajuda";
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.btnAjuda, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.btnAjuda, BunifuAnimatorNS.DecorationType.None);
            this.btnAjuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.White;
            this.btnAjuda.IdleBorderThickness = 1;
            this.btnAjuda.IdleCornerRadius = 20;
            this.btnAjuda.IdleFillColor = System.Drawing.Color.Black;
            this.btnAjuda.IdleForecolor = System.Drawing.Color.White;
            this.btnAjuda.IdleLineColor = System.Drawing.Color.White;
            this.btnAjuda.Location = new System.Drawing.Point(4, 3);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(177, 41);
            this.btnAjuda.TabIndex = 23;
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjuda.Click += new System.EventHandler(this.BtnAjuda_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.ActiveBorderThickness = 1;
            this.btnSobre.ActiveCornerRadius = 20;
            this.btnSobre.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnSobre.ActiveForecolor = System.Drawing.Color.White;
            this.btnSobre.ActiveLineColor = System.Drawing.Color.White;
            this.btnSobre.BackColor = System.Drawing.Color.Black;
            this.btnSobre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSobre.BackgroundImage")));
            this.btnSobre.ButtonText = "Sobre";
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrLogo.SetDecoration(this.btnSobre, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.btnSobre, BunifuAnimatorNS.DecorationType.None);
            this.btnSobre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.IdleBorderThickness = 1;
            this.btnSobre.IdleCornerRadius = 20;
            this.btnSobre.IdleFillColor = System.Drawing.Color.Black;
            this.btnSobre.IdleForecolor = System.Drawing.Color.White;
            this.btnSobre.IdleLineColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(4, 41);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(5);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(177, 41);
            this.btnSobre.TabIndex = 22;
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // pnlDGV
            // 
            this.pnlDGV.BackColor = System.Drawing.Color.White;
            this.pnlDGV.Controls.Add(this.ibLogo);
            this.btrLogo.SetDecoration(this.pnlDGV, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.pnlDGV, BunifuAnimatorNS.DecorationType.None);
            this.pnlDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDGV.Location = new System.Drawing.Point(0, 58);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(961, 697);
            this.pnlDGV.TabIndex = 2;
            // 
            // ibLogo
            // 
            this.ibLogo.BackColor = System.Drawing.Color.White;
            this.btrLogo.SetDecoration(this.ibLogo, BunifuAnimatorNS.DecorationType.None);
            this.Animação_Menu.SetDecoration(this.ibLogo, BunifuAnimatorNS.DecorationType.None);
            this.ibLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibLogo.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Espaço_Da_Beleza___Logo;
            this.ibLogo.ImageActive = null;
            this.ibLogo.Location = new System.Drawing.Point(0, 0);
            this.ibLogo.Name = "ibLogo";
            this.ibLogo.Size = new System.Drawing.Size(961, 697);
            this.ibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibLogo.TabIndex = 25;
            this.ibLogo.TabStop = false;
            this.ibLogo.Zoom = 10;
            // 
            // Movimento
            // 
            this.Movimento.Fixed = true;
            this.Movimento.Horizontal = true;
            this.Movimento.TargetControl = this.pnlCabeçalho;
            this.Movimento.Vertical = true;
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // Animação_Menu
            // 
            this.Animação_Menu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Animação_Menu.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Animação_Menu.DefaultAnimation = animation2;
            // 
            // btrLogo
            // 
            this.btrLogo.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.btrLogo.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 0.3F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.btrLogo.DefaultAnimation = animation1;
            // 
            // Hora_Atual
            // 
            this.Hora_Atual.Enabled = true;
            this.Hora_Atual.Tick += new System.EventHandler(this.Hora_Atual_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 755);
            this.Controls.Add(this.pnlDGV);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlCabeçalho);
            this.Animação_Menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.btrLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espaço Da Beleza";
            this.pnlCabeçalho.ResumeLayout(false);
            this.pnlCabeçalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibEspaçoDaBeleza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibConfiguracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMenu)).EndInit();
            this.pnlConfiguracao.ResumeLayout(false);
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabeçalho;
        private Bunifu.Framework.UI.BunifuImageButton ibEspaçoDaBeleza;
        private Bunifu.Framework.UI.BunifuImageButton ibFechar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEspaço_da_beleza;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlDGV;
        private Bunifu.Framework.UI.BunifuImageButton ibMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgendamento;
        private Bunifu.Framework.UI.BunifuDragControl Movimento;
        private Bunifu.Framework.UI.BunifuFlatButton btnEstoque;
        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private BunifuAnimatorNS.BunifuTransition Animação_Menu;
        private BunifuAnimatorNS.BunifuTransition btrLogo;
        private Bunifu.Framework.UI.BunifuImageButton ibMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton ibMaximizar;
        private System.Windows.Forms.Timer Hora_Atual;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHora_Atual;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuImageButton ibLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnBackup;
        private Bunifu.Framework.UI.BunifuFlatButton btnRelatorio;
        private Bunifu.Framework.UI.BunifuTileButton btnImage;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton ibConfiguracao;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlConfiguracao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAjuda;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSobre;
    }
}