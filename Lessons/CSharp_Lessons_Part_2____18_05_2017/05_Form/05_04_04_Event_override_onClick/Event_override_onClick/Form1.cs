using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Event_override_onClick
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
        protected override void OnClick(EventArgs e)
        {
            _myLabel_.Text = "Form1  clicked";
        }
    }
}