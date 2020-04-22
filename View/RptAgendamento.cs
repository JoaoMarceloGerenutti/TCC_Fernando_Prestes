using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espaco_da_Beleza_Gerenciamento
{
    public partial class RptAgendamento : Form
    {
        public RptAgendamento()
        {
            InitializeComponent();
        }

        private void RptAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsEBGerenciamento.BDEB_Servicos' table. You can move, or remove it, as needed.
            this.BDEB_ServicosTableAdapter.Fill(this.DsEBGerenciamento.BDEB_Servicos);

            this.reportViewer1.RefreshReport();
        }
    }
}
