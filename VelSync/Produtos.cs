using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velsync;

namespace veiculosForm
{
    public class Produtos
    {
        private int id_Produto;
        private string nome_produto;
        private string descricao;
        private float preco;
        private int quantidade_estoque;
        public ConexaoBanco banco;

        public Produtos()
        {
            id_Produto = 0;
            nome_produto = "";
            descricao = "";
            preco = 0;
            quantidade_estoque = 0;
            this.banco = new ConexaoBanco();

        }

        public int Id_Produto
        {
            get { return id_Produto; }
            set { id_Produto = value; }
        }
        public string Nome_produto
        {
            get { return nome_produto; }
            set { nome_produto = value; }
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
        public int Quantidade_estoque
        {
            get { return quantidade_estoque; }
            set { quantidade_estoque = value; }
        }
        public void cadastrarprodutos()
        {
            this.banco.conectar();
            this.banco.nonQuery($"insert into Produtos (nome_Produto,descricao,preco,qt_estoque) values ('{nome_produto}','{descricao}','{preco}','{quantidade_estoque}');");
            this.banco.close();
        }

        public MySqlDataReader pesquisar(string coluna, string value)
        {
            this.banco.conectar();
            return this.banco.Query($"select * from Produtos where cast({coluna} as char) like '%{value}%';");
        }

        public MySqlDataReader listarprodutos()
        {
            this.banco.conectar();
            return this.banco.Query("Select * from Produtos");
        }

        public void alterarprodutos()
        {
            this.banco.conectar();
            this.banco.nonQuery($"update Produtos set nome_produto = '{nome_produto}', descricao = '{descricao}', preco = '{preco}', qt_estoque = {quantidade_estoque} where id_produtos = {id_Produto};");
            this.banco.close();
        }
        public void deletarprodutos(int id_produtos)
        {
            this.banco.conectar();
            this.banco.nonQuery($"delete from Produtos where id_produtos = {id_produtos};");
            this.banco.close();
        }
    }
}
