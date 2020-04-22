namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmControleClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlCabeçalho = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pnlOpções = new System.Windows.Forms.Panel();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.bDEB_ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEBGerenciamento = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamento();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGravar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ibMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAlterar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPesquisa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.dgvControleClientes = new System.Windows.Forms.DataGridView();
            this.codCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDEB_ClientesTableAdapter = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.BDEB_ClientesTableAdapter();
            this.tableAdapterManager = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.TableAdapterManager();
            this.pnlCabeçalho.SuspendLayout();
            this.pnlOpções.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDEB_ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // pnlCabeçalho
            // 
            this.pnlCabeçalho.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlCabeçalho.Controls.Add(this.lblTexto);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.Location = new System.Drawing.Point(234, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Size = new System.Drawing.Size(711, 67);
            this.pnlCabeçalho.TabIndex = 26;
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
            this.lblTexto.Size = new System.Drawing.Size(711, 45);
            this.lblTexto.TabIndex = 23;
            this.lblTexto.Text = "Controle de Clientes";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOpções
            // 
            this.pnlOpções.BackColor = System.Drawing.Color.White;
            this.pnlOpções.Controls.Add(this.txtNomeCli);
            this.pnlOpções.Controls.Add(this.mskTelefone);
            this.pnlOpções.Controls.Add(this.txtCodCli);
            this.pnlOpções.Controls.Add(this.txtFiltrar);
            this.pnlOpções.Controls.Add(this.lblTelefone);
            this.pnlOpções.Controls.Add(this.lblNome);
            this.pnlOpções.Controls.Add(this.lblCodigo);
            this.pnlOpções.Controls.Add(this.btnCliente);
            this.pnlOpções.Controls.Add(this.btnFechar);
            this.pnlOpções.Controls.Add(this.btnCancelar);
            this.pnlOpções.Controls.Add(this.btnGravar);
            this.pnlOpções.Controls.Add(this.ibMenu);
            this.pnlOpções.Controls.Add(this.btnAdicionar);
            this.pnlOpções.Controls.Add(this.btnAlterar);
            this.pnlOpções.Controls.Add(this.btnExcluir);
            this.pnlOpções.Controls.Add(this.btnPesquisa);
            this.pnlOpções.Controls.Add(this.lblFiltrar);
            this.pnlOpções.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpções.Location = new System.Drawing.Point(0, 0);
            this.pnlOpções.Name = "pnlOpções";
            this.pnlOpções.Size = new System.Drawing.Size(234, 678);
            this.pnlOpções.TabIndex = 25;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bDEB_ClientesBindingSource, "nomeCliente", true));
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(54, 487);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(122, 26);
            this.txtNomeCli.TabIndex = 50;
            // 
            // bDEB_ClientesBindingSource
            // 
            this.bDEB_ClientesBindingSource.DataMember = "BDEB_Clientes";
            this.bDEB_ClientesBindingSource.DataSource = this.dsEBGerenciamento;
            // 
            // dsEBGerenciamento
            // 
            this.dsEBGerenciamento.DataSetName = "DsEBGerenciamento";
            this.dsEBGerenciamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mskTelefone
            // 
            this.mskTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bDEB_ClientesBindingSource, "Telefone", true));
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(54, 544);
            this.mskTelefone.Mask = "(00)00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(122, 26);
            this.mskTelefone.TabIndex = 49;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskTelefone_KeyPress);
            // 
            // txtCodCli
            // 
            this.txtCodCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bDEB_ClientesBindingSource, "codCli", true));
            this.txtCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCli.Location = new System.Drawing.Point(77, 433);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(73, 26);
            this.txtCodCli.TabIndex = 48;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(44, 311);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(146, 26);
            this.txtFiltrar.TabIndex = 45;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.TxtFiltrar_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTelefone.ForeColor = System.Drawing.Color.Purple;
            this.lblTelefone.Location = new System.Drawing.Point(80, 519);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(79, 22);
            this.lblTelefone.TabIndex = 41;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNome.ForeColor = System.Drawing.Color.Purple;
            this.lblNome.Location = new System.Drawing.Point(80, 462);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 22);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCodigo.ForeColor = System.Drawing.Color.Purple;
            this.lblCodigo.Location = new System.Drawing.Point(32, 408);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(158, 22);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Código do Cliente";
            // 
            // btnCliente
            // 
            this.btnCliente.Activecolor = System.Drawing.Color.Purple;
            this.btnCliente.BackColor = System.Drawing.Color.Purple;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.BorderRadius = 0;
            this.btnCliente.ButtonText = "            CLIENTE";
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnCliente.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCliente.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Adicionar_Cliente1;
            this.btnCliente.Iconimage_right = null;
            this.btnCliente.Iconimage_right_Selected = null;
            this.btnCliente.Iconimage_Selected = null;
            this.btnCliente.IconMarginLeft = 0;
            this.btnCliente.IconMarginRight = 0;
            this.btnCliente.IconRightVisible = true;
            this.btnCliente.IconRightZoom = 0D;
            this.btnCliente.IconVisible = true;
            this.btnCliente.IconZoom = 90D;
            this.btnCliente.IsTab = false;
            this.btnCliente.Location = new System.Drawing.Point(0, 348);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Normalcolor = System.Drawing.Color.Purple;
            this.btnCliente.OnHovercolor = System.Drawing.Color.Purple;
            this.btnCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCliente.selected = false;
            this.btnCliente.Size = new System.Drawing.Size(247, 48);
            this.btnCliente.TabIndex = 36;
            this.btnCliente.Text = "            CLIENTE";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Textcolor = System.Drawing.Color.White;
            this.btnCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnFechar.Location = new System.Drawing.Point(24, 623);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(181, 41);
            this.btnFechar.TabIndex = 35;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.Purple;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.Purple;
            this.btnCancelar.Location = new System.Drawing.Point(120, 578);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 41);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.ActiveBorderThickness = 1;
            this.btnGravar.ActiveCornerRadius = 20;
            this.btnGravar.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnGravar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGravar.ActiveLineColor = System.Drawing.Color.White;
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravar.BackgroundImage")));
            this.btnGravar.ButtonText = "Gravar";
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGravar.IdleBorderThickness = 1;
            this.btnGravar.IdleCornerRadius = 20;
            this.btnGravar.IdleFillColor = System.Drawing.Color.White;
            this.btnGravar.IdleForecolor = System.Drawing.Color.Purple;
            this.btnGravar.IdleLineColor = System.Drawing.Color.Purple;
            this.btnGravar.Location = new System.Drawing.Point(4, 578);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(109, 41);
            this.btnGravar.TabIndex = 33;
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
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
            this.ibMenu.Size = new System.Drawing.Size(247, 67);
            this.ibMenu.TabIndex = 32;
            this.ibMenu.Text = "      MENU";
            this.ibMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibMenu.Textcolor = System.Drawing.Color.White;
            this.ibMenu.TextFont = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAdicionar.ButtonText = "Adicionar Cliente";
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
            this.btnAlterar.ButtonText = "Alterar Cliente";
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
            this.btnExcluir.ButtonText = "Excluir Cliente";
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
            // btnPesquisa
            // 
            this.btnPesquisa.Activecolor = System.Drawing.Color.Purple;
            this.btnPesquisa.BackColor = System.Drawing.Color.Purple;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisa.BorderRadius = 0;
            this.btnPesquisa.ButtonText = "          PESQUISAR";
            this.btnPesquisa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisa.DisabledColor = System.Drawing.Color.Gray;
            this.btnPesquisa.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPesquisa.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Procurar;
            this.btnPesquisa.Iconimage_right = null;
            this.btnPesquisa.Iconimage_right_Selected = null;
            this.btnPesquisa.Iconimage_Selected = null;
            this.btnPesquisa.IconMarginLeft = 0;
            this.btnPesquisa.IconMarginRight = 0;
            this.btnPesquisa.IconRightVisible = true;
            this.btnPesquisa.IconRightZoom = 0D;
            this.btnPesquisa.IconVisible = true;
            this.btnPesquisa.IconZoom = 90D;
            this.btnPesquisa.IsTab = false;
            this.btnPesquisa.Location = new System.Drawing.Point(0, 237);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Normalcolor = System.Drawing.Color.Purple;
            this.btnPesquisa.OnHovercolor = System.Drawing.Color.Purple;
            this.btnPesquisa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPesquisa.selected = false;
            this.btnPesquisa.Size = new System.Drawing.Size(247, 48);
            this.btnPesquisa.TabIndex = 27;
            this.btnPesquisa.Text = "          PESQUISAR";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Textcolor = System.Drawing.Color.White;
            this.btnPesquisa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFiltrar.ForeColor = System.Drawing.Color.Purple;
            this.lblFiltrar.Location = new System.Drawing.Point(62, 286);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(114, 22);
            this.lblFiltrar.TabIndex = 19;
            this.lblFiltrar.Text = "Filtrar Nome";
            // 
            // dgvControleClientes
            // 
            this.dgvControleClientes.AllowUserToAddRows = false;
            this.dgvControleClientes.AllowUserToDeleteRows = false;
            this.dgvControleClientes.AllowUserToResizeColumns = false;
            this.dgvControleClientes.AllowUserToResizeRows = false;
            this.dgvControleClientes.AutoGenerateColumns = false;
            this.dgvControleClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControleClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCli,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dgvControleClientes.DataSource = this.bDEB_ClientesBindingSource;
            this.dgvControleClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControleClientes.GridColor = System.Drawing.Color.DarkViolet;
            this.dgvControleClientes.Location = new System.Drawing.Point(234, 67);
            this.dgvControleClientes.Name = "dgvControleClientes";
            this.dgvControleClientes.ReadOnly = true;
            this.dgvControleClientes.RowHeadersVisible = false;
            this.dgvControleClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControleClientes.Size = new System.Drawing.Size(711, 611);
            this.dgvControleClientes.TabIndex = 27;
            this.dgvControleClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvControleClientes_CellFormatting);
            // 
            // codCli
            // 
            this.codCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codCli.DataPropertyName = "codCli";
            this.codCli.HeaderText = "Código do Cliente";
            this.codCli.Name = "codCli";
            this.codCli.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "nomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome do Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            dataGridViewCellStyle4.Format = "(00)00000-0000";
            this.telefoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDEB_ClientesTableAdapter
            // 
            this.bDEB_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BDEB_ClientesTableAdapter = this.bDEB_ClientesTableAdapter;
            this.tableAdapterManager.BDEB_ProdutosTableAdapter = null;
            this.tableAdapterManager.BDEB_ServicoProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmControleClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(945, 678);
            this.Controls.Add(this.dgvControleClientes);
            this.Controls.Add(this.pnlCabeçalho);
            this.Controls.Add(this.pnlOpções);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControleClientes";
            this.Text = "Controle_de_Clientes";
            this.Load += new System.EventHandler(this.FrmControleClientes_Load);
            this.pnlCabeçalho.ResumeLayout(false);
            this.pnlOpções.ResumeLayout(false);
            this.pnlOpções.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDEB_ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private System.Windows.Forms.Panel pnlCabeçalho;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Panel pnlOpções;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFechar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGravar;
        private Bunifu.Framework.UI.BunifuFlatButton ibMenu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdicionar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAlterar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcluir;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisa;
        private System.Windows.Forms.Label lblFiltrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.DataGridView dgvControleClientes;
        private DsEBGerenciamentoTableAdapters.BDEB_ClientesTableAdapter bDEB_ClientesTableAdapter;
        private System.Windows.Forms.BindingSource bDEB_ClientesBindingSource;
        private DsEBGerenciamento dsEBGerenciamento;
        
        private DsEBGerenciamentoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNomeCli;
    }
}