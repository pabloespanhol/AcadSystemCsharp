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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((usuario.Text == "Davi") && (senha.Text == "admin1"))
            {
                Principal principal = new Principal();
                principal.Show();
            }
            else
                if ((usuario.Text == "Julio") && (senha.Text == "admin2"))
                {
                    Principal principal = new Principal();
                    principal.Show();
                }
                else
                    if ((usuario.Text == "Lidiane") && (senha.Text == "admin3"))
                    {
                        Principal principal = new Principal();
                        principal.Show();
                    }
                    else
                        if ((usuario.Text == "Pablo") && (senha.Text == "admin4"))
                        {
                            Principal principal = new Principal();
                            principal.Show();
                        }
                        else
                            if ((usuario.Text == "Wagner") && (senha.Text == "admin5"))
                            {
                                Principal principal = new Principal();
                                principal.Show();
                            }
                            else
                            {
                                MessageBox.Show("Login e senha não conferem!!");
                            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       }
}

