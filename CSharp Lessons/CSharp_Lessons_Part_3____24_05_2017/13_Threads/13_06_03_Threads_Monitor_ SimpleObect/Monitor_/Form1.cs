using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Monitor_
{
    public delegate void mySetLabelTextDelegate(string myString);
   
    public class Simple
    {
    }
    public partial class Form1 : Form
    {
        private Random R = new Random();
        private int commonCounter = 0;
        private Simple mySimple = new Simple();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread_1 = new Thread(action);
            thread_1.Start();

            Thread thread_2 = new Thread(action);
            thread_2.Start();

            Thread thread_3 = new Thread(action);
            thread_3.Start();
        }
        void action()
        {
            while (commonCounter < 500)
            {
                Monitor.Enter(mySimple);
                commonCounter++;
                int temp = commonCounter;

                if (R.Next(0, 3) == 0)
                    Thread.Sleep(1);
                if (temp != commonCounter)
                    this.Invoke(new mySetLabelTextDelegate(mySetLabelText),commonCounter.ToString() );
                else
                    this.Invoke(new mySetLabelTextDelegate(mySetLabelText),  "*" );
                Monitor.Exit(mySimple);
            }
        }
        private void mySetLabelText(string myString)
        {
            label1.Text += myString + " ";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}