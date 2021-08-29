using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyBeat
{
    public partial class frmStart : Form
    {
        
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmMainGame game = new frmMainGame();
            
            game.StartTime = 60;
            game.PicBQuestions.Show();
            game.pbMnM.Hide();
            game.ButtonHide();
            game.CheckBoxHide();
            game.Score = 0;
            game.QCount = 0;
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

              
        
    }
}
