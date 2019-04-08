using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            statusdata.Text = DateTime.Now.ToShortDateString();
            statushora.Text = DateTime.Now.ToShortTimeString();
        }
       
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliForm f1 = new CadastroCliForm();
            f1.Show();
           
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PagCli f2 = new PagCli();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
