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
        int loginCount = 0;
        string[] loginCompare = new string[2];
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader dr;

        public frmLogin()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=DESKTOP-MK3GTIU\\SQLEXPRESS; Initial Catalog = dbdSkyBeat; Integrated security = SSPI");
        }

        //Method is used in Main Menu
        public void ReceiveMode(int mode)
        {
            this.ModeNumber = mode;
            loginCount = 0;
            if (ModeNumber==1)
            {
                lblPlayer.Text = "";
            }
            else
            {
                lblPlayer.Text = "Player 1";
            }
        }

        //Takes the user to the signup form
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

        //The fields are validated and the user is logged in and taken to the next form 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            if (loginCount == 0)
            {
                loginCompare[0] = Username;
            }
            else
            {
                loginCompare[1] = Username;
            }
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
                    loginCount++;
                    if (ModeNumber == 2)
                    {
                        lblPlayer.Text = "Player 2";
                    }
                    MessageBox.Show("Welcome! " + txtUsername.Text, "Login Successful", MessageBoxButtons.OK);
                    txtUsername.Clear();
                    txtPass.Clear();
                    txtUsername.Focus();
                }
                else 
                {
                    MessageBox.Show("Invalid Username or Password!", "Invalid Login Details", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    txtUsername.Clear();
                    txtPass.Clear();
                    txtUsername.Focus();
                }

                if (loginCount == ModeNumber)
                {
                    this.Hide();
                    frmStart strt = new frmStart();
                    strt.Show();
                    strt.ReceiveMode(loginCompare[0], loginCompare[1], ModeNumber);
                }
            }
            connection.Close();
        }


        //Validation that the fields cannot be empty
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

        //When forgot password is clicked, the following method is called
        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            string question = "";
            string pass = "";
            cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            string UsernamePrompt = Interaction.InputBox("Please enter Username", "Forgot Password", "Username", -1, 1);
            cmd.CommandText = "SELECT UserDetails.SecurityQuestion FROM UserDetails INNER JOIN UserLogin " +
                "ON UserLogin.UserID = UserDetails.UserID WHERE UserLogin.Username ='" + UsernamePrompt + "'";
            
            bool returnvalue = false;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    question = reader["SecurityQuestion"].ToString();
                }
                returnvalue = true;
            }
            else
            {
                returnvalue = false;
                MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();

            bool returnvalue2 = false;
            if (returnvalue == true)
            {
                string Security = Interaction.InputBox(question, "Security Question", "Answer");
                cmd.CommandText = "SELECT UserLogin.UserPassword FROM UserLogin INNER JOIN UserDetails " +
                    "ON UserDetails.UserID = UserLogin.UserID WHERE UserDetails.SecurityAnswer ='" + Security + "' AND UserLogin.Username = '" + UsernamePrompt+ "'";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pass = reader["UserPassword"].ToString();
                    }
                    returnvalue2 = true;
                }
                else
                {
                    returnvalue2 = false;
                    MessageBox.Show("Security question was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (returnvalue2 == true)
            {
                MessageBox.Show(pass, "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
