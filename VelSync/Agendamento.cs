using MySql.Data.MySqlClient;
using Velsync;

namespace veiculosForm
{
    public class Agendamento
    {
        private int id_Agendamento;
        private string data;
        private string status;
        private string forma_pagamento;
        private string hora;
        private int id_cliente;
        private int id_funcionario;
        private int id_servico;
        public ConexaoBanco banco;

        public Agendamento()
        {
            id_Agendamento = 0;
            data = "";
            status = "";
            forma_pagamento = "";
            hora = "";
            id_funcionario = 0;
            id_servico = 0;
            id_cliente= 0;
            this.banco = new ConexaoBanco();
        }

        public int Id_Agendamento
        {
            get { return id_Agendamento; }
            set { id_Agendamento = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Forma_pagamento
        {
            get { return forma_pagamento; }
            set { forma_pagamento = value; }
        }
        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        public int Id_servico
        {
            get { return id_servico; }
            set { id_servico = value; }
        }
        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public int Id_funcionario
        {
            get { return id_funcionario; }
            set { id_funcionario = value; }
        }
        public void cadastrarAgendamento()
        {
            this.banco.conectar();
            this.banco.nonQuery($"insert into Agendamento (id_cliente, id_servico, id_funcionario, data,status,forma_pagamento,hora) values ('{id_cliente}', '{id_servico}', '{id_funcionario}','{data}','{status}','{forma_pagamento}','{hora}');");
            this.banco.close();
        }

        public MySqlDataReader pesquisar(string coluna, string value)
        {
            this.banco.conectar();
            return this.banco.Query($"select * from Agendamento where cast({coluna} as char) like '%{value}%';");
        }

        public MySqlDataReader listarAgendamento()
        {
            this.banco.conectar();
            return this.banco.Query("Select * from Agendamento");
        }

        public MySqlDataReader listarAgendamentoPosCadastro()
        {
            this.banco.conectar();
            return this.banco.Query("Select c.nome, s.nome_servico, f.nome, a.* from agendamento a join cliente c on a.id_cliente = c.id_cliente\r\njoin servico s on a.id_servico = s.id_servico\r\njoin funcionario f on a.id_funcionario = f.id_funcionario");
        }

        public void alterarAgendamento()
        {
            this.banco.conectar();
            this.banco.nonQuery($"update Agendamento set data = '{data}', status = '{status}', forma_pagamento = '{forma_pagamento}', hora = '{hora}', id_cliente = {id_cliente}, id_funcionario = {id_funcionario}, id_servico = {id_servico} where id_agendamento = {id_Agendamento};");
            this.banco.close();
        }
        public void deletarAgendamento(int id_Agendamento)
        {
            this.banco.conectar();
            this.banco.nonQuery($"delete from Agendamento where id_Agendamento = {id_Agendamento};");
            this.banco.close();
        }
        
    }
}

