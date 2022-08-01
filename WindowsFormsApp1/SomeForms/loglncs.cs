using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loglncs : Form
    {
        public loglncs()
        {
            InitializeComponent();
        }
        double log, mu,lna,lnb;
        const double E = 2.718281828;
        private void btn10_Click(object sender, EventArgs e)
        {
            if (txtnmu.Text != "")
            {
                mu = Convert.ToDouble(txtnmu.Text);
                mu = (Math.Pow(10, mu));
                txt10.Text = mu.ToString();
            }
            else txtnmu.Text = "nhap co so";
        }

        private void btne_Click(object sender, EventArgs e)
        {
            if (txtnmu.Text != "")
            {
                mu = Convert.ToDouble(txtnmu.Text);
                mu = (Math.Pow(E, mu));
                txte.Text = mu.ToString();
            }
            else txte.Text = "nhap co so";
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (txtnlog.Text != "")
            {
                log = Convert.ToDouble(txtnlog.Text);
                if (log > 0)
                {
                    log = Math.Log10(log);
                    txtlog.Text = log.ToString();
                }
                else txtlog.Text = "Error";
            }
            else txtlog.Text = "nhap co so";
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            if (txtnlog.Text != "")
            {
                log = Convert.ToDouble(txtnlog.Text);
                if (log > 0)
                {
                    log = Math.Log(log, E); 
                    txtln.Text = log.ToString();
                }
                else txtln.Text = "Error";
            }
            else txtlog.Text = "nhap co so";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                log = Convert.ToDouble(textBox1.Text);
                if (log > 0)
                {
                    log = Math.Log10(log);
                    textBox2.Text = log.ToString();
                }
                else textBox2.Text = "Error";
            }
            else textBox2.Text = "nhap co so";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (textBox1.Text != "" && txtnlog.Text != "")
            {
                lna = Convert.ToDouble(textBox1.Text);
                lnb = Convert.ToDouble(txtnlog.Text);
                if (lna > 0 && lnb > 0)
                {
                    lna = Math.Log(lna, E);
                    lnb = Math.Log(lnb, E);
                    txtlogba.Text = (lna / lnb).ToString();
                }
                else txtlogba.Text = "Error";
            }
            else txtlogba.Text = "nhap co so";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                log = Convert.ToDouble(textBox1.Text);
                if (log > 0)
                {
                    log = Math.Log(log, E);
                    textBox3.Text = log.ToString();
                }
                else textBox3.Text = "Error";
            }
            else textBox3.Text = "nhap co so";
        }

        private void btlogab_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && txtnlog.Text != "")
            {
                lna = Convert.ToDouble(textBox1.Text);
                lnb = Convert.ToDouble(txtnlog.Text);
                if (lna > 0 && lnb > 0)
                {
                    lna = Math.Log(lna, E);
                    lnb = Math.Log(lnb, E);
                    txtlogab.Text = (lnb/lna).ToString();
                }
                else txtlogab.Text = "Error";
            }
            else txtlogab.Text = "nhap co so";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txtlogab.Text = "";
            txtlogba.Text = "";
            txt10.Text = "";
            txte.Text = "";
            txtln.Text = "";
            txtlog.Text = "";
            txtnlog.Text = "";
            txtnmu.Text = "";
            textBox1.Focus();
        }
    }
}
