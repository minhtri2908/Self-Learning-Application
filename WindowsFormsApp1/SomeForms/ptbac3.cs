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
    public partial class ptbac3 : Form
    {
        public ptbac3()
        {
            InitializeComponent();
        }
        double a = 0, b = 0, c = 0, d = 0, dt, k,x1,x2,x3,x;

        private void txt_d_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x\u00b3 + " + txt_b.Text + "x\u00b2 + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x\u00b3 + " + txt_b.Text + "x\u00b2 + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void txt_b_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x\u00b3 + " + txt_b.Text + "x\u00b2 + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x\u00b3 + " + txt_b.Text + "x\u00b2 + " + txt_c.Text + "x + " + txt_d.Text + " = 0" ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();
            txt_d.Clear();
            lbl_kq.Text = "";
            //lbl_pt.Text = "";
            txt_a.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_a.Text == "" || txt_b.Text == "" || txt_c.Text == ""|| txt_d.Text =="")
                lbl_kq.Text = "nhap he so! \n neu khong thi nhap so 0";
            else
            {
                a = Convert.ToDouble(txt_a.Text);
                b = Convert.ToDouble(txt_b.Text);
                c = Convert.ToDouble(txt_c.Text);
                d = Convert.ToDouble(txt_d.Text);
                dt = Math.Pow(b, 2) - 3 * a * c;
                k = (9 * a * b * c - 2 * Math.Pow(b, 3) - 27 * Math.Pow(a, 2) * d) / (2 * Math.Sqrt(Math.Pow(Math.Abs(dt), 3)));
                if (dt > 0)
                {
                    if (Math.Abs(k) <= 1)
                    {
                        x1 = (2 * Math.Sqrt(dt) * Math.Cos(Math.Acos(k) / 3) - b) / (3 * a);
                        x2 = (2 * Math.Sqrt(dt) * Math.Cos(Math.Acos(k) / 3 - (2 * Math.PI / 3)) - b) / (3 * a);
                        x3 = (2 * Math.Sqrt(dt) * Math.Cos(Math.Acos(k) / 3 + (2 * Math.PI / 3)) - b) / (3 * a);
                        lbl_kq.Text = "Phuong trinh co 3 nghiem phan biet:\nx1 = " + x1 + "\nx2 = " + x2 + "\nx3 = " + x3;
                    }
                    if (Math.Abs(k) > 1)
                    {
                        x = ((Math.Sqrt(dt) * Math.Abs(k)) / (3 * a * k)) * (Math.Pow((Math.Abs(k) + Math.Sqrt(Math.Pow(k, 2) - 1)), 1.0 / 3) + Math.Pow((Math.Abs(k) - Math.Sqrt(Math.Pow(k, 2) - 1)), 1.0 / 3)) - (b / (3 * a));
                        lbl_kq.Text = "Phuong trinh co 1 ngiem duy nhat la: x = " + x;
                    }
                }
                else if (dt == 0)
                {
                    x = (-b - Math.Pow(-(Math.Pow(b, 3) - 27 * a * a * d), 1.0 / 3)) / (3 * a);
                    lbl_kq.Text = "Phuong trinh co nghiem boi: x = " + x;
                }
                else
                {
                    x = (Math.Sqrt(Math.Abs(dt)) / (3 * a)) * (Math.Pow((k + Math.Sqrt(k * k + 1)), 1.0 / 3) - Math.Pow(-(k - Math.Sqrt(k * k + 1)), 1.0 / 3)) - (b / (3 * a));
                    lbl_kq.Text = "Phuong trinh co 1 nghiem duy nhat: x = " + x;
                }
            }
        }
    }
}
