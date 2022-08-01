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
    public partial class FormTodoList : Form
    {
        public FormTodoList()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string x = "- " + textList.Text;
            listBox1.Items.Add(x);
        }
    }
}
