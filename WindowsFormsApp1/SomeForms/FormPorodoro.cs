using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.SomeForms
{
    public partial class FormPomodoro : Form
    {

        public FormPomodoro()
        {
            InitializeComponent();
        }
        MyTimer myTime2 = new MyTimer(0,05, 00);
        MyTimer myTime;
        int myTime_old;
        SoundPlayer  sound = new SoundPlayer(@"D:\chuongbao.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            myTime = new MyTimer( Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), 00);
            myTime_old = myTime.H*60*60 + myTime.M*60 + myTime.S ;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myTime.timeDown();
            label1.Text = myTime.timeToString();
            int time_now = myTime.H * 60*60 + myTime.M*60 + myTime.S;
            if ((myTime_old - time_now) % (25 * 60) == 0)
            {
                    timer1.Stop();
                    sound.Play();
                    timer2.Enabled = true;
                    timer2.Start();
                    myTime2 = new MyTimer(0, 05, 00);
                    break_notice fm = new break_notice();
                    fm.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            myTime2.timeDown();
            if (myTime2.M == 0 && myTime2.S == 0)
            {
                timer2.Stop();
                sound.Play();  
                timer1.Start();
            }
        }
    }
}
