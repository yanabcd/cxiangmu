using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜数字
{
    public partial class Form1 : Form
    {
        int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 使用说明toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        //题目区
        private void button2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            number = rd.Next(1, 100);
            textBox1.Text = string.Format("已经产生了一个（1-100）（不包括100）的整数，请在答题区输入你的答案！");
            button2.Enabled = false;

        }
        //答题区
        private void button3_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text;
            int number1;
            bool x = int.TryParse(a, out number1);
            if (x)
            {
                number1=int.Parse(a);
                if (number1 >= 1 && number1 < 100)
                {
                    if(number1>number)
                    {
                        MessageBox.Show("高了");
                        textBox2.Clear();
                    }
                    else if(number1<number){
                        MessageBox.Show("低了");
                        textBox2.Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("恭喜你答对了");
                        textBox2.Clear();
                        button3.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("2请输入1-100(不包括100)的整数");
                    textBox2.Clear();
                    
                }
            }
            else
            {
                MessageBox.Show("1请输入1-100(不包括100)的整数");
                textBox2.Clear();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.点击按钮“产生随机数”随机产生一个1-100的数" + "\r\n" + "2.在答题区输入答案并提交");
        }
      
        
        
    }
}
