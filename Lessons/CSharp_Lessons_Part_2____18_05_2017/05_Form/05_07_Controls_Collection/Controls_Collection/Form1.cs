using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controls_Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Button myButton = new Button();
            myButton.Name = "Button2";
            myButton.Location = new Point(20, 120);
            this.Controls.Add(myButton);

            Label myLabel = new Label();
            myLabel.Name = "Label2";
            myLabel.Location = new Point(100, 120);
            myLabel.BackColor = Color.Yellow;
            this.Controls.Add(myLabel);

            TextBox myTextBox = new TextBox();
            myTextBox.Name = "TextBox2";
            myTextBox.Location = new Point(200, 120);
            this.Controls.Add(myTextBox);

            InitializeComponent();

            label3.Text += Controls.Count.ToString() + "\n";
            foreach (Control control in Controls)
            {
                label3.Text += control.Name + "   ";
            }
        }
    }
}