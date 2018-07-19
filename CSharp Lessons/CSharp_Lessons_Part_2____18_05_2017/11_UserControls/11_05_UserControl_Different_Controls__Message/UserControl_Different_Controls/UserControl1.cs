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
            for (int i = 0; i < 16; i++)
            {
                Control tempControl;
                if (myRand.Next(0, 2) == 0)
                {
                    tempControl = new Label();
                    tempControl.BackColor = Color.LightCoral;
                }
                else
                {
                    tempControl = new Button();
                    tempControl.BackColor = Color.LightGreen;
                }
                tempControl.Font = new Font("Arial", 22, FontStyle.Bold);
                tempControl.Text = myRand.Next(1, 99).ToString();
                tempControl.Size = new Size(60, 40);
                if (i % 2 == 0)
                    tempControl.Location = new Point(10, i / 2 * 45 + 10);
                else
                    tempControl.Location = new Point(75, i / 2 * 45 + 10);

                tempControl.Click += new System.EventHandler(commonClick);
                this.Controls.Add(tempControl);
            }
        }
        private void commonClick(object sender, EventArgs e)
        {
            string sText = ((Control)sender).Text;
            string sType = sender.GetType().Name;

            myEventArgs myEventArgs_temp = new myEventArgs(sText, sType);
            if (myEvent != null)
                myEvent(this, myEventArgs_temp);
        }
    }
}
