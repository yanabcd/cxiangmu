using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 模仿练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Dailyperformance;
            double Exammark;
            double Finalexam;
            double sum;
            Dailyperformance = int.Parse(textBox1.Text);
            Exammark = int.Parse(textBox2.Text);
            Finalexam = int.Parse(textBox3.Text);

            sum = ((Dailyperformance/100*20) + (Exammark / 100 * 30) + (Finalexam / 100 * 50));
            textBox4.Text = sum.ToString();
        }
    }
}
