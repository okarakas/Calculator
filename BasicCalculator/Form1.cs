using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        double FirstNumber, SecondNumber, Result;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        public void calculate(double first, double second, string op)
        {
            if (op == "+")
            {
                Result = (first + second);
                textBox1.Text = Convert.ToString(Result);
                first = Result;
            }
            else if (op == "-")
            {
                Result = (first - second);
                textBox1.Text = Convert.ToString(Result);
                first = Result;
            }
            else if (op == "*")
            {
                Result = (first * second);
                textBox1.Text = Convert.ToString(Result);
                first = Result;
            }
            else if (op == "/")
            {
                if (second == 0)
                {
                    textBox1.Text = "Cannot be Divided by Zero";
                    calculateError();
                }
                else
                {
                    Result = (first / second);
                    textBox1.Text = Convert.ToString(Result);
                    first = Result;
                }
            }
            else if (op == "pow")
            {
                if (textBox1.Text.IndexOf(",") < 0)
                {
                    Result = Math.Pow(first, Convert.ToInt32(second));
                    textBox1.Text = Convert.ToString(Result);
                    first = Result;
                }
                else
                {
                    textBox1.Text = "The Power Cannot Be Double";
                    calculateError();
                }
            }
        }

        public void calculateError()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 35)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else if (textBox1.TextLength >= 30)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Bold);
            }
            else if (textBox1.TextLength >= 20)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            }
            else if (textBox1.TextLength >= 15)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            }
            else if (textBox1.TextLength >= 12)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "pow";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            for (int i = 1; i <= Convert.ToInt32(textBox1.Text); i++)
            {
                factorial = factorial * i;
            }
            textBox1.Text = Convert.ToString(factorial);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            textBox1.Text = "0";
            textBox1.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
            FirstNumber = 0;
            SecondNumber = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), 2));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), 3));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0 && textBox1.Text != null)
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else if (Convert.ToDouble(textBox1.Text) < 0 && textBox1.Text != null)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * (-1));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Are you sure you want to close?", "Closing...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") < 0)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToDouble(textBox1.Text);
            calculate(FirstNumber, SecondNumber, Operation);
        }
    }
}
