using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {

        double acumula = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fora d td
        }

        private void button10_Click(object sender, EventArgs e) //o
        {
            display.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e) //9
        {
            display.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e) //8
        {
            display.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e) //7
        {
            display.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e) //6
        {
            display.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e) //5
        {
            display.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e) //4
        {
            display.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e) //3
        {
            display.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e) //2
        {
            display.Text += "2";
        }

        private void button1_Click_1(object sender, EventArgs e) //1
        {
            display.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e) // +
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula += double.Parse(display.Text);
                display.Text = "";
                operacao = "+";
            }
        }

        private void button15_Click(object sender, EventArgs e) // -
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "-";
            }
        }

        private void button16_Click(object sender, EventArgs e) // *
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "*";
            }
        }

        private void button17_Click(object sender, EventArgs e) // /
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "/";
            }
        }

        private void button12_Click(object sender, EventArgs e) // apagar um numero
        {
            display.Text = "";
            operacao = "";
        }

        private void button18_Click(object sender, EventArgs e) // apagar td
        {
            int x = display.Text.Length - 1;
            if (x >= 0)
            {
                display.Text = display.Text.Substring(0, x);
            }
        }

        private void button11_Click(object sender, EventArgs e) // ponto
        {
            display.Text += ".";
        }

        private void BoxTela_TextChanged(object sender, EventArgs e)
        {

        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }
            }
    }
}
