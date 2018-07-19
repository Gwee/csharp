using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChildIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void all_buttons_Click(object sender, EventArgs e)
        {
            this.Controls.SetChildIndex((Button)sender, 0);
        }

    }
}