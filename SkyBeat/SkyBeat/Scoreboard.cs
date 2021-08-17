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
    public partial class frmScoreboard : Form
    {
        public frmScoreboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Close SkyBeat", 
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStart playagain = new frmStart();
            playagain.Show();
            
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainmenu = new frmMain();
            mainmenu.Show();
        }
    }
}
