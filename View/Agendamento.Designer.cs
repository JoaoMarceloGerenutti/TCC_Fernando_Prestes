namespace Espaco_da_Beleza_Gerenciamento
{
    partial class FrmAgendamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlOpções = new System.Windows.Forms.Panel();
            this.dtpDisponibilidade = new System.Windows.Forms.DateTimePicker();
            this.btnDisponibilidade = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHorario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txbFiltroCliente = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.btnLimpar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnFechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ibMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAlterar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPesquisa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pnlCabeçalho = new System.Windows.Forms.Panel();
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bDEBServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEBGerenciamento = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamento();
            this.bDEB_ServicosTableAdapter = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.BDEB_ServicosTableAdapter();
            this.tableAdapterManager = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.TableAdapterManager();
            this.dgvAgendamento = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnGravar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimparAgenda = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbObservacao = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txbServico = new System.Windows.Forms.TextBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.txbCodigoServico = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.cmbNomeCliente = new System.Windows.Forms.ComboBox();
            this.bDEBClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDEB_ClientesTableAdapter = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.BDEB_ClientesTableAdapter();
            this.dgvTela = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOpções.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCabeçalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDEBServicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEBClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTela)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpções
            // 
            this.pnlOpções.BackColor = System.Drawing.Color.White;
            this.pnlOpções.Controls.Add(this.dtpDisponibilidade);
            this.pnlOpções.Controls.Add(this.btnDisponibilidade);
            this.pnlOpções.Controls.Add(this.pictureBox1);
            this.pnlOpções.Controls.Add(this.btnHorario);
            this.pnlOpções.Controls.Add(this.txbFiltroCliente);
            this.pnlOpções.Controls.Add(this.lblFiltrar);
            this.pnlOpções.Controls.Add(this.btnLimpar);
            this.pnlOpções.Controls.Add(this.btnFechar);
            this.pnlOpções.Controls.Add(this.ibMenu);
            this.pnlOpções.Controls.Add(this.btnAdicionar);
            this.pnlOpções.Controls.Add(this.btnAlterar);
            this.pnlOpções.Controls.Add(this.btnExcluir);
            this.pnlOpções.Controls.Add(this.btnPesquisa);
            this.pnlOpções.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpções.Location = new System.Drawing.Point(0, 0);
            this.pnlOpções.Name = "pnlOpções";
            this.pnlOpções.Size = new System.Drawing.Size(234, 697);
            this.pnlOpções.TabIndex = 22;
            // 
            // dtpDisponibilidade
            // 
            this.dtpDisponibilidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDisponibilidade.CustomFormat = "dd/MM/yyyy";
            this.dtpDisponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDisponibilidade.Location = new System.Drawing.Point(47, 581);
            this.dtpDisponibilidade.Name = "dtpDisponibilidade";
            this.dtpDisponibilidade.Size = new System.Drawing.Size(142, 31);
            this.dtpDisponibilidade.TabIndex = 120;
            this.dtpDisponibilidade.Value = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // btnDisponibilidade
            // 
            this.btnDisponibilidade.ActiveBorderThickness = 1;
            this.btnDisponibilidade.ActiveCornerRadius = 20;
            this.btnDisponibilidade.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnDisponibilidade.ActiveForecolor = System.Drawing.Color.White;
            this.btnDisponibilidade.ActiveLineColor = System.Drawing.Color.White;
            this.btnDisponibilidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisponibilidade.BackColor = System.Drawing.Color.White;
            this.btnDisponibilidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisponibilidade.BackgroundImage")));
            this.btnDisponibilidade.ButtonText = "Disponibilidade";
            this.btnDisponibilidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisponibilidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibilidade.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDisponibilidade.IdleBorderThickness = 1;
            this.btnDisponibilidade.IdleCornerRadius = 20;
            this.btnDisponibilidade.IdleFillColor = System.Drawing.Color.White;
            this.btnDisponibilidade.IdleForecolor = System.Drawing.Color.Purple;
            this.btnDisponibilidade.IdleLineColor = System.Drawing.Color.Purple;
            this.btnDisponibilidade.Location = new System.Drawing.Point(47, 612);
            this.btnDisponibilidade.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisponibilidade.Name = "btnDisponibilidade";
            this.btnDisponibilidade.Size = new System.Drawing.Size(142, 41);
            this.btnDisponibilidade.TabIndex = 49;
            this.btnDisponibilidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDisponibilidade.Click += new System.EventHandler(this.BtnDisponibilidade_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Calendario1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 405);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnHorario
            // 
            this.btnHorario.Activecolor = System.Drawing.Color.Purple;
            this.btnHorario.BackColor = System.Drawing.Color.Purple;
            this.btnHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHorario.BorderRadius = 0;
            this.btnHorario.ButtonText = "        CALENDÁRIO";
            this.btnHorario.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHorario.DisabledColor = System.Drawing.Color.Gray;
            this.btnHorario.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHorario.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.Calendario;
            this.btnHorario.Iconimage_right = null;
            this.btnHorario.Iconimage_right_Selected = null;
            this.btnHorario.Iconimage_Selected = null;
            this.btnHorario.IconMarginLeft = 0;
            this.btnHorario.IconMarginRight = 0;
            this.btnHorario.IconRightVisible = true;
            this.btnHorario.IconRightZoom = 0D;
            this.btnHorario.IconVisible = true;
            this.btnHorario.IconZoom = 90D;
            this.btnHorario.IsTab = false;
            this.btnHorario.Location = new System.Drawing.Point(0, 351);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Normalcolor = System.Drawing.Color.Purple;
            this.btnHorario.OnHovercolor = System.Drawing.Color.Purple;
            this.btnHorario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHorario.selected = false;
            this.btnHorario.Size = new System.Drawing.Size(247, 48);
            this.btnHorario.TabIndex = 38;
            this.btnHorario.Text = "        CALENDÁRIO";
            this.btnHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorario.Textcolor = System.Drawing.Color.White;
            this.btnHorario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txbFiltroCliente
            // 
            this.txbFiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltroCliente.Location = new System.Drawing.Point(43, 319);
            this.txbFiltroCliente.Name = "txbFiltroCliente";
            this.txbFiltroCliente.Size = new System.Drawing.Size(146, 26);
            this.txbFiltroCliente.TabIndex = 47;
            this.txbFiltroCliente.TextChanged += new System.EventHandler(this.TxtFiltrar_TextChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFiltrar.ForeColor = System.Drawing.Color.Purple;
            this.lblFiltrar.Location = new System.Drawing.Point(59, 294);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(120, 22);
            this.lblFiltrar.TabIndex = 46;
            this.lblFiltrar.Text = "Filtrar Cliente";
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
            this.btnLimpar.Location = new System.Drawing.Point(117, 651);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 41);
            this.btnLimpar.TabIndex = 37;
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(5, 651);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(109, 41);
            this.btnFechar.TabIndex = 35;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
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
            this.btnAdicionar.ButtonText = "Adicionar Horário";
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
            this.btnAlterar.ButtonText = "Alterar Horário";
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
            this.btnExcluir.ButtonText = "Excluir Horário";
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
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click_1);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Activecolor = System.Drawing.Color.Purple;
            this.btnPesquisa.BackColor = System.Drawing.Color.Purple;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisa.BorderRadius = 0;
            this.btnPesquisa.ButtonText = "          PESQUISAR";
            this.btnPesquisa.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            this.btnPesquisa.Size = new System.Drawing.Size(245, 48);
            this.btnPesquisa.TabIndex = 27;
            this.btnPesquisa.Text = "          PESQUISAR";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Textcolor = System.Drawing.Color.White;
            this.btnPesquisa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblTexto.Text = "Agendamento";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCabeçalho
            // 
            this.pnlCabeçalho.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlCabeçalho.Controls.Add(this.lblTexto);
            this.pnlCabeçalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeçalho.Location = new System.Drawing.Point(234, 0);
            this.pnlCabeçalho.Name = "pnlCabeçalho";
            this.pnlCabeçalho.Size = new System.Drawing.Size(727, 67);
            this.pnlCabeçalho.TabIndex = 24;
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // bDEBServicosBindingSource
            // 
            this.bDEBServicosBindingSource.DataMember = "BDEB_Servicos";
            this.bDEBServicosBindingSource.DataSource = this.dsEBGerenciamento;
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
            // dgvAgendamento
            // 
            this.dgvAgendamento.AllowUserToAddRows = false;
            this.dgvAgendamento.AllowUserToDeleteRows = false;
            this.dgvAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgendamento.AutoGenerateColumns = false;
            this.dgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.DataS,
            this.Horario,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.dgvAgendamento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAgendamento.DataSource = this.bDEBServicosBindingSource;
            this.dgvAgendamento.GridColor = System.Drawing.Color.Purple;
            this.dgvAgendamento.Location = new System.Drawing.Point(234, 385);
            this.dgvAgendamento.Name = "dgvAgendamento";
            this.dgvAgendamento.ReadOnly = true;
            this.dgvAgendamento.RowHeadersVisible = false;
            this.dgvAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgendamento.Size = new System.Drawing.Size(727, 312);
            this.dgvAgendamento.TabIndex = 24;
            this.dgvAgendamento.Visible = false;
            this.dgvAgendamento.SelectionChanged += new System.EventHandler(this.DgvAgendamento_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codServico";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código do Serviço";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomeServico";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Serviço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "codCli";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código do Cliente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nomeCliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // DataS
            // 
            this.DataS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataS.DataPropertyName = "DataS";
            this.DataS.HeaderText = "Data";
            this.DataS.Name = "DataS";
            this.DataS.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            dataGridViewCellStyle7.Format = "t";
            dataGridViewCellStyle7.NullValue = "##";
            this.Horario.DefaultCellStyle = dataGridViewCellStyle7;
            this.Horario.HeaderText = "Horário";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precoCobrado";
            dataGridViewCellStyle8.Format = "$ ###,###,##0.00";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Obs";
            this.dataGridViewTextBoxColumn4.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // txbPreco
            // 
            this.txbPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbPreco.Enabled = false;
            this.txbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreco.Location = new System.Drawing.Point(457, 195);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(103, 31);
            this.txbPreco.TabIndex = 116;
            this.txbPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPreco_KeyPress);
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(329, 201);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(66, 22);
            this.lblPreco.TabIndex = 115;
            this.lblPreco.Text = "Preço :";
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
            this.btnGravar.Location = new System.Drawing.Point(441, 336);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(132, 41);
            this.btnGravar.TabIndex = 113;
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
            this.btnCancelar.Location = new System.Drawing.Point(723, 336);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 41);
            this.btnCancelar.TabIndex = 112;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnLimparAgenda
            // 
            this.btnLimparAgenda.ActiveBorderThickness = 1;
            this.btnLimparAgenda.ActiveCornerRadius = 20;
            this.btnLimparAgenda.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnLimparAgenda.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimparAgenda.ActiveLineColor = System.Drawing.Color.White;
            this.btnLimparAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparAgenda.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimparAgenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparAgenda.BackgroundImage")));
            this.btnLimparAgenda.ButtonText = "Limpar";
            this.btnLimparAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparAgenda.Enabled = false;
            this.btnLimparAgenda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAgenda.ForeColor = System.Drawing.Color.Black;
            this.btnLimparAgenda.IdleBorderThickness = 1;
            this.btnLimparAgenda.IdleCornerRadius = 20;
            this.btnLimparAgenda.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnLimparAgenda.IdleForecolor = System.Drawing.Color.White;
            this.btnLimparAgenda.IdleLineColor = System.Drawing.Color.White;
            this.btnLimparAgenda.Location = new System.Drawing.Point(587, 336);
            this.btnLimparAgenda.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimparAgenda.Name = "btnLimparAgenda";
            this.btnLimparAgenda.Size = new System.Drawing.Size(126, 41);
            this.btnLimparAgenda.TabIndex = 111;
            this.btnLimparAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimparAgenda.Click += new System.EventHandler(this.BtnLimparAgenda_Click);
            // 
            // txbObservacao
            // 
            this.txbObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbObservacao.Enabled = false;
            this.txbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservacao.Location = new System.Drawing.Point(457, 232);
            this.txbObservacao.Multiline = true;
            this.txbObservacao.Name = "txbObservacao";
            this.txbObservacao.Size = new System.Drawing.Size(392, 96);
            this.txbObservacao.TabIndex = 110;
            // 
            // lblObs
            // 
            this.lblObs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.White;
            this.lblObs.Location = new System.Drawing.Point(329, 238);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(122, 22);
            this.lblObs.TabIndex = 109;
            this.lblObs.Text = "Observações :";
            // 
            // txbServico
            // 
            this.txbServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbServico.Enabled = false;
            this.txbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbServico.Location = new System.Drawing.Point(457, 158);
            this.txbServico.Name = "txbServico";
            this.txbServico.Size = new System.Drawing.Size(392, 31);
            this.txbServico.TabIndex = 108;
            // 
            // lblServico
            // 
            this.lblServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.White;
            this.lblServico.Location = new System.Drawing.Point(326, 167);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(79, 22);
            this.lblServico.TabIndex = 107;
            this.lblServico.Text = "Serviço :";
            // 
            // txbCodigoServico
            // 
            this.txbCodigoServico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbCodigoServico.Enabled = false;
            this.txbCodigoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoServico.Location = new System.Drawing.Point(457, 84);
            this.txbCodigoServico.Name = "txbCodigoServico";
            this.txbCodigoServico.Size = new System.Drawing.Size(75, 31);
            this.txbCodigoServico.TabIndex = 105;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(538, 88);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(76, 22);
            this.lblCliente.TabIndex = 103;
            this.lblCliente.Text = "Cliente :";
            // 
            // lblCódigo
            // 
            this.lblCódigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.ForeColor = System.Drawing.Color.White;
            this.lblCódigo.Location = new System.Drawing.Point(329, 88);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(80, 22);
            this.lblCódigo.TabIndex = 102;
            this.lblCódigo.Text = "Código :";
            // 
            // cmbHora
            // 
            this.cmbHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.cmbHora.Location = new System.Drawing.Point(676, 121);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(173, 33);
            this.cmbHora.TabIndex = 121;
            this.cmbHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHora_KeyPress);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(594, 129);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 22);
            this.lblHora.TabIndex = 120;
            this.lblHora.Text = "Hora :";
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Enabled = false;
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(457, 121);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(131, 31);
            this.dtpData.TabIndex = 119;
            this.dtpData.Value = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(329, 129);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(58, 22);
            this.lblData.TabIndex = 118;
            this.lblData.Text = "Data :";
            // 
            // cmbNomeCliente
            // 
            this.cmbNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNomeCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNomeCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNomeCliente.DataSource = this.bDEBClientesBindingSource;
            this.cmbNomeCliente.DisplayMember = "nomeCliente";
            this.cmbNomeCliente.Enabled = false;
            this.cmbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeCliente.FormattingEnabled = true;
            this.cmbNomeCliente.Location = new System.Drawing.Point(623, 82);
            this.cmbNomeCliente.Name = "cmbNomeCliente";
            this.cmbNomeCliente.Size = new System.Drawing.Size(226, 33);
            this.cmbNomeCliente.TabIndex = 122;
            this.cmbNomeCliente.ValueMember = "codCli";
            // 
            // bDEBClientesBindingSource
            // 
            this.bDEBClientesBindingSource.DataMember = "BDEB_Clientes";
            this.bDEBClientesBindingSource.DataSource = this.dsEBGerenciamento;
            // 
            // bDEB_ClientesTableAdapter
            // 
            this.bDEB_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvTela
            // 
            this.dgvTela.AllowUserToAddRows = false;
            this.dgvTela.AllowUserToDeleteRows = false;
            this.dgvTela.AutoGenerateColumns = false;
            this.dgvTela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvTela.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvTela.DataSource = this.bDEBServicosBindingSource;
            this.dgvTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTela.GridColor = System.Drawing.Color.Purple;
            this.dgvTela.Location = new System.Drawing.Point(234, 67);
            this.dgvTela.Name = "dgvTela";
            this.dgvTela.ReadOnly = true;
            this.dgvTela.RowHeadersVisible = false;
            this.dgvTela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTela.Size = new System.Drawing.Size(727, 630);
            this.dgvTela.TabIndex = 123;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codServico";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código do Serviço";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nomeServico";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nome do Serviço";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "codCli";
            this.dataGridViewTextBoxColumn9.HeaderText = "Código do Cliente";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nomeCliente";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DataS";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Horario";
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = "##";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn12.HeaderText = "Horário";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "precoCobrado";
            dataGridViewCellStyle6.Format = "$ ###,###,##0.00";
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn13.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Obs";
            this.dataGridViewTextBoxColumn14.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(961, 697);
            this.Controls.Add(this.dgvTela);
            this.Controls.Add(this.dgvAgendamento);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimparAgenda);
            this.Controls.Add(this.txbObservacao);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txbServico);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.txbCodigoServico);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.pnlCabeçalho);
            this.Controls.Add(this.pnlOpções);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cmbNomeCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FrmAgendamento_Load);
            this.pnlOpções.ResumeLayout(false);
            this.pnlOpções.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCabeçalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bDEBServicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEBGerenciamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEBClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpções;
        private System.Windows.Forms.Panel pnlCabeçalho;
        private System.Windows.Forms.Label lblTexto;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisa;
        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcluir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdicionar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAlterar;
        private Bunifu.Framework.UI.BunifuFlatButton ibMenu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFechar;
        private DsEBGerenciamento dsEBGerenciamento;
        private System.Windows.Forms.BindingSource bDEBServicosBindingSource;
        private DsEBGerenciamentoTableAdapters.BDEB_ServicosTableAdapter bDEB_ServicosTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpar;
        private System.Windows.Forms.TextBox txbFiltroCliente;
        private System.Windows.Forms.Label lblFiltrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnHorario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvAgendamento;
        private DsEBGerenciamentoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label lblPreco;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGravar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimparAgenda;
        private System.Windows.Forms.TextBox txbObservacao;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txbServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.TextBox txbCodigoServico;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cmbNomeCliente;
        private System.Windows.Forms.BindingSource bDEBClientesBindingSource;
        private DsEBGerenciamentoTableAdapters.BDEB_ClientesTableAdapter bDEB_ClientesTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDisponibilidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DateTimePicker dtpDisponibilidade;
        private System.Windows.Forms.DataGridView dgvTela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}

