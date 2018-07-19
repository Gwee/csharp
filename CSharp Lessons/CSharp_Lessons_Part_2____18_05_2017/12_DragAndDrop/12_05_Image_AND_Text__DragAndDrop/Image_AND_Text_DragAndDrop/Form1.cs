using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Image_AND_Text_DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap liliaBitmap = new Bitmap("../../lilia.jpg");
            label1.Image = liliaBitmap;

            label1.AllowDrop = true;
            label2.AllowDrop = true;
        }
        private void label1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dragClass myDragClass = new dragClass();
            myDragClass.getSetImage = ((Label)sender).Image;
            myDragClass.getSetString = ((Label)sender).Text;
            label1.DoDragDrop(myDragClass, DragDropEffects.Move);
        }

        private void all_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
           e.Effect = DragDropEffects.Move;
        }
        private void label2_DragDrop(object sender, DragEventArgs e)
        {
            label2.Image = ((dragClass)(e.Data.GetData(typeof(dragClass)))).getSetImage;
            label2.Text = ((dragClass)(e.Data.GetData(typeof(dragClass)))).getSetString;
        }
    }
}