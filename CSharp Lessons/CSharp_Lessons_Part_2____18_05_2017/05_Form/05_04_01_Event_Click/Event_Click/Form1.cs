using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Event_Click
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myClick(object sender, EventArgs e)
        {
            label1.Text = ((Control)sender).Name + "  clicked";
        }
     }
}