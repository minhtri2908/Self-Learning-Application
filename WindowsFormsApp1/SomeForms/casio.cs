using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class casio : Form
    {

        public bool clickBang = false;
        public string ketQua = "";
        public int ngoacTrai = 0;
        public int ngoacPhai = 0;
        double m;
        public casio()
        {
            InitializeComponent();
        }
        public bool KiemTraLoiChuoi(string chuoi)
        {
            string s1;
            string s2;
            if (txt_pheptinh1.Text == "") return true;
            if (ngoacTrai != ngoacPhai) return true;
            int l = chuoi.Length;
            s1 = chuoi.Substring(l - 1, 1);
            if (s1 == "+" || s1 == "-" || s1 == "/" || s1 == "*") return true;
            for (int i = 0; i < l - 1; i++)
            {

                s1 = chuoi.Substring(i, 1);
                s2 = chuoi.Substring(i + 1, 1);
                if (s1 == "1" || s1 == "2" || s1 == "3" || s1 == "4" || s1 == "5" || s1 == "6" || s1 == "7" || s1 == "8" || s1 == "9" || s1 == "0")
                    if (s2 == "s" || s2 == "c" || s2 == "t") return true;
                if (s1 == ")")
                    if (s2 == "s" || s2 == "c" || s2 == "t") return true;
                if (s1 == "(")
                    if (s2 == ")") return true;
                if (s1 == "/" || s1 == "*" || s1 == "+" || s1 == "-" || s1 == ".")
                    if (s2 == "/" || s2 == "*" || s2 == "+" || s2 == "-" || s2 == ".") return true;
            }

            return false;
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "0";
            clickBang = false;
        }
        private void bt_cham_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text += ".";
            clickBang = false;
        }
        private void bt_E_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text += Math.E;
            clickBang = false;
        }
        private void bt_PI_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text += Math.PI;
            clickBang = false;
        }
        private void bt_bang_Click(object sender, EventArgs e)
        {
            if (KiemTraLoiChuoi(txt_pheptinh1.Text) == true)
            {
                txt_ketqua.Text = "Error";
                return;
            }
            else
            {
                txt_ketqua.Text = tinhKetQua(XuLyChuoi(txt_pheptinh1.Text)).ToString();
                ketQua = txt_ketqua.Text;
                clickBang = true;
            }
        }
        public double tinhKetQua(string str)
        {
            int l = str.Length;
            double result = 0;
            while (l > 0)
            {
                string s1 = "";
                string dau = "";
                string s = str.Substring(l - 1, 1);
                while (s != "+" && s != "-" && s != "*" && s != "/" && l > 0)
                {
                    s1 = str.Substring(l - 1, 1) + s1;
                    l--;
                    if (l == 0) break;
                    s = str.Substring(l - 1, 1);
                }
                if (l == 0)
                    dau = "";
                else
                    dau = str.Substring(l - 1, 1);
                if (dau == "")
                {
                    result += double.Parse(s1);
                }
                if (dau == "+")
                {
                    result = result + double.Parse(s1);
                    l--;
                    continue;
                }
                if (dau == "-")
                {
                    result = result - double.Parse(s1);
                    l--;
                    continue;
                }
                if (dau == "*" || dau == "/")
                {
                    string str_s1 = str.Substring(l - 1, 1);
                    string str_s2 = s1;
                    string d = "";
                    while (str_s1 != "+" && str_s1 != "-" && l > 0)
                    {
                        str_s2 = str.Substring(l - 1, 1) + str_s2;
                        l--;
                        if (l == 0) break;
                        str_s1 = str.Substring(l - 1, 1);
                    }
                    if (l == 0)
                        d = "+";
                    else
                        d = str.Substring(l - 1, 1);
                    if (d == "+")
                    {
                        result += tinhTich(str_s2);
                        l--;
                    }
                    if (d == "-")
                    {
                        result -= tinhTich(str_s2);
                        l--;
                    }
                }
            }
            return result;
        }
        public double tinhTich(string str)
        {
            double tich = 0;
            int l = 0;
            string s1 = str.Substring(l, 1);
            string s2 = "";
            string dau = "";
            while (s1 != "*" && s1 != "/" && l < str.Length)
            {
                s2 = s2 + str.Substring(l, 1);
                l++;
                if (l == str.Length) break;
                s1 = str.Substring(l, 1);
            }
            tich = double.Parse(s2);
            while (l < str.Length)
            {
                string s3 = "";
                dau = str.Substring(l, 1);
                l++;
                s1 = str.Substring(l, 1);
                while (s1 != "*" && s1 != "/" && l < str.Length)
                {
                    s3 = s3 + str.Substring(l, 1);
                    l++;
                    if (l == str.Length) break;
                    s1 = str.Substring(l, 1);
                }
                if (dau == "*")
                {
                    tich = tich * double.Parse(s3);
                    continue;
                }
                if (dau == "/")
                {
                    tich = tich / double.Parse(s3);
                    continue;
                }
            }
            return tich;
        }
        public string XuLyChuoiCoSinCosTan(string str)
        {
            string u, v, result;
            u = XuLyChuoiCoSin(str);
            v = XuLyChuoiCoCos(u);
            result = XuLyChuoiCoTan(v);
            return result;
        }
        public string XuLyChuoiCoCos(string str)
        {

            string result = "";
            int i = 0;
            while (i < str.Length)
            {
                string chuoitam = "";
                double sin, s;
                if (str.Substring(i, 1) == "c" && str.Substring(i + 3, 1) == "(")
                {
                    i = i + 4;
                    int daumongoac = 1;
                    int daudongngoac = 0;
                    while (daumongoac != daudongngoac)
                    {
                        chuoitam += str.Substring(i, 1);

                        if (str.Substring(i, 1) == "(")
                            daumongoac++;
                        if (str.Substring(i, 1) == ")")
                            daudongngoac++;
                        i++;
                    }
                    i--;
                    string u, v;
                    u = XuLyNgoac(chuoitam, chuoitam.Length);
                    v = chinhLaiDau(u);
                    s = tinhKetQua(v);
                    s = s * Math.PI / 180;
                    sin = Math.Cos(s);
                    result += sin.ToString();
                    i++;
                }
                else
                {
                    result += str.Substring(i, 1);
                    i++;
                }
            }
            return result;
        }
        public string XuLyChuoiCoTan(string str)
        {
            string result = "";
            int i = 0;
            while (i < str.Length)
            {
                string chuoitam = "";
                double sin, s;
                if (str.Substring(i, 1) == "t" && str.Substring(i + 3, 1) == "(")
                {
                    i = i + 4;
                    int daumongoac = 1;
                    int daudongngoac = 0;
                    while (daumongoac != daudongngoac)
                    {
                        chuoitam += str.Substring(i, 1);

                        if (str.Substring(i, 1) == "(")
                            daumongoac++;
                        if (str.Substring(i, 1) == ")")
                            daudongngoac++;
                        i++;
                    }
                    i--;
                    string u, v;
                    u = XuLyNgoac(chuoitam, chuoitam.Length);
                    v = chinhLaiDau(u);
                    s = tinhKetQua(v);
                    s = s * Math.PI / 180;
                    sin = Math.Tan(s);
                    result += sin.ToString();
                    i++;
                }
                else
                {
                    result += str.Substring(i, 1);
                    i++;
                }
            }

            return result;
        }
        public string XuLyChuoiCoSin(string str)
        {
            string result = "";
            int i = 0;
            while (i < str.Length)
            {
                string chuoitam = "";
                double sin, s;
                if (str.Substring(i, 1) == "s" && str.Substring(i + 3, 1) == "(")
                {
                    i = i + 4;
                    int daumongoac = 1;
                    int daudongngoac = 0;
                    while (daumongoac != daudongngoac)
                    {
                        chuoitam += str.Substring(i, 1);

                        if (str.Substring(i, 1) == "(")
                            daumongoac++;
                        if (str.Substring(i, 1) == ")")
                            daudongngoac++;
                        i++;
                    }
                    i--;
                    string u, v;
                    u = XuLyNgoac(chuoitam, chuoitam.Length);
                    v = chinhLaiDau(u);
                    s = tinhKetQua(v);
                    s = s * Math.PI / 180;
                    sin = Math.Sin(s);
                    result += sin.ToString();
                    i++;
                }
                else
                {
                    result += str.Substring(i, 1);
                    i++;
                }
            }
            return result;
        }
        public string XuLyChuoi(string str)
        {
            string u, v, k;
            k = XuLyChuoiCoSinCosTan(str);
            u = XuLyNgoac(k, k.Length);
            v = chinhLaiDau(u);
            return v;
        }
        public string chinhLaiDau(string str)
        {
            string s1, s2;
            s2 = chuoiCongVoiNgoacCoDauTru(str);
            s1 = chuoiNhanVoiNgoacCoDauTru(s2);
            return s1;
        }
        public string chuoiNhanVoiNgoacCoDauTru(string str)
        {
            if (str.Substring(0, 1) != "+" && str.Substring(0, 1) != "-")
                str = "+" + str;
            string result = "";
            int i = str.Length - 1;
            while (i >= 0)
            {
                if (str.Substring(i, 1) == "-" && i > 0 && (str.Substring(i - 1, 1) == "*" || str.Substring(i - 1, 1) == "/"))
                {
                    string chuoitam = str.Substring(i - 1, 1);
                    int vitridaunhan = i - 1;
                    i = i - 2;
                    while ((str.Substring(i, 1) != "+" && str.Substring(i, 1) != "-") && i > 0)
                    {
                        chuoitam += str.Substring(i, 1);
                        i--;
                    }
                    string dau;
                    if (str.Substring(i, 1) == "-")
                        dau = "+";
                    else
                        dau = "-";
                    chuoitam += dau;
                    i--;
                    result += chuoitam;

                }
                else
                {

                    result += str.Substring(i, 1);
                    i--;
                }
            }
            return (DaoDau(result));
        }
        public string DaoDau(string str)
        {
            string result = "";
            int i = str.Length - 1;
            while (i >= 0)
            {
                result += str.Substring(i, 1);
                i--;
            }
            return result;
        }
        public string chuoiCongVoiNgoacCoDauTru(string str)
        {
            string result = "";
            int i = 0;

            while (i < str.Length)
            {
                if (str.Substring(i, 1) == "-" && str.Substring(i + 1, 1) == "-")
                {
                    result += "+";
                    i = i + 2;
                }
                if (str.Substring(i, 1) == "+" && str.Substring(i + 1, 1) == "-")
                {
                    result += "-";
                    i = i + 2;
                }
                if (str.Substring(i, 1) == "+" && str.Substring(i + 1, 1) == "+")
                {
                    result += "+";
                    i = i + 2;
                }
                else
                {
                    result += str.Substring(i, 1);
                    i++;
                }
            }
            return result;
        }
        public string XuLyNgoac(string str, int l)
        {

            string s = "";
            string ketQua = "";
            while (l > 0)
            {

                if (str.Substring(l - 1, 1) == ")")
                {
                    l--;
                    s = XuLyNgoac(str, l);
                    str = s + ketQua;
                    l = str.Length;
                    ketQua = "";
                }
                else
                {
                    if (str.Substring(l - 1, 1) == "(")
                    {
                        return (str.Substring(0, l - 1) + tinhKetQua(chinhLaiDau(ketQua)).ToString());

                    }
                    ketQua = str.Substring(l - 1, 1) + ketQua;
                    l--;
                }
            }
            return chinhLaiDau(ketQua);
        }
        private void bt_tru_Click(object sender, EventArgs e)
        {
            if (clickBang == true)
            {
                txt_pheptinh1.Text = ketQua;
                clickBang = false;
            }
            txt_pheptinh1.Text += "-";
        }

        private void bt_cong_Click(object sender, EventArgs e)
        {
            if (clickBang == true)
            {
                txt_pheptinh1.Text = ketQua;
                clickBang = false;
            }
            txt_pheptinh1.Text += "+";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "3";
            clickBang = false;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "2";
            clickBang = false;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "1";
            clickBang = false;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "4";
            clickBang = false;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "5";
            clickBang = false;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "6";
            clickBang = false;
        }

        private void bt_chia_Click(object sender, EventArgs e)
        {
            if (clickBang == true)
            {
                txt_pheptinh1.Text = ketQua;
                clickBang = false;
            }
            txt_pheptinh1.Text += "/";
        }

        private void bt_nhan_Click(object sender, EventArgs e)
        {
            if (clickBang == true)
            {
                txt_pheptinh1.Text = ketQua;
                clickBang = false;
            }
            txt_pheptinh1.Text += "*";
        }

        private void btAC_Click(object sender, EventArgs e)
        {
            txt_ketqua.Text = "";
            txt_pheptinh1.Text = "";
        }

        private void btDEL_Click(object sender, EventArgs e)
        {
            int l = txt_pheptinh1.Text.Length;
            if (l > 0)
            {
                txt_pheptinh1.Text = txt_pheptinh1.Text.Remove(l - 1);
                return;
            }
            clickBang = false;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "9";
            clickBang = false;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "8";
            clickBang = false;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text = txt_pheptinh1.Text + "7";
            clickBang = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clickBang == true) txt_pheptinh1.Text = "";
            txt_pheptinh1.Text = txt_pheptinh1.Text + m.ToString();
            clickBang = false;
        }

        private void bt_gt_Click(object sender, EventArgs e)
        {
            giaithua fm = new giaithua();
            fm.Show();
        }

        private void bt_trai_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text += "(";
            ngoacTrai += 1;
        }

        private void bt_phai_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text += ")";
            ngoacPhai += 1;
        }

        private void bt_M_Click(object sender, EventArgs e)
        {
            m = Convert.ToDouble(txt_ketqua.Text);
            textBox1.Text = "M";
        }

        private void bt_cotan_Click(object sender, EventArgs e)
        {
            luonggiac from = new luonggiac();
            from.Show();
        }

        private void bt_sphai_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Select();
            SendKeys.Send("{RIGHT}");
        }

        private void bt_strai_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Select();
            SendKeys.Send("{LEFT}");
        }

        private void bt_am_Click(object sender, EventArgs e)
        {
            txt_pheptinh1.Text += "-";
        }

        private void bt_bac2_Click(object sender, EventArgs e)
        {
            ptbac2 fm = new ptbac2();
            fm.Show();
        }

        private void bt_bac3_Click(object sender, EventArgs e)
        {
            ptbac3 fm = new ptbac3();
            fm.Show();
        }

        private void bt_heptb2_Click(object sender, EventArgs e)
        {
            he_ptb1_2an fm = new he_ptb1_2an();
            fm.Show();
        }

        private void bt_cann_Click(object sender, EventArgs e)
        {
            khaican fm = new khaican();
            fm.Show();
        }

        private void bt_mu2_Click(object sender, EventArgs e)
        {
            luythua fm = new luythua();
            fm.Show();
        }

        private void bt_heptb3_Click(object sender, EventArgs e)
        {
            he_ptb1_3an fm = new he_ptb1_3an();
            fm.Show();
        }

        private void bt_ln_Click(object sender, EventArgs e)
        {
            loglncs fm = new loglncs();
            fm.Show();
        }

        private void bt_log_Click(object sender, EventArgs e)
        {
            loglncs fm = new loglncs();
            fm.Show();
        }

        private void bt_can2_Click(object sender, EventArgs e)
        {
            khaican fm = new khaican();
            fm.Show();
        }

        private void bt_mu3_Click(object sender, EventArgs e)
        {
            luythua fm = new luythua();
            fm.Show();
        }

        private void bt_sin_Click(object sender, EventArgs e)
        {
            luonggiac from = new luonggiac();
            from.Show();
        }

        private void bt_cos_Click(object sender, EventArgs e)
        {
            luonggiac from = new luonggiac();
            from.Show();
        }

        private void bt_tan_Click(object sender, EventArgs e)
        {
            luonggiac from = new luonggiac();
            from.Show();
        }
    }
}
