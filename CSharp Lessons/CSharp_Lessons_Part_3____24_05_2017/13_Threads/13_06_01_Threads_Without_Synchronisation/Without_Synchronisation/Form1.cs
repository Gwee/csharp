using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Without_Synchronisation
{
    public delegate void mySetLabelTextDelegate(string myString);

    public partial class Form1 : Form
    {
        private int commonCounter = 0;
        private Random R = new Random();
        private Thread thread_1, thread_2, thread_3; 

        public Form1()
        {
            InitializeComponent();
        }
 
        void action()
        {
            while (commonCounter < 1000)
            {
                commonCounter++;
                int temp = commonCounter;
                
                if (R.Next(0, 3) == 0)
                    Thread.Sleep(1);
                if (temp != commonCounter)
       //             this.Invoke(new mySetLabelTextDelegate(mySetLabelText), new object[] { commonCounter.ToString() });
                     this.Invoke(new mySetLabelTextDelegate(mySetLabelText), commonCounter.ToString());
                else
        //            this.Invoke(new mySetLabelTextDelegate(mySetLabelText), new object[] { "*" });
                    this.Invoke(new mySetLabelTextDelegate(mySetLabelText), "*" );
            }
        }
        private void mySetLabelText(string myString)
        {
            label1.Text += myString + " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thread_1 = new Thread(action);
            /// thread_1 = new Thread(new ThreadStart(action));
            thread_1.Start();

            thread_2 = new Thread(action);
            /// thread_2 = new Thread(new ThreadStart(action));
            thread_2.Start();

            thread_3 = new Thread(action);
            /// thread_3 = new Thread(new ThreadStart(action));
            thread_3.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}