using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velsync;

namespace VelSync
{
    public partial class Velsync_login : Form
    {
        public Velsync_login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Frm_dashboard form = new Frm_dashboard();
            this.Hide();
            form.Show();
        }
    }
}
