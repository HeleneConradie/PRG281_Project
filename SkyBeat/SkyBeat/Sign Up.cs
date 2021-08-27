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
using System.Text.RegularExpressions;

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
                bool success = ValidationSignup();
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
            cmbGender.SelectedIndex = -1;
            txtEmail.Clear();
            rtxtSecQuestion.Clear();
            txtSecAnswer.Clear();
            txtUsername2.Clear();
            txtPass2.Clear();
        }

        public bool ValidationSignup()
        {
            Regex nums = new Regex("^[0-9]{13}");
            Regex strings = new Regex("^[a-zA-Z]{50}");
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex multi = new Regex("^[a-zA-Z0-9]{50}");
            bool isValidName = strings.IsMatch(txtName.Text);
            bool isValidSurname = strings.IsMatch(txtSurname.Text);
            bool isValidemail = email.IsMatch(txtEmail.Text);
            bool isValidid = nums.IsMatch(txtID.Text);
            bool isValidSecQues = multi.IsMatch(rtxtSecQuestion.Text);
            bool isValidSecAnswer = multi.IsMatch(txtSecAnswer.Text);

            if (txtName.Text == "" || txtSurname.Text == "" || txtID.Text == "" || txtEmail.Text == "" || cmbGender.Text == null
                || txtSecAnswer.Text == null || rtxtSecQuestion == null)
            {
                MessageBox.Show("No fields can be left blank!", "Failed to create account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (txtID.Text.Length != 13)
            {
                MessageBox.Show("Invalid ID Number!", "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }
            if (!isValidid)
            {
                MessageBox.Show("Please enter valid ID Number!", "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }
            if (!isValidName)
            {
                MessageBox.Show("Please enter valid First Name!", "First Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (!isValidSurname)
            {
                MessageBox.Show("Please enter valid Last Name!", "Last Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return false;
            }
            if (!isValidemail)
            {
                MessageBox.Show("Please enter valid Email address!", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            if (!isValidSecQues)
            {
                MessageBox.Show("Please enter Security Question!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtSecQuestion.Focus();
                return false;
            }
            if (!isValidSecAnswer)
            {
                MessageBox.Show("Please enter valid Security Answer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecAnswer.Focus();
                return false;
            }

            return true;

        }
    }
}
