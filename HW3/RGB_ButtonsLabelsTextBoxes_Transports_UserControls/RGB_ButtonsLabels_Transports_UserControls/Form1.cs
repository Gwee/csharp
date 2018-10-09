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

namespace RGB_ButtonsLabels_Transports_UserControls
{
    public delegate void myDelegate(UserControl1 UC, int index, Control C);

    public partial class Form1 : Form
    {
        private UserControl1 UC_From;
        private UserControl1[] arrUC_Transport = new UserControl1[3], arrUC_To = new UserControl1[3];
        private const int N_rows_From = 3, N_columns_From = 30, N_To = 40,  N_Trasport = 5;

        private string[] arrColors = { "Red", "Green", "Blue" };
        private string[] arrTypes = { "Button", "Label", "TextBox" };
        private Thread[] arr_toTransport = new Thread[3], arr_fromTransport = new Thread[3];

        private int[] arrIndex_Color = { 0, 0, 0 };
        private bool[] arrIsEnd = { false, false, false };
        private int[] arrIndex_Transport =  { 0, 0, 0 };
        private int[] arrIndex_To =  { 0, 0, 0 };

private AutoResetEvent[] arrAutoResetEvent_1 = new AutoResetEvent[3],
                         arrAutoResetEvent_2 = new AutoResetEvent[3];

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrAutoResetEvent_1.Count(); i++)
            {
                arrAutoResetEvent_1[i] = new AutoResetEvent(false);
            }
            for (int i = 0; i < arrAutoResetEvent_2.Count(); i++)
            {
                arrAutoResetEvent_2[i] = new AutoResetEvent(false);
            }
            for (int i = 0; i < arr_toTransport.Count(); i++)
            {
                arr_toTransport[i] = new Thread(toTransport_Function);
                arr_toTransport[i].Start(i);
            }
            for (int i = 0; i < arr_fromTransport.Count(); i++)
            {
                arr_fromTransport[i] = new Thread(fromTransport_Function);
                arr_fromTransport[i].Start(i);
            }
        }


        public Form1()
        {
            InitializeComponent();

            UC_From = new UserControl1(N_rows_From, N_columns_From, "Full");
            UC_From.Location = new Point(2, 47);
            this.Controls.Add(UC_From);

            for (int i = 0; i < 3; i++)
            {
                arrUC_Transport[i] = new UserControl1(1, N_Trasport, "Empty");
                arrUC_Transport[i].Location = new Point(2 + 250 * i, 182);
                this.Controls.Add(arrUC_Transport[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                arrUC_To[i] = new UserControl1(1, N_To, "Empty");
                arrUC_To[i].Location = new Point(2, 250 + 73 * i);
                this.Controls.Add(arrUC_To[i]);
            }
        }

        void toTransport_Function(object o)
        {
            int threadID = (int)o;
            int counter = 0;
            string controlType = arrTypes[threadID];
            string controlColor = arrColors[arrIndex_Color[threadID]];
            UserControl1 transport = arrUC_Transport[threadID];

            var clonedControls = UC_From.Controls.Clone();

            while (true)
            {
                Thread.Sleep(50);
                foreach (Control control in clonedControls)
                {
                    if (control.GetType().Name == controlType && control.BackColor.Name == controlColor)
                    {
                        counter++;
                        this.Invoke(new myDelegate(add),new object[] { transport, threadID , control});
                        this.Invoke(new myDelegate(remove), new object[] { UC_From, threadID, control });
                    }
                    if (counter == N_Trasport)
                    {
                        counter = 0;

                        if (controlType == "Button") { arrAutoResetEvent_2[0].Set(); arrAutoResetEvent_1[0].WaitOne(); }
                        if (controlType == "Label") { arrAutoResetEvent_2[1].Set(); arrAutoResetEvent_1[1].WaitOne(); }
                        if (controlType == "TextBox") { arrAutoResetEvent_2[2].Set(); arrAutoResetEvent_1[2].WaitOne(); }
                    }
                }
                arrIndex_Color[threadID]++;//get next color
                }
            }
            

        void fromTransport_Function(object o)
        {

        }

        private void add(UserControl1 UC, int index, Control C)
        {
            int pos = UC.Controls.Count;
            C.Location = new Point(3 + 31 * pos, 0);
            UC.Controls.Add(C);
            UC.Refresh();
        }
        private void remove(UserControl1 UC, int index, Control C)
        {
     
        }
    }
}
