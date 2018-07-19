using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListControls_Sort
{
    public partial class Form1 : Form
    {
        private List<Control> ListControls = new List<Control>();
        public Form1()
        {
            InitializeComponent();
            Random myRand = new Random();
            int ListSize = myRand.Next(7, 11);
            Control tempControl;

            int lastY = 2;

            for (int i = 0; i < ListSize; i++)
            {
                if (myRand.Next(0, 2) == 0)
                    tempControl = new Label();
                else
                    tempControl = new Button();
                tempControl.Size = new Size(myRand.Next(30, 150), myRand.Next(30, 100));
                tempControl.BackColor = Color.FromArgb(myRand.Next(80, 255), myRand.Next(80, 255), myRand.Next(80, 255));
                tempControl.Location = new Point(10, lastY);

                lastY += tempControl.Size.Height + 2;
                this.Controls.Add(tempControl);

                ListControls.Add(tempControl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListControls.Sort((x, y) => x.Width * x.Height - y.Width * y.Height);
 
            int lastY = 2;
            for (int i = 0; i < ListControls.Count; i++)
            {
                ListControls[i].Location = new Point(10, lastY);
                lastY += ListControls[i].Size.Height + 2;
            }
        }
    }
}
