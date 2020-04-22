using Espaco_da_Beleza_Gerenciamento.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espaco_da_Beleza_Gerenciamento
{
    public partial class FrmAdicionarHorario : Form
    {
        bool incluir = false;

        public FrmAdicionarHorario()
        {
            InitializeComponent();

            txbCodigoServico.Text = "";
            cmbNomeCliente.Text = "";
            dtpData.Text = "";
            txbServico.Text = "";
            txbPreco.Text = "";
            txbObservacao.Text = "";
        }

        private void habilitaCampos(bool hab)
        {
            /*
             * Habilita os campos.
             */
            dtpData.Enabled = hab;
            cmbNomeCliente.Enabled = hab;
            txbServico.Enabled = hab;
            txbPreco.Enabled = hab;
            txbObservacao.Enabled = hab;
        }

        private void habilitaBotoes(bool hab)
        {
            /*
             * Habilita os botões.
             */
            btnAdicionar.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }

        private void FrmAdicionarHorario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsEBGerenciamento.BDEB_Clientes'.
            this.bDEB_ClientesTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Clientes);
            // TODO: esta linha de código carrega dados na tabela 'dsEBGerenciamento1.BDEB_Servicos'.
            this.bDEB_ServicosTableAdapter.Fill(this.dsEBGerenciamento1.BDEB_Servicos);
        }

        private void IbFechar_Click(object sender, EventArgs e)
        {
            /*
             * Fecha o formulario adicionar horario e volta para tela de agendamento
             */
            if (MessageBox.Show(" Deseja mesmo fechar? ", "Todas as alterações feitas não seram salvas ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ((FrmAgendamento)this.Owner).AtualizaDados();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao voltar para tela de agendamento!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            /*
             * Habilita os campos para edição.
             */
            cmbHora.Enabled = true;
            btnAdicionar.Visible = false;
            habilitaBotoes(false);
            habilitaCampos(true);
            limpaCampos();
            incluir = true;
            txbCodigoServico.Focus();
        }

        private void limpaCampos()
        {
            /*
             * Limpas os campos do tipo textbox, combobox e datetimepicker.
             */
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count > 0)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Pega as informações inseridas nas combobox e textbox, e inseri no banco de dados.
                 */
                DateTime dataS = Convert.ToDateTime(dtpData.Value.ToShortDateString());
                TimeSpan hora;
                TimeSpan.TryParseExact(cmbHora.Text, @"hh\:mm", CultureInfo.InvariantCulture, out hora);
                string dataC = (dtpData.Value).ToString("dd/MM/yyyy");
                string sql = $"select Horario, BDEB_Servicos.codCli , DataS, BDEB_Clientes.nomeCliente from BDEB_Servicos inner join BDEB_Clientes on BDEB_Servicos.codCli = BDEB_Clientes.codCli where DataS = '{dataC}' and Horario = '{hora.ToString()}'";
                BancoSQL bs = new BancoSQL();
                DataTable dt = bs.QueryAsDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    MessageBox.Show(null, "Já existe um cliente neste horário, por favor verifique"
                        + "\n" + "Cliente: " + (row["codCli"]).ToString()
                        + "\n" + "Nome: " + (row["nomeCliente"]).ToString()
                        + "\n" + "Data do Atendimento: " + Convert.ToDateTime((row["DataS"])).ToString("dd/MM/yyyy")
                        + "\n" + "Horário: " + (row["Horario"]).ToString(), "Conflito de horário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DateTime dataSa = Convert.ToDateTime(dtpData.Value.ToShortDateString());
                    TimeSpan horaSa;
                    horaSa = TimeSpan.Parse(cmbHora.SelectedItem.ToString());     
                    horaSa = TimeSpan.Parse(cmbHora.SelectedItem.ToString());
                    btnGravar.Visible = true;
                    if (incluir)
                        bDEB_ServicosTableAdapter.InsertQuery(horaSa.ToString(),
                            txbServico.Text,
                            txbObservacao.Text,
                            Convert.ToInt32(cmbNomeCliente.SelectedValue),
                            Convert.ToDouble(txbPreco.Text), dataS);
                    MessageBox.Show(null, "Serviço adicionado a agenda com sucesso!", "Incluindo novo serviço",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            /*
             * Limpa os campos.
             */
            txbCodigoServico.Text = "";
            cmbNomeCliente.Text = "";
            dtpData.Text = "";
            txbServico.Text = "";
            txbPreco.Text = "";
            txbObservacao.Text = "";
            cmbHora.Text = "";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            /*
             * Cancela a edição e desativa os campos apos limpar.
             */
            btnAdicionar.Visible = true;
            cmbHora.Enabled = false;
            cmbHora.Enabled = false;
            incluir = false;
            habilitaBotoes(true);
            habilitaCampos(false);
            limpaCampos();
        }

        private void TxbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * Formata a textbox txbPreco.
             */
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void cmbHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * Formata a combobox cmbHora.
             */
            e.Handled = true;
        }
    }
}
