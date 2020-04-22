using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Espaco_da_Beleza_Gerenciamento.Model;

namespace Espaco_da_Beleza_Gerenciamento
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void IbFechar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre o formulario para confirmação da saida.
                 */
                FrmConfirmacaoDeSaida frmSaida = new FrmConfirmacaoDeSaida();
                frmSaida.ShowDialog();
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
                 * Muda o estado da janela para minimizado.
                 */
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LblEsqueciSenha_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre o formulario para trocar a senha.
                 */
                FrmEsqueciMinhaSenha frmesqueciminhasenha = new FrmEsqueciMinhaSenha();
                frmesqueciminhasenha.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Pega oque foi digita na textbox e compara com a senha do usuario no banco de dados,
                 * para efetuar o acesso ao sistema.
                 */
                Controle controle = new Controle();
                controle.acessar(txbSenha.Text);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem)
                    {
                        MessageBox.Show("Logado com sucesso!");
                        this.Close();
                        FrmMenu Menu = new FrmMenu();
                        Menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login inválido!");
                        txbSenha.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Mostra os caracteres da senha.
                 */
                txbSenha.UseSystemPasswordChar = false;
                btnMostrar.Visible = false;
                btnEsconder.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEsconder_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Esconde os caracteres da senha.
                 */
                txbSenha.UseSystemPasswordChar = true;
                btnMostrar.Visible = true;
                btnEsconder.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                /*
                 * Faz com que quando pressione a tecla ENTER, dispare o evento do BtnLogin.
                 */
                if (e.KeyCode == Keys.Enter)
                {
                    BtnLogin_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
