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
        private static int counter = 0;
        private const int maxCounter = 3;
        private static Form1[] arrForm1 = new Form1[maxCounter];

        public Form1()
        {
            InitializeComponent();
            Bitmap liliaBitmap = new Bitmap("../../lilia.jpg");
            pictureBox1.Image = liliaBitmap;

            pictureBox1.AllowDrop = true;	// without Desiner
            label1.AllowDrop = true;
            label2.AllowDrop = true;

            arrForm1[counter] = this;
            counter++;
            arrForm1[counter - 1].Text += counter.ToString();
            if (counter < maxCounter)
            {
                Form1 temp = new Form1();
                temp.Show();
            }
        }
        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.All);
        }
        private void label1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            label1.DoDragDrop(label1.Text, DragDropEffects.All);
        }

        private void label2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if ((e.Data.GetDataPresent(DataFormats.Bitmap)))
                label2.Image = (Bitmap)(e.Data.GetData(DataFormats.Bitmap));
            if ((e.Data.GetDataPresent(DataFormats.Text)))
                label2.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}