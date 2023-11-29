using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelSync;

namespace Velsync
{
    public partial class Frm_dashboard : Form
    {
        public Frm_dashboard()
        {
            InitializeComponent();
        }
        public void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = pnl_center.Controls.OfType<Forms>().FirstOrDefault();
            {
                if (formulario == null)
                {
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    pnl_center.Controls.Add(formulario);
                    pnl_center.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                }
                else
                {
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }
                    formulario.BringToFront();
                }
            }
        }

        private void pnl_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn__Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Velsync_Usuarios>();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Velsync_funcionario>();

        }

        private void btn_agendamento_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Velsync_agendamento>();

        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Velsync_produtos>();
        }

        private void btn_servico_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Velsync_servico>();
        }
    }
}
