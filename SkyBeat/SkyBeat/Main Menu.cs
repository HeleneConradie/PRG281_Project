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
    public partial class frmMain : Form
    {
        int Mode;
        public frmMain()
        {
            InitializeComponent();
        }

       
  
        //Closes the application
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Opens the login form
        private void btnSingle_Click(object sender, EventArgs e)
        {
            Mode = 1;
            this.Hide();
            frmLogin loginS = new frmLogin();
            loginS.Show();
            loginS.ReceiveMode(Mode);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Mode = 2;
            this.Hide();
            frmLogin loginM = new frmLogin();
            loginM.Show();
            loginM.ReceiveMode(Mode);
        }
    }
}
