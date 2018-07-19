using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Image_Text_DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap liliaBitmap = new Bitmap("../../lilia.jpg");
            pictureBox1.Image = liliaBitmap;

            pictureBox1.AllowDrop = true;	// without Desiner
            label1.AllowDrop = true;
            label2.AllowDrop = true;
        }
        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.All);
        }
        private void label1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            label1.DoDragDrop(label1.Text, DragDropEffects.All);
        }

        private void all_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void label2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                label2.Image = (Bitmap)(e.Data.GetData(DataFormats.Bitmap));
            if (e.Data.GetDataPresent(DataFormats.Text))
                label2.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}