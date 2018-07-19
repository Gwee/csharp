using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pictures_MDI
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

         private void flowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Child my_Child_Flower = new Child();
			my_Child_Flower.MdiParent = this;
			my_Child_Flower.Text = "Flower";
			my_Child_Flower.pictureBox1.Image = Image.FromFile( "../../Flower.jpg" );
			my_Child_Flower.Show();          
        }

        private void nightToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Child my_Child_Night = new Child();
			my_Child_Night.MdiParent = this;
			my_Child_Night.Text = "Night";
			my_Child_Night.pictureBox1.Image = Image.FromFile( "../../Night.jpg" );
			my_Child_Night.Show();         
//////		my_Child_Night.SendToBack();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.LayoutMdi( MdiLayout.Cascade );
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.LayoutMdi( MdiLayout.TileHorizontal );
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.LayoutMdi( MdiLayout.TileVertical );
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
			foreach (Form frm in this.MdiChildren)
			{
				frm.WindowState = FormWindowState.Minimized;
			}
        }
    }
}
