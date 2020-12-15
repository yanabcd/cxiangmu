using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int math,english;
            double ave;
            int count;
            string s;
            math = int.Parse(textBox1.Text);
            english = int.Parse(textBox2.Text);
            ave = (double)(english + math) / 2;
            count = int.Parse(textBox3.Text);
            ++count;
            s=count.ToString()+"---数学"+math.ToString()+"英语："+english.ToString()+"平均："+ave.ToString();
            textBox4.AppendText(s+"\r\n");
            //清空输入框以便接受下次输入
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text=count.ToString();
        }
    }
}
