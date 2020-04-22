using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espaco_da_Beleza_Gerenciamento.Model;
using Espaco_da_Beleza_Gerenciamento.Dao;

namespace Espaco_da_Beleza_Gerenciamento
{
    public partial class FrmEsqueciMinhaSenha : Form
    {

        public FrmEsqueciMinhaSenha()
        {
            InitializeComponent();
        }

        private String codigo = "x5cj68";

        private void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Compara com a senha do banco de dados e retorna se é igual ou não,
                 * caso não seja, permite alterar o login se o código estiver correto.
                 */
                BancoSQL bs = new BancoSQL();
                String loginUser = "";

                String sqlUser = "SELECT loginUser FROM Usuarios";
                DataTable dt = bs.QueryAsDataTable(sqlUser);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    loginUser = (row["loginUser"]).ToString();
                }

                Controle controle = new Controle();
                controle.acessar(txbSenhaNova.Text);

                if (controle.mensagem.Equals(""))
                {
                    if (!controle.tem && txbCodigo.Text == codigo)
                    {
                        if (string.IsNullOrEmpty(txbSenhaNova.Text))
                        {
                            MessageBox.Show("Preencha o campo senha!");
                        }
                        else
                        {
                            BancoSQL bsql = new BancoSQL();
                            String sql = $"UPDATE Usuarios SET senha = '{txbSenhaNova.Text}' WHERE loginUser = '{loginUser}'";
                            bsql.InserirDeletarAtualizar(sql);
                            MessageBox.Show("Senha alterada com sucesso");
                            this.Close();
                        }

                    }
                    else if (controle.tem && txbCodigo.Text == codigo)
                    {
                        MessageBox.Show("A senha digitada é igual a senha anterior!");
                    }
                    else
                    {
                        MessageBox.Show("O código está incorreto! Tente novamente!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Cancela a operação de troca de senha e volta para o formulario de login.
                 */
                if (MessageBox.Show(null, "Deseja cancelar a troca de senha?",
                "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibMostrarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Mostra os caracteres do campo código
                 */
                txbCodigo.UseSystemPasswordChar = false;
                ibMostrarCodigo.Visible = false;
                ibEsconderCodigo.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibMostrarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Mostra os caracteres do campo senha
                 */
                txbSenhaNova.UseSystemPasswordChar = false;
                ibMostrarSenha.Visible = false;
                ibEsconderSenha.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibEsconderSenha_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Esconde os caracteres do campo senha.
                 */
                txbSenhaNova.UseSystemPasswordChar = true;
                ibMostrarSenha.Visible = true;
                ibEsconderSenha.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibEsconderCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Esconde os caracteres do campo código.
                 */
                txbCodigo.UseSystemPasswordChar = true;
                ibMostrarCodigo.Visible = true;
                ibEsconderCodigo.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}