using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_RGB
{
    public partial class Form1 : Form
    {
        private int R = 255, G = 0, B = 0, signR = -1, signG = 0, signB = 1, count;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
                timer1.Start();
            else
                timer1.Stop();

            ////           timer1.Enabled = ! timer1.Enabled;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            R += signR; G += signG; B += signB;
            count++;
            if (count == 255)
            {
                count = 0;
                int temp = signR;
                signR = signG; signG = signB; signB = temp;
            }
            label1.ForeColor = Color.FromArgb(R, G, B);

            label1.Text = DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." +
                DateTime.Now.Day.ToString() + "." + DateTime.Now.Hour.ToString() + "." + 
                DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString() + "." +   
                (DateTime.Now.Millisecond / 10).ToString();
        }
    }
}
