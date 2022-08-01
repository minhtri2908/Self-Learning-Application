using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
namespace WindowsFormsApp1.SomeForms
{
    public partial class Formgoogle : Form
    {
        public Formgoogle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            button1.Hide();
            textBox1.Hide();
            textBox2.Hide();
            //textBox3.Hide();
           // textBox4.Hide();
            //button3.Hide();
        }

       /* private void button2_Click(object sender, EventArgs e)
        {

            String source = ("viewsource.txt");
            StreamWriter writer = File.CreateText(source);
            writer.Write(webBrowser1.DocumentText);
            writer.Close();
            Process.Start("notepad.exe", source);
        }*/
    }
}
