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
    public partial class he_ptb1_3an : Form
    {
        public he_ptb1_3an()
        {
            InitializeComponent();
        }
        double a11, a12, a13, a21, a22, a23, a31, a32, a33, b1, b2, b3, d, dx, dy, dz;

        private void td3_TextChanged(object sender, EventArgs e)
        {
            lblpt3.Text = ta3.Text + "x + " + tb3.Text + "y + " + tc3.Text + "z = " + td3.Text;
        }

        private void tc3_TextChanged(object sender, EventArgs e)
        {
            lblpt3.Text = ta3.Text + "x + " + tb3.Text + "y + " + tc3.Text + "z = " + td3.Text;
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {
            lblpt3.Text = ta3.Text + "x + " + tb3.Text + "y + " + tc3.Text + "z = " + td3.Text;
        }

        private void ta3_TextChanged(object sender, EventArgs e)
        {
            lblpt3.Text = ta3.Text + "x + " + tb3.Text + "y + " + tc3.Text + "z = " + td3.Text;
        }

        private void td2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text = ta2.Text + "x + " + tb2.Text + "y + " + tc2.Text + "z = " + td2.Text;
        }

        private void tc2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text = ta2.Text + "x + " + tb2.Text + "y + " + tc2.Text + "z = " + td2.Text;
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text = ta2.Text + "x + " + tb2.Text + "y + " + tc2.Text + "z = " + td2.Text;
        }

        private void ta2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text = ta2.Text + "x + " + tb2.Text + "y + " + tc2.Text + "z = " + td2.Text;
        }

        private void td1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y + " + tc1.Text + "z = " + td1.Text;
        }

        private void tc1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y + " + tc1.Text + "z = " + td1.Text;
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y + " + tc1.Text + "z = " + td1.Text;
        }

        private void ta1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y + " + tc1.Text + "z = " + td1.Text;
        }

        private void btgiai_Click(object sender, EventArgs e)
        {
            a11 = Convert.ToDouble(ta1.Text);
            a12 = Convert.ToDouble(tb1.Text);
            a13 = Convert.ToDouble(tc1.Text);
            b1 = Convert.ToDouble(td1.Text);

            a21 = Convert.ToDouble(ta2.Text);
            a22 = Convert.ToDouble(tb2.Text);
            a23 = Convert.ToDouble(tc2.Text);
            b2 = Convert.ToDouble(td2.Text);

            a31 = Convert.ToDouble(ta3.Text);
            a32 = Convert.ToDouble(tb3.Text);
            a33 = Convert.ToDouble(tc3.Text);
            b3 = Convert.ToDouble(td3.Text);

            d = a11 * a22 * a33 + a12 * a23 * a31 + a21 * a32 * a13 - a13 * a22 * a31 - a12 * a21 * a33 - a11 * a32 * a23;
            dx = b1 * a22 * a33 + a12 * a23 * b3 + b2 * a32 * a13 - a13 * a22 * b3 - a12 * b2 * a33 - a23 * a32 * b1;
            dy = a11 * b2 * a33 + b1 * a23 * a31 + a21 * b3 * a13 - a13 * b2 * a31 - b1 * a21 * a33 - a23 * b3 * a11;
            dz = a11 * a22 * b3 + a12 * b2 * a31 + a21 * a32 * b1 - b1 * a22 * a31 - a12 * a21 * b3 - b2 * a32 * a11;

            if (d == 0)
            {
                if ((dx == 0) && (dy == 0) && (dz == 0))
                    lblkq.Text = "he phuong trinh VO SO NGHIEM ! ";
                else lblkq.Text = "He phuong trinh VO NGHIEM !";
            }
            else
            {
                lblkq.Text = "Nghiem cua he phuong trinh :\n x = " + dx / d + "\n y = " + dy / d + "\n z = " + dz / d;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {

            ta1.Clear(); tb1.Clear(); tc1.Clear(); td1.Clear();
            ta2.Clear(); tb2.Clear(); tc2.Clear(); td2.Clear();
            ta3.Clear(); tb3.Clear(); tc3.Clear(); td3.Clear();
            lblpt1.Text = "";
            lblpt2.Text = "";
            lblpt3.Text = "";
            lblkq.Text = "";
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
