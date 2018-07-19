using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Opacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.1)
                this.Opacity -= 0.1;
            if (this.Opacity < 0.0001)
                this.Close();
        }
    }
}