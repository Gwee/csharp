using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Threads_Invoke
{
    public delegate void mySetLabeDelegate_String(string myString);
    public delegate void mySetLabeDelegate_StringInt(string myString, int myInt);

    public partial class Form1 : Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void action()
        {
            while (counter < 200)
            {
                counter++;
/*
                if (Thread.CurrentThread.Name == "First")
                    label1.Text += "+";
                else
                    label1.Text += "/";
*/
/*                if (Thread.CurrentThread.Name == "First")
                    label1.Text += " +" + counter.ToString();
                else
                    label1.Text += " /" + counter.ToString();
*/
//---------------------------------------
                /*
                                if (Thread.CurrentThread.Name == "First")
                                    this.Invoke(new mySetLabeDelegate_String(mySetLabel_String), new object[] { "+" });
                                else
                                    this.Invoke(new mySetLabeDelegate_String(mySetLabel_String), new object[] { "/" });
                */
                /*
                                if (Thread.CurrentThread.Name == "First")
                                    this.Invoke(new mySetLabeDelegate_(mySetLabel_String),  "+" );
                                else
                                    this.Invoke(new mySetLabeDelegate_(mySetLabel_String), "/" );
                */
//---------------------------------------
/*
            if (Thread.CurrentThread.Name == "First")
                this.Invoke(new mySetLabeDelegate_StringInt(mySetLabel_StringInt), new object[] { " +", counter });
            else
                this.Invoke(new mySetLabeDelegate_StringInt(mySetLabel_StringInt), new object[] { " /" , counter });
*/

           if (Thread.CurrentThread.Name == "First")
               this.Invoke(new mySetLabeDelegate_StringInt(mySetLabel_StringInt), " +", counter );
           else
               this.Invoke(new mySetLabeDelegate_StringInt(mySetLabel_StringInt), " /" , counter );


            }
        }

        private void mySetLabel_String(string myString)
        {
            label1.Text += myString;
        }
        private void mySetLabel_StringInt(string myString, int myInt)
        {
            label1.Text += myString + " " + myInt.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread_1 = new Thread(action);
            //// Thread thread_1 = new Thread(new ThreadStart(action));
            thread_1.Name = "First";
            thread_1.Start();

            Thread thread_2 = new Thread(action);
            /// Thread thread_2 = new Thread(new ThreadStart(action));
            thread_2.Name = "Second";
            thread_2.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
 //         System.Environment.Exit(System.Environment.ExitCode);
            Application.Exit();
        }
    }
}