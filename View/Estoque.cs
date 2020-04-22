using Espaco_da_Beleza_Gerenciamento;
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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        public void AtualizaDados()
        {
            try
            {
                /*
                 * Atualiza os dados do DataGridView dgvMenu.
                 */
                this.bDEB_ProdutosTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Produtos);
                this.bDEB_ProdutosTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Produtos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre um formulario para adicionar produto
                 */
                Form Produto = new FrmAdicionarProduto();
                Produto.Owner = this;
                Produto.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Limpa os campos
                 */
                txbFiltroNome.Text = "";
                txbFiltroMarca.Text = "";
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
                 * Deixa visivel os campos e botões necessarios para fazer a alteração do produto e desabilita a pesquisa.
                 */
                btnGravar.Enabled = true;
                btnLimparEstoque.Enabled = true;
                btnCancelar.Enabled = true;
                btnAdicionar.Visible = false;
                btnExcluir.Visible = false;
                txbFiltroNome.Enabled = false;
                txbFiltroMarca.Enabled = false;
                txbPreco.Enabled = true;
                txbProduto.Enabled = true;
                txbMarca.Enabled = true;
                txbObservacao.Enabled = true;
                nudQuantidade.Enabled = true;
                txbCodigoProduto.Focus();
                dgvMenu.Visible = false;
                dgvEstoque.Visible = true;
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
                 * Pega a linha selecionada do DataGridView e deleta do banco de dados.
                 */
                if (dgvEstoque.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o produto do estoque?",
                        "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        bDEB_ProdutosTableAdapter.Delete(Convert.ToInt32
                            (dgvEstoque[0, dgvEstoque.CurrentRow.Index].Value.ToString()));
                        FrmEstoque_Load(null, null);
                        MessageBox.Show(null, "Produto apagado do estoque com sucesso!",
                            "Excluindo um produto do estoque",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um produto para exclui-lo do estoque primeiro",
                        "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Fecha o formulario de estoque.
                 */
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dsEBGerenciamento.BDEB_Produtos'.
                this.bDEB_ProdutosTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Produtos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbInfo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Filtra o nome do produto no DataGridView.
                 */
                bDEB_ProdutosTableAdapter.FillByNome(this.dsEBGerenciamento.BDEB_Produtos,
                    "%" + txbFiltroNome.Text + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbMarca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Filtra a marca do produto no DataGridView.
                 */
                bDEB_ProdutosTableAdapter.FillByMarca(this.dsEBGerenciamento.BDEB_Produtos,
                    "%" + txbFiltroMarca.Text + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvEstoque_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Verifica se trocou a linha do DataGridView e coloca nas textbox.
                 */
                if (dgvEstoque.RowCount > 0)
                {
                    txbCodigoProduto.Text = dgvEstoque[0, dgvEstoque.CurrentRow.Index].Value.ToString();
                    txbProduto.Text = dgvEstoque[1, dgvEstoque.CurrentRow.Index].Value.ToString();
                    txbPreco.Text = dgvEstoque[2, dgvEstoque.CurrentRow.Index].Value.ToString();
                    txbMarca.Text = dgvEstoque[3, dgvEstoque.CurrentRow.Index].Value.ToString();
                    nudQuantidade.Text = dgvEstoque[4, dgvEstoque.CurrentRow.Index].Value.ToString();
                    txbObservacao.Text = dgvEstoque[5, dgvEstoque.CurrentRow.Index].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimparEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Limpa os campos referente ao estoque.
                 */
                txbProduto.Text = "";
                txbPreco.Text = "";
                txbMarca.Text = "";
                nudQuantidade.Text = "";
                txbObservacao.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Cancela a operação de alterar o produto do estoque.
                 */
                dgvEstoque.Visible = false;
                dgvMenu.Visible = true;
                btnAdicionar.Visible = true;
                btnExcluir.Visible = true;
                txbFiltroNome.Enabled = true;
                txbFiltroMarca.Enabled = true;
                txbPreco.Enabled = false;
                txbProduto.Enabled = false;
                txbMarca.Enabled = false;
                txbObservacao.Enabled = false;
                nudQuantidade.Enabled = false;
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
                 * Inseri no banco de dados as informações das textbox.
                 */
                {
                    bDEB_ProdutosTableAdapter.Update(txbProduto.Text, Convert.ToDouble(txbPreco.Text),
                        txbMarca.Text, (Int32)nudQuantidade.Value, txbObservacao.Text,
                        Convert.ToInt32(txbCodigoProduto.Text));
                    MessageBox.Show(null, "Estoque atualizado com sucesso!", "Atualizando estoque",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                BtnCancelar_Click(null, null);
                FrmEstoque_Load(null, null);
                btnAlterar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                /*
                 * Formata a textbox txbPreco para o formato de dinheiro.
                 */
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre a calculadora nativa do windows.
                 */
                System.Diagnostics.Process.Start("Calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
