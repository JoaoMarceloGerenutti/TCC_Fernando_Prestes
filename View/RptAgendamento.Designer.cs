namespace Espaco_da_Beleza_Gerenciamento
{
    partial class RptAgendamento
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BDEB_ServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsEBGerenciamento = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamento();
            this.TirarBorda = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BDEB_ServicosTableAdapter = new Espaco_da_Beleza_Gerenciamento.DsEBGerenciamentoTableAdapters.BDEB_ServicosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BDEB_ServicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsEBGerenciamento)).BeginInit();
            this.SuspendLayout();
            // 
            // BDEB_ServicosBindingSource
            // 
            this.BDEB_ServicosBindingSource.DataMember = "BDEB_Servicos";
            this.BDEB_ServicosBindingSource.DataSource = this.DsEBGerenciamento;
            // 
            // DsEBGerenciamento
            // 
            this.DsEBGerenciamento.DataSetName = "DsEBGerenciamento";
            this.DsEBGerenciamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TirarBorda
            // 
            this.TirarBorda.ElipseRadius = 5;
            this.TirarBorda.TargetControl = this;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Agenda";
            reportDataSource1.Value = this.BDEB_ServicosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Espaco_da_Beleza_Gerenciamento.RptAgenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(545, 364);
            this.reportViewer1.TabIndex = 0;
            // 
            // BDEB_ServicosTableAdapter
            // 
            this.BDEB_ServicosTableAdapter.ClearBeforeFill = true;
            // 
            // RptAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 364);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RptAgendamento";
            this.Text = "RptAgendamento";
            this.Load += new System.EventHandler(this.RptAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BDEB_ServicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsEBGerenciamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TirarBorda;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BDEB_ServicosBindingSource;
        private DsEBGerenciamento DsEBGerenciamento;
        private DsEBGerenciamentoTableAdapters.BDEB_ServicosTableAdapter BDEB_ServicosTableAdapter;
    }
}