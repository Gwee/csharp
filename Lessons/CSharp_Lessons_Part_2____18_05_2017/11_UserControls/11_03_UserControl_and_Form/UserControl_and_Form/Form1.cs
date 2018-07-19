using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserControl_and_Form
{
    public partial class Form1 : Form
    {
        UserControl1 myUserControl;

        public string Form_TextInOut
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                label2.Text = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            myUserControl = new UserControl1();
            myUserControl.Location = new System.Drawing.Point(5, 5);
            this.Controls.Add(myUserControl);

        }

        private void button_FormToControl_Click(object sender, System.EventArgs e)
        {
            myUserControl.UserControl_TextInOut = "Hello, " + textBox1.Text + " !";
        }

        private void button_ControlToForm_Click(object sender, System.EventArgs e)
        {
            label2.Text = "Hello, " + myUserControl.UserControl_TextInOut + " !";
        }
    }
}