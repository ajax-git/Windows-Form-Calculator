using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double EnteredNumber; 
        string CurrentCalc = ""; 
        string option; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else textBox1.Text = textBox1.Text + "8";
        }

        private void buttoncyfra_Click(object sender, EventArgs e)
        {
            string c = (sender as Button).Text;
            CurrentCalc += c;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = c;
            }
            else textBox1.Text = textBox1.Text + c;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else textBox1.Text = textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            CurrentCalc += (sender as Button).Text;
            
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i].ToString() == ",")
                {
                    flag = true; 
                    break;
                }
                else flag = false;
            }
            if (flag == false)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EnteredNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "0";

            //textBox1.Clear();
            //textBox1.Focus();
            option = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            EnteredNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "0";

            //textBox1.Clear();
            //textBox1.Focus();
            option = "-";
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            EnteredNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "0";

            //textBox1.Clear();
            //textBox1.Focus();
            option = "*";
        }
        private void buttonSplit_Click(object sender, EventArgs e)
        {
            EnteredNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "0";

            //textBox1.Clear();
            //textBox1.Focus();
            option = "/";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            double LastNumber; double result;

            LastNumber = Convert.ToDouble(textBox1.Text);

            CurrentCalc += (sender as Button).Text;

            if (option == "+")
            {
                result = (EnteredNumber + LastNumber);
                textBox1.Text = Convert.ToString(result);
                EnteredNumber = result;
            }

            if (option == "-")
            {
                result = (EnteredNumber - LastNumber);
                textBox1.Text = Convert.ToString(result);
                EnteredNumber = result;
            }

            if (option == "*")
            {
                result = (EnteredNumber * LastNumber);
                textBox1.Text = Convert.ToString(result);
                EnteredNumber = result;
            }

            if (option == "/")
            {
                if (LastNumber == 0)
                {
                    string message = "Nie można dzielić przez zero!";
                    string title = "Wystąpił błąd";
                    
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult select = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    if (select == DialogResult.OK)
                    {
                        textBox1.Text = "0";
                    }
                }
                else
                {
                    result = (EnteredNumber / LastNumber);
                    textBox1.Text = Convert.ToString(result);
                    EnteredNumber = result;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (CurrentCalc.Length > 0)
                CurrentCalc = CurrentCalc.Remove(CurrentCalc.Length - 1, 1);

            textBox1.Text = CurrentCalc;
        }
    }
}
