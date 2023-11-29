using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veiculosForm;
using Velsync;

namespace VelSync
{
    internal class Caixa
    {
        private int id_caixa;
        private int id_funcionario;
        private int id_produtos;
        private string data;
        private float valor_total;
        private string detalhe_transacao;
        public ConexaoBanco banco;

        public Caixa()
        {
            id_produtos = 0;
            id_funcionario = 0;
            id_caixa = 0;
            data = "";
            valor_total = 0;
            detalhe_transacao = "";
            this.banco = new ConexaoBanco();

        }
        public int Id_produtos
        {
            get { return id_produtos; }
            set { id_produtos = value; }
        }
        public int Id_funcionario
        {
            get { return id_funcionario; }
            set { id_funcionario = value; }
        }
        public int Id_caixa
        {
            get { return id_caixa; }
            set { id_caixa = value; }
        }
        public string Date
        {
            get { return data; }
            set { data = value; }
        }
        public float Valor_total
        {
            get { return valor_total; }
            set { valor_total = value; }
        }
        public string Detalhe_transacao
        {
            get { return detalhe_transacao; }
            set { detalhe_transacao = value; }
        }
        public void efetuarPagamento()
        {
            this.banco.conectar();
            this.banco.nonQuery($"insert into caixa (data,valor_total,detalhe_transacao, id_funconario, id_produtos) values ('{data}','{valor_total}','{detalhe_transacao}','{id_funcionario}','{id_produtos}');");
            this.banco.close();
        }

        public MySqlDataReader pesquisar(string coluna, string value)
        {
            this.banco.conectar();
            return this.banco.Query($"select * from caixa where cast({coluna} as char) like '%{value}%';");
        }

        public MySqlDataReader listarPagamentos()
        {
            this.banco.conectar();
            return this.banco.Query("Select * from caixa");
        }

        public void deletarCliente(int id_caixa)
        {
            this.banco.conectar();
            this.banco.nonQuery($"delete from caixa where id_caixa = {id_caixa};");
            this.banco.close();
        }
    }
}
