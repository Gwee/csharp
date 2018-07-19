using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TwoForms
{
    public partial class FormA : Form
    {
        public FormA()
        {
            InitializeComponent();
        }

        private void button_To_B_Click(object sender, EventArgs e)
        {
            FormB myFormB = new FormB();
            myFormB.Show();
        }

        private void button_To_B_Dialog_Click(object sender, EventArgs e)
        {
            FormB myFormB = new FormB();
            myFormB.ShowDialog();
        }
    }
}