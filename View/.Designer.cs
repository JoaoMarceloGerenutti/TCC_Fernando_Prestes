namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            this.txbFiltroNome = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblFiltroNome = new System.Windows.Forms.Label();
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlOpções = new System.Windows.Forms.Panel();
            this.pbCalculadora = new System.Windows.Forms.PictureBox();
            this.btnCalculadora = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txbFiltroMarca = new System.Windows.Forms.TextBox();
            this.ibMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAlterar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPesquisar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlCabeçalho = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDEBProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEBGerenciamento = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamento();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbObservacao = new System.Windows.Forms.TextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.txbCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.bDEB_ProdutosTableAdapter = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.BDEB_ProdutosTableAdapter();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGravar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimparEstoque = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlOpções.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculadora)).BeginInit();
            this.pnlCabeçalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEBProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // txbFiltroNome
            // 
            this.txbFiltroNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txbFiltroNome.Location = new System.Drawing.Point(33, 335);
            this.txbFiltroNome.Name = "txbFiltroNome";
            this.txbFiltroNome.Size = new System.Drawing.Size(170, 29);
            this.txbFiltroNome.TabIndex = 24;
            this.txbFiltroNome.TextChanged += new System.EventHandler(this.TxbInfo_TextChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMarca.ForeColor = System.Drawing.Color.Purple;
            this.lblMarca.Location = new System.Drawing.Point(54, 370);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(128, 22);
            this.lblMarca.TabIndex = 20;
            this.lblMarca.Text = "Digite a Marca";
            // 
            // lblFiltroNome
            // 
            this.lblFiltroNome.AutoSize = true;
            this.lblFiltroNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFiltroNome.ForeColor = System.Drawing.Color.Purple;
            this.lblFiltroNome.Location = new System.Drawing.Point(53, 310);
            this.lblFiltroNome.Name = "lblFiltroNome";
            this.lblFiltroNome.Size = new System.Drawing.Size(131, 22);
            this.lblFiltroNome.TabIndex = 19;
            this.lblFiltroNome.Text = "Digite o Nome";
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // pnlOpções
            // 
            this.pnlOpções.BackColor = System.Drawing.Color.White;
            this.pnlOpções.Controls.Add(this.pbCalculadora);
            this.pnlOpções.Controls.Add(this.btnCalculadora);
            this.pnlOpções.Controls.Add(this.txbFiltroMarca);
            this.pnlOpções.Controls.Add(this.ibMenu);
            this.pnlOpções.Controls.Add(this.txbFiltroNome);
            this.pnlOpções.Controls.Add(this.btnFechar);
            this.pnlOpções.Controls.Add(this.btnLimpar);
            this.pnlOpções.Controls.Add(this.lblMarca);
            this.pnlOpções.Controls.Add(this.btnAdicionar);
            this.pnlOpções.Controls.Add(this.lblFiltroNome);
            this.pnlOpções.Controls.Add(this.btnAlterar);
            this.pnlOpções.Controls.Add(this.btnExcluir);
            this.pnlOpções.Controls.Add(this.btnPesquisar);
            this.pnlOpções.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpções.Location = new System.Drawing.Point(0, 0);
            this.pnlOpções.Name = "pnlOpções";
            this.pnlOpções.Size = new System.Drawing.Size(234, 697);
            this.pnlOpções.TabIndex = 34;
            // 
            // pbCalculadora
            // 
            this.pbCalculadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbCalculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCalculadora.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Calculadora;
            this.pbCalculadora.Location = new System.Drawing.Point(42, 509);
            this.pbCalculadora.Name = "pbCalculadora";
            this.pbCalculadora.Size = new System.Drawing.Size(158, 119);
            this.pbCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalculadora.TabIndex = 49;
            this.pbCalculadora.TabStop = false;
            this.pbCalculadora.Click += new System.EventHandler(this.pbCalculadora_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Activecolor = System.Drawing.Color.Purple;
            this.btnCalculadora.BackColor = System.Drawing.Color.Purple;
            this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculadora.BorderRadius = 0;
            this.btnCalculadora.ButtonText = "          CALCULADORA";
            this.btnCalculadora.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalculadora.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalculadora.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalculadora.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Calculadora_Icone;
            this.btnCalculadora.Iconimage_right = null;
            this.btnCalculadora.Iconimage_right_Selected = null;
            this.btnCalculadora.Iconimage_Selected = null;
            this.btnCalculadora.IconMarginLeft = 0;
            this.btnCalculadora.IconMarginRight = 0;
            this.btnCalculadora.IconRightVisible = true;
            this.btnCalculadora.IconRightZoom = 0D;
            this.btnCalculadora.IconVisible = true;
            this.btnCalculadora.IconZoom = 90D;
            this.btnCalculadora.IsTab = false;
            this.btnCalculadora.Location = new System.Drawing.Point(0, 442);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Normalcolor = System.Drawing.Color.Purple;
            this.btnCalculadora.OnHovercolor = System.Drawing.Color.Purple;
            this.btnCalculadora.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalculadora.selected = false;
            this.btnCalculadora.Size = new System.Drawing.Size(234, 48);
            this.btnCalculadora.TabIndex = 37;
            this.btnCalculadora.Text = "          CALCULADORA";
            this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.Textcolor = System.Drawing.Color.White;
            this.btnCalculadora.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txbFiltroMarca
            // 
            this.txbFiltroMarca.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txbFiltroMarca.Location = new System.Drawing.Point(33, 395);
            this.txbFiltroMarca.Name = "txbFiltroMarca";
            this.txbFiltroMarca.Size = new System.Drawing.Size(170, 29);
            this.txbFiltroMarca.TabIndex = 36;
            this.txbFiltroMarca.TextChanged += new System.EventHandler(this.TxbMarca_TextChanged);
            // 
            // ibMenu
            // 
            this.ibMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ibMenu.BackColor = System.Drawing.Color.Purple;
            this.ibMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ibMenu.BorderRadius = 0;
            this.ibMenu.ButtonText = "      MENU";
            this.ibMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ibMenu.DisabledColor = System.Drawing.Color.DarkViolet;
            this.ibMenu.Enabled = false;
            this.ibMenu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.ibMenu.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Menu_Opções;
            this.ibMenu.Iconimage_right = null;
            this.ibMenu.Iconimage_right_Selected = null;
            this.ibMenu.Iconimage_Selected = null;
            this.ibMenu.IconMarginLeft = 0;
            this.ibMenu.IconMarginRight = 0;
            this.ibMenu.IconRightVisible = true;
            this.ibMenu.IconRightZoom = 0D;
            this.ibMenu.IconVisible = true;
            this.ibMenu.IconZoom = 90D;
            this.ibMenu.IsTab = false;
            this.ibMenu.Location = new System.Drawing.Point(0, 0);
            this.ibMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibMenu.Name = "ibMenu";
            this.ibMenu.Normalcolor = System.Drawing.Color.Purple;
            this.ibMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ibMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.ibMenu.selected = false;
            this.ibMenu.Size = new System.Drawing.Size(245, 67);
            this.ibMenu.TabIndex = 33;
            this.ibMenu.Text = "      MENU";
            this.ibMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibMenu.Textcolor = System.Drawing.Color.White;
            this.ibMenu.TextFont = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnFechar
            // 
            this.btnFechar.ActiveBorderThickness = 1;
            this.btnFechar.ActiveCornerRadius = 20;
            this.btnFechar.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnFechar.ActiveForecolor = System.Drawing.Color.White;
            this.btnFechar.ActiveLineColor = System.Drawing.Color.White;
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.ButtonText = "Fechar";
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFechar.IdleBorderThickness = 1;
            this.btnFechar.IdleCornerRadius = 20;
            this.btnFechar.IdleFillColor = System.Drawing.Color.White;
            this.btnFechar.IdleForecolor = System.Drawing.Color.Purple;
            this.btnFechar.IdleLineColor = System.Drawing.Color.Purple;
            this.btnFechar.Location = new System.Drawing.Point(5, 650);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(109, 41);
            this.btnFechar.TabIndex = 35;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ActiveBorderThickness = 1;
            this.btnLimpar.ActiveCornerRadius = 20;
            this.btnLimpar.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnLimpar.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpar.ActiveLineColor = System.Drawing.Color.White;
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.ButtonText = "Limpar";
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLimpar.IdleBorderThickness = 1;
            this.btnLimpar.IdleCornerRadius = 20;
            this.btnLimpar.IdleFillColor = System.Drawing.Color.White;
            this.btnLimpar.IdleForecolor = System.Drawing.Color.Purple;
            this.btnLimpar.IdleLineColor = System.Drawing.Color.Purple;
            this.btnLimpar.Location = new System.Drawing.Point(120, 650);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 41);
            this.btnLimpar.TabIndex = 34;
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click_1);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.ActiveBorderThickness = 1;
            this.btnAdicionar.ActiveCornerRadius = 20;
            this.btnAdicionar.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnAdicionar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdicionar.ActiveLineColor = System.Drawing.Color.White;
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            this.btnAdicionar.ButtonText = "Adicionar Estoque";
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdicionar.IdleBorderThickness = 1;
            this.btnAdicionar.IdleCornerRadius = 20;
            this.btnAdicionar.IdleFillColor = System.Drawing.Color.White;
            this.btnAdicionar.IdleForecolor = System.Drawing.Color.Purple;
            this.btnAdicionar.IdleLineColor = System.Drawing.Color.Purple;
            this.btnAdicionar.Location = new System.Drawing.Point(24, 72);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(181, 41);
            this.btnAdicionar.TabIndex = 31;
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ActiveBorderThickness = 1;
            this.btnAlterar.ActiveCornerRadius = 20;
            this.btnAlterar.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnAlterar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAlterar.ActiveLineColor = System.Drawing.Color.White;
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.ButtonText = "Alterar Estoque";
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAlterar.IdleBorderThickness = 1;
            this.btnAlterar.IdleCornerRadius = 20;
            this.btnAlterar.IdleFillColor = System.Drawing.Color.White;
            this.btnAlterar.IdleForecolor = System.Drawing.Color.Purple;
            this.btnAlterar.IdleLineColor = System.Drawing.Color.Purple;
            this.btnAlterar.Location = new System.Drawing.Point(24, 123);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(181, 41);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ActiveBorderThickness = 1;
            this.btnExcluir.ActiveCornerRadius = 20;
            this.btnExcluir.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnExcluir.ActiveForecolor = System.Drawing.Color.White;
            this.btnExcluir.ActiveLineColor = System.Drawing.Color.White;
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.ButtonText = "Excluir Estoque";
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExcluir.IdleBorderThickness = 1;
            this.btnExcluir.IdleCornerRadius = 20;
            this.btnExcluir.IdleFillColor = System.Drawing.Color.White;
            this.btnExcluir.IdleForecolor = System.Drawing.Color.Purple;
            this.btnExcluir.IdleLineColor = System.Drawing.Color.Purple;
            this.btnExcluir.Location = new System.Drawing.Point(24, 173);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(181, 41);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Activecolor = System.Drawing.Color.Purple;
            this.btnPesquisar.BackColor = System.Drawing.Color.Purple;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.BorderRadius = 0;
            this.btnPesquisar.ButtonText = "          PESQUISAR";
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisar.DisabledColor = System.Drawing.Color.Gray;
            this.btnPesquisar.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Procurar;
            this.btnPesquisar.Iconimage_right = null;
            this.btnPesquisar.Iconimage_right_Selected = null;
            this.btnPesquisar.Iconimage_Selected = null;
            this.btnPesquisar.IconMarginLeft = 0;
            this.btnPesquisar.IconMarginRight = 0;
            this.btnPesquisar.IconRightVisible = true;
            this.btnPesquisar.IconRightZoom = 0D;
            this.btnPesquisar.IconVisible = true;
            this.btnPesquisar.IconZoom = 90D;
            this.btnPesquisar.IsTab = false;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 237);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Normalcolor = System.Drawing.Color.Purple;
            this.btnPesquisar.OnHovercolor = System.Drawing.Color.Purple;
            this.btnPesquisar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPesquisar.selected = false;
            this.btnPesquisar.Size = new System.Drawing.Size(245, 48);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "          PESQUISAR";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Textcolor = System.Drawing.Color.White;
            this.btnPesquisar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlCabeçalho
            // 
            this.pnlCabeçalho.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlCabeçalho.Controls.Add(this.lblTexto);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.Location = new System.Drawing.Point(234, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Size = new System.Drawing.Size(727, 67);
            this.pnlCabeçalho.TabIndex = 35;
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto.BackColor = System.Drawing.Color.DarkViolet;
            this.lblTexto.Enabled = false;
            this.lblTexto.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(0, 9);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(727, 45);
            this.lblTexto.TabIndex = 23;
            this.lblTexto.Text = "Estoque";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstoque.AutoGenerateColumns = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn});
            this.dgvEstoque.DataSource = this.bDEBProdutosBindingSource;
            this.dgvEstoque.GridColor = System.Drawing.Color.Purple;
            this.dgvEstoque.Location = new System.Drawing.Point(234, 388);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(727, 309);
            this.dgvEstoque.TabIndex = 36;
            this.dgvEstoque.Visible = false;
            this.dgvEstoque.SelectionChanged += new System.EventHandler(this.DgvEstoque_SelectionChanged);
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "Código do Produto";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            dataGridViewCellStyle5.Format = "$ ###,###,##0.00";
            this.precoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "Obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDEBProdutosBindingSource
            // 
            this.bDEBProdutosBindingSource.DataMember = "BDEB_Produtos";
            this.bDEBProdutosBindingSource.DataSource = this.dsEBGerenciamento;
            // 
            // dsEBGerenciamento
            // 
            this.dsEBGerenciamento.DataSetName = "DsEBGerenciamento";
            this.dsEBGerenciamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(415, 133);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(88, 22);
            this.lblProduto.TabIndex = 96;
            this.lblProduto.Text = "Produto :";
            // 
            // txbPreco
            // 
            this.txbPreco.Enabled = false;
            this.txbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreco.Location = new System.Drawing.Point(698, 90);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(107, 31);
            this.txbPreco.TabIndex = 95;
            this.txbPreco.Text = "R$ 0,00";
            this.txbPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPreco_KeyPress);
            // 
            // txbObservacao
            // 
            this.txbObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbObservacao.Enabled = false;
            this.txbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservacao.Location = new System.Drawing.Point(543, 241);
            this.txbObservacao.Multiline = true;
            this.txbObservacao.Name = "txbObservacao";
            this.txbObservacao.Size = new System.Drawing.Size(262, 84);
            this.txbObservacao.TabIndex = 93;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Enabled = false;
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(543, 204);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(75, 31);
            this.nudQuantidade.TabIndex = 92;
            // 
            // txbMarca
            // 
            this.txbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMarca.Enabled = false;
            this.txbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMarca.Location = new System.Drawing.Point(543, 164);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(262, 31);
            this.txbMarca.TabIndex = 91;
            // 
            // txbProduto
            // 
            this.txbProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProduto.Enabled = false;
            this.txbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(543, 127);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(262, 31);
            this.txbProduto.TabIndex = 90;
            // 
            // txbCodigoProduto
            // 
            this.txbCodigoProduto.Enabled = false;
            this.txbCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoProduto.Location = new System.Drawing.Point(543, 90);
            this.txbCodigoProduto.Name = "txbCodigoProduto";
            this.txbCodigoProduto.Size = new System.Drawing.Size(75, 31);
            this.txbCodigoProduto.TabIndex = 89;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.White;
            this.lblObs.Location = new System.Drawing.Point(415, 247);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(122, 22);
            this.lblObs.TabIndex = 88;
            this.lblObs.Text = "Observações :";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(626, 96);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(66, 22);
            this.lblPreco.TabIndex = 84;
            this.lblPreco.Text = "Preço :";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(415, 209);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(114, 22);
            this.lblQuantidade.TabIndex = 83;
            this.lblQuantidade.Text = "Quantidade :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(415, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "Marca :";
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.ForeColor = System.Drawing.Color.White;
            this.lblCódigo.Location = new System.Drawing.Point(415, 96);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(80, 22);
            this.lblCódigo.TabIndex = 81;
            this.lblCódigo.Text = "Código :";
            // 
            // bDEB_ProdutosTableAdapter
            // 
            this.bDEB_ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvMenu.DataSource = this.bDEBProdutosBindingSource;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.GridColor = System.Drawing.Color.Purple;
            this.dgvMenu.Location = new System.Drawing.Point(234, 67);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(727, 630);
            this.dgvMenu.TabIndex = 97;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código do Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            dataGridViewCellStyle6.Format = "$ ###,###,##0.00";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn4.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Obs";
            this.dataGridViewTextBoxColumn6.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnGravar
            // 
            this.btnGravar.ActiveBorderThickness = 1;
            this.btnGravar.ActiveCornerRadius = 20;
            this.btnGravar.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnGravar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGravar.ActiveLineColor = System.Drawing.Color.White;
            this.btnGravar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravar.BackgroundImage")));
            this.btnGravar.ButtonText = "Gravar";
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.IdleBorderThickness = 1;
            this.btnGravar.IdleCornerRadius = 20;
            this.btnGravar.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnGravar.IdleForecolor = System.Drawing.Color.White;
            this.btnGravar.IdleLineColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(397, 339);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(132, 41);
            this.btnGravar.TabIndex = 87;
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.White;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(679, 339);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 41);
            this.btnCancelar.TabIndex = 86;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnLimparEstoque
            // 
            this.btnLimparEstoque.ActiveBorderThickness = 1;
            this.btnLimparEstoque.ActiveCornerRadius = 20;
            this.btnLimparEstoque.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnLimparEstoque.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimparEstoque.ActiveLineColor = System.Drawing.Color.White;
            this.btnLimparEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparEstoque.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimparEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparEstoque.BackgroundImage")));
            this.btnLimparEstoque.ButtonText = "Limpar";
            this.btnLimparEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparEstoque.Enabled = false;
            this.btnLimparEstoque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnLimparEstoque.IdleBorderThickness = 1;
            this.btnLimparEstoque.IdleCornerRadius = 20;
            this.btnLimparEstoque.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnLimparEstoque.IdleForecolor = System.Drawing.Color.White;
            this.btnLimparEstoque.IdleLineColor = System.Drawing.Color.White;
            this.btnLimparEstoque.Location = new System.Drawing.Point(543, 339);
            this.btnLimparEstoque.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimparEstoque.Name = "btnLimparEstoque";
            this.btnLimparEstoque.Size = new System.Drawing.Size(126, 41);
            this.btnLimparEstoque.TabIndex = 85;
            this.btnLimparEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimparEstoque.Click += new System.EventHandler(this.BtnLimparEstoque_Click);
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(961, 697);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.txbObservacao);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.txbCodigoProduto);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimparEstoque);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.pnlCabeçalho);
            this.Controls.Add(this.pnlOpções);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            this.pnlOpções.ResumeLayout(false);
            this.pnlOpções.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculadora)).EndInit();
            this.pnlCabeçalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEBProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbFiltroNome;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblFiltroNome;
        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private Bunifu.Framework.UI.BunifuFlatButton ibMenu;
        private System.Windows.Forms.Panel pnlOpções;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFechar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdicionar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAlterar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcluir;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisar;
        private System.Windows.Forms.Panel pnlCabeçalho;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private DsEBGerenciamento dsEBGerenciamento;
        private System.Windows.Forms.BindingSource bDEBProdutosBindingSource;
        private DsEBGerenciamentoTableAdapters.BDEB_ProdutosTableAdapter bDEB_ProdutosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txbFiltroMarca;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbObservacao;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.TextBox txbCodigoProduto;
        private System.Windows.Forms.Label lblObs;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGravar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimparEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalculadora;
        private System.Windows.Forms.PictureBox pbCalculadora;
    }
}