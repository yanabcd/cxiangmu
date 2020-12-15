using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目二
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int math, english, physics;
            double ave;
            math = int.Parse(textBox1.Text);
            english = int.Parse(textBox2.Text);
            physics = int.Parse(textBox3.Text);
            ave=(double)(math+english+physics)/3;
            label4.Text = "平均成绩:" + ave.ToString();
        }
    }
}
