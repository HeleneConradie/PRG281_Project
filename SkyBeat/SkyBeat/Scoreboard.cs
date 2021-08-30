﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyBeat
{
    public partial class frmScoreboard : Form, IScoreBoard
    {
        public string player1;
        public string player2;
        public int mode;
        public void SinglePlayer(string user, int score, int time)
        {
            mode = 1;
            player1 = user;
            lblWinnername.Text = user;
            lblWinnerscore.Text = score.ToString() + "/10";
            lblWinnertime.Text = time.ToString() + " s";
            lblLosername.Hide();
            lblLoserscore.Hide();
            lblLosertime.Hide();
            lblWinner.Hide();
        }

        public void Multiplayer(string winner, int winnerscore, int winnertime, string loser, int loserscore, int losertime, string pone, string ptwo)
        {
            mode = 2;
            player1 = pone;
            player2 = ptwo;
            lblWinnername.Text = winner;
            lblWinnername.ForeColor = Color.Yellow;
            lblWinnerscore.Text = winnerscore.ToString() + "/10";
            lblWinnertime.Text = winnertime.ToString() + "s";
            lblLosername.Text = loser;
            lblLosername.ForeColor = Color.Red;
            lblLoserscore.Text = loserscore.ToString() + "/10";
            lblLosertime.Text = losertime.ToString() + "s";
            lblWinner.Show();
            lblWinner.Text = winner + " Wins!";
        }

        public frmScoreboard()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=DESKTOP-MK3GTIU\\SQLEXPRESS; Initial Catalog = dbdSkyBeat; Integrated security = SSPI");
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
            frmMainGame maing = new frmMainGame();
            maing.Show();
            maing.ReceiveMode(player1, player2, mode);
            this.Hide();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainmenu = new frmMain();
            mainmenu.Show();
        }

        SqlConnection connection;
        SqlCommand cmd;

        private void frmScoreboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            string userid = "";
            string userid2 = "";
            string lose = "Lose";
            string win = "Win";
            cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;

            if (mode == 1)
            {
                cmd.CommandText = "SELECT UserID FROM UserLogin WHERE Username = '" + lblWinnername.Text + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userid = reader[0].ToString();
                    }
                }
                reader.Close();

                int wintime = int.Parse(lblWinnertime.Text.Remove(lblWinnertime.Text.Length - 1, 1));
                int winscore = int.Parse(lblWinnerscore.Text.Remove(lblWinnerscore.Text.Length - 3, 3));
                cmd.CommandText = "INSERT INTO UserHistory(UserID, Score, Time, WinOrLose)" +
                    "VALUES ('" + int.Parse(userid) + "','" + winscore + "','" + wintime + "','" + win + "')";
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Save was successful!", "Save Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(mode == 2)
            {
                cmd.CommandText = "SELECT UserID FROM UserLogin WHERE Username = '" + lblWinnername.Text + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userid = reader[0].ToString();
                    }
                }
                reader.Close();

                int wintime = int.Parse(lblWinnertime.Text.Remove(lblWinnertime.Text.Length - 1, 1));
                int winscore = int.Parse(lblWinnerscore.Text.Remove(lblWinnerscore.Text.Length - 3, 3));
                cmd.CommandText = "INSERT INTO UserHistory(UserID, Score, Time, WinOrLose)" +
                    "VALUES ('" + int.Parse(userid) + "','" + winscore + "','" + wintime + "','" + win + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT UserID FROM UserLogin WHERE Username = '" + lblLosername.Text + "'";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userid2 = reader[0].ToString();
                    }
                }
                reader.Close();

                int losetime = int.Parse(lblLosertime.Text.Remove(lblLosertime.Text.Length - 1, 1));
                int losescore = int.Parse(lblLoserscore.Text.Remove(lblLoserscore.Text.Length - 3, 3));
                cmd.CommandText = "INSERT INTO UserHistory(UserID, Score, Time, WinOrLose)" +
                    "VALUES ('" + int.Parse(userid2) + "','" + losescore + "','" + losetime + "','" + lose + "')";

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Save was successful!", "Save Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
