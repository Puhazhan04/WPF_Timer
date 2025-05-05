using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Timer_ILBA24
{
    public partial class Form1 : Form
    {
        public TimeSpan timerL;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            timerL = new TimeSpan(0,0,20);
            label1.Text= timerL.ToString(@"hh\:mm\:ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerL= timerL.Subtract(TimeSpan.FromSeconds(1));
            label1.Text = timerL.ToString(@"hh\:mm\:ss");
            if (timerL.TotalSeconds <= 0)
            {
                timer1.Stop();
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text= timerL.ToString(@"hh\:mm\:ss");
        }

        private void btn_weiter_Click(object sender, EventArgs e)
        {
            label1.Text = timerL.ToString(@"hh\:mm\:ss");
            timer1.Start();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerL = new TimeSpan(0, 0, 20);
            label1.Text= timerL.ToString(@"hh\:mm\:ss");
        }

      
    }
}
