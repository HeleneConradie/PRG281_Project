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
    public partial class frmMainGameForm : Form
    {

        public int StartTime = 60;
        public Thread thread1 = null;
        public frmMainGameForm()
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

        private void frmMainGameForm_Load(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(StartTiming));
            thread1.Start();
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
    }
}
