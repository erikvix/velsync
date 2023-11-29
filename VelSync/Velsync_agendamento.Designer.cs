namespace VelSync
{
    partial class Velsync_agendamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_servico = new System.Windows.Forms.ComboBox();
            this.txt_fp = new System.Windows.Forms.ComboBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.dtg_agendamento = new System.Windows.Forms.DataGridView();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_cliente = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_funcionario = new System.Windows.Forms.ComboBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_agendamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(59)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(53, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(59)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(408, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Forma de pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(59)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(208)))));
            this.label5.Location = new System.Drawing.Point(408, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Serviço";
            // 
            // txt_servico
            // 
            this.txt_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_servico.FormattingEnabled = true;
            this.txt_servico.Location = new System.Drawing.Point(412, 272);
            this.txt_servico.Name = "txt_servico";
            this.txt_servico.Size = new System.Drawing.Size(323, 28);
            this.txt_servico.TabIndex = 21;
            // 
            // txt_fp
            // 
            this.txt_fp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fp.FormattingEnabled = true;
            this.txt_fp.Items.AddRange(new object[] {
            "PIX",
            "Cartão",
            "Dinheiro"});
            this.txt_fp.Location = new System.Drawing.Point(412, 338);
            this.txt_fp.Name = "txt_fp";
            this.txt_fp.Size = new System.Drawing.Size(323, 28);
            this.txt_fp.TabIndex = 22;
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(57, 272);
            this.txt_data.Multiline = true;
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(349, 28);
            this.txt_data.TabIndex = 23;
            this.txt_data.TextChanged += new System.EventHandler(this.txt_data_TextChanged);
            // 
            // dtg_agendamento
            // 
            this.dtg_agendamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_agendamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(59)))));
            this.dtg_agendamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_agendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_agendamento.Location = new System.Drawing.Point(57, 427);
            this.dtg_agendamento.Name = "dtg_agendamento";
            this.dtg_agendamento.Size = new System.Drawing.Size(678, 180);
            this.dtg_agendamento.TabIndex = 24;
            this.dtg_agendamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_agendamento_CellDoubleClick);
            // 
            // btn_agendar
            // 
            this.btn_agendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btn_agendar.FlatAppearance.BorderSize = 0;
            this.btn_agendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agendar.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_agendar.Location = new System.Drawing.Point(57, 373);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(349, 43);
            this.btn_agendar.TabIndex = 25;
            this.btn_agendar.Text = "Agendar";
            this.btn_agendar.UseVisualStyleBackColor = false;
            this.btn_agendar.Click += new System.EventHandler(this.btn_agendar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(412, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 43);
            this.button1.TabIndex = 26;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(183)))), ((int)(((byte)(226)))));
            this.label6.Location = new System.Drawing.Point(53, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Agendamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(59)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(53, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Status";
            // 
            // dtg_cliente
            // 
            this.dtg_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(59)))));
            this.dtg_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_cliente.Location = new System.Drawing.Point(58, 106);
            this.dtg_cliente.Name = "dtg_cliente";
            this.dtg_cliente.Size = new System.Drawing.Size(677, 65);
            this.dtg_cliente.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(189)))));
            this.label4.Location = new System.Drawing.Point(52, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Clientes";
            // 
            // txt_hora
            // 
            this.txt_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora.Location = new System.Drawing.Point(58, 209);
            this.txt_hora.Multiline = true;
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(349, 28);
            this.txt_hora.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(59)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(208)))));
            this.label7.Location = new System.Drawing.Point(54, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Hora";
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.FormattingEnabled = true;
            this.txt_status.Items.AddRange(new object[] {
            "Atendido",
            "Em espera"});
            this.txt_status.Location = new System.Drawing.Point(58, 338);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(348, 28);
            this.txt_status.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(59)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(208)))));
            this.label8.Location = new System.Drawing.Point(408, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Funcionário";
            // 
            // txt_funcionario
            // 
            this.txt_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcionario.FormattingEnabled = true;
            this.txt_funcionario.Location = new System.Drawing.Point(413, 209);
            this.txt_funcionario.Name = "txt_funcionario";
            this.txt_funcionario.Size = new System.Drawing.Size(323, 28);
            this.txt_funcionario.TabIndex = 40;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_excluir.Location = new System.Drawing.Point(57, 617);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(349, 43);
            this.btn_excluir.TabIndex = 41;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaShell;
            this.button2.Location = new System.Drawing.Point(596, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 43);
            this.button2.TabIndex = 42;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Velsync_agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(818, 667);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.txt_funcionario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtg_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.dtg_agendamento);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_fp);
            this.Controls.Add(this.txt_servico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Velsync_agendamento";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Velsync_agendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_agendamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_servico;
        private System.Windows.Forms.ComboBox txt_fp;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.DataGridView dtg_agendamento;
        private System.Windows.Forms.Button btn_agendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txt_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txt_funcionario;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button button2;
    }
}