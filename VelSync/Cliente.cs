using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velsync
{
    public class Cliente
    {
        private int id_cliente;
        private string nome;
        private string tel;
        private string email;
        private string dt_aniversario;
        public ConexaoBanco banco;

        public Cliente()
        {
            id_cliente = 0;
            nome = "";
            tel = "";
            email = "";
            dt_aniversario = "";
            this.banco = new ConexaoBanco();

        }

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Dt_aniversario
        {
            get { return dt_aniversario; }
            set { dt_aniversario = value; }
        }
        public void cadastrarCliente()
        {
            this.banco.conectar();
            this.banco.nonQuery($"insert into cliente (nome,tel,email,dt_aniversario) values ('{Nome}','{Tel}','{Email}','{Dt_aniversario}');");
            this.banco.close();
        }

        public MySqlDataReader pesquisar(string coluna, string value)
        {
            this.banco.conectar();
            return this.banco.Query($"select * from cliente where cast({coluna} as char) like '%{value}%';");
        }


        public MySqlDataReader listarCliente()
        {
            this.banco.conectar();
            return this.banco.Query("Select * from cliente");
        }

        public void alterarCliente()
        {
            this.banco.conectar();
            this.banco.nonQuery($"update cliente set nome = '{nome}', tel = '{tel}', email = '{email}', dt_aniversario = {dt_aniversario} where id_cliente = {id_cliente};");
            this.banco.close();
        }
        public void deletarCliente(int id_cliente)
        {
            this.banco.conectar();
            this.banco.nonQuery($"delete from cliente where id_cliente = {id_cliente};");
            this.banco.close();
        }
    }
}

