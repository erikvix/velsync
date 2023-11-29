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

namespace VelSync
{
    public partial class Velsync_funcionario : Form
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        Funcionario funcionario = new Funcionario();
        public Velsync_funcionario()
        {
            InitializeComponent();
            atualizarGrid(funcionario.listarFuncionario());

        }
        private void limpar()
        {
            txt_cpf.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_senha.Text = string.Empty;
        }
        private void atualizarGrid(MySqlDataReader temp)
        {
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtg_funcionarios.DataSource = dt;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txt_nome.Text;
            funcionario.Cpf = txt_cpf.Text;
            funcionario.Senha = txt_senha.Text;
            try
            {

                funcionario.cadastrarFuncionario();
                MessageBox.Show("funcionario cadastrado com sucesso!");
                limpar();
                atualizarGrid(funcionario.listarFuncionario());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o funcionario" + ex.Message);
            }
        }

        private void Velsync_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == string.Empty
             && txt_cpf.Text == string.Empty
             && txt_senha.Text == string.Empty)

            {
                MessageBox.Show("*****************falta preencher");
            }
            else
            {
                try
                {
                    funcionario.Nome = txt_nome.Text;
                    funcionario.Cpf = txt_cpf.Text;
                    funcionario.Senha = txt_senha.Text;
                    funcionario.alterarFuncionario();
                    limpar();
                    MessageBox.Show(" Atualizado");
                    atualizarGrid(funcionario.listarFuncionario());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro {ex.Message}");
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dtg_funcionarios.SelectedRows.Count > 0)
            {
                int rowIndex = dtg_funcionarios.SelectedCells[0].RowIndex;
                object valorCelula = dtg_funcionarios.Rows[rowIndex].Cells[0].Value;
                object nomeUsuario = dtg_funcionarios.Rows[rowIndex].Cells[1].Value;
                int funcionarioSelecionado = int.Parse(valorCelula.ToString());

                funcionario.deletarFuncionario(funcionarioSelecionado);


                MessageBox.Show($"Usuário {nomeUsuario} deletado");
                atualizarGrid(funcionario.listarFuncionario());
            }
            else
            {
                MessageBox.Show("Excluido com sucesso");
            }
        }

        private void dtg_funcionarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int row;
            row = dtg_funcionarios.CurrentRow.Index;

            try
            {
                funcionario.Id_funcionario = int.Parse(dtg_funcionarios[0, row].Value.ToString());
                txt_nome.Text = dtg_funcionarios[1, row].Value.ToString();
                txt_cpf.Text = dtg_funcionarios[2, row].Value.ToString();
                txt_senha.Text = dtg_funcionarios[3, row].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
