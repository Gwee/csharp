using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace Client
{
    public partial class Form1 : Form
    {
        CommonPart myCommonPart;

        public Form1()
        {
            InitializeComponent();
            myCommonPart = new CommonPart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (myCommonPart.plus(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text))).ToString();
        }
    }
}