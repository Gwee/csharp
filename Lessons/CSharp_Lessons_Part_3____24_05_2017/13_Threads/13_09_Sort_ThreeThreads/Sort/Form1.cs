using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Sort
{
    public delegate void delegateSwapLabels(int index1, int index2);

    public partial class Form1 : Form
    {
        private Label[] arrLabels;
        private int arrSize = 100;

        private Thread t1, t2, t3;
        private AutoResetEvent AutoResetEvent_1 = new AutoResetEvent(false);
        private AutoResetEvent AutoResetEvent_2 = new AutoResetEvent(false);
        private AutoResetEvent AutoResetEvent_3 = new AutoResetEvent(false);
        private AutoResetEvent AutoResetEvent_4 = new AutoResetEvent(false);

        private int boundaryLeft, boundaryRight;
        private int indexMax, indexMin ;
 
        public Form1()
        {
            InitializeComponent();
            arrLabels = new Label[100];
            Random myRandom = new Random();
            for (int i = 0; i < arrSize; i++)
            {
                arrLabels[i] = new Label();
                arrLabels[i].Size = new Size(60, 30);
                arrLabels[i].BorderStyle = BorderStyle.FixedSingle;
                arrLabels[i].Location = new Point(i % 10 * 60, i / 10 * 30);
                arrLabels[i].BackColor = Color.Yellow;
               // arrLabels[i].BackColor = Color.White;
                arrLabels[i].Font = new Font("Arial", 18);
                arrLabels[i].Text = myRandom.Next(1, 500).ToString();
                this.Controls.Add( arrLabels[i]);
            }
            boundaryLeft = 0; boundaryRight = arrSize - 1;
        }

        void swap(int index1, int index2)
        {
            string temp = arrLabels[index1].Text;
            arrLabels[index1].Text = arrLabels[index2].Text;
            arrLabels[index2].Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new Thread(myFunction_1);
            t1.Start();
            t2 = new Thread(myFunction_2);
            t2.Start();
            t3 = new Thread(myFunction_3);
            t3.Start();
        }
        void myFunction_1()
        {
            while (true)
            {
                indexMin = boundaryLeft;
                for ( int i = boundaryLeft + 1; i <= boundaryRight; i++)
                    if ( Int32.Parse(arrLabels[i].Text) < Int32.Parse(arrLabels[indexMin].Text))
                        indexMin = i;
                AutoResetEvent_1.Set();
                AutoResetEvent_2.WaitOne();
            }
        }

        void myFunction_2()
        {
            while (true)
            {
                indexMax = boundaryRight;
                for (int i = boundaryRight - 1; i >= boundaryLeft; i--)
                    if (Int32.Parse(arrLabels[i].Text) > Int32.Parse(arrLabels[indexMax].Text))
                        indexMax = i;
                AutoResetEvent_3.Set();
                AutoResetEvent_4.WaitOne();
            }
        }

        void myFunction_3()
        {
            while (true)
            {
                AutoResetEvent_1.WaitOne();
                AutoResetEvent_3.WaitOne();

                this.Invoke(new delegateSwapLabels(swap), indexMin, boundaryLeft);
                if (indexMax == boundaryLeft)
                    indexMax = indexMin;
                this.Invoke(new delegateSwapLabels(swap),  indexMax, boundaryRight );

                boundaryLeft ++;
                boundaryRight --;
                if (boundaryRight <= boundaryLeft )
                {
                    t1.Abort();
                    t2.Abort();
                    break;
                }
                AutoResetEvent_2.Set();
                AutoResetEvent_4.Set();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}