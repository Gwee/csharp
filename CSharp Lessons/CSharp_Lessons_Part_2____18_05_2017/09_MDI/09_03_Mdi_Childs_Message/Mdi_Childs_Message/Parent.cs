using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mdi_Childs_Message
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
  			int counter = 3;
            this.Width = 0;
            for (int i = 0; i < counter; i++)
            {
                Child tempChild = new Child((i + 1).ToString());
                tempChild.MdiParent = this;
                this.Width += tempChild.Width;
                tempChild.Show();
            }
        }
        private void Parent_Shown(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}