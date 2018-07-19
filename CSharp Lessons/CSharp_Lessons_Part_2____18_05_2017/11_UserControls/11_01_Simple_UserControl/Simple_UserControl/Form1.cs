using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simple_UserControl
{
    public partial class Form1 : Form
    {
        UserControl1 myUserControl = new UserControl1();
        public Form1()
        {
            InitializeComponent();
            myUserControl.Location = new System.Drawing.Point(40, 8);
            this.Controls.Add(myUserControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello, " + myUserControl.TextOut + " !";
        }
    }
}