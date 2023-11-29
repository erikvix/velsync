using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient; // inserir esta linha
using Velsync;

namespace VelSync
{
    internal class Funcionario
    {
        private int id_funcionario;
        private string nome;
        private string cpf;
        private string senha;
        public ConexaoBanco banco;


        public Funcionario()
        {
            id_funcionario = 0;
            nome = "";
            cpf = "";
            senha = "";
            this.banco = new ConexaoBanco();

        }

        public int Id_funcionario
        {
            get { return id_funcionario; }
            set { id_funcionario = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public void cadastrarFuncionario()
        {
            this.banco.conectar();
            this.banco.nonQuery($"insert into funcionario (nome,cpf,senha) values ('{Nome}','{Cpf}', '{Senha}');");
            this.banco.close();
        }

        public MySqlDataReader listarFuncionario()
        {
            this.banco.conectar();
            return this.banco.Query("Select * from Funcionario");
        }

        public MySqlDataReader pesquisarFuncionario(string coluna, string value)
        {
            this.banco.conectar();
            return this.banco.Query($"select * from Funcionario where cast({coluna} as char) like '%{value}%';");
        }

        public void alterarFuncionario()
        {
            this.banco.conectar();
            this.banco.nonQuery($"update funcionario set nome = '{Nome}', cpf = '{Cpf}', senha = '{Senha}' where id_funcionario = {id_funcionario};");
            this.banco.close();
        }
        public void deletarFuncionario(int id_funcionario)
        {
            this.banco.conectar();
            this.banco.nonQuery($"delete from funcionario where id_funcionario = {id_funcionario};");
            this.banco.close();
        }


        public string verificarLogin()
        {
            this.banco.conectar();
            try
            {
                MySqlDataReader reader = this.banco.Query("SELECT * FROM funcionario WHERE usuario='" + this.nome + "' AND senha='" + this.senha + "'");

                if (reader.Read())
                {
                    return "aceito";
                }
                else
                {
                    return "negado";
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("ERRO ao fazer a verificação na base da dados" + ex.Message);
            }
            this.banco.close();
            return "negado";
        }
        public List<string> buscarDado(string dado)
        {
            List<string> resultados = new List<string>();

            using (MySqlDataReader reader = this.banco.Query($"SELECT {dado} FROM funcionario"))
            {
                while (reader.Read())
                {
                    resultados.Add(reader[dado].ToString());
                }
            }

            this.banco.close();

            return resultados;
        }
        public int ObterIdSelecionado(string dadoSelecionado)
        {
            this.banco.conectar();
            MySqlDataReader query = this.banco.Query($"SELECT id_funcionario FROM funcionario where nome = '{dadoSelecionado}'");
            while (query.Read())
            {
                try
                {
                    int id = query.GetInt32(0);
                    return id;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return -1;
        }
    }
}

