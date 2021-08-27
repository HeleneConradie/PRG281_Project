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
    public partial class frmStart : Form
    {
        public int modeType;
        public string player1;
        public string player2;

        public frmStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainGameForm game = new frmMainGameForm();
            game.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult mainmenu = MessageBox.Show("Are you sure you want to return to the Main Menu?", "Are you sure?"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mainmenu == DialogResult.Yes)
            {
                this.Hide();
                frmMain MainMenu = new frmMain();
                MainMenu.Show();
            }
        }

        public void ReceiveMode(string one, string two, int x)
        {
            this.modeType = x;
            this.player1 = one;
            this.player2 = two;
            
        }
    }
}
