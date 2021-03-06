﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_RGBi_Square_Rectangle_Manager
{
    public partial class Form1 : Form
    {
        public UserControl1[] arrUC = new UserControl1[2];
        public Control ButtonLabel_MinMax_RectangleSquare_control = null;
        public event myDelegate myCallbackFormEvent;

        public Form1(string ButtonLabel, string MinMax, string RectangleSquare)
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
            {
                arrUC[i] = new UserControl1();
                arrUC[i].Location = new Point(100, 27 + 85 * i);
                arrUC[i].myUCCallbackEvent += new myDelegate(my_formTrigger);
                this.Controls.Add(arrUC[i]);
            }
            this.Text = ButtonLabel;
            Min_Max_label.Text = MinMax;
            Rectangle_Square_label.Text = RectangleSquare;

            if (ButtonLabel == "Button")
                ButtonLabel_MinMax_RectangleSquare_control = new Button();
            else
                ButtonLabel_MinMax_RectangleSquare_control = new Label();

            ButtonLabel_MinMax_RectangleSquare_control.Size = new Size(20, 20);
            ButtonLabel_MinMax_RectangleSquare_control.BackColor = Color.White;
            ButtonLabel_MinMax_RectangleSquare_control.Location = new Point(2, 60);
            ButtonLabel_MinMax_RectangleSquare_control.Name = "ButtonLabel_MinMax_RectangleSquare_control";
            this.Controls.Add(ButtonLabel_MinMax_RectangleSquare_control);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void my_formTrigger(object sender, myEventArgs e)
        {
            myEventArgs myEventArgs_temp = new myEventArgs(this,e.userControl);
            myCallbackFormEvent(this, myEventArgs_temp); //throw form to the parent 
        }
    }
}