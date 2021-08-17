using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyBeat
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            frmSignup signup = new frmSignup();
            this.Hide();
            signup.Show();
            this.Close();

        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

    }
}
