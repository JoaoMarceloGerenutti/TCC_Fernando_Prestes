using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Espaco_da_Beleza_Gerenciamento
{
    public partial class FrmBackup : Form
    {
        /*
         * Usa uma string para fazer conexão com o banco de dados.
         */
        String sqlconnection = @"Provider=SQLOLEDB.1;Persist Security Info=False;User ID=04909_14_A_1_2017; Password=Informatica1; Initial Catalog=db_04909_14_A_1_2017;Data Source=MOTORHEAD";

        string SqlConn = @"Provider=SQLOLEDB.1;Persist Security Info=False;User ID=04909_14_A_1_2017;Password=Informatica1;Initial Catalog=master;Data Source=DAN\SQLEXPRESSO";
        OleDbConnection conexao;
        string _sql;
        OleDbCommand comando;

        public FrmBackup()
        {
            InitializeComponent();
        }

        private void IbFechar_Click(object sender, EventArgs e)
        {
            /*
             * Fecha a tela de backup e volta para o formulario principal.
             */
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Carrega o arquivo backup.
                 */
                if (rbBackup.Checked)
                {
                    SaveFileDialog SalvarArquivo = new SaveFileDialog();
                    SalvarArquivo.Title = "Gerar Backup";
                    SalvarArquivo.Filter = "Salvar|*.bak";
                    if (SalvarArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        btnLocalArquivo.Text = SalvarArquivo.FileName;
                    }
                }
                else if (rbCarregar.Checked)
                {
                    OpenFileDialog AbrirArquivo = new OpenFileDialog();
                    AbrirArquivo.Title = "Carregar Backup";
                    AbrirArquivo.Filter = "Restaurar o Sistema|*.bak";
                    if (AbrirArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        btnLocalArquivo.Text = AbrirArquivo.FileName;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCarregarGerar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Conecta com o banco de dados e cria um arquivo backup no lugar selecionado, e depois, fecha a conexão.
                 */
                if (rbBackup.Checked)
                {
                    conexao = new OleDbConnection(sqlconnection);
                    _sql = "BACKUP DATABASE db_04909_14_A_1_2017 TO DISK =  '" + btnLocalArquivo.Text + "'";
                    comando = new OleDbCommand(_sql, conexao);
                    comando.CommandText = _sql;
                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Backup realizado com sucesso", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
                else if (rbCarregar.Checked)
                {
                    conexao = new OleDbConnection(SqlConn);
                    conexao.Open();
                    _sql = "Use Master ALTER DATABASE db_04909_14_A_1_2017 SET OFFLINE WITH ROLLBACK IMMEDIATE RESTORE DATABASE db_04909_14_A_1_2017 FROM DISK = '" + btnLocalArquivo.Text + "' ALTER DATABASE db_04909_14_A_1_2017 SET ONLINE WITH ROLLBACK IMMEDIATE";
                    comando = new OleDbCommand(_sql, conexao);
                    comando.CommandText = _sql;
                    try
                    {
                        comando.ExecuteNonQuery();
                        conexao.Close();
                        conexao.Dispose();

                        MessageBox.Show("Restauração do Sistem realizada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a opção desejada!", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RbBackup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Muda o icone e o nome do botão btnCarregarGerar.
                 */
                this.btnCarregarGerar.Text = "Gerar Backup";
                this.btnCarregarGerar.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.GerarBackup;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RbCarregar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Muda o icone e o nome do botão btnCarregarGerar.
                 */
                this.btnCarregarGerar.Text = "Carregar Backup";
                this.btnCarregarGerar.Iconimage = global::Espaco_da_Beleza_Gerenciamento.Properties.Resources.GerarBackup;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
