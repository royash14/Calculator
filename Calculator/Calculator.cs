using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private string preVal;
        private string result;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string textBoxString = textBox1.Text;

            if (textBoxString.Length >= 1)
            {
                textBoxString = textBoxString.Substring(0, textBoxString.Length - 1);
            }
            else
                MessageBox.Show("No numbers or operators have been entered!");

            textBox1.Text = textBoxString;
        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            preVal = textBox1.Text;
            textBox1.Text = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            preVal = textBox1.Text;
            textBox1.Text = "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            preVal = textBox1.Text;
            textBox1.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            preVal = textBox1.Text;
            textBox1.Text = "/";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string temp = preVal + textBox1.Text;
            result = new DataTable().Compute(temp, null).ToString();
            textBox1.Text = result;
            preVal = result;
        }
    }
}
