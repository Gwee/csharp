using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mdi_Childs_Message
{
    public partial class Child : Form
    {
        public Child(string newId)
        {
            InitializeComponent();
            this.Text = " " + newId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Child tmpChild in this.MdiParent.MdiChildren)
                if (ReferenceEquals(tmpChild, this) != true)
                {
                    tmpChild.label1.Text = textBox1.Text;
                }
        }
    }
}