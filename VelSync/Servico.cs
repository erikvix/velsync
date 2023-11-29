using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Velsync
{
    public class Servico
    {
        private int id_servico;
        private string nome_servico;
        private string tempo_servico;
        private string descricao;
        private float preco;
        public ConexaoBanco banco;

        public Servico()
        {
            id_servico = 0;
            nome_servico = "";
            tempo_servico = "";
            descricao = "";
            preco = 0;
            this.banco = new ConexaoBanco();

        }

        public int Id_servico
        {
            get { return id_servico; }
            set { id_servico = value; }
        }
        public string Nome_servico
        {
            get { return nome_servico; }
            set { nome_servico = value; }
        }
        public string Tempo_servico
        {
            get { return tempo_servico; }
            set { tempo_servico = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public void cadastrarServico()
        {
            this.banco.conectar();
            this.banco.nonQuery($"insert into servico (nome_servico,tempo_servico,descricao,preco) values ('{Nome_servico}','{Tempo_servico}','{Descricao}',{Preco});");
            this.banco.close();
        }

        public void alterarServico()
        {
            this.banco.conectar();
            this.banco.nonQuery($"update servico set nome_servico = '{Nome_servico}', tempo_servico = '{Tempo_servico}', descricao = '{Descricao}', preco = {Preco} where id_servico = {Id_servico};");
            this.banco.close();
        }
        public MySqlDataReader listarServico()
        {
            this.banco.conectar();
            return this.banco.Query("Select * from servico");
        }
        public void deletarCliente(int Id_servico)
        {
            this.banco.conectar();
            this.banco.nonQuery($"delete from servico where id_servico = {Id_servico};");
            this.banco.close();
        }
        public List<string> buscarDado(string dado)
        {
            List<string> resultados = new List<string>();

            using (MySqlDataReader reader = this.banco.Query($"SELECT {dado} FROM servico"))
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
            MySqlDataReader query = this.banco.Query($"SELECT id_servico FROM servico where nome_servico = '{dadoSelecionado}'");
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

