using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left )
                label1.Text = "In Label\n" + e.X.ToString() + " , " + e.Y.ToString();
         }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show(Cursor.Position.X.ToString() + " , " + Cursor.Position.Y.ToString());
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                label1.Text = "In Form\n" +  e.X.ToString() + " , " + e.Y.ToString();
        }
    }
}