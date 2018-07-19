using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UserControl_and_Form
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public string UserControl_TextInOut
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

        private void UserControl_ControlToForm_Click(object sender, EventArgs e)
        {
            ((Form1)(this.Parent)).Form_TextInOut = "Hello, " + textBox1.Text + " !";
        }

        private void UserControl_FormToControl_Click(object sender, EventArgs e)
        {
            label2.Text = "Hello, " + ((Form1)(this.Parent)).Form_TextInOut + " !";
        }
    }
}
