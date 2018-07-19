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
        private Control[] arrControls_User;
        private const int arrSize = 8;
        Random myRand = new Random();

        public event myDelegate myEvent;

        public UserControl1()
        {
            InitializeComponent();

            arrControls_User = new Control[arrSize];
            int lastY = 10;

            for (int i = 0; i < arrSize; i++)
            {
                if (myRand.Next(0, 2) == 0)
                {
                    arrControls_User[i] = new Label();
                    ((Label)arrControls_User[i]).TextAlign = ContentAlignment.MiddleCenter;
                    ((Label)arrControls_User[i]).BorderStyle = BorderStyle.FixedSingle;
                }
                else
                    arrControls_User[i] = new Button();
                arrControls_User[i].Font = new Font("Arial", 18, FontStyle.Bold);
                arrControls_User[i].Size = new Size(myRand.Next(50, 100), myRand.Next(30, 80));
                arrControls_User[i].BackColor = Color.FromArgb(myRand.Next(80, 255), myRand.Next(80, 255), myRand.Next(80, 255));
                arrControls_User[i].Location = new Point(10, lastY);
     
                lastY += arrControls_User[i].Size.Height + 5;
                arrControls_User[i].Click += new System.EventHandler(commonClick);

                this.Controls.Add(arrControls_User[i]);
            }
        }

        private void commonClick(object sender, EventArgs e)
        {
            if (((Control)sender).Text == "")
                ((Control)sender).Text = myRand.Next(1, 99).ToString();
            else
                ((Control)sender).Text = "";
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            myEventArgs myEventArgs_temp = new myEventArgs(arrControls_User);
            if (myEvent != null)
                myEvent(this, myEventArgs_temp);
        }
    }
}
