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
    public partial class frmMainGame : Form, IFinishMessage
    {

        public int StartTime = 60;
        public Thread thread1 = null;
        public int Score = 0;
        public int QuestionNumber = 0;
        public int QCount = 0;
        public int timefinish;
        public int modeNum;
        public string player1;
        public string player2;
        public int score1;
        public int score2;
        public int time1;
        public int time2;
        public int[] Questions = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int Count = 0;
        string correctanswer = "";

        public frmMainGame()
        {
            InitializeComponent();
            pnlGame.Show();
            lblTimer.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit mid-game?", "Exit?"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (exit == DialogResult.Yes)
            {
                thread1.Abort();
                Application.Exit();
            }

        }

        public delegate void Time();
        private void frmMainGameForm_Load(object sender, EventArgs e)
        {

            while (Count < 10)
            {
                Random rd = new Random();
                int rand_num = rd.Next(1, 11);
                var result = Array.Find(Questions, element => element == rand_num);
                if (result == 0)
                {
                    int Pos = Count;
                    Questions[Pos] = rand_num;
                    Count++;
                }
                result = 0;
            }
            ScoreCalculator();
        }

        public delegate void Delegate1();
        public event Delegate1 MessageEvent;

        Random rnd = new Random();
        string genre = "What Genre does the artist belong to?";
        string lyrics = "Who sings the song that the lyrics belongs to?";

        public void ReceiveMode(string one, string two, int x)
        {
            this.modeNum = x;
            this.player1 = one;
            this.player2 = two;
            if (modeNum == 1)
            {
                lblPlayer.Text = "";
            }
            else
            {
                lblPlayer.Text = "Player 1";
            }
        }

        frmScoreboard screb = new frmScoreboard();
        public void ScoreCalculator()
        {
            switch (Questions[QCount])
                {
                    case 1:
                        PicBQuestions.Image = Properties.Resources.Elvis_Presley;
                        lblQuestion.Text = genre;
                    correctanswer = "Elvis";
                    UncheckCheckboxes();
                    pbMnM.Hide();
                    ButtonHide();
                   CheckBoxShow();
                        btnNext.Show();
                        break;
                    case 2:
                        PicBQuestions.Image = Properties.Resources.SlipKnot;
                        lblQuestion.Text = genre;
                    correctanswer = "Slipknot";
                    UncheckCheckboxes();
                    pbMnM.Hide();
                    ButtonHide();
                        CheckBoxShow();
                        btnNext.Show();
                        break;
                    case 3:
                        PicBQuestions.Image = Properties.Resources.Eminem;
                        pbMnM.Show();
                        lblQuestion.Text = genre;
                    correctanswer = "Eminem";
                    UncheckCheckboxes();
                    ButtonHide();
                        CheckBoxShow();
                        btnNext.Show();
                        break;
                    case 4:
                        PicBQuestions.Image = Properties.Resources.BillyRayCyrus;
                        lblQuestion.Text = genre;
                    correctanswer = "BRC";
                    UncheckCheckboxes();
                    pbMnM.Hide();
                    ButtonHide();
                        CheckBoxShow();
                        btnNext.Show();
                        break;
                    case 5:
                        PicBQuestions.Image = Properties.Resources.KatyPerry;
                        lblQuestion.Text = genre;
                    correctanswer = "Katy";
                    UncheckCheckboxes();
                    pbMnM.Hide();
                    ButtonHide();
                        CheckBoxShow();
                        btnNext.Show();
                        break;
                    case 6:
                        PicBQuestions.Image = Properties.Resources.JoleneLyrics;
                        lblQuestion.Text = lyrics;
                    correctanswer = "Jolene";
                    pbMnM.Hide();
                    CheckBoxHide();
                        ButtonShow();
                        btnNext.Hide();
                        break;
                    case 7:
                        PicBQuestions.Image = Properties.Resources.AwaySunLyrics;
                        lblQuestion.Text = lyrics;
                    correctanswer = "AFTS";
                    pbMnM.Hide();
                    CheckBoxHide();
                        ButtonShow();
                        btnNext.Hide();
                        break;
                    case 8:
                        PicBQuestions.Image = Properties.Resources.RiseLyrics;
                        lblQuestion.Text = lyrics;
                    correctanswer = "Rise";
                    pbMnM.Hide();
                    CheckBoxHide();
                        ButtonShow();
                        btnNext.Hide();
                        break;
                    case 9:
                        PicBQuestions.Image = Properties.Resources.OutOfControlLyics;
                        lblQuestion.Text = lyrics;
                    correctanswer = "OOC";
                    pbMnM.Hide();
                    CheckBoxHide();
                        ButtonShow();
                        btnNext.Hide();
                        break;
                    case 10:
                        PicBQuestions.Image = Properties.Resources.WithYouLyrics;
                        lblQuestion.Text = lyrics;
                    correctanswer = "WithYou";
                    pbMnM.Hide();
                    CheckBoxHide();
                        ButtonShow();
                        btnNext.Hide();
                        break;
            }
            QCount++;

            if (QCount == 10)
            {
                if (modeNum == 1)
                {
                    timefinish = 70 - StartTime;
                    thread1.Abort();
                    score1 = Score;
                    screb.Show();
                    screb.SinglePlayer(player1, score1, timefinish);
                    lblPlayer.Hide();
                    this.Hide();
                }
                else if ((modeNum == 2) && (lblPlayer.Text == "Player 1"))
                {
                    time1 = 60 - StartTime;
                    score1 = Score;
                    QuestionNumber = 0;
                    Score = 0;
                    Start();
                    lblPlayer.Show();
                    lblPlayer.Text = "Player 2";
                    thread1.Abort();
                    lblTimer.Hide();

                }
                else
                {
                    score2 = Score;
                    time2 = 60 - StartTime;
                    if (score1 > score2)
                    {
                        screb.Multiplayer(player1, score1, time1, player2, score2, time2, player1, player2);
                    }
                    else if (score1 == score2)
                    {
                        if (time1 < time2)
                        {
                            screb.Multiplayer(player1, score1, time1, player2, score2, time2, player1, player2);
                        }
                        else
                        {
                            screb.Multiplayer(player2, score2, time2, player1, score1, time1, player1, player2);
                        }
                    }
                    else
                    {
                        screb.Multiplayer(player2, score2, time2, player1, score1, time1, player1, player2);
                    }

                    thread1.Abort();
                    screb.Show();
                    this.Hide();
                }
                MessageEvent += Message;
                MessageEvent();
                MessageEvent -= Message;
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
        frmMain mainmenu = new frmMain();

        public void Start()
        {
            pnlStartButton.Show();
        }

        private void UncheckCheckboxes()
        {
            cbCountry.Checked = false;
            cbHipHop.Checked = false;
            cbMetal.Checked = false;
            cbPop.Checked = false;
            cbRock.Checked = false;
        }

        public void ButtonHide()
        {
            btnDolly.Hide();
            btnDoorsDown.Hide();
            btnHooba.Hide();
            btnKaty.Hide();
            btnLinkin.Hide();
        }

        public void CheckBoxHide()
        {
            cbPop.Hide();
            cbCountry.Hide();
            cbHipHop.Hide();
            cbMetal.Hide();
            cbRock.Hide();
        }

        private void ButtonShow()
        {
            btnDolly.Show();
            btnDoorsDown.Show();
            btnHooba.Show();
            btnKaty.Show();
            btnLinkin.Show();
        }
        private void CheckBoxShow()
        {
            cbPop.Show();
            cbCountry.Show();
            cbHipHop.Show();
            cbMetal.Show();
            cbRock.Show();
        }


        public void Message()
        {
            MessageBox.Show("Congratulations! You are finished!");
        }


        private void btnKaty_Click(object sender, EventArgs e)
        {
            if (correctanswer == "Rise")
            {
                Score++;
            }
            ScoreCalculator();
        }

        private void btnDoorsDown_Click(object sender, EventArgs e)
        {
            if (correctanswer == "AFTS")
            {
                Score++;
            }
            ScoreCalculator();
        }

        private void btnHooba_Click(object sender, EventArgs e)
        {
            if (correctanswer == "OOC")
            {
                Score++;
            }
            ScoreCalculator();
        }

        private void btnDolly_Click(object sender, EventArgs e)
        {
            if (correctanswer == "Jolene")
            {
                Score++;
            }
            ScoreCalculator();
        }

        private void btnLinkin_Click(object sender, EventArgs e)
        {
            if (correctanswer == "WithYou")
            {
                Score++;
            }
            ScoreCalculator();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (correctanswer == "Elvis")
            {
                if (cbRock.Checked && cbCountry.Checked)
                {
                    Score++;
                }
            }

            else if (correctanswer == "Slipknot")
            {
                if (cbMetal.Checked)
                {
                    Score++;
                }
            }

            else if (correctanswer == "Eminem")
            {
                if (cbHipHop.Checked)
                {
                    Score++;
                }
            }

            else if (correctanswer == "BRC")
            {
                if (cbCountry.Checked)
                {
                    Score++;
                }
            }

            else if (correctanswer == "Katy")
            {
                if (cbPop.Checked && cbRock.Checked)
                {
                    Score++;
                }
            }
            ScoreCalculator();
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(StartTiming));
            thread1.Start();

            pnlStartButton.Hide();
            StartTime = 60;
            PicBQuestions.Show();
            pbMnM.Hide();
            Score = 0;
            QCount = 0;
            lblTimer.Show();
            
        }
    }
}
