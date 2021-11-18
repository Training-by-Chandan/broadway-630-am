using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double firstNumber;
        private double secondNumber;
        private double result;
        private string op;

        private void numberClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var txt = btn.Text;
            SetNumber(txt);
        }

        private void SetNumber(string txt)
        {
            if (txtScreen.Text.Contains(".") && txt == ".")
            {
                return;
            }
            txtScreen.Text += txt;
        }

        private void btnAssignOperator(object sender, EventArgs e)
        {
            op = ((Button)sender).Text;
            firstNumber = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = string.Empty;
        }

        private void calculateResult(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(txtScreen.Text);
            switch (op)
            {
                case "+":
                    txtScreen.Text = (firstNumber + secondNumber).ToString();
                    break;

                case "-":
                    txtScreen.Text = (firstNumber - secondNumber).ToString();
                    break;

                case "x":
                    txtScreen.Text = (firstNumber * secondNumber).ToString();
                    break;

                case "/":
                    txtScreen.Text = (firstNumber / secondNumber).ToString();
                    break;

                default:
                    break;
            }
        }

        private void clear(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            txtScreen.Text = string.Empty;
            op = string.Empty;
        }
    }
}
