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
    public partial class Velsync_servico : Form
    {
        Servico servico = new Servico();
        public Velsync_servico()
        {
            InitializeComponent();
        }
        private void limpar()
        {
            txt_preco.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_tempo.Text = string.Empty;
            rtb_desc.Text = string.Empty;
        }
        private void atualizarGrid(MySqlDataReader temp)
        {
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtg_servico.DataSource = dt;
        }
        private void Velsync_servico_Load(object sender, EventArgs e)
        {
            atualizarGrid(servico.listarServico());
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            servico.Nome_servico = txt_nome.Text;
            servico.Tempo_servico = txt_tempo.Text;
            servico.Preco = float.Parse(txt_preco.Text);
            servico.Descricao = rtb_desc.Text;
            try
            {

                servico.cadastrarServico();
                MessageBox.Show("servico cadastrado com sucesso!");
                limpar();
                atualizarGrid(servico.listarServico());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o servico" + ex.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == string.Empty
             && txt_tempo.Text == string.Empty
             && txt_preco.Text == string.Empty
             && rtb_desc.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os dados");
            }
            else
            {
                try
                {
                    servico.Nome_servico = txt_nome.Text;
                    servico.Tempo_servico = txt_tempo.Text;
                    servico.Descricao = rtb_desc.Text;
                    servico.Preco = int.Parse(txt_preco.Text);
                    servico.alterarServico();
                    limpar();
                    MessageBox.Show("Veiculo atualizado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao atualizar {ex.Message}");
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dtg_servico.SelectedRows.Count > 0)
            {
                int rowIndex = dtg_servico.SelectedCells[0].RowIndex;
                object valorCelula = dtg_servico.Rows[rowIndex].Cells[0].Value;
                object nomeUsuario = dtg_servico.Rows[rowIndex].Cells[1].Value;
                int usuarioSelecionado = int.Parse(valorCelula.ToString());

                servico.deletarCliente(usuarioSelecionado);


                MessageBox.Show($"Usuário {nomeUsuario} deletado");
                atualizarGrid(servico.listarServico());
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado");
            }
        }

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            if (txb_pesquisar.Text == "")
            {
                atualizarGrid(servico.listarServico());
            }
            else
            {
                if (cbx_pesquisa.Text == "")
                {
                    MessageBox.Show("Favor selecionar o filtro de pesquisa!");
                }
                else
                {
                    /*atualizarGrid(servico.buscarDado(cbx_pesquisa.Text);*/
                }
            }
        }
    }
}
