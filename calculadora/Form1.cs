using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BoxTela.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fora d td
        }

        private void button10_Click(object sender, EventArgs e) //o
        {
            button10.Text = "0";
            BoxTela.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e) //9
        {
            button9.Text = "9";
            BoxTela.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e) //8
        {
            button8.Text = "8";
            BoxTela.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e) //7
        {
            button7.Text = "7";
            BoxTela.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e) //6
        {
            button6.Text = "6";
            BoxTela.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e) //5
        {
            button5.Text = "5";
            BoxTela.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e) //4
        {
            button4.Text = "4";
            BoxTela.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e) //3
        {
            button3.Text = "3";
            BoxTela.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e) //2
        {
            button2.Text = "2";
            BoxTela.Text += "2";
        }

        private void button1_Click_1(object sender, EventArgs e) //1
        {
            button1.Text = "1";
            BoxTela.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e) // +
        {
            button14.Text = " + ";
            BoxTela.Text += " + ";
        }

        private void button15_Click(object sender, EventArgs e) // -
        {
            button15.Text = " - ";
            BoxTela.Text += " - ";
        }

        private void button16_Click(object sender, EventArgs e) // *
        {
            button16.Text = " * ";
            BoxTela.Text += " * ";
        }

        private void button17_Click(object sender, EventArgs e) // /
        {
            button17.Text = " / ";
            BoxTela.Text += " / ";
        }

        private void button12_Click(object sender, EventArgs e) // apagar um numero
        {
            // apagar um número
        }

        private void button18_Click(object sender, EventArgs e) // apagar td
        {
            // apagar td
        }

        private void button11_Click(object sender, EventArgs e) // ponto
        {
            button11.Text = ".";
            BoxTela.Text += ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // tela calculadora
        {
            // tela da calculadora
        }

        private void operacao (object sender, EventArgs e)
        {
            int contas;



        }
    }
}
