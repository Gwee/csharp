using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Message_Form_To_Form
{
    public partial class FormA : Form
    {
        FormB myFormB;

        public string LabelSet
        {
            set
            {
                label1.Text = value;
            }
        }

        public FormA()
        {
            InitializeComponent();
        }
        private void FormA_Load(object sender, EventArgs e)
        {
            myFormB = new FormB(this);
            myFormB.Show();             ///    myFormB.Visible = true;        
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            myFormB.LabelSet = textBox1.Text;
            myFormB.Focus();          ///         myFormB.Activate();
        }

        private void FormA_Activated(object sender, EventArgs e)
        {

        }
    }
}