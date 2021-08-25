using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader dr;
        public frmLogin()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=DESKTOP-MK3GTIU\\SQLEXPRESS; Initial Catalog = dbdSkyBeat; Integrated security = SSPI");
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
            cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM UserLogin WHERE Username ='" + txtUsername.Text + "' AND UserPassword = '" + txtPass.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Welcome! " + txtUsername.Text, "Login Successful", MessageBoxButtons.OK);
                this.Hide();
                frmStart strt = new frmStart();
                strt.Show();
            }
            else
            {
                DialogResult res = MessageBox.Show("Invalid Username or Password!", "Invalid Login Details", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPass.Clear();
                txtUsername.Focus();
            }
            connection.Close();
        }

        //Closes the application
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {

        }
    }
}
