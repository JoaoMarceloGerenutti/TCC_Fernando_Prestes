using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espaco_da_Beleza_Gerenciamento
{
    public partial class FrmMenu : Form
    {
        private Form objForm;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void IbFechar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Exibe uma mensagem ao tentar sair, caso a resposta seja "Sim", fecha o programa.
                 */
                if (MessageBox.Show(" Deseja continuar? ",
                    "Confirmação de saida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
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
                        MessageBox.Show("Um erro ocorreu ao sair!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbMenu_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Faz com que o menu expanda e contraia.
                 */
                if (pnlMenu.Width == 63)
                {
                    btnLogout.Visible = true;
                    pnlMenu.Visible = false;
                    pnlMenu.Width = 279;
                    Animação_Menu.ShowSync(pnlMenu);
                }
                else
                {
                    btnLogout.Visible = false;
                    pnlMenu.Visible = false;
                    pnlMenu.Width = 63;
                    Animação_Menu.ShowSync(pnlMenu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre o formulario de agendamento e encaixa no menu.
                 */
                this.Text = "Espaço Da Beleza - Agendamento";
                objForm?.Close();
                objForm = new FrmAgendamento
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                /*
                 * Verifica se esta aberto em segundo plano e traz para frente.
                 */
                pnlDGV.Controls.Add(objForm);
                objForm.Show();
                objForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre o formulario de estoque e encaixa no menu.
                 */
                this.Text = "Espaço Da Beleza - Estoque";
                objForm?.Close();
                objForm = new FrmEstoque
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                /*
                 * Verifica se esta aberto em segundo plano e traz para frente.
                 */
                pnlDGV.Controls.Add(objForm);
                objForm.Show();
                objForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbMaximizar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Maximiza a tela e volta para o estado normal dela.
                 */
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.MaximumSize = this.Size;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.MinimumSize = this.Size = new Size(1240, 755);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbMinimizar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Mizimiza a tela.
                 */
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hora_Atual_Tick(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Pega a hora atual e coloca nas labels.
                 */
                lblHora_Atual.Text = DateTime.Now.Hour.ToString("00")
                    + ":" + DateTime.Now.Minute.ToString("00")
                    + ":" + DateTime.Now.Second.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            /*
             * Abre uma confirmação de saida para tela de login.
             */
            if (MessageBox.Show(" Deseja mesmo voltar para a tela de login? ",
                "Fazendo Logoff!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    /*
                     * Reabre o formulario de login.
                     */
                    this.Close();
                    FrmLogin frmlogin = new FrmLogin();
                    frmlogin.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu ao fazer Logoff!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre o formulario de controle de clientes e encaixa no menu.
                 */
                this.Text = "Espaço Da Beleza - Clientes";
                objForm?.Close();
                objForm = new FrmControleClientes
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                /*
                 * Verifica se esta aberto em segundo plano e traz para frente.
                 */
                pnlDGV.Controls.Add(objForm);
                objForm.Show();
                objForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre o formulario de backup e da foco para ele.
                 */
                Form Backup = new FrmBackup();
                Backup.Owner = this;
                Backup.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre o formulario de relatorio e encaixa no menu.
                 */
                this.Text = "Espaço Da Beleza - Relatório";
                objForm?.Close();
                objForm = new RptAgendamento
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                /*
                 * Verifica se esta aberto em segundo plano e traz para frente.
                 */
                pnlDGV.Controls.Add(objForm);
                objForm.Show();
                objForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbConfiguracao_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre e fecha as configurações.
                 */
                if (pnlConfiguracao.Visible == false)
                    pnlConfiguracao.Visible = true;

                else
                {
                    pnlConfiguracao.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre o PDF do manual do usuario que fica dentro da pasta do projeto.
                 */
                System.Diagnostics.Process.Start(@"C:\Users\Votogames\Desktop\TCC-Espaço Da Beleza\Manual Do Usuario.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre o formulario sobre e encaixa no menu.
                 */
                this.Text = "Espaço Da Beleza - Sobre";
                objForm?.Close();
                objForm = new FrmSobre
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                /*
                 * Verifica se esta aberto em segundo plano e traz para frente.
                 */
                pnlDGV.Controls.Add(objForm);
                objForm.Show();
                objForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
