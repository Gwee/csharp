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
    public delegate void delegate_Swap_Controls(int index1, int index2);

    public partial class Form1 : Form
    {
        private Control[] arrControls;
        private int arrControls_Size = 180;

        private Color[] arrColors = new Color[]{Color.LightCoral, Color.LightGreen, Color.LightBlue,
            Color.Pink, Color.Yellow, Color.Gray, Color.Magenta, Color.Orange, 
            Color.LightPink, Color.Cyan};

        private const int arrColors_ActualSize = 8;
        private int currentColors_Index_Left = 0;
        private int currentColors_Index_Right = arrColors_ActualSize - 1;

        private Thread t1, t2, t3;
        private AutoResetEvent AutoResetEvent_1 = new AutoResetEvent(false);
        private AutoResetEvent AutoResetEvent_2 = new AutoResetEvent(false);
        private AutoResetEvent AutoResetEvent_3 = new AutoResetEvent(false);
        private AutoResetEvent AutoResetEvent_4 = new AutoResetEvent(false);

        private int boundaryLeft, boundaryRight;
        private int indexLeft, indexRight;

        private bool left_IsLabel = true, right_IsLabel = false;
        private Color ColorLeft , ColorRight;

        public Form1()
        {
            InitializeComponent();
            Random myRandom = new Random();
            arrControls = new Control[arrControls_Size];
            for (int i = 0; i < arrControls_Size; i++)
            {
                if (myRandom.Next(0, 2) == 0)
                    arrControls[i] = new Label();
                else
                    arrControls[i] = new Button();

                arrControls[i].Size = new Size(60, 30);
                arrControls[i].Location = new Point(i % 12 * 62 + 1, i / 12 * 32 + 1);
                arrControls[i].Font = new Font("Arial", 16);
                arrControls[i].BackColor = arrColors[myRandom.Next(0, arrColors_ActualSize)];
                this.Controls.Add(arrControls[i]);
            }
            boundaryLeft = 0; boundaryRight = arrControls_Size - 1 ;
            ColorLeft = arrColors[currentColors_Index_Left];
            ColorRight = arrColors[currentColors_Index_Right];
        }

        void swap(int index1, int index2)
        {
            if (index1 == index2)
                return;

            int tempX = arrControls[index1].Location.X;
            int tempY = arrControls[index1].Location.Y;

            arrControls[index1].Location = new Point(
                arrControls[index2].Location.X, arrControls[index2].Location.Y);
            arrControls[index2].Location = new Point(tempX, tempY);

            Control tempControl = arrControls[index1];
            arrControls[index1] = arrControls[index2];
            arrControls[index2] = tempControl;
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
                indexLeft = -1;
                for (int i = boundaryLeft; i <= boundaryRight; i++)
                    if (arrControls[i].BackColor == ColorLeft ) 
                        if( left_IsLabel == true && arrControls[i].GetType().Name == "Label"
                            || 
                            left_IsLabel == false && arrControls[i].GetType().Name == "Button" )
                    {
                        indexLeft = i;
                        break;
                    }
                AutoResetEvent_1.Set();
                AutoResetEvent_3.WaitOne();
            }
        }

        void myFunction_2()
        {
            while (true)
            {
                indexRight = -1;
                for (int i = boundaryRight ; i >= boundaryLeft; i--)
                    if (arrControls[i].BackColor == ColorRight)
                        if( right_IsLabel == true && arrControls[i].GetType().Name == "Label"
                            || 
                            right_IsLabel == false && arrControls[i].GetType().Name == "Button" )
                    {
                        indexRight = i;
                        break;
                    }
                AutoResetEvent_2.Set();
                AutoResetEvent_4.WaitOne();
            }
        }

        void myFunction_3()
        {
            while (boundaryLeft < boundaryRight)
            {
                AutoResetEvent_1.WaitOne();
                AutoResetEvent_2.WaitOne();

                if (indexLeft != -1)
                {
                    this.Invoke(new delegate_Swap_Controls(swap), new object[] { indexLeft, boundaryLeft });
                    if (indexRight == boundaryLeft)
                        indexRight = indexLeft;
                    boundaryLeft++;
                }
                else
                {
                    if (left_IsLabel == true)
                        left_IsLabel = false;
                    else
                    {
                        left_IsLabel = true;
                        currentColors_Index_Left++;
                        ColorLeft = arrColors[currentColors_Index_Left];
                    }
                }

                if (indexRight != -1)
                {
                    this.Invoke(new delegate_Swap_Controls(swap), new object[] { indexRight, boundaryRight });
 
                    boundaryRight--;
                }
                else
                {
                    if (right_IsLabel == false)
                        right_IsLabel = true;
                    else
                    {
                        right_IsLabel = false;
                        currentColors_Index_Right--;
                        ColorRight = arrColors[currentColors_Index_Right];
                    }
                }
     
                if (boundaryRight - boundaryLeft < 1 )
                {
                    t1.Abort();
                    t2.Abort();
                    break;
                }
                AutoResetEvent_3.Set();
                AutoResetEvent_4.Set();
             }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}