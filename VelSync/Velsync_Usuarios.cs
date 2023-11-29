using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using veiculosForm;

namespace Velsync
{
    public partial class Velsync_Usuarios : Form
    {
        public string nome { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string dt_aniversario { get; set; }
        Cliente cliente = new Cliente();
        public Velsync_Usuarios()
        {
            InitializeComponent();
            atualizarGrid(cliente.listarCliente());
        }

        private void atualizarGrid(MySqlDataReader temp)
        {
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtg_clientes.DataSource = dt;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            cliente.Nome = txt_nome.Text;
            cliente.Email = txt_email.Text;
            cliente.Tel = txt_tel.Text;
            cliente.Dt_aniversario = txt_dtAniversario.Text;
            try
            {

                cliente.cadastrarCliente();
                MessageBox.Show("Cliente cadastrado com sucesso!");
                limpar();
                atualizarGrid(cliente.listarCliente());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o cliente" + ex.Message);
            }
        }
        private void limpar()
        {
            txt_nome.Text = "";
            txt_email.Text = "";
            txt_tel.Text = "";
            txt_dtAniversario.Text = "";
        }

        private void VelSync_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtg_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            {
                if (dtg_clientes.SelectedRows.Count > 0)
                {
                    int rowIndex = dtg_clientes.SelectedCells[0].RowIndex;
                    object valorCelula = dtg_clientes.Rows[rowIndex].Cells[0].Value;
                    object nomeUsuario = dtg_clientes.Rows[rowIndex].Cells[1].Value;
                    int usuarioSelecionado = int.Parse(valorCelula.ToString());

                    cliente.deletarCliente(usuarioSelecionado);


                    MessageBox.Show($"Usuário {nomeUsuario} deletado");
                    atualizarGrid(cliente.listarCliente());
                }
                else
                {
                    MessageBox.Show("Nenhum usuário selecionado");
                }
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == string.Empty
             && txt_tel.Text == string.Empty
             && txt_email.Text == string.Empty
             && txt_dtAniversario.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os dados");
            }
            else
            {
                try
                {
                    cliente.Nome = txt_nome.Text;
                    cliente.Tel = txt_tel.Text;
                    cliente.Email = txt_email.Text;
                    cliente.Dt_aniversario = txt_dtAniversario.Text;
                    cliente.alterarCliente();
                    limpar();
                    MessageBox.Show("Veiculo atualizado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao atualizar {ex.Message}");
                }
            }
        }

        private void dtg_clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int row;
            row = dtg_clientes.CurrentRow.Index;

            try
            {
                txt_nome.Text = dtg_clientes[1, row].Value.ToString();
                txt_tel.Text = dtg_clientes[2, row].Value.ToString();
                txt_email.Text = dtg_clientes[3, row].Value.ToString();
                txt_dtAniversario.Text = dtg_clientes[4, row].Value.ToString();
               /* txb_id.Text = dtg_clientes[0, row].Value.ToString();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pesquisar_Click_1(object sender, EventArgs e)
        {
            if (txb_pesquisar.Text == "")
            {
                atualizarGrid(cliente.listarCliente());
            }
            else
            {
                if (cbx_pesquisa.Text == "")
                {
                    MessageBox.Show("Favor selecionar o filtro de pesquisa!");
                }
                else
                {
                    atualizarGrid(cliente.pesquisar(cbx_pesquisa.Text, txb_pesquisar.Text));
                }
            }
        }
    }
}
