using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Message_Form_To_Form
{
    public partial class FormB : Form
    {
        FormA myFormA;

        public string LabelSet
        {
            set
            {
                label1.Text = value;
            }
        }

        public FormB(FormA myA)
        {
            InitializeComponent();
            myFormA = myA;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            myFormA.LabelSet = textBox1.Text;
            myFormA.Focus();
        }
        private void FormB_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}