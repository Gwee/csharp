using System;
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
    public partial class Manager : Form
    {
        private Form1 myForm_1 = null, myForm_2 = null;
        private Random myRand = new Random();
        public Manager()
        {
            InitializeComponent();

            string ButtonLabel1 = "Button", ButtonLabel2 = "Label";
            if (myRand.Next(2) == 0)
            {
                ButtonLabel1 = "Label"; ButtonLabel2 = "Button";
            }

            string MinMax1 = "Min", MinMax2 = "Max";
            if (myRand.Next(2) == 0)
            {
                MinMax1 = "Max"; MinMax2 = "Min";
            }

            string RectangleSquare1 = "Rectangle", RectangleSquare2 = "Square";
            if (myRand.Next(2) == 0)
            {
                RectangleSquare1 = "Square"; RectangleSquare2 = "Rectangle";
            }

            myForm_1 = new Form1(ButtonLabel1, MinMax1, RectangleSquare1);
            myForm_1.Show();
            myForm_2 = new Form1(ButtonLabel2, MinMax2, RectangleSquare2);
            myForm_2.Show();
        }
    }
}