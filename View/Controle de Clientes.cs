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
    public partial class FrmControleClientes : Form
    {
        bool incluir = false;
        bool alterar = false;

        public FrmControleClientes()
        {
            InitializeComponent();

            try
            {
                /*
                 * Desabilita todos os campos ao iniciar.
                 */
                btnGravar.Visible = false;
                btnCancelar.Visible = false;
                txtCodCli.Enabled = false;
                txtNomeCli.Enabled = false;
                mskTelefone.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BDEB_ClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Valida os campos do DataGridView e o atualiza.
                 */
                this.Validate();
                this.bDEB_ClientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsEBGerenciamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaBotoes(bool hab)
        {
            try
            {
                /*
                 * Habilita os botões.
                 */
                btnAdicionar.Enabled = hab;
                btnAlterar.Enabled = hab;
                btnExcluir.Enabled = hab;
                btnGravar.Enabled = !hab;
                btnCancelar.Enabled = !hab;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaCampos(bool hab)
        {
            try
            {
                /*
                 * Habilita os campos.
                 */
                txtNomeCli.Enabled = hab;
                txtFiltrar.Enabled = !hab;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpaCampos()
        {
            try
            {
                /*
                 * Limpa os campos.
                 */
                txtFiltrar.Text = "";
                txtNomeCli.Text = "";
                mskTelefone.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Fecha o controle de clientes.
                 */
                this.Close();
            }
            catch
            {
                MessageBox.Show(null, "Termine de adicionar/alterar um cliente primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Libera os campos para fazer edição.
                 */
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                btnGravar.Visible = true;
                btnCancelar.Visible = true;
                mskTelefone.Enabled = true;
                txtCodCli.Text = "";
                habilitaBotoes(false);
                habilitaCampos(true);
                incluir = true;
                txtNomeCli.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Ativa os campos necessarios para editar um cliente.
                 */
                if (dgvControleClientes.SelectedRows.Count > 0)
                {
                    btnAdicionar.Visible = false;
                    btnExcluir.Visible = false;
                    btnGravar.Visible = true;
                    btnCancelar.Visible = true;
                    mskTelefone.Enabled = true;
                    alterar = true;
                    habilitaBotoes(false);
                    habilitaCampos(true);
                    txtCodCli.Text = dgvControleClientes[0, dgvControleClientes.CurrentRow.Index].Value.ToString();
                    txtNomeCli.Text = dgvControleClientes[1, dgvControleClientes.CurrentRow.Index].Value.ToString();
                    mskTelefone.Text = dgvControleClientes[2, dgvControleClientes.CurrentRow.Index].Value.ToString();
                }
                else
                {
                    MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Exclui o cliente selecionado do DataGridView. 
                 */
                if (dgvControleClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado da lista?",
                        "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        bDEB_ClientesTableAdapter.Delete(Convert.ToInt32
                            (dgvControleClientes[0, dgvControleClientes.CurrentRow.Index].Value.ToString()));
                        FrmControleClientes_Load(null, null);
                        MessageBox.Show(null, "Cliente excluido da lista com sucesso!", "Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um cliente para excluir primeiro", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmControleClientes_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dsEBGerenciamento.BDEB_Clientes'.
                this.bDEB_ClientesTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Clientes);

                // TODO: esta linha de código carrega dados na tabela 'dsEBGerenciamento.BDEB_Clientes'.
                this.bDEB_ClientesTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Filtra os clientes por nome.
                 */
                bDEB_ClientesTableAdapter.FillByNome(this.dsEBGerenciamento.BDEB_Clientes,
                    "%" + txtFiltrar.Text + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvControleClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                /*
                 * Aplica formatação no DataGridView.
                 */
                if (this.dgvControleClientes.Columns[e.ColumnIndex].DataPropertyName == "Telefone")
                {
                    if (e.Value != null)
                    {
                        string stringValue = (string)e.Value;
                        if (stringValue != "")
                        {
                            stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5)
                                + "-" + stringValue.Substring(7, 4);
                            e.Value = stringValue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Grava as informações dos campos no banco de dados e reccarega o DataGridView.
                 */
                if (incluir)
                {
                    bDEB_ClientesTableAdapter.Insert(txtNomeCli.Text, mskTelefone.Text);
                    MessageBox.Show("Cliente incluido na lista com sucesso!", "Inclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnGravar.Visible = false;
                    btnCancelar.Visible = false;
                    txtNomeCli.Enabled = true;
                    btnAdicionar.Visible = true;
                    btnAlterar.Visible = true;
                    btnExcluir.Visible = true;
                    mskTelefone.Enabled = false;
                }
                if (alterar)
                {
                    bDEB_ClientesTableAdapter.Update(txtNomeCli.Text, mskTelefone.Text, Convert.ToInt32(txtCodCli.Text));
                    MessageBox.Show("Os dados do cliente foram alterados com sucesso!", "Alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnGravar.Visible = false;
                    btnCancelar.Visible = false;
                    btnAdicionar.Visible = true;
                    btnAlterar.Visible = true;
                    btnExcluir.Visible = true;
                    mskTelefone.Enabled = false;
                }
                FrmControleClientes_Load(null, null);
                BtnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Cancela a operação de adicionar os clientes e desativos os campos.
                 */
                mskTelefone.Enabled = false;
                btnGravar.Visible = false;
                btnCancelar.Visible = false;
                btnAdicionar.Visible = true;
                btnAlterar.Visible = true;
                btnExcluir.Visible = true;
                incluir = false;
                alterar = false;
                habilitaBotoes(true);
                habilitaCampos(false);

                FrmControleClientes_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BDEB_ClientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Valida os campos do DataGridView e o atualiza.
                 */
                this.Validate();
                this.bDEB_ClientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsEBGerenciamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MskTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                /*
                 * Formata o campo de telefone.
                 */
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
