using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perform_Event
{
    public partial class Form1 : Form
    {
        public event EventHandler myEvent;
        public Form1()
        {
            InitializeComponent();
            this.myEvent += new EventHandler(button2_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1");
            myEvent(this, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2");
        }
    }
}
