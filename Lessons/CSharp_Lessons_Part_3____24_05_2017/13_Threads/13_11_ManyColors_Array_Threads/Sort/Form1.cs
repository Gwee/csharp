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
        private Label[] arrLabels ;
        private int arrLabels_Size = 150;

        private Color[] arrColors = new Color[]{Color.Red, Color.Green, Color.Blue,
            Color.Yellow, Color.Gray, Color.Magenta, Color.LightGreen, Color.LightBlue,
            Color.LightPink, Color.LightCyan};
        private const int arrColors_ActualSize = 8;  

        private Thread[] arrThreads;
        private Thread commonThread;
        private AutoResetEvent[] arrAutoResetEvent_1, arrAutoResetEvent_2;

        private int[] arrBoundary = new int[arrColors_ActualSize],
                    arrResult = new int[arrColors_ActualSize];

        public Form1()
        {
            InitializeComponent();
            Random myRandom = new Random();
            
            arrLabels = new Label[arrLabels_Size];
            for (int i = 0; i < arrLabels_Size; i++)
            {
                arrLabels[i] = new Label();
                arrLabels[i].Size = new Size(50, 30);
                arrLabels[i].BorderStyle = BorderStyle.FixedSingle;
                arrLabels[i].Location = new Point(i % 15 * 50, i / 15 * 30);
                arrLabels[i].BackColor = arrColors[myRandom.Next(0, arrColors_ActualSize)];
//////                arrLabels[i].Text =  "";
                arrLabels[i].Tag = "0";
                this.Controls.Add(arrLabels[i]);
            }
            int[] arrCounters = new int[arrColors_ActualSize];
            for (int i = 0; i < arrLabels_Size; i++)
                for (int j = 0; j < arrColors_ActualSize; j++)
                    if (arrLabels[i].BackColor == arrColors[j])
                    {
                        arrCounters[j]++;
                        break;
                    }

            arrBoundary[0] = 0;
            for (int i = 1; i < arrColors_ActualSize; i++)
                arrBoundary[i] = arrBoundary[i-1] + arrCounters[i-1];

            arrAutoResetEvent_1 = new AutoResetEvent[arrColors_ActualSize];
            arrAutoResetEvent_2 = new AutoResetEvent[arrColors_ActualSize];
            for (int i = 0; i < arrColors_ActualSize; i++)
            {
                arrAutoResetEvent_1[i] = new AutoResetEvent(false);
                arrAutoResetEvent_2[i] = new AutoResetEvent(false);
            }
        }

        void swap(int index1, int index2)
        {
            if (index1 == index2)
                return;
            Color temp = arrLabels[index1].BackColor;
            arrLabels[index1].BackColor = arrLabels[index2].BackColor;
            arrLabels[index2].BackColor = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arrThreads = new Thread[arrColors_ActualSize];
            for (int i = 0; i < arrColors_ActualSize; i++)
            {
                arrThreads[i] = new Thread(myFunction);
                arrThreads[i].Start(i);
            }
            commonThread = new Thread(new ThreadStart(myFunction_Common));
            commonThread.Start();
        }

        void myFunction(object obj)
        {
            int colorIndex = (int)obj;
            while (true)
            {
                arrResult[colorIndex] = -1;
                for (int i = 0; i < arrLabels_Size; i++)
                    if (arrLabels[i].BackColor == arrColors[colorIndex] &&
///////                       arrLabels[i].Text == "")
                        arrLabels[i].Tag == "0")
                    {
                        arrResult[colorIndex] = i;
                        break;
                    }
                arrAutoResetEvent_1[colorIndex].Set();
                arrAutoResetEvent_2[colorIndex].WaitOne();
            }
        }

        void myFunction_Common()
        {
            while (true)
            {
                int i;

                for (i = 0; i < arrColors_ActualSize; i++)
                    arrAutoResetEvent_1[i].WaitOne();

                for (i = 0; i < arrColors_ActualSize; i++)
                    if (arrResult[i] != -1)
                        break;
                if (i == arrColors_ActualSize)
                {
                    for (i = 0; i < arrColors_ActualSize; i++)
                        arrThreads[i].Abort();
                    break;
                }

                for (i = 0; i < arrColors_ActualSize; i++)
                {
                    if (arrResult[i] != -1)
                    {
                        this.Invoke(new delegateSwapLabels(swap),  arrBoundary[i], arrResult[i] );
//////////                        arrLabels[arrBoundary[i]].Text = " ";
                        arrLabels[arrBoundary[i]].Tag = "1";

                        for (int j = i + 1; j < arrColors_ActualSize; j++)
                            if (arrResult[j] == arrBoundary[i])
                                arrResult[j] = arrResult[i];
  
                        arrBoundary[i]++;
                    }
                }
                for (i = 0; i < arrColors_ActualSize; i++)
                    arrAutoResetEvent_2[i].Set();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}