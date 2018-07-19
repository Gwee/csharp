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
        Control myControl;
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
            this.Controls.Remove(myControl);
            if (e.mControl.GetType().Name == "Button")
                myControl = new Button();
            else
                myControl = new Label();
            myControl.Text = e.mControl.Text;
            myControl.BackColor = e.mControl.BackColor;
            myControl.Font = e.mControl.Font;
            myControl.Size = e.mControl.Size;
            myControl.Location = new Point(250, 150);
            this.Controls.Add(myControl);
        }

    }
}