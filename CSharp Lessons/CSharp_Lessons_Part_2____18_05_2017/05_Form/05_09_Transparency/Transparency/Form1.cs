using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Transparency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool flag = false;
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (flag)
                this.TransparencyKey = SystemColors.ControlLight;
            else
                this.TransparencyKey = Color.Black;
            flag = !flag;
        }
    }
}