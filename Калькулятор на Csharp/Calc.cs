using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_на_Csharp
{
    public partial class Calc : Form
    {
        float first, second;
        int countForSwitch;
        bool znak = true;
        public Calc()
        {
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            textBox1.Clear();
            countForSwitch = 1;
            label1.Text = first.ToString() + "+";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            textBox1.Clear();
            countForSwitch = 2;
            label1.Text = first.ToString() + "-";
            znak = true;
        }

        private void calculate()
        {
            switch (countForSwitch)
            {
                case 1:
                    second = first + float.Parse(textBox1.Text);
                    textBox1.Text = second.ToString();
                    break;
                case 2:
                    second = first - float.Parse(textBox1.Text);
                    textBox1.Text = second.ToString();
                    break;
                case 3:
                    second = first * float.Parse(textBox1.Text);
                    textBox1.Text = second.ToString();
                    break;
                case 4:
                    second = first / float.Parse(textBox1.Text);
                    textBox1.Text = second.ToString();
                    break;

                default:
                    break;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            textBox1.Clear();
            countForSwitch = 4;
            label1.Text = first.ToString() + "/";
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            textBox1.Clear();
            countForSwitch = 3;
            label1.Text = first.ToString() + "*";
            znak = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
    }
}