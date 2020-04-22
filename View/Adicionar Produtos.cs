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
    public partial class FrmAdicionarProduto : Form
    {

        public FrmAdicionarProduto()
        {
            InitializeComponent();

            txbCodigo.Text = "";
            txbProduto.Text = "";
            txbPreco.Text = "";
            txbMarca.Text = "";
            nudQuantidade.Text = "";
            txbObs.Text = "";
        }

        private void habilitaCampos(bool hab)
        {
            /*
             * Habilita os campos.
             */
            txbProduto.Enabled = hab;
            txbMarca.Enabled = hab;
            txbPreco.Enabled = hab;
            nudQuantidade.Enabled = hab;
            txbObs.Enabled = hab;
        }

        private void habilitaBotoes(bool hab)
        {
            /*
             * Habilita os botões.
             */
            btnGravar.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }

        private void limpaCampos()
        {
            /*
             * Limpa os campos do tipo textbox, maskedtextbox e numericuodown.
             */
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "$";
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }
            }
        }

        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            /*
             * Limpas os campos.
             */
            txbProduto.Text = "";
            txbPreco.Text = "";
            txbMarca.Text = "";
            nudQuantidade.Text = "";
            txbObs.Text = "";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            /*
             * Cancela a operação de adicionar os produtos.
             */
            habilitaBotoes(true);
            habilitaCampos(false);
            limpaCampos();
            btnAdicionar.Visible = true;
        }

        private void IbFechar_Click(object sender, EventArgs e)
        {
            /*
             * Fecha o formulario de adicionar produtos e volta para tela de estoque.
             */
            if (MessageBox.Show(" Deseja mesmo fechar? ", "Todas as alterações feitas não seram salvas ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ((FrmEstoque)this.Owner).AtualizaDados();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao voltar para tela de estoque!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BDEB_ProdutosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*
             * Salva a posição do DataGridView.
             */
            this.Validate();
            this.bDEB_ProdutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsEBGerenciamento);

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsEBGerenciamento.BDEB_Produtos'.
            this.bDEB_ProdutosTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Produtos);

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            /*
             * Pega as informações dos campos e salva no banco de dados.
             */
            try
            {
                {
                    bDEB_ProdutosTableAdapter.Insert(txbProduto.Text, Convert.ToDouble(txbPreco.Text),
                        txbMarca.Text, (Int32)nudQuantidade.Value, txbObs.Text);
                    MessageBox.Show(null, "Produto adicionado ao estoque com sucesso!", "Adicionando novo produto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            /*
             * Faz com que os campos necessarios para adicionar produtos sejam habilitados.
             */
            btnAdicionar.Visible = false;
            habilitaBotoes(false);
            habilitaCampos(true);
            limpaCampos();
            txbProduto.Focus();
        }

        private void TxbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * Formata a textbox txbPreco para ficar no formato de dinheiro.
             */
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }
    }
}

