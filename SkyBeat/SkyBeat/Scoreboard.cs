using System;
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
        public string player1 = "";
        public string player2 = "";
        public int mode;

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
            this.Hide();
            frmStart playagain = new frmStart();
            playagain.Show();
            GameHandler maing = new GameHandler();
            maing.ReceiveMode(player1, player2, mode);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainmenu = new frmMain();
            mainmenu.Show();
        }

        public void SinglePlayer(string user, int score, int time)
        {
            mode = 1;
            player1 = user;
            lblWinnername.Text = user;
            lblWinnerscore.Text = score.ToString()+ "/10";
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
            lblWinnerscore.Text = winnerscore.ToString() + "/10";
            lblWinnertime.Text = winnertime.ToString() + " s";
            lblLosername.Text = loser;
            lblLoserscore.Text = loserscore.ToString() + "/10";
            lblLosertime.Text = losertime.ToString() + " s";
            lblWinner.Text = winner + " Wins!";
        }

        SqlConnection connection;
        SqlCommand cmd;

        private void frmScoreboard_Load(object sender, EventArgs e)
        {
            string userid = "";
            string userid2 = "";
            string lose = "Lose";
            string win = "Win";
            cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT UserID FROM UserLogin WHERE Username = '" + lblWinnername + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userid = reader[0].ToString();
                }
            }
            reader.Close();

            cmd.CommandText = "INSERT INTO UserHistory(UserID, Score, Time, WinOrLose)" +
                "VALUES ('" + userid + "','" + lblWinnerscore + "','" + lblWinnertime + "','" + win + "')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT UserID FROM UserLogin WHERE Username = '" + lblLosername + "'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userid2 = reader[0].ToString();
                }
            }
            reader.Close();

            cmd.CommandText = "INSERT INTO UserHistory(UserID, Score, Time, WinOrLose)" +
                "VALUES ('" +  userid2 + "','" + lblLoserscore + "','" + lblLosertime + "','" + lose + "')";
            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
