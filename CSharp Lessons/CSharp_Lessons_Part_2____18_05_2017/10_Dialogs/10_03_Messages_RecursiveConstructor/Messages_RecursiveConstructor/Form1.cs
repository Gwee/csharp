using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Messages_RecursiveConstructor
{
    public partial class Form1 : Form
    {
        private static int counter = 4;
        private static Form1[] arrForm1 = new Form1[counter];
 
        //  private static Form1[] arrForm1;
        //  static Form1()
        //  {
        //      arrForm1 = new Form1[counter];
        //  }

        public Form1()
        {
            InitializeComponent();
            arrForm1[counter - 1] = this;
            arrForm1[counter - 1].Text = counter.ToString();
            counter--;
            if (counter > 0)
            {
                Form1 temp = new Form1();
                temp.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form1 tempForm1 in arrForm1)
                if (!ReferenceEquals(tempForm1, this))
                    tempForm1.label1.Text = this.textBox1.Text; 
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
   //   private void Form1_Closed(object sender, System.EventArgs e)
   //   {
   //      Application.Exit();
   //   }
   //    protected override void OnClosed(EventArgs e)
   //    {
   //        Application.Exit();
   //    }

    }
}