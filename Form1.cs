using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_form
{
    public partial class Form1 : Form
    {
        double answer , num1, num2;
        string btn;
        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text =((Convert.ToDouble( textBox1.Text ))* -1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "X";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "/";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((Convert.ToDouble(textBox1.Text)) / 100).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = string.Empty;
            btn ="+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn.ToString() == "+")
                {
                    num2 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(num1 + num2);
                }
                if (btn.ToString() == "-")
                {
                    num2 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(num1 - num2);
                }
                if (btn.ToString() == "X")
                {
                    num2 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(num1 * num2);
                }
                if (btn.ToString() == "/")
                {
                    num2 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(num1 / num2);
                }
            }
            catch
            {
                MessageBox.Show("somthing went wrong!","Error!",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
