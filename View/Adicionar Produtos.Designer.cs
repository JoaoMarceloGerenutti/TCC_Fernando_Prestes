namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmAdicionarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdicionarProduto));
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblCódigo = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.Movimento = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlCabeçalho = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ibProdutos = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblProdutos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ibFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblObs = new System.Windows.Forms.Label();
            this.dsEBGerenciamento = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamento();
            this.bDEB_ProdutosTableAdapter = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.BDEB_ProdutosTableAdapter();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.bDEB_ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbObs = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.TableAdapterManager();
            this.btnAdicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGravar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pnlCabeçalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEB_ProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.ForeColor = System.Drawing.Color.White;
            this.lblCódigo.Location = new System.Drawing.Point(38, 85);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(80, 22);
            this.lblCódigo.TabIndex = 51;
            this.lblCódigo.Text = "Código :";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(38, 122);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(88, 22);
            this.lblProduto.TabIndex = 54;
            this.lblProduto.Text = "Produto :";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(38, 198);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(114, 22);
            this.lblQuantidade.TabIndex = 60;
            this.lblQuantidade.Text = "Quantidade :";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(249, 85);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(66, 22);
            this.lblPreco.TabIndex = 63;
            this.lblPreco.Text = "Preço :";
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
            this.pnlCabeçalho.Controls.Add(this.ibProdutos);
            this.pnlCabeçalho.Controls.Add(this.lblProdutos);
            this.pnlCabeçalho.Controls.Add(this.ibFechar);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.GradientBottomLeft = System.Drawing.Color.Purple;
            this.pnlCabeçalho.GradientBottomRight = System.Drawing.Color.Purple;
            this.pnlCabeçalho.GradientTopLeft = System.Drawing.Color.White;
            this.pnlCabeçalho.GradientTopRight = System.Drawing.Color.Purple;
            this.pnlCabeçalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Quality = 10;
            this.pnlCabeçalho.Size = new System.Drawing.Size(466, 31);
            this.pnlCabeçalho.TabIndex = 37;
            // 
            // ibProdutos
            // 
            this.ibProdutos.BackColor = System.Drawing.Color.Transparent;
            this.ibProdutos.Enabled = false;
            this.ibProdutos.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Produtos;
            this.ibProdutos.ImageActive = null;
            this.ibProdutos.Location = new System.Drawing.Point(0, 0);
            this.ibProdutos.Name = "ibProdutos";
            this.ibProdutos.Size = new System.Drawing.Size(44, 31);
            this.ibProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibProdutos.TabIndex = 51;
            this.ibProdutos.TabStop = false;
            this.ibProdutos.Zoom = 10;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.ForeColor = System.Drawing.Color.Black;
            this.lblProdutos.Location = new System.Drawing.Point(47, 1);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(206, 28);
            this.lblProdutos.TabIndex = 36;
            this.lblProdutos.Text = "Adicionar Produtos";
            this.lblProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibFechar
            // 
            this.ibFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibFechar.BackColor = System.Drawing.Color.Transparent;
            this.ibFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibFechar.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Fechar;
            this.ibFechar.ImageActive = null;
            this.ibFechar.InitialImage = null;
            this.ibFechar.Location = new System.Drawing.Point(430, 3);
            this.ibFechar.Name = "ibFechar";
            this.ibFechar.Size = new System.Drawing.Size(28, 25);
            this.ibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibFechar.TabIndex = 33;
            this.ibFechar.TabStop = false;
            this.ibFechar.Zoom = 20;
            this.ibFechar.Click += new System.EventHandler(this.IbFechar_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.White;
            this.lblObs.Location = new System.Drawing.Point(38, 236);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(122, 22);
            this.lblObs.TabIndex = 70;
            this.lblObs.Text = "Observações :";
            // 
            // dsEBGerenciamento
            // 
            this.dsEBGerenciamento.DataSetName = "DsEBGerenciamento";
            this.dsEBGerenciamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDEB_ProdutosTableAdapter
            // 
            this.bDEB_ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // txbCodigo
            // 
            this.txbCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bDEB_ProdutosBindingSource, "codProduto", true));
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(166, 79);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(75, 31);
            this.txbCodigo.TabIndex = 72;
            // 
            // bDEB_ProdutosBindingSource
            // 
            this.bDEB_ProdutosBindingSource.DataMember = "BDEB_Produtos";
            this.bDEB_ProdutosBindingSource.DataSource = this.dsEBGerenciamento;
            // 
            // txbProduto
            // 
            this.txbProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bDEB_ProdutosBindingSource, "nomeProduto", true));
            this.txbProduto.Enabled = false;
            this.txbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(166, 116);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(262, 31);
            this.txbProduto.TabIndex = 73;
            // 
            // txbMarca
            // 
            this.txbMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bDEB_ProdutosBindingSource, "Marca", true));
            this.txbMarca.Enabled = false;
            this.txbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMarca.Location = new System.Drawing.Point(166, 153);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(262, 31);
            this.txbMarca.TabIndex = 74;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bDEB_ProdutosBindingSource, "Quantidade", true));
            this.nudQuantidade.Enabled = false;
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(166, 193);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(75, 31);
            this.nudQuantidade.TabIndex = 75;
            // 
            // txbPreco
            // 
            this.txbPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bDEB_ProdutosBindingSource, "Preco", true));
            this.txbPreco.Enabled = false;
            this.txbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreco.Location = new System.Drawing.Point(321, 79);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(107, 31);
            this.txbPreco.TabIndex = 76;
            this.txbPreco.Text = "R$ 0,00";
            this.txbPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPreco_KeyPress);
            // 
            // txbObs
            // 
            this.txbObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bDEB_ProdutosBindingSource, "Obs", true));
            this.txbObs.Enabled = false;
            this.txbObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObs.Location = new System.Drawing.Point(166, 230);
            this.txbObs.Multiline = true;
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(262, 84);
            this.txbObs.TabIndex = 77;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BDEB_ClientesTableAdapter = null;
            this.tableAdapterManager.BDEB_ProdutosTableAdapter = null;
            this.tableAdapterManager.BDEB_ServicoProdutoTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.ActiveBorderThickness = 1;
            this.btnAdicionar.ActiveCornerRadius = 20;
            this.btnAdicionar.ActiveFillColor = System.Drawing.Color.White;
            this.btnAdicionar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnAdicionar.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAdicionar.BackColor = System.Drawing.Color.Purple;
            this.btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            this.btnAdicionar.ButtonText = "Adicionar";
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.IdleBorderThickness = 1;
            this.btnAdicionar.IdleCornerRadius = 20;
            this.btnAdicionar.IdleFillColor = System.Drawing.Color.Purple;
            this.btnAdicionar.IdleForecolor = System.Drawing.Color.White;
            this.btnAdicionar.IdleLineColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(20, 277);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(132, 41);
            this.btnAdicionar.TabIndex = 78;
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.ActiveBorderThickness = 1;
            this.btnGravar.ActiveCornerRadius = 20;
            this.btnGravar.ActiveFillColor = System.Drawing.Color.White;
            this.btnGravar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnGravar.ActiveLineColor = System.Drawing.Color.Black;
            this.btnGravar.BackColor = System.Drawing.Color.Purple;
            this.btnGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravar.BackgroundImage")));
            this.btnGravar.ButtonText = "Gravar";
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.IdleBorderThickness = 1;
            this.btnGravar.IdleCornerRadius = 20;
            this.btnGravar.IdleFillColor = System.Drawing.Color.Purple;
            this.btnGravar.IdleForecolor = System.Drawing.Color.White;
            this.btnGravar.IdleLineColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(20, 328);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(132, 41);
            this.btnGravar.TabIndex = 68;
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.White;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.Black;
            this.btnCancelar.BackColor = System.Drawing.Color.Purple;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.Purple;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.White;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(302, 328);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 41);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ActiveBorderThickness = 1;
            this.btnLimpar.ActiveCornerRadius = 20;
            this.btnLimpar.ActiveFillColor = System.Drawing.Color.White;
            this.btnLimpar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLimpar.ActiveLineColor = System.Drawing.Color.Black;
            this.btnLimpar.BackColor = System.Drawing.Color.Purple;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.ButtonText = "Limpar";
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.IdleBorderThickness = 1;
            this.btnLimpar.IdleCornerRadius = 20;
            this.btnLimpar.IdleFillColor = System.Drawing.Color.Purple;
            this.btnLimpar.IdleForecolor = System.Drawing.Color.White;
            this.btnLimpar.IdleLineColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(166, 328);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 41);
            this.btnLimpar.TabIndex = 66;
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click_1);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(38, 159);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(69, 22);
            this.lblMarca.TabIndex = 79;
            this.lblMarca.Text = "Marca :";
            // 
            // FrmAdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(466, 383);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbObs);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.pnlCabeçalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Produtos";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.pnlCabeçalho.ResumeLayout(false);
            this.pnlCabeçalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEB_ProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlCabeçalho;
        private Bunifu.Framework.UI.BunifuImageButton ibProdutos;
        private Bunifu.Framework.UI.BunifuCustomLabel lblProdutos;
        private Bunifu.Framework.UI.BunifuImageButton ibFechar;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGravar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpar;
        private Bunifu.Framework.UI.BunifuDragControl Movimento;
        private System.Windows.Forms.BindingSource bDEB_ProdutosBindingSource;
        private DsEBGerenciamento dsEBGerenciamento;
        private System.Windows.Forms.Label lblObs;
        private DsEBGerenciamentoTableAdapters.BDEB_ProdutosTableAdapter bDEB_ProdutosTableAdapter;
        private DsEBGerenciamentoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txbObs;
        private System.Windows.Forms.TextBox txbPreco;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdicionar;
        private System.Windows.Forms.Label lblMarca;
    }
}