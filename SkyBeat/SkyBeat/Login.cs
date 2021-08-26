using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            bool success = ValidationLogin();
            cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM UserLogin WHERE Username ='" + txtUsername.Text + "' AND UserPassword = '" + txtPass.Text + "'";
            dr = cmd.ExecuteReader();
            if (success == true)
            {
                if (dr.Read())
                {
                    MessageBox.Show("Welcome! " + txtUsername.Text, "Login Successful", MessageBoxButtons.OK);
                    this.Hide();
                    frmStart strt = new frmStart();
                    strt.Show();
                }
                DialogResult res = MessageBox.Show("Invalid Username or Password!", "Invalid Login Details", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPass.Clear();
                txtUsername.Focus();
            }
            else if (success == false)
            {
                MessageBox.Show("No fields can be left blank!", "Failed to create account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            connection.Close();
        }

        private bool ValidationLogin()
        {
            if (txtUsername == null || txtUsername == null)
            {
                return false;
            }
            return true;
        }

        //Closes the application
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            string UsernamePrompt = Interaction.InputBox("Please enter Username", "Forgot Password", "Username", -1, 1);
            if (UsernamePrompt == "HeleneConradie")
            {

            }
            else
            {
                MessageBox.Show("Username does not exist!", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //string SecurityQuestionAnswer = Interaction.InputBox(, "Forgot Password", "");
        }
    }
}
