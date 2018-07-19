using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Messages_ContainerForms
{
    public partial class Form1 : Form
    {
        private Container_Forms parentCF;

        public Form1(int index, Container_Forms CF)
        {
            InitializeComponent();
            this.Text = (index + 1).ToString();
            parentCF = CF;
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            foreach (Form1 tempForm1 in parentCF.arrForm1)
                if (!ReferenceEquals(tempForm1, this))
                    tempForm1.label1.Text = this.textBox1.Text; 
        }
    }
    public class Container_Forms : Form
    {
        private int counter = 4;
        public Form1[] arrForm1;
        public Container_Forms()
        {
            arrForm1 = new Form1[counter];
            for (int i = 0; i < counter; i++)
            {
                arrForm1[i] = new Form1(i, this);
                arrForm1[i].Show();
            }
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = SystemColors.Control;
            this.ShowInTaskbar = false;
        }
        static void Main()
        {
            Container_Forms myContainer_Forms = new Container_Forms();
            Application.Run(myContainer_Forms);
        }
    }
}