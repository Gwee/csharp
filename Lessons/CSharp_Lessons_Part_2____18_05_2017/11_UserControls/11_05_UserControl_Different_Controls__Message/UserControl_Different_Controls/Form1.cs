using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserControl_Different_Controls
{
    public partial class Form1 : Form
    {
        private UserControl1 myUserControl1;

        public Form1()
        {
            InitializeComponent();
            myUserControl1 = new UserControl1();
            myUserControl1.Location = new Point(10, 10);
            this.Controls.Add(myUserControl1);

            myUserControl1.myEvent += new myDelegate(fromUser);
        }
        private void fromUser(object sender, myEventArgs e)
        {
            label1.Text = e.myStrText + "  from  " + e.myStrType;
        }

    }
}