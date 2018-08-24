using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace Red_Green_Blue_Transport_UserControls
{
    public delegate void myAddDelegate(UserControl1 UC, int counter, Color temp);
    public delegate void myRemoveDelegate(UserControl1 UC, int i);

    public partial class Form1 : Form
    {
        private UserControl1[] arrUC_From = new UserControl1[3],
            arrUC_To = new UserControl1[3], arrUC_Transport = new UserControl1[3];
        private const int N = 52;
        private Color[] arrColors = new Color[] { Color.Red, Color.Green, Color.Blue };
        private Thread[] arr_toTransport = new Thread[3], arr_fromTransport = new Thread[3];
        private int[] arrIndex_From = new int[3];

        private bool[] arrIsEnd = new bool[3];
        private int[] arrCounter_Transport = new int[3];
        private int[] arrCounter_To = new int[3];

        private AutoResetEvent[] arrAutoResetEvent_1 = new AutoResetEvent[3], arrAutoResetEvent_2 = new AutoResetEvent[3];

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                arrUC_From[i] = new UserControl1(N, "Full", i);
                arrUC_From[i].Location = new Point(2, 40 + 55 * i);
                this.Controls.Add(arrUC_From[i]);

                arrUC_Transport[i] = new UserControl1(5, "Empty", 0);
                arrUC_Transport[i].Location = new Point(2 + 135 * i, 210);
                this.Controls.Add(arrUC_Transport[i]);

                arrUC_To[i] = new UserControl1(N, "Empty", 0);
                arrUC_To[i].Location = new Point(2, 270 + 55 * i);
                this.Controls.Add(arrUC_To[i]);

                arrAutoResetEvent_1[i] = new AutoResetEvent(false);
                arrAutoResetEvent_2[i] = new AutoResetEvent(false);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                arr_toTransport[i] = new Thread(toTransport_Function);
                arr_fromTransport[i] = new Thread(fromTransport_Function);

                arr_toTransport[i].Start(i);
                arr_fromTransport[i].Start(i);
            }

        }

        void toTransport_Function(object o)
        {
            int indexColor = (int)o;
            for (int k = 0; k < 3; k++)
            {
                if( k != indexColor )
                {
                    for (int i = 0; i < N; i++)
                    {
                        Label temp = arrUC_From[arrIndex_From[indexColor]].arrLabels[i];
                        if (temp.BackColor == arrColors[indexColor])
                        {
                            this.Invoke(new myAddDelegate(add), arrUC_Transport[indexColor], arrCounter_Transport[indexColor], temp.BackColor);
                            this.Invoke(new myRemoveDelegate(remove), arrUC_From[arrIndex_From[indexColor]], i);
                            arrCounter_Transport[indexColor]++;
                            Thread.Sleep(100);
                            if (arrCounter_Transport[indexColor] == 5)
                            {
                                arrAutoResetEvent_1[indexColor].Set();
                                arrAutoResetEvent_2[indexColor].WaitOne();
                            }
                        }
                    }
                }
                arrIndex_From[indexColor]++;
                if (arrIndex_From[indexColor] == 3)
                    break;
            }
            arrAutoResetEvent_1[indexColor].Set();
            arrIsEnd[indexColor] = true;
        }

        void fromTransport_Function(object o)
        {
            int indexColor = (int)o;

            while (true)
            {
                arrAutoResetEvent_1[indexColor].WaitOne();

                for (int i = 0; i < arrCounter_Transport[indexColor]; i++)
                {
                    this.Invoke(new myAddDelegate(add), arrUC_To[indexColor], arrCounter_To[indexColor], arrColors[indexColor]);
                    this.Invoke(new myRemoveDelegate(remove), arrUC_Transport[indexColor], i);
                    Thread.Sleep(100);
                    arrCounter_To[indexColor]++;
                }
                if (arrIsEnd[indexColor] == false)
                {
                    arrCounter_Transport[indexColor] = 0;
                    arrAutoResetEvent_2[indexColor].Set();
                }
                else
                    break;
            }
        }

        private void add(UserControl1 UC, int counter, Color temp)
        {
            UC.arrLabels[counter].BackColor = temp;
        }
        private void remove(UserControl1 UC, int index)
        {
            UC.arrLabels[index].BackColor = Color.White;
        }

    }
}
