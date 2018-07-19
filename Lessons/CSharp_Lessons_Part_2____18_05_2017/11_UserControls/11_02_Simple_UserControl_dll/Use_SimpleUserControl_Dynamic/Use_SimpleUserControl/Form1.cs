using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Use_SimpleUserControl
{
    public partial class Form1 : Form
    {
        private Simple_UserControl.UserControl1 userControl11;
        public Form1()
        {
            InitializeComponent();
            userControl11 = new Simple_UserControl.UserControl1();
            userControl11.Location = new Point(10, 10);
            this.Controls.Add(userControl11);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello, " + userControl11.TextOut + " !";
        }
    }
}