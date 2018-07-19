using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserControl_Different_Controls
{
    public partial class Form1 : Form
    {
        private UserControl1 myUserControl1;
        Control myControl;
        public Form1()
        {
            InitializeComponent();
            myUserControl1 = new UserControl1();
            myUserControl1.Location = new Point(10, 10);
            this.Controls.Add(myUserControl1);

            panel1.DragEnter += new System.Windows.Forms.DragEventHandler(myUserControl1.all_DragEnter);
            panel1.DragDrop += new System.Windows.Forms.DragEventHandler(panel1_DragDrop);
        }
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            panel1.Controls.Remove(myControl);
            if ( ((dragClass)(e.Data.GetData(typeof(dragClass)))).mControl.GetType().Name == "Button") 
                myControl = new Button();
            else
                myControl = new Label();
            myControl.Text = ((dragClass)(e.Data.GetData(typeof(dragClass)))).mControl.Text;
            myControl.BackColor = ((dragClass)(e.Data.GetData(typeof(dragClass)))).mControl.BackColor;
            myControl.Font = ((dragClass)(e.Data.GetData(typeof(dragClass)))).mControl.Font;
            myControl.Size = ((dragClass)(e.Data.GetData(typeof(dragClass)))).mControl.Size;
            myControl.Location = new Point(50, 50);
            panel1.Controls.Add(myControl);
        }
    }
}