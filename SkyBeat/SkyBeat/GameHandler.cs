using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyBeat
{
    class GameHandler : IFinishMessage
    {
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
        public string UserChoice = "";
        int[] Questions = new int[10];


        public delegate void Delegate1();
        public event Delegate1 MessageEvent;

        frmMainGame main = new frmMainGame();
        frmStart start = new frmStart();
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
                main.lblPlayer.Text = "";
            }
            else
            {
                main.lblPlayer.Text = "Player 1";
            }
        }

        public void ScoreCalculator()
        {
            frmScoreboard screb = new frmScoreboard();
            Random rd = new Random();
            MessageEvent += Message;
            while(Questions.Length < 10)
            {
                int rand_num = rd.Next(1, 10);
                var result = Array.Find(Questions, element => element == rand_num);
                if (result == -1)
                {
                    int Pos = Questions.Length + 1;
                    Questions[Pos] = rand_num;
                }
            }
                switch (Questions[QCount - 1])
                {
                    case 1:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.Elvis_Presley;
                        main.lblQuestion.Text = genre;
                        ButtonHide();
                        ChechkBoxShow();
                        main.btnNext.Show();
                        QCount++;
                        break;
                    case 2:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.SlipKnot;
                        main.lblQuestion.Text = genre;
                        ButtonHide();
                        ChechkBoxShow();
                        main.btnNext.Show();
                        QCount++;
                        break;
                    case 3:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.Eminem;
                        main.pbMnM.Show();
                        main.lblQuestion.Text = genre;
                        ButtonHide();
                        ChechkBoxShow();
                        main.btnNext.Show();
                        QCount++;
                        break;
                    case 4:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.BillyRayCyrus;
                        main.lblQuestion.Text = genre;
                        ButtonHide();
                        ChechkBoxShow();
                        main.btnNext.Show();
                        QCount++;
                        break;
                    case 5:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.KatyPerry;
                        main.lblQuestion.Text = genre;
                        ButtonHide();
                        ChechkBoxShow();
                        main.btnNext.Show();
                        QCount++;
                        break;
                    case 6:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.JoleneLyrics;
                        main.lblQuestion.Text = lyrics;
                        CheckBoxHide();
                        ButtonShow();
                        main.btnNext.Hide();
                        QCount++;
                        break;
                    case 7:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.AwaySunLyrics;
                        main.lblQuestion.Text = lyrics;
                        CheckBoxHide();
                        ButtonShow();
                        main.btnNext.Hide();
                        QCount++;
                        break;
                    case 8:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.RiseLyrics;
                        main.lblQuestion.Text = lyrics;
                        CheckBoxHide();
                        ButtonShow();
                        main.btnNext.Hide();
                        QCount++;
                        break;
                    case 9:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.OutOfControlLyics;
                        main.lblQuestion.Text = lyrics;
                        CheckBoxHide();
                        ButtonShow();
                        main.btnNext.Hide();
                        QCount++;
                        break;
                    case 10:
                        main.PicBQuestions.BackgroundImage = Properties.Resources.WithYouLyrics;
                        main.lblQuestion.Text = lyrics;
                        CheckBoxHide();
                        ButtonShow();
                        main.btnNext.Hide();
                        QCount++;
                        break;
                }
            
            if (QCount == 10)
            {
                if (modeNum == 1)
                {
                    timefinish = 70 - main.StartTime;
                    main.thread1.Abort();
                    score1 = Score;
                    screb.Show();
                    screb.SinglePlayer(player1, score1, timefinish);
                }
                else if ((modeNum == 2) && (main.lblPlayer.Text== "Player 1"))
                {
                    time1 = 60 - timefinish;
                    MessageEvent();
                    score1 = Score;
                    QuestionNumber = 0;
                    Score = 0;
                    start.Show();
                    main.lblPlayer.Show();
                    main.lblPlayer.Text = "Player 2";
                    main.thread1.Abort();
                }
                else
                {
                    score2 = Score;
                    time2 = 60 - timefinish;
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
                    {
                        screb.Multiplayer(player2, score2, time2, player1, score1, time1, player1, player2);
                    }

                    main.thread1.Abort();
                    MessageEvent();
                    main.Hide();

                }
            }
        }
          
        public void ButtonHide()
        {
            main.btnDolly.Hide();
            main.btnDoorsDown.Hide();
            main.btnHooba.Hide();
            main.btnKaty.Hide();
            main.btnLinkin.Hide();
        }

        public void CheckBoxHide()
        {
            main.cbPop.Hide();
            main.cbCountry.Hide();
            main.cbHipHop.Hide();
            main.cbMetal.Hide();
            main.cbRock.Hide();
        }

        public void ButtonShow()
        {
            main.btnDolly.Show();
            main.btnDoorsDown.Show();
            main.btnHooba.Show();
            main.btnKaty.Show();
            main.btnLinkin.Show();
        }
        public void ChechkBoxShow()
        {
            main.cbPop.Show();
            main.cbCountry.Show();
            main.cbHipHop.Show();
            main.cbMetal.Show();
            main.cbRock.Show();
        }


        public void Message()
        {
            MessageBox.Show("Congratulations! You are finished!");
        }
    }
}
