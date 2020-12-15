using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目一
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sno, sname;
            sno = textBox1.Text;
            sname = textBox2.Text;
            label3.Text = "学号" + sno + "姓名" + sname;
        }
    }
}
