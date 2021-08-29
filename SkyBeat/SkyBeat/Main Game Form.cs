using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SkyBeat
{
    public partial class frmMainGame : Form
    {

        public int StartTime = 60;
        public Thread thread1 = null;

        public frmMainGame()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit =  MessageBox.Show("Are you sure you want to exit mid-game?", "Exit?"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        public delegate void Time();
        GameHandler gamehandler = new GameHandler();
        private void frmMainGameForm_Load(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(StartTiming));
            thread1.Start();
            PicBQuestions.Show();
            pbMnM.Hide();

            gamehandler.ButtonHide();
            gamehandler.CheckBoxHide();
            if (gamehandler.QCount < 10)
            {
                gamehandler.ScoreCalculator();
            }
            
        }
        

        public void StartTimer()
        {
            if (lblTimer.InvokeRequired)
            {
                Time TimerThr = new Time(StartTimer);
                this.Invoke(TimerThr);
            }
            else
            {
                var Layout = TimeSpan.FromSeconds(StartTime);
                lblTimer.Text = "Time Left \"" + Layout.ToString(@"mm\:ss") + "\"";
            }
        }


        public void StartTiming()
        {
            for (int i = 60; i >= 0; i--)
            {
                StartTimer();
                StartTime--;
                Thread.Sleep(1000);
            }
            MessageBox.Show("Your time is up", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnKaty_Click(object sender, EventArgs e)
        {
            if (gamehandler.QCount == 8)
            {
                gamehandler.Score++;
            }
        }

        private void btnDoorsDown_Click(object sender, EventArgs e)
        {
            if (gamehandler.QCount == 7)
            {
                gamehandler.Score++;
            }
        }

        private void btnHooba_Click(object sender, EventArgs e)
        {
            if (gamehandler.QCount == 9)
            {
                gamehandler.Score++;
            }
        }

        private void btnDolly_Click(object sender, EventArgs e)
        {
            if (gamehandler.QCount == 6)
            {
                gamehandler.Score++;
            }
        }

        private void btnLinkin_Click(object sender, EventArgs e)
        {
            if (gamehandler.QCount == 10)
            {
                gamehandler.Score++;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (gamehandler.QCount == 1)
            {
                if (cbRock.Checked && cbCountry.Checked)
                {
                    gamehandler.Score++;
                }
            }

            else if (gamehandler.QCount == 2)
            {
                if (cbMetal.Checked)
                {
                    gamehandler.Score++;
                }
            }

            else if (gamehandler.QCount == 3)
            {
                if (cbHipHop.Checked)
                {
                    gamehandler.Score++;
                }
            }

            else if (gamehandler.QCount == 4)
            {
                if (cbCountry.Checked)
                {
                    gamehandler.Score++;
                }
            }

            else if (gamehandler.QCount == 5)
            {
                if (cbPop.Checked && cbRock.Checked)
                {
                    gamehandler.Score++;
                }
            }
        }
    }
}
