using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UserControl_Different_Controls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Random myRand = new Random();
            for (int i = 0; i < 8; i++)
            {
                Control tempControl;
                if(myRand.Next(0, 2) == 0)
                    tempControl = new Label();
                else
                    tempControl = new Button();
                tempControl.Font = new Font("Arial", 18, FontStyle.Bold);
                tempControl.Text = myRand.Next(1, 99).ToString();
                tempControl.Size = new Size(myRand.Next(50, 100), myRand.Next(30, 80));
                tempControl.BackColor = Color.FromArgb(myRand.Next(80, 255), myRand.Next(80, 255), myRand.Next(80, 255)); 
                if (i % 2 == 0)
                    tempControl.Location = new Point(10, i / 2 * 85 + 10);
                else
                    tempControl.Location = new Point(120, i / 2 * 85 + 10);
                tempControl.AllowDrop = true;
                tempControl.MouseDown += new MouseEventHandler(all_MouseDown);
                tempControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.all_DragEnter);
                this.Controls.Add(tempControl);
            }
        }
        private void all_MouseDown(object sender, MouseEventArgs e)
        {
            dragClass myDragClass = new dragClass((Control)sender);
            ((Control)sender).DoDragDrop(myDragClass, DragDropEffects.Move);
        }
        public void all_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

    }
}
