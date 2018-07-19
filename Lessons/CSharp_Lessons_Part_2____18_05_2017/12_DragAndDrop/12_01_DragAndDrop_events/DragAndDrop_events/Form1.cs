using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DragAndDrop_events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Label_1.DoDragDrop(Label_1.Text, DragDropEffects.All);
        }
        private void all_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            label3.Text += "DragEnter  " + ((Label)sender).Name + "   ";
        }
        private void all_DragLeave(object sender, EventArgs e)
        {
            label3.Text += "DragLeave  " + ((Label)sender).Name + "   ";
        }
        private void label2_DragDrop(object sender, DragEventArgs e)
        {
            Label_2.Text = e.Data.GetData(DataFormats.Text).ToString();
            label3.Text += "DragDrop  " + ((Label)sender).Name + "   ";
        }
        private void all_DragOver(object sender, DragEventArgs e)
        {
            label3.Text += "DragOver  " + ((Label)sender).Name + "   ";
            label4.Text = e.X.ToString() + " , " + e.Y.ToString();
        }
    }
}