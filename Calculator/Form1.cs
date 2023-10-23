using System;
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
    public partial class Form1 : Form
    {
        private char _operation;

        private bool _clean;

        private int _firstNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                ekran.Text = "";
                _clean = false; 
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                ekran.Text = "";
                _clean = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                ekran.Text = "";
                _clean = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                ekran.Text = "";
                _clean = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                ekran.Text = "";
                _clean = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                ekran.Text = "";
                _clean = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                ekran.Text = "";
                _clean = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                ekran.Text = "";
                _clean = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_clean)
            {
                ekran.Text = "";
                _clean = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(_clean)
            {
                ekran.Text = "";
                _clean = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }

            ekran.Text += 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _operation = '+';
            _clean = true;
            _firstNum = Convert.ToInt32(ekran.Text);
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            _operation = '-';
            _clean = true;
            _firstNum = Convert.ToInt32(ekran.Text);
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            _operation = 'x';
            _clean = true;
            _firstNum = Convert.ToInt32(ekran.Text);
        }


        private void buttonDivided_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _clean = true;
            _firstNum = Convert.ToInt32(ekran.Text);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ekran.Text = "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            int secondNum = Convert.ToInt32(ekran.Text);

            int result = 0;

            switch(_operation)
            {
                case '+':
                    result = _firstNum + secondNum;
                    break;

                case '-':
                    result = _firstNum - secondNum;
                    break;

                case 'x':
                    result = _firstNum * secondNum;
                    break;
                
                case '/':
                    result = _firstNum / secondNum;
                    break;
            }

            ekran.Text = Convert.ToString(result);
        }

        
    }
}
