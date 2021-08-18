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
        int ModeNumber;
        public frmLogin()
        {
            InitializeComponent();
        }

        //Method is used in frmMain (Choose Option Form)
        public void ReceiveMode(int mode)
        {
            this.ModeNumber = mode;
            if (ModeNumber==1)
            {
                lblPlayer.Text = "";
            }
            else
            {
                lblPlayer.Text = "Player 1";
            }
        }

        //Goes to frmSignUp (Sign Up Form)
        private void lblSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignup signup = new frmSignup();
            signup.Show();
        }

        //Shows and hides password when the picturebox is clicked
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

        //The user is logged in and the next form appears
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        //Closes the application
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
