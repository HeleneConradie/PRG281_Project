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

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string message = "Make use of Characters and Numbers";
            MessageBox.Show(message, "Hint");
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

        }
    }
}
