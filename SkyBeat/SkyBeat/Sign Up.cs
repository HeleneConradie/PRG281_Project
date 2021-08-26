using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SkyBeat
{
    public partial class frmSignup : Form
    {
        SqlConnection connection;
        SqlCommand cmd;

        public frmSignup()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=DESKTOP-MK3GTIU\\SQLEXPRESS; Initial Catalog = dbdSkyBeat; Integrated security = SSPI");
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
            try
            {
                bool success = true;
                if (success == true)
                {
                    DialogResult termsnconditions = MessageBox.Show("Have you read the terms and conditions?\n" +
                    "By saying yes, you are agreeing with the terms and conditions.", "Terms and Conditions", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (termsnconditions == DialogResult.Yes)
                    {
                        cmd = new SqlCommand();
                        connection.Open();
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO UserDetails(FirstName, LastName, IDNumber, Gender, Email, SecurityQuestion, SecurityAnswer)" +
                            "VALUES ('" + txtName.Text + "','" + txtSurname.Text + "', '" + txtID.Text + "', '" + cmbGender.Text + "', '" + txtEmail.Text + "', '" + rtxtSecQuestion.Text + "', '" + txtSecAnswer + "')";

                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "INSERT INTO UserLogin(Username, UserPassword)" +
                            "VALUES ('" + txtUsername2.Text + "','" + txtPass2.Text + "')";

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        this.Hide();
                        frmLogin login = new frmLogin();
                        login.Show();
                    }
                    throw new Exception("Failed to create an account!\nYou need to agree to the terms and conditions.");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
          
        //Validation method 
        //Validation method should return true or false (bool)

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

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtID.Clear();
            cmbGender.Text = "";
            txtEmail.Clear();
            rtxtSecQuestion.Clear();
            txtSecAnswer.Clear();
            txtUsername2.Clear();
            txtPass2.Clear();
        }
    }
}
