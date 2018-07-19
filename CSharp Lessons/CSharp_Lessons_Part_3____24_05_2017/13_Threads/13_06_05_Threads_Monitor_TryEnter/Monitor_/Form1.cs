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
    class Simple
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
            Thread thread_1 = new Thread(new ThreadStart(action));
            thread_1.Name = "A";
            thread_1.Start();

            Thread thread_2 = new Thread(new ThreadStart(action));
            thread_2.Name = "B";
            thread_2.Start();

            Thread thread_3 = new Thread(new ThreadStart(action));
            thread_3.Name = "C";
            thread_3.Start();
        }
        void action()
        {
            while (commonCounter < 200)
            {
                if (System.Threading.Monitor.TryEnter(mySimple))
                {
                    commonCounter++;
                    Thread.Sleep(1);
                    this.Invoke(new mySetLabelTextDelegate(mySetLabelText), Thread.CurrentThread.Name + commonCounter.ToString() );
                    System.Threading.Monitor.Exit(mySimple);
                }
                else
                    this.Invoke(new mySetLabelTextDelegate(mySetLabelText),  " " + Thread.CurrentThread.Name );
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