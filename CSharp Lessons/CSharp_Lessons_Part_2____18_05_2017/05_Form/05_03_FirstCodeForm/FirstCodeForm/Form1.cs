using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FirstCodeForm
{
    public partial class Form1 : Form
    {
        private Button myButton = new Button();
        private Label myLabel = new Label();
        
        public Form1()
        {
            this.Text = "First Code Form";
            this.Width = 300;
            this.Height = 200;
            //  	this.MaximizeBox = false;
            //		this.MinimizeBox = true;

            myButton.Width = 60;
            myButton.Height = 40;
            myButton.Left = 120;
            myButton.Top = 40;
            myButton.Font = new System.Drawing.Font("Arial", 12);
            myButton.Text = "OK";
            myButton.Click += new EventHandler(myButton_Click);
            this.Controls.Add(myButton);
           // myButton.Parent = this;

            myLabel.Width = 260;
            myLabel.Height = 40;
            myLabel.Left = 20;
            myLabel.Top = 100;
            myLabel.Font = new System.Drawing.Font("Arial", 30);
            this.Controls.Add(myLabel);
        }
        private void myButton_Click(object sender, System.EventArgs e)
        {
            if (myLabel.Text == "")
                myLabel.Text = "Hello, world!";
            else
                myLabel.Text = "";
        }
    }
}