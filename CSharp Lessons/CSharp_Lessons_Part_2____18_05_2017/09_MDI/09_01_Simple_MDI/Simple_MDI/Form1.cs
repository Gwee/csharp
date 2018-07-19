using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simple_MDI
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            MdiClient myMdiClient = myGetMdiClient();
            myMdiClient.Click += new EventHandler(myMdiClient_Click);

            Child myChild_1 = new Child("Child 1");
            myChild_1.MdiParent = this;
            myChild_1.Show();
            Child myChild_2 = new Child("Child 2");
            myChild_2.MdiParent = this;
            myChild_2.Show();
        }
        private MdiClient myGetMdiClient()
        {
            foreach (Control control in Controls)
            {
                MdiClient tempMdiClient = control as MdiClient;
                if (tempMdiClient != null)
                    return tempMdiClient;
            }
            return null;
        }
        private void myMdiClient_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Click on Container");
            ((MdiClient)sender).BackColor = Color.Yellow;
        }

    }
}