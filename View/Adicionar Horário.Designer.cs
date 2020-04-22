namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmAdicionarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdicionarHorario));
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlCabeçalho = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ibHorario = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblHorario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ibFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dsEBGerenciamento = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamento();
            this.bDEB_ServicosTableAdapter = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.BDEB_ServicosTableAdapter();
            this.tableAdapterManager = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.TableAdapterManager();
            this.txbCodigoServico = new System.Windows.Forms.TextBox();
            this.Movimento = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblServico = new System.Windows.Forms.Label();
            this.txbServico = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txbObservacao = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGravar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblPreco = new System.Windows.Forms.Label();
            this.dsEBGerenciamento1 = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamento();
            this.bDEBServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDEB_ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDEB_ClientesTableAdapter = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.BDEB_ClientesTableAdapter();
            this.cmbNomeCliente = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.pnlCabeçalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEBServicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEB_ClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // pnlCabeçalho
            // 
            this.pnlCabeçalho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCabeçalho.BackgroundImage")));
            this.pnlCabeçalho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCabeçalho.Controls.Add(this.ibHorario);
            this.pnlCabeçalho.Controls.Add(this.lblHorario);
            this.pnlCabeçalho.Controls.Add(this.ibFechar);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.GradientBottomLeft = System.Drawing.Color.Purple;
            this.pnlCabeçalho.GradientBottomRight = System.Drawing.Color.Purple;
            this.pnlCabeçalho.GradientTopLeft = System.Drawing.Color.White;
            this.pnlCabeçalho.GradientTopRight = System.Drawing.Color.Purple;
            this.pnlCabeçalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Quality = 10;
            this.pnlCabeçalho.Size = new System.Drawing.Size(567, 31);
            this.pnlCabeçalho.TabIndex = 38;
            // 
            // ibHorario
            // 
            this.ibHorario.BackColor = System.Drawing.Color.Transparent;
            this.ibHorario.Enabled = false;
            this.ibHorario.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Relogio;
            this.ibHorario.ImageActive = null;
            this.ibHorario.Location = new System.Drawing.Point(11, 1);
            this.ibHorario.Name = "ibHorario";
            this.ibHorario.Size = new System.Drawing.Size(30, 28);
            this.ibHorario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibHorario.TabIndex = 51;
            this.ibHorario.TabStop = false;
            this.ibHorario.Zoom = 10;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Location = new System.Drawing.Point(47, 1);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(191, 28);
            this.lblHorario.TabIndex = 36;
            this.lblHorario.Text = "Adicionar Horário";
            this.lblHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibFechar
            // 
            this.ibFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibFechar.BackColor = System.Drawing.Color.Transparent;
            this.ibFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibFechar.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Fechar;
            this.ibFechar.ImageActive = null;
            this.ibFechar.InitialImage = null;
            this.ibFechar.Location = new System.Drawing.Point(535, 3);
            this.ibFechar.Name = "ibFechar";
            this.ibFechar.Size = new System.Drawing.Size(24, 25);
            this.ibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibFechar.TabIndex = 33;
            this.ibFechar.TabStop = false;
            this.ibFechar.Zoom = 20;
            this.ibFechar.Click += new System.EventHandler(this.IbFechar_Click);
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.ForeColor = System.Drawing.Color.White;
            this.lblCódigo.Location = new System.Drawing.Point(38, 85);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(80, 22);
            this.lblCódigo.TabIndex = 52;
            this.lblCódigo.Text = "Código :";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(247, 85);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(76, 22);
            this.lblCliente.TabIndex = 55;
            this.lblCliente.Text = "Cliente :";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(38, 126);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(58, 22);
            this.lblData.TabIndex = 59;
            this.lblData.Text = "Data :";
            // 
            // dsEBGerenciamento
            // 
            this.dsEBGerenciamento.DataSetName = "DsEBGerenciamento";
            this.dsEBGerenciamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDEB_ServicosTableAdapter
            // 
            this.bDEB_ServicosTableAdapter.ClearBeforeFill = true;
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
            // txbCodigoServico
            // 
            this.txbCodigoServico.Enabled = false;
            this.txbCodigoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoServico.Location = new System.Drawing.Point(166, 81);
            this.txbCodigoServico.Name = "txbCodigoServico";
            this.txbCodigoServico.Size = new System.Drawing.Size(75, 31);
            this.txbCodigoServico.TabIndex = 61;
            // 
            // Movimento
            // 
            this.Movimento.Fixed = true;
            this.Movimento.Horizontal = true;
            this.Movimento.TargetControl = this.pnlCabeçalho;
            this.Movimento.Vertical = true;
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Enabled = false;
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(166, 118);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(131, 31);
            this.dtpData.TabIndex = 63;
            this.dtpData.Value = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.White;
            this.lblServico.Location = new System.Drawing.Point(35, 164);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(79, 22);
            this.lblServico.TabIndex = 64;
            this.lblServico.Text = "Serviço :";
            // 
            // txbServico
            // 
            this.txbServico.Enabled = false;
            this.txbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbServico.Location = new System.Drawing.Point(166, 155);
            this.txbServico.Name = "txbServico";
            this.txbServico.Size = new System.Drawing.Size(389, 31);
            this.txbServico.TabIndex = 65;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.White;
            this.lblObs.Location = new System.Drawing.Point(38, 235);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(122, 22);
            this.lblObs.TabIndex = 71;
            this.lblObs.Text = "Observações :";
            // 
            // txbObservacao
            // 
            this.txbObservacao.Enabled = false;
            this.txbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservacao.Location = new System.Drawing.Point(166, 229);
            this.txbObservacao.Multiline = true;
            this.txbObservacao.Name = "txbObservacao";
            this.txbObservacao.Size = new System.Drawing.Size(389, 96);
            this.txbObservacao.TabIndex = 72;
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
            this.btnAdicionar.Location = new System.Drawing.Point(5, 333);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(132, 41);
            this.btnAdicionar.TabIndex = 82;
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
            this.btnGravar.Location = new System.Drawing.Point(147, 333);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(132, 41);
            this.btnGravar.TabIndex = 81;
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
            this.btnCancelar.Location = new System.Drawing.Point(429, 333);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 41);
            this.btnCancelar.TabIndex = 80;
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
            this.btnLimpar.Location = new System.Drawing.Point(291, 333);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 41);
            this.btnLimpar.TabIndex = 79;
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(38, 198);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(66, 22);
            this.lblPreco.TabIndex = 83;
            this.lblPreco.Text = "Preço :";
            // 
            // dsEBGerenciamento1
            // 
            this.dsEBGerenciamento1.DataSetName = "DsEBGerenciamento";
            this.dsEBGerenciamento1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDEBServicosBindingSource
            // 
            this.bDEBServicosBindingSource.DataMember = "BDEB_Servicos";
            this.bDEBServicosBindingSource.DataSource = this.dsEBGerenciamento1;
            // 
            // bDEB_ClientesBindingSource
            // 
            this.bDEB_ClientesBindingSource.DataMember = "BDEB_Clientes";
            this.bDEB_ClientesBindingSource.DataSource = this.dsEBGerenciamento;
            // 
            // bDEB_ClientesTableAdapter
            // 
            this.bDEB_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // cmbNomeCliente
            // 
            this.cmbNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bDEB_ClientesBindingSource, "codCli", true));
            this.cmbNomeCliente.DataSource = this.bDEB_ClientesBindingSource;
            this.cmbNomeCliente.DisplayMember = "nomeCliente";
            this.cmbNomeCliente.Enabled = false;
            this.cmbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeCliente.FormattingEnabled = true;
            this.cmbNomeCliente.Location = new System.Drawing.Point(329, 79);
            this.cmbNomeCliente.Name = "cmbNomeCliente";
            this.cmbNomeCliente.Size = new System.Drawing.Size(226, 33);
            this.cmbNomeCliente.TabIndex = 85;
            this.cmbNomeCliente.ValueMember = "codCli";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(303, 126);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 22);
            this.lblHora.TabIndex = 86;
            this.lblHora.Text = "Hora :";
            // 
            // cmbHora
            // 
            this.cmbHora.Enabled = false;
            this.cmbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "05:00",
            "05:15",
            "05:30",
            "05:45",
            "06:00",
            "06:15",
            "06:30",
            "06:45",
            "07:00",
            "07:15",
            "07:30",
            "07:45",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00",
            "18:15",
            "18:30",
            "18:45",
            "19:00",
            "19:15",
            "19:30",
            "19:45",
            "20:00",
            "20:15",
            "20:30",
            "20:45",
            "21:00",
            "21:15",
            "21:30",
            "21:45",
            "22:00"});
            this.cmbHora.Location = new System.Drawing.Point(385, 118);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(170, 33);
            this.cmbHora.TabIndex = 87;
            this.cmbHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHora_KeyPress);
            // 
            // txbPreco
            // 
            this.txbPreco.Enabled = false;
            this.txbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreco.Location = new System.Drawing.Point(166, 193);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(131, 31);
            this.txbPreco.TabIndex = 90;
            this.txbPreco.Text = "R$ 00,00";
            this.txbPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPreco_KeyPress);
            // 
            // FrmAdicionarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(567, 383);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cmbNomeCliente);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbObservacao);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txbServico);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txbCodigoServico);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.pnlCabeçalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdicionarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Horário";
            this.Load += new System.EventHandler(this.FrmAdicionarHorario_Load);
            this.pnlCabeçalho.ResumeLayout(false);
            this.pnlCabeçalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEBServicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEB_ClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlCabeçalho;
        private Bunifu.Framework.UI.BunifuImageButton ibHorario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHorario;
        private Bunifu.Framework.UI.BunifuImageButton ibFechar;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblData;
        private DsEBGerenciamento dsEBGerenciamento;
        private DsEBGerenciamentoTableAdapters.BDEB_ServicosTableAdapter bDEB_ServicosTableAdapter;
        private DsEBGerenciamentoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txbCodigoServico;
        private Bunifu.Framework.UI.BunifuDragControl Movimento;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txbServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.TextBox txbObservacao;
        private System.Windows.Forms.Label lblObs;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdicionar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGravar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpar;
        private System.Windows.Forms.Label lblPreco;
        private DsEBGerenciamento dsEBGerenciamento1;
        private System.Windows.Forms.BindingSource bDEBServicosBindingSource;
        private System.Windows.Forms.BindingSource bDEB_ClientesBindingSource;
        private DsEBGerenciamentoTableAdapters.BDEB_ClientesTableAdapter bDEB_ClientesTableAdapter;
        private System.Windows.Forms.ComboBox cmbNomeCliente;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.TextBox txbPreco;
    }
}