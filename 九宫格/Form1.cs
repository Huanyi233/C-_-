using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 九宫格
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random c = new Random();
        int[] n = new int[9];

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            a = 0;
            for (int i = 0; i < 9; i++)
            {
                n[i] = c.Next(1, 10);
                for(int j = 0; j < i; j++)
                {
                    if (n[i] == n[j])
                    {
                        i--;
                    }
                } 
            }
            button2.Text = n[0].ToString();
            button3.Text = n[1].ToString();
            button4.Text = n[2].ToString();
            button5.Text = n[3].ToString();
            button6.Text = n[4].ToString();
            button7.Text = n[5].ToString();
            button8.Text = n[6].ToString();
            button9.Text = n[7].ToString();
            button10.Text = n[8].ToString();
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            a++;
            if (a == 1) button2.Visible = true;
            if (a == 2) button3.Visible = true;
            if (a == 3) button4.Visible = true;
            if (a == 4) button5.Visible = true;
            if (a == 5) button6.Visible = true;
            if (a == 6) button7.Visible = true;
            if (a == 7) button8.Visible = true;
            if (a == 8) button9.Visible = true;
            if (a == 9) button10.Visible = true;
            if (a == 10)
            {
                a = 0;
                timer1.Enabled = false;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是" + n[0].ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是" + n[7].ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是" + n[6].ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是" + n[5].ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是" + n[4].ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是" + n[3].ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是" + n[2].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是" + n[1].ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是" + n[8].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }
    }
}
