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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string message = "Make use of Characters and Numbers.\nYour password should contain at least 8 characters.";
            MessageBox.Show(message, "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbHelp2_Click(object sender, EventArgs e)
        {
            string message = "Use a question only you know. \nIt cannot be too long";
            MessageBox.Show(message, "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTnC_Click(object sender, EventArgs e)
        {
            frmTnC terms = new frmTnC();
            this.Hide();
            terms.ShowDialog();
            this.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            DialogResult termsnconditions = MessageBox.Show("Have you read the terms and conditions?\n" +
                "By saying yes, you are agreeing with the terms and conditions.","Terms and Conditions", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (termsnconditions == DialogResult.Yes)
            {
                //Opens next form after calling and applying validation method
            }
            
        }

        private void pbShowPass2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass2.PasswordChar = '\0';
        }

        private void pbShowPass2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass2.PasswordChar = '*';
        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {
            txtPass2.PasswordChar = '*';
        }

        private void frmSignup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
