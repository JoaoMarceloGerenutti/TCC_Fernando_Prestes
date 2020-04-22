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
    public partial class FrmConfirmacaoDeSaida : Form
    {
        public FrmConfirmacaoDeSaida()
        {
            InitializeComponent();

            btnCancelar.Location = new Point(52, 85);
        }

        private void Tmr4_Tick(object sender, EventArgs e)
        {
            /*
             * Muda a label para o valor "4", ativa o timer 3 e desativa o 4.
             */
            lblNumeros.Text = "4";
            tmr4.Enabled = false;
            tmr3.Enabled = true;
        }

        private void Tmr3_Tick(object sender, EventArgs e)
        {
            /*
             * Muda a label para o valor "3", ativa o timer 2 e desativa o 3.
             */
            lblNumeros.Text = "3";
            tmr3.Enabled = false;
            tmr2.Enabled = true;

            /*
             * Organiza os botões e deixa visivel o sair.
             */
            btnSair.Visible = true;
            btnCancelar.Location = new Point(52, 109);
            btnSair.Location = new Point(52, 66);
        }

        private void Tmr2_Tick(object sender, EventArgs e)
        {
            /*
             * Muda a label para o valor "2", ativa o timer 1 e desativa o 2.
             */
            lblNumeros.Text = "2";
            tmr2.Enabled = false;
            tmr1.Enabled = true;
        }

        private void Tmr1_Tick(object sender, EventArgs e)
        {
            /*
             * Muda a label para o valor "1", ativa o timer 0 e desativa o 1.
             */
            lblNumeros.Text = "1";
            tmr1.Enabled = false;
            tmr0.Enabled = true;
        }

        private void Tmr0_Tick(object sender, EventArgs e)
        {
            /*
             * Desativa o timer 0.
             */
            lblNumeros.Text = "0";
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            /*
             * Cancela o fechamento do programa e volta para a tela de login.
             */
            tmr4.Enabled = false;
            tmr3.Enabled = false;
            tmr2.Enabled = false;
            tmr1.Enabled = false;
            tmr0.Enabled = false;
            tmrSair.Enabled = false;
            this.Close();
        }

        private void TmrSair_Tick(object sender, EventArgs e)
        {
            /*
             * Depois de passar o tempo, fecha o programa.
             */
            try
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is Form)
                    {
                        frm.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Fecha o programa.
                 */
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is Form)
                    {
                        frm.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
