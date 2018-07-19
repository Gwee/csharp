using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace SuspendLayout_ResumeLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SuspendLayout ();
            for (int i = 0; i < 150; i++)
            {
                this.Height--;
                Thread.Sleep(5);
            }
            // ResumeLayout ();
        }
    }
}
