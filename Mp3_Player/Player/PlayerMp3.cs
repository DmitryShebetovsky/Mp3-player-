﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Player.Views;
using Player.Presenters;

namespace Player
{
    public partial class Pl : Form, IViewPlayer
    {

        public event EventHandler Play;
        public event EventHandler VolumeScroll;
        public event EventHandler TimeScroll;
        public event EventHandler Pause;
        public event EventHandler Stop;
        public event EventHandler Next;
        public event EventHandler Prev;
        public event EventHandler OnEndTrack;
        public event EventHandler CheckChanged;

        public Pl()
        {
            InitializeComponent();
            checkBoxVisual.Checked = false;
            pictureBoxGif.Hide();
        }

   

        private void _play_Click(object sender, EventArgs e)
        {
            Play(sender,e);
            
        }

        public void SetName(string name)
        {
            Name.Text = name;
            label3.Text = name;
        }

        public void SetTime(TimeSpan time)
        {
            Time.Text = time.ToString("mm\\:ss");
            
        }

        private void SoundBar_Scroll(object sender, EventArgs e)
        {
            VolumeScroll(sender, e);
        }

        public void SetTimePosition(int position)
        {
             TimeBar.Value = position;
        }

        private void TimeBar_Scroll(object sender, EventArgs e)
        {
            TimeScroll(sender, e);
        }

        private void _stop_Click(object sender, EventArgs e)
        {
            
            Stop(sender, e);
        }

        private void _pause_Click(object sender, EventArgs e)
        {
            Pause(sender, e);
        }

        private void _prev_Click(object sender, EventArgs e)
        {
            Prev(sender,e);
        }

        private void _next_Click(object sender, EventArgs e)
        {
            Next(sender, e);
        }

        private void TimeBar_ValueChanged(object sender, EventArgs e)
        {
            if(TimeBar.Value == 100)
            {
                OnEndTrack(sender, e);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanged(sender, e);
        }

        private void Pl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxGif_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisual.Checked)
                pictureBoxGif.Show();
            else pictureBoxGif.Hide();
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Maximize();
        }
        public bool Minimize()
        {
            // timerHide.Interval = 1;
            if (Height > 200)
            {
                Height -= 5;
            }
            else
            {
                timer2.Stop();
            }
            return true;
        }

        public bool Maximize()
        {
            // timer.Interval = 1;
            if (Height < 296)
            {
                Height += 5;
            }
            else
            {
                timer1.Stop();
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Minimize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
    }
}
