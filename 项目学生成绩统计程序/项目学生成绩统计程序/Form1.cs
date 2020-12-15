using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目学生成绩统计程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no;
            int mark, count, sum;
            float ave;
            no = txtno.Text;
            mark = int.Parse(txtmark.Text);
            count = int.Parse(txtcount.Text);
            sum = int.Parse(txtsum.Text);
            sum = sum + mark;
            count = count + 1;
            ave = (float)sum / count;
            txtcount.Text = count.ToString();
            txtsum.Text = sum.ToString();
            txtave.Text = ave.ToString();
            txtshow.AppendText(no + "," + mark.ToString() + "\r\n");//显示到多行文本框
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtcount.Text = "0";
            txtsum.Text = "0";
        }
    }
}
