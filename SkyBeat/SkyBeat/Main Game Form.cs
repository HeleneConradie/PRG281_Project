﻿using System;
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

        private void StartTime()
        {
            string TimeLeft = "";
            for (int i = 60; i < 0; i++)
            {
                TimeLeft = "Timer 00:" + i;
                lblTimer.Text = TimeLeft;
                Thread.Sleep(1000);
            }
        }

        private void frmMainGameForm_Load(object sender, EventArgs e)
        {
            Thread TimerThread = new Thread(StartTime);
            TimerThread.Start();
        }
    }
}
