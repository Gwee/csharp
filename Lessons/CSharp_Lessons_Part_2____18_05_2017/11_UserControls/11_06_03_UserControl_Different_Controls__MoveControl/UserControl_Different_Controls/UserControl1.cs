using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UserControl_Different_Controls
{
    public delegate void myDelegate(object sender, myEventArgs e);

    public partial class UserControl1 : UserControl
    {
        public event myDelegate myEvent;

        public UserControl1()
        {
            InitializeComponent();
            Random myRand = new Random();
            for (int i = 0; i < 8; i++)
            {
                Control tempControl;
                if(myRand.Next(0, 2) == 0)
                    tempControl = new Label();
                else
                    tempControl = new Button();
                tempControl.Font = new Font("Arial", 18, FontStyle.Bold);
                tempControl.Text = myRand.Next(1, 99).ToString();
                tempControl.Size = new Size(myRand.Next(50, 100), myRand.Next(30, 80));
                tempControl.BackColor = Color.FromArgb(myRand.Next(80, 255), myRand.Next(80, 255), myRand.Next(80, 255)); 
                if (i % 2 == 0)
                    tempControl.Location = new Point(10, i / 2 * 85 + 10);
                else
                    tempControl.Location = new Point(120, i / 2 * 85 + 10);

                tempControl.Click += new System.EventHandler(commonClick);
                this.Controls.Add(tempControl);
            }
        }
        private void commonClick(object sender, EventArgs e)
        {
            myEventArgs myEventArgs_temp = new myEventArgs((Control)sender, this);
            if (myEvent != null)
                myEvent(this, myEventArgs_temp);
        }
    }
}
