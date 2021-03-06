﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_RGBi_Square_Rectangle_Manager
{
    public delegate void myDelegate(object sender, myEventArgs e);
    public partial class UserControl1 : UserControl
    {
        public myDelegate myEvent;
        public Control[] arrControls;
        private static Random tempRand = new Random();

        public UserControl1()
        {
            InitializeComponent();
            int arrSize = tempRand.Next(15, 24);
            arrControls = new Control[arrSize];

            int currPosition = 2;

            for (int i = 0; i < arrSize; i++)
            {
                if (tempRand.Next(2) == 0)
                    arrControls[i] = new Label();
                else
                    arrControls[i] = new Button();

                arrControls[i].Location = new Point(currPosition, 3);
                int temp = tempRand.Next(15, 40);
                switch (tempRand.Next(4))
                {
                    case 0: arrControls[i].Size = new Size(temp, temp); break;
                    case 1: arrControls[i].Size = new Size(2 * temp, 2 * temp); break;
                    case 2: arrControls[i].Size = new Size(2 * temp, temp); break;
                    case 3: arrControls[i].Size = new Size(temp, 2 * temp); break;
                }

                switch (tempRand.Next(3))
                {
                    case 0: arrControls[i].BackColor = Color.Red; break;
                    case 1: arrControls[i].BackColor = Color.Green; break;
                    case 2: arrControls[i].BackColor = Color.Blue; break;
                }

                currPosition += arrControls[i].Size.Width + 2;
                this.Controls.Add(arrControls[i]);
            }
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            myEventArgs temp = new myEventArgs(this,null);
            if (myEvent != null)
            {
                myEvent(this, temp);
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}