using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace UserControl_Event
{
    public partial class Form1 : Form
    {
        UserControl1 myUserControl;
        public Form1()
        {
            InitializeComponent();
            myUserControl = new UserControl1();
            myUserControl.Location = new System.Drawing.Point(5, 5);
            this.Controls.Add(myUserControl);
            myUserControl.myEvent += new myDelegate(myFunction);
        }
        private void myFunction(object sender, myEventArgs e)
        {
            label1.Text = "Hello, " + e.myString + " !";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}