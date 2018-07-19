using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UserControl_Event
{
    public delegate void myDelegate(object sender, myEventArgs e);

    public partial class UserControl1 : UserControl
    {
        public event myDelegate myEvent;
        public UserControl1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myEventArgs myEventArgs_temp = new myEventArgs(textBox1.Text);
            if (myEvent != null)
                myEvent(this, myEventArgs_temp);
        }
    }
}
