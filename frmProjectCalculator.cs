using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsBasicOperators
{
    public partial class frmProjectCalculator : Form
    {
        public frmProjectCalculator()
        {
            InitializeComponent();
        }

        Double num1, result;
        char symbol='^';

        //to calculate after click on equal sign OR If last calculation is not simllar to current
        public double compute()
        {
            switch (symbol)
            {
                case '+':
                    return result + Convert.ToDouble(lblResult.Text);
                case '-':
                     return result - Convert.ToDouble(lblResult.Text);
                case '*':
                    return result * Convert.ToDouble(lblResult.Text);
                case '/':
                    return result / Convert.ToDouble(lblResult.Text);
                default:
                    return Convert.ToDouble(null);
            }
        }

        private void writeHistory()
        {
            if (lblHistory.Text != "HISTORY")
            {
                lblHistory.Text += lblCurrent.Text + "=" + lblResult.Text + "\n";
                lblCurrent.Text = "";
            }
            else
            {
                lblHistory.Text = lblCurrent.Text + "=" + lblResult.Text + "\n";
                lblCurrent.Text = "";
            }
        }

        //for input number
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '1';
            else
                lblResult.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '2';
            else
                lblResult.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '3';
            else
                lblResult.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '4';
            else
                lblResult.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '5';
            else
                lblResult.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '6';
            else
                lblResult.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '7';
            else
                lblResult.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '8';
            else
                lblResult.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '9';
            else
                lblResult.Text = "9";
        }

        //action of equal button
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "")
            {
                result = num1;
                lblResult.Text = result.ToString();
                lblCurrent.Text += lblResult.Text;
            }
            else
            {
                result=compute();
                num1 = result;
                lblCurrent.Text += lblResult.Text;
                lblCurrent.Text = lblCurrent.Text + '=' + result.ToString();
                lblResult.Text = result.ToString();
                symbol = '^';
            }

            if (lblHistory.Text == "HISTORY")
                lblHistory.Text = lblCurrent.Text+"\n";
            else
                lblHistory.Text += lblCurrent.Text+"\n";

            lblCurrent.Text = "";
        }

        //Subtract button
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                if (symbol != '-' && symbol != '^')
                {
                    num1 = compute();
                }
                else if (symbol == '^')
                {
                    num1 = Convert.ToDouble(lblResult.Text);
                }
                else
                {
                    num1 -= Convert.ToDouble(lblResult.Text);
                }

                lblCurrent.Text += lblResult.Text;
                lblResult.Text = "";
                result = num1;
                symbol = '-';
                lblCurrent.Text += symbol;
            }
        }

        //Multiplication Button
        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                if (symbol != '*' && symbol != '^')
                {
                    num1 = compute();
                }
                else if (symbol == '^')
                {
                    num1 = Convert.ToDouble(lblResult.Text);
                }
                else
                {
                    num1 *= Convert.ToDouble(lblResult.Text);
                }

                lblCurrent.Text += lblResult.Text;
                lblResult.Text = "";
                result = num1;
                symbol = '*';
                lblCurrent.Text += symbol;
            }
        }

        //Division Button
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                if (symbol != '/' && symbol != '^')
                {
                    num1 = compute();
                }
                else if (symbol == '^')
                {
                    num1 = Convert.ToDouble(lblResult.Text);
                }
                else
                {
                    num1 = num1 / Convert.ToDouble(lblResult.Text);
                }

                lblCurrent.Text += lblResult.Text;
                lblResult.Text = "";
                result = num1;
                symbol = '/';
                lblCurrent.Text += symbol;
            }
        }

        //BackSpace Key
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if(lblResult.Text.Length!=0)
                lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
        }

        //Reset Key
        private void btnC_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(null);
            symbol = '^';
            lblResult.Text = "";
            lblHistory.Text = "HISTORY";
            lblCurrent.Text = "";
        }

        //Percentage Button
        private void btnPer_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                lblCurrent.Text += "(" + lblResult.Text + ")/" + 100;
                lblResult.Text = (Convert.ToDouble(lblResult.Text) / 100).ToString();

                writeHistory();                
            }
        }

        //Cube Button 
        private void btnCube_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                lblCurrent.Text += "cube(" + lblResult.Text + ")";
                lblResult.Text = (Convert.ToDouble(lblResult.Text) * Convert.ToDouble(lblResult.Text) * Convert.ToDouble(lblResult.Text)).ToString();

                writeHistory();
            }        
        }

        //One divide by Something 
        private void btnOneByX_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                lblCurrent.Text += "1/(" + lblResult.Text + ")";
                lblResult.Text = (1 / Convert.ToDouble(lblResult.Text)).ToString();

                writeHistory();
            }
                
        }

        private void frmProjectCalculator_Load(object sender, EventArgs e)
        {
            this.Text= "Windows Calculator";
        }

        // Square the value
        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                lblCurrent.Text += "sqr(" + lblResult.Text + ")";
                lblResult.Text = (Convert.ToDouble(lblResult.Text) * Convert.ToDouble(lblResult.Text)).ToString();

                writeHistory();
            }
        }

        // provide Root of the text value
        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                lblCurrent.Text += "√(" + lblResult.Text + ")";
                lblResult.Text = Math.Sqrt(Convert.ToDouble(lblResult.Text)).ToString();

                writeHistory();
            }
        }

        // change symbol to + OR -
        private void btnSymbolChanger_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
                lblResult.Text = (Convert.ToDouble(lblResult.Text) * -1).ToString();
        }

        // input . in textbox
        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (lblResult.Text !="") 
            {
                if (lblResult.Text.IndexOf('.') == -1)
                    lblResult.Text = lblResult.Text + ".";
            }
            else
            {
                lblResult.Text = "0.";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0" && lblResult.Text != null)
                lblResult.Text += '0';
            else
                lblResult.Text = "0";
        }

        //Addition button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                if (symbol != '+' && symbol != '^')
                {
                    num1 = compute();
                }
                else if (symbol == '^')
                {
                    num1 = Convert.ToDouble(lblResult.Text);
                }
                else
                {
                    num1 = num1 + Convert.ToDouble(lblResult.Text);                   
                }

                lblCurrent.Text += lblResult.Text;
                lblResult.Text = "";
                result = num1;
                symbol = '+';
                lblCurrent.Text += symbol;
            }
        }
    }
}
