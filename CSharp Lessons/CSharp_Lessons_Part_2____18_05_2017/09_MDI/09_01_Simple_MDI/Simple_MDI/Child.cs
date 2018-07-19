using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simple_MDI
{
    public partial class Child : Form
    {
        public Child(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        private void Child_Click(object sender, EventArgs e)
        {
		MessageBox.Show("Click on " + this.Text);
	}
    }
}