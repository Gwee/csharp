using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace WidthHeight_Events
{
    public partial class Form1 : Form
    {
        private UserControl1[] arrUserControl;
        private int arrUser_size = 2;

        public Form1(int counter)
        {
            InitializeComponent();
            if (counter == 1)
            {
                this.Text = "Button";
                labelMinMaxSize.Text = "MAX SIZE";
            }
            else
            {
                this.Text = "Label";
                labelMinMaxSize.Text = "MIN SIZE";
            }

            arrUserControl = new UserControl1[arrUser_size];
            for (int i = 0; i < arrUser_size; i++)
            {
                arrUserControl[i] = new UserControl1();
                arrUserControl[i].Location = new Point(58, 35 + 127 * i);
                this.Controls.Add(arrUserControl[i]);
            }

            if (counter > 1)
            {
                Form1 temp = new Form1(counter - 1);
                temp.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
