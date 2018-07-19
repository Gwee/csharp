using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserControls_DragDrop
{
    public partial class Form1 : Form
    {
        private UserControl1[] arrUserControl;
        private int arrUser_size = 7;
        private Random myRand = new Random();

        public Form1()
        {
            InitializeComponent();

            arrUserControl = new UserControl1[arrUser_size];
            for (int i = 0; i < arrUser_size; i++)
            {
                string str = "Button";
                if (myRand.Next(0, 2) == 0)
                    str = "Label";

                arrUserControl[i] = new UserControl1(str);
                arrUserControl[i].Location = new Point(2 + 108 * i, 3);
                this.Controls.Add(arrUserControl[i]);
            }

        }
    }
}
