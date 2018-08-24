using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace Red_Green_Blue_Transport_UserControls
{
    public partial class Form1 : Form
    {
        private UserControl1[] arrUC_From = new UserControl1[3],
            arrUC_To = new UserControl1[3], arrUC_Transport = new UserControl1[3];
        private const int N = 52;
        private Color[] arrColors = new Color[] { Color.Red, Color.Green, Color.Blue };
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                arrUC_From[i] = new UserControl1(N, "Full", i);
                arrUC_From[i].Location = new Point(2, 40 + 55 * i);
                this.Controls.Add(arrUC_From[i]);

                arrUC_Transport[i] = new UserControl1(5, "Empty", 0);
                arrUC_Transport[i].Location = new Point(2 + 135 * i, 210);
                this.Controls.Add(arrUC_Transport[i]);

                arrUC_To[i] = new UserControl1(N, "Empty", 0);
                arrUC_To[i].Location = new Point(2, 270 + 55 * i);
                this.Controls.Add(arrUC_To[i]);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
