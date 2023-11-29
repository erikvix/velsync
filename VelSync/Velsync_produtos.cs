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
    public partial class Velsync_produtos : Form
    {
        Produtos produtos = new Produtos();
        public Velsync_produtos()
        {
            InitializeComponent();
            atualizarGrid(produtos.listarprodutos());

        }
        private void atualizarGrid(MySqlDataReader temp)
        {
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtg_produtos.DataSource = dt;
        }
        private void limpar()
        {
            txt_nome.Text = string.Empty;
            txt_quant.Text = string.Empty;
            txt_preco.Text = string.Empty;
        }

        private void Velsync_produtos_Load(object sender, EventArgs e)
        {

        }

        private void dtg_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            produtos.Nome_produto = txt_nome.Text;
            produtos.Quantidade_estoque = int.Parse(txt_quant.Text);
            produtos.Preco = float.Parse(txt_preco.Text);
            produtos.Descricao = rtb_desc.Text;
            try
            {

                produtos.cadastrarprodutos();
                MessageBox.Show("produtos cadastrado com sucesso!");
                limpar();
                atualizarGrid(produtos.listarprodutos());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o produtos" + ex.Message);
            }
        }

        private void rtb_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }
    }
}
