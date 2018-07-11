using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solution1
{
    public partial class Form1 : Form
    {
        private TextBox currentTextBox;
        
        public Form1()
        {
            InitializeComponent();
            currentTextBox = leftTextBox;
        }
        
        // Click on operator button
        private void OperatorClick(object sender, EventArgs e)
        {
            OperatorTextBox.Text = ((Button)sender).Text;
        }

        // Click on "=" button
        private void ResultClick(object sender, EventArgs e)
        {
            if (leftTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error: left text box is empty");

            }
            else if (RightTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error right text box is empty");
            }
            else if (OperatorTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error: operator text box is empty");
            }
            else
            {
                if (RightTextBox.Text.Trim().Equals("0") && OperatorTextBox.Text.Trim().Equals("/"))
                {
                    MessageBox.Show("Error : division by zero is not defined");
                }
                else
                {
                    try
                    {
                        double x = double.Parse(leftTextBox.Text.Trim());
                        double y = double.Parse(RightTextBox.Text.Trim());

                        switch (OperatorTextBox.Text.Trim())
                        {
                            case "+":
                                resultTestBox.Text = (x + y).ToString();
                                resultTestBox.BackColor = Color.AliceBlue;
                                leftTextBox.Text = "";
                                RightTextBox.Text = "";
                                break;

                            case "-":
                                resultTestBox.Text = (x - y).ToString();
                                resultTestBox.BackColor = Color.AliceBlue;
                                leftTextBox.Text = "";
                                RightTextBox.Text = "";
                                break;

                            case "*":
                                resultTestBox.Text = (x * y).ToString();
                                resultTestBox.BackColor = Color.AliceBlue;
                                leftTextBox.Text = "";
                                RightTextBox.Text = "";
                                break;

                            case "/":
                                resultTestBox.Text = (x / y).ToString();
                                resultTestBox.BackColor = Color.AliceBlue;
                                leftTextBox.Text = "";
                                RightTextBox.Text = "";
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please enter only numbers");
                    }

                }
            }
        }

        // Click on left or right textboxes. Stores the textbox
        private void TextBoxClick(object sender, EventArgs e)
        {
            currentTextBox = ((TextBox)sender);
        }

        // Clicked on one of the digits
        private void DigitClick(object sender, EventArgs e)
        {
            if (currentTextBox.Text.Trim().Equals(""))
            {
                if (((Button)sender).Text.Trim().Equals(".") || ((Button)sender).Text.Trim().Equals("00"))
                {
                    currentTextBox.Text = "0";
                }
                else
                {
                    currentTextBox.Text = ((Button)sender).Text;

                }
            }
            else
            {
                if (currentTextBox.Text.Trim().Equals("0") && ((Button)sender).Text.Equals("0"))
                {
                    currentTextBox.Text = "0";
                }
                else if (currentTextBox.Text.Contains(".") && ((Button)sender).Equals("."))
                {
                    currentTextBox.Text += "";
                }
                else
                {
                    // append the pressed no to the text box
                    currentTextBox.Text += ((Button)sender).Text;
                }
            }
        }
    }
}
