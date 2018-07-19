using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labels_Swap___DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random myRand = new Random();
            for (int i = 0; i < 8; i++)
            {
                Label tempLabel = new Label();
                tempLabel.Font = new Font("Arial", 18, FontStyle.Bold);
                tempLabel.Text = myRand.Next(1, 99).ToString();
                tempLabel.Size = new Size(myRand.Next(50, 100), myRand.Next(30, 80));
                tempLabel.BackColor = Color.FromArgb(myRand.Next(80, 255), myRand.Next(80, 255), myRand.Next(80, 255));
                if (i % 2 == 0)
                    tempLabel.Location = new Point(10, i / 2 * 85 + 10);
                else
                    tempLabel.Location = new Point(120, i / 2 * 85 + 10);
                tempLabel.AllowDrop = true;
                tempLabel.MouseDown += new MouseEventHandler(all_MouseDown);
                tempLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.all_DragEnter);
                tempLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.all_DragDrop);

                this.Controls.Add(tempLabel);
            }
        }

        private void all_MouseDown(object sender, MouseEventArgs e)
        {
            dragClass myDragClass = new dragClass((Label)sender);
            ((Label)sender).DoDragDrop(myDragClass, DragDropEffects.Move);
        }
        public void all_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void all_DragDrop(object sender, DragEventArgs e)
        {
            Label currentLabel = (Label)sender;
            Label dragLabel = ((dragClass)(e.Data.GetData(typeof(dragClass)))).mLabel;

 /*           string tempText = currentLabel.Text;
            Color tempColor = currentLabel.BackColor;
            Font tempFont = currentLabel.Font;
            Size tempSize = currentLabel.Size;

            currentLabel.Text = dragLabel.Text;
            currentLabel.BackColor = dragLabel.BackColor;
            currentLabel.Font = dragLabel.Font;
            currentLabel.Size = dragLabel.Size;

            dragLabel.Text = tempText;
            dragLabel.BackColor = tempColor;
            dragLabel.Font = tempFont;
            dragLabel.Size = tempSize;
  */
            int tempX = currentLabel.Location.X;
            int tempY = currentLabel.Location.Y;
            currentLabel.Location = dragLabel.Location;
            dragLabel.Location = new Point(tempX, tempY);
        }
    }
}
