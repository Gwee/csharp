using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Button_Move
{
    public partial class Form1 : Form
    {
        private int xMouseInitial, yMouseInitial;
        private bool MovingFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            xMouseInitial = e.X;
            yMouseInitial = e.Y;
            MovingFlag = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            MovingFlag = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingFlag == false)
                return;
      //      Console.WriteLine(e.X.ToString() + "  " + xMouseInitial.ToString());
            button1.Location = new Point(button1.Location.X + e.X - xMouseInitial,
                button1.Location.Y + e.Y - yMouseInitial);

            
        }
    }
}