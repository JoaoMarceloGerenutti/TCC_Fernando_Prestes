using Espaco_da_Beleza_Gerenciamento.Dao;
using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Espaco_da_Beleza_Gerenciamento
{
    public partial class FrmAgendamento : Form
    {
        ArrayList listaHoras = new ArrayList();

        public FrmAgendamento()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Fecha apenas o formulario agendamento.
                 */
                this.Close();
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
                 * Abre um novo formulario para adicionar o horario.
                 */
                Form Agenda = new FrmAdicionarHorario();
                Agenda.Owner = this;
                Agenda.ShowDialog();
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
                 * Esconde os botões adicionar e excluir.
                 * Esconde o DataGridView e desativa o filtro.
                 */
                dgvTela.Visible = false;
                btnAdicionar.Visible = false;
                btnExcluir.Visible = false;
                txbFiltroCliente.Enabled = false;

                /*
                 * Ativa os botões, campos e o DataGridView usados para alterar as informações do banco.
                 */

                dgvAgendamento.Visible = true;
                btnCancelar.Enabled = true;
                btnLimparAgenda.Enabled = true;
                btnGravar.Enabled = true;
                cmbHora.Enabled = true;
                cmbNomeCliente.Enabled = true;
                dtpData.Enabled = true;
                cmbHora.Enabled = true;
                txbServico.Enabled = true;
                txbPreco.Enabled = true;
                txbObservacao.Enabled = true;

                /*
                 * Da foco para a textbox CodidoServiço.
                 */
                txbCodigoServico.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Pega a contagem da linha do DataGridView e exclui, caso a mensagem de confirmação for "sim".
                 */
                if (dgvAgendamento.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir serviço da agenda?",
                        "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        bDEB_ServicosTableAdapter.DeleteQuery(Convert.ToInt32
                            (dgvAgendamento[0, dgvAgendamento.CurrentRow.Index].Value.ToString()));
                        FrmAgendamento_Load(null, null);
                        MessageBox.Show(null, "Serviço apagado da agenda com sucesso!", "Excluindo um serviço",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    /*
                     * Da uma mensagem de erro se não tiver nenhuma linha selecionada.
                     */
                    MessageBox.Show(null, "Selecione um serviço para excluir primeiro", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAgendamento_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dsEBGerenciamento.BDEB_Clientes'.
                this.bDEB_ClientesTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Clientes);
                // TODO: esta linha de código carrega dados na tabela 'dsEBGerenciamento.BDEB_Servicos'.
                this.bDEB_ServicosTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Servicos);
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
                 * Filtra os os clientes e os serviços.
                 */
                bDEB_ServicosTableAdapter.FillByNome(this.dsEBGerenciamento.BDEB_Servicos, "%" + txbFiltroCliente.Text + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Limpa o campo de filtro do cliente.
                 */
                txbFiltroCliente.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AtualizaDados()
        {
            try
            {
                /*
                 * Atualiza o DataGridView.
                 */
                this.bDEB_ServicosTableAdapter.Fill(this.dsEBGerenciamento.BDEB_Servicos);
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
                 * Verifica se o horario colocado na combobox ja esta cadastrado no banco e apos, adiciona ao banco.
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
                    bDEB_ServicosTableAdapter.UpdateQuery(hora.ToString(),
                        txbServico.Text,
                        txbObservacao.Text,
                        Convert.ToDouble(txbPreco.Text),
                        Convert.ToInt32(cmbNomeCliente.SelectedValue),
                        dataS, Convert.ToInt32(txbCodigoServico.Text));
                    MessageBox.Show(null, "Horário alterado com sucesso!", "Alterando Horário",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnCancelar_Click(null, null);
                    FrmAgendamento_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvAgendamento_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Quando clicado em algum index do DataGridView, adiciona as informações na labels.
                 */
                if (dgvAgendamento.RowCount > 0)
                {
                    TimeSpan hora;
                    txbCodigoServico.Text = dgvAgendamento[0, dgvAgendamento.CurrentRow.Index].Value.ToString();
                    txbServico.Text = dgvAgendamento[1, dgvAgendamento.CurrentRow.Index].Value.ToString();
                    cmbNomeCliente.SelectedValue = dgvAgendamento[2, dgvAgendamento.CurrentRow.Index].Value.ToString();
                    dtpData.Value = Convert.ToDateTime(dgvAgendamento[4, dgvAgendamento.CurrentRow.Index].Value.ToString());
                    hora = TimeSpan.Parse(dgvAgendamento[5, dgvAgendamento.CurrentRow.Index].Value.ToString());
                    cmbHora.Text = hora.ToString(@"hh\:mm");
                    txbPreco.Text = dgvAgendamento[6, dgvAgendamento.CurrentRow.Index].Value.ToString();
                    txbObservacao.Text = dgvAgendamento[7, dgvAgendamento.CurrentRow.Index].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnLimparAgenda_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Limpa os campos da agenda.
                 */
                txbCodigoServico.Text = "";
                cmbNomeCliente.Text = "";
                dtpData.Text = "";
                cmbHora.Text = "";
                txbServico.Text = "";
                txbPreco.Text = "";
                txbObservacao.Text = "";
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
                 * Limpa as textbox, combobox e DateTimePicker.
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
                 * Mostra os botões adicionar e excluir.
                 * Mostra o DataGridView e ativa o filtro.                 
                 * Desativa os botões, campos e o DataGridView usados para alterar as informações do banco.
                 */

                dgvTela.Visible = true;
                btnCancelar.Enabled = false;
                btnLimparAgenda.Enabled = false;
                btnGravar.Enabled = false;
                btnAdicionar.Visible = true;
                btnExcluir.Visible = true;
                txbFiltroCliente.Enabled = true;
                cmbNomeCliente.Enabled = false;
                txbServico.Enabled = false;
                txbPreco.Enabled = false;
                txbObservacao.Enabled = false;
                dgvAgendamento.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDisponibilidade_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Pega as informações do cmbHora e compara com os horarios do banco de dados, e depois, volta a lista
                 * de horarios disponiveis.
                 */
                listaHoras.Clear();
                foreach (var item in cmbHora.Items)
                {
                    listaHoras.Add(item);
                }
                string horas = "";
                DateTime data = dtpDisponibilidade.Value;
                string sql = $"select Horario from BDEB_Servicos WHERE DataS = '{data.ToShortDateString()}'";
                BancoSQL bs = new BancoSQL();
                DataTable dt = bs.QueryAsDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    string hora;
                    foreach (DataRow linha in dt.Rows)
                    {
                        hora = linha["Horario"].ToString();
                        TimeSpan horabloq = TimeSpan.Parse(hora);
                        if (listaHoras.Contains(horabloq.ToString(@"hh\:mm")))
                        {
                            listaHoras.Remove(horabloq.ToString(@"hh\:mm"));
                        }
                    }
                    foreach (var item in listaHoras)
                    {
                        horas += "\n" + item.ToString();
                    }
                    MessageBox.Show(null, horas.ToString(), "Horários disponíveis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (var item in listaHoras)
                    {
                        horas += "\n" + item.ToString();
                    }
                    MessageBox.Show(null, horas.ToString(), "Todos os horários estão disponíveis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Abre um calendario no navegador.
                 */
                string url = "https://icalendario.br.com/";
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                /*
                 * Adiciona formatação na textbox txbPreco.
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

        private void cmbHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                /*
                 * Adiciona formatação de hora na combobox cmbHora.
                 */
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
