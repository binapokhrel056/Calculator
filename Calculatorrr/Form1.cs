using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorrr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button2_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn2.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn7.Text;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn1.Text;

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn3.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn4.Text;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn5.Text;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn6.Text;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn8.Text;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn9.Text;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = TxtTotal.Text + btn0.Text;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(TxtTotal.Text);
            TxtTotal.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(TxtTotal.Text);
            TxtTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(TxtTotal.Text);
            TxtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(TxtTotal.Text);
            TxtTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(TxtTotal.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            TxtTotal.Text = result + "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);

        }
    }
}
