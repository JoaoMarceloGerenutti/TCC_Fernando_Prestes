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
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void Loading_Tick(object sender, EventArgs e)
        {
            /* 
             * Desativa o timer e abre o Formulario de Login
             */
            this.Visible = false;
            tmrLoading.Enabled = false;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void tmrProgresso_Tick(object sender, EventArgs e)
        {
            /*
             * Faz o carregamento da barra de progresso
             */
            pgbSplash.PerformStep();

            /*
             * Compara se a barra esta carregada e para o timer
             */
            if (pgbSplash.Value == 100)
            tmrProgresso.Stop();
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            /*
             * Deixa a label transparente na splash screen
             */
            lblTechnoTrab.Parent = ptbSplashScreen;
            lblTechnoTrab.BackColor = Color.Transparent;
        }
    }
}
