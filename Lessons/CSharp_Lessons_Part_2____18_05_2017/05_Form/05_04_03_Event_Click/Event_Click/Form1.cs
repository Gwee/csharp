using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Event_Click
{
    public partial class Form1 : Form
    {
        private myLabel _myLabel_;

        public Form1()
        {
            InitializeComponent();
            _myLabel_ = new myLabel();
            this.Controls.Add(_myLabel_);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            _myLabel_.Text = "Form  clicked";
        }
    }
}
