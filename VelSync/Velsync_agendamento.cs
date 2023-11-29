using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veiculosForm;
using Velsync;

namespace VelSync
{
    public partial class Velsync_agendamento : Form
    {
        Agendamento agendamento = new Agendamento();
        Cliente cliente = new Cliente();
        Funcionario funcionario = new Funcionario();
        Servico servico = new Servico();
        public Velsync_agendamento()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txt_data.Text = string.Empty;
            txt_fp.Text = string.Empty;
            txt_hora.Text = string.Empty;
            txt_servico.Text = string.Empty;
        }
        private void atualizarGrid(MySqlDataReader temp, DataGridView dtg)
        {
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtg.DataSource = dt;
        }

        private void Velsync_agendamento_Load(object sender, EventArgs e)
        {
            fillComboBoxServico(txt_servico);
            fillComboBoxFuncionario(txt_funcionario);
            atualizarGrid(cliente.listarCliente(), dtg_cliente);
            atualizarGrid(agendamento.listarAgendamentoPosCadastro(), dtg_agendamento);
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            try
            {
                agendamento.Data = txt_data.Text;
                agendamento.Forma_pagamento = txt_fp.Text;
                agendamento.Hora = txt_hora.Text;
                agendamento.Status = txt_status.Text;
                agendamento.Id_servico = servico.ObterIdSelecionado(txt_servico.Text);
                agendamento.Id_funcionario = funcionario.ObterIdSelecionado(txt_funcionario.Text);
                agendamento.Id_cliente = int.Parse(dtg_cliente.CurrentCell.Value.ToString());
                agendamento.cadastrarAgendamento();
                MessageBox.Show("agendamento cadastrado com sucesso!");
                limpar();
                atualizarGrid(agendamento.listarAgendamentoPosCadastro(), dtg_agendamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_data_TextChanged(object sender, EventArgs e)
        {

        }
        public void fillComboBoxServico(ComboBox comboBox)
        {
            List<string> nomesServicos = servico.buscarDado("nome_servico");

            comboBox.Items.Clear();
            comboBox.Items.AddRange(nomesServicos.ToArray());
        }
        public void fillComboBoxFuncionario(ComboBox comboBox)
        {
            List<string> nomesServicos = funcionario.buscarDado("nome");

            comboBox.Items.Clear();
            comboBox.Items.AddRange(nomesServicos.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == string.Empty &&
                txt_fp.Text == string.Empty &&
                txt_hora.Text == string.Empty &&
                txt_status.Text == string.Empty &&
                txt_servico.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                try
                {
                    agendamento.Id_Agendamento = int.Parse(dtg_agendamento.CurrentCell.Value.ToString());
                    agendamento.Data = txt_data.Text;
                    agendamento.Forma_pagamento = txt_fp.Text;
                    agendamento.Hora = txt_hora.Text;
                    agendamento.Status = txt_status.Text;
                    agendamento.Id_funcionario = funcionario.ObterIdSelecionado(txt_funcionario.Text);
                    agendamento.Id_cliente = int.Parse(dtg_cliente.CurrentCell.Value.ToString());
                    agendamento.Id_servico = servico.ObterIdSelecionado(txt_servico.Text);
                    agendamento.alterarAgendamento();
                    MessageBox.Show("agendamento atualizado com sucesso!");
                    limpar();
                    atualizarGrid(agendamento.listarAgendamentoPosCadastro(), dtg_agendamento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtg_agendamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = dtg_agendamento.CurrentRow.Index;

            try
            {
                MessageBox.Show(dtg_agendamento[0, row].Value.ToString());
                txt_data.Text = dtg_agendamento[4, row].Value.ToString();
                txt_status.Text = dtg_agendamento[5, row].Value.ToString();
                txt_fp.Text = dtg_agendamento[6, row].Value.ToString();
                txt_hora.Text = dtg_agendamento[7, row].Value.ToString();
                txt_servico.Text = dtg_agendamento[1, row].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            {
                if (dtg_agendamento.SelectedRows.Count > 0)
                {
                    int rowIndex = dtg_agendamento.SelectedCells[0].RowIndex;
                    object valorCelula = dtg_agendamento.Rows[rowIndex].Cells[3].Value;
                    int usuarioSelecionado = int.Parse(valorCelula.ToString());

                    agendamento.deletarAgendamento(usuarioSelecionado);


                    MessageBox.Show($"Agendamento deletado!");
                    atualizarGrid(agendamento.listarAgendamentoPosCadastro(), dtg_agendamento);
                }
                else
                {
                    MessageBox.Show("Nenhum usuário selecionado");
                }
            }
        }
    }
}
