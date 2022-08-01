using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.SomeForms
{
    public partial class break_notice : Form
    {
        MyTimer time1 = new MyTimer(0, 05 , 00);
        public break_notice()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            label2.Text = "Don't give up!\nKeep moving forward.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1.timeDown();
            label1.Text = time1.timeToString();
            if (time1.M == 0 && time1.S == 0)
            {
                this.Close();     
            }
        }
    }
}
