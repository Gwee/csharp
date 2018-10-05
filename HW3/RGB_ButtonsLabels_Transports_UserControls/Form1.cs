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
        private const int N_rows_From = 3,
                          N_columns_From = 30,
                          N_To = 40,
                          N_Trasport = 5;

        private string[] arrColors = { "Red", "Green", "Blue" };
        private string[] arrTypes = { "Button", "Label", "TextBox" };
        private Thread[] arr_toTransport = new Thread[3],
                         arr_fromTransport = new Thread[3];

        private int[] arrIndex_Color = { 0, 0, 0 };
        private bool[] arrIsEnd = { false, false, false };
        private int[] arrIndex_Transport = { 0, 0, 0 };
        private int[] arrIndex_To = { 0, 0, 0 };

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
            int controlIndex = (int)o;// thread indicator
            int colorIndex = 0;
            int counter = 0;

            Color temp_color;
            string control_type = arrTypes[controlIndex];
            UserControl1 transport = arrUC_Transport[controlIndex];
            var arr_controls = UC_From.Controls.Clone();// make copy of UC_From controls to itereate on

            while (true)
            {
                Thread.Sleep(50);
                temp_color = Color.FromName(arrColors[colorIndex]);

                for (int i = 0; i < arr_controls.Count(); i++)
                {
                    if (control_type == arr_controls[i].GetType().Name && temp_color == arr_controls[i].BackColor)
                    {
                        counter++;
                        this.Invoke(new myDelegate(add), new object[] { transport, i, arr_controls[i] });
                        this.Invoke(new myDelegate(remove), new object[] { UC_From, i, arr_controls[i] });
                    }

                    if (counter == N_Trasport || colorIndex == arrColors.Length - 1 && i == arr_controls.Count() - 1)
                    {
                        counter = 0;

                        if (control_type == "Button") { arrAutoResetEvent_2[0].Set(); arrAutoResetEvent_1[0].WaitOne(); }
                        if (control_type == "Label") { arrAutoResetEvent_2[1].Set(); arrAutoResetEvent_1[1].WaitOne(); }
                        if (control_type == "TextBox") { arrAutoResetEvent_2[2].Set(); arrAutoResetEvent_1[2].WaitOne(); }
                    }
                }
                colorIndex++;//get next color

                if (colorIndex == arrColors.Length)//finish
                {
                    if (control_type == "Button") { arr_toTransport[0].Abort(); arr_fromTransport[0].Abort(); }
                    if (control_type == "Label") { arr_toTransport[1].Abort(); arr_fromTransport[1].Abort(); }
                    if (control_type == "TextBox") { arr_toTransport[2].Abort(); arr_fromTransport[2].Abort(); }
                }
            }
        }

        void fromTransport_Function(object o)
        {
            int controlIndex = (int)o;
            string control_type = arrTypes[controlIndex];

            if (control_type == "Button") arrAutoResetEvent_2[0].WaitOne();
            if (control_type == "Label") arrAutoResetEvent_2[1].WaitOne();
            if (control_type == "TextBox") arrAutoResetEvent_2[2].WaitOne();

            while (true)
            {
                Thread.Sleep(50);
                UserControl1 transport_tr = arrUC_Transport[controlIndex];
                UserControl1 transport_to = arrUC_To[controlIndex];
                var arr_controls = transport_tr.Controls.Clone();

                for (int i = 0; i < arr_controls.Count(); i++)
                {
                    this.Invoke(new myDelegate(add), new object[] { transport_to, i, arr_controls[i] });
                    this.Invoke(new myDelegate(remove), new object[] { transport_tr, i, arr_controls[i] });
                }

                if (control_type == "Button") { arrAutoResetEvent_1[0].Set(); arrAutoResetEvent_2[0].WaitOne(); }
                if (control_type == "Label") { arrAutoResetEvent_1[1].Set(); arrAutoResetEvent_2[1].WaitOne(); }
                if (control_type == "TextBox") { arrAutoResetEvent_1[2].Set(); arrAutoResetEvent_2[2].WaitOne(); }
            }
        }

        private void add(UserControl1 UC, int index, Control C)
        {
            int i = UC.Controls.Count;
            C.Location = new Point(3 + 31 * i, 0);
            UC.Controls.Add(C);
            UC.Refresh();
        }
        private void remove(UserControl1 UC, int index, Control C)
        {
            UC.Controls.Remove(C);
            UC.Refresh();
        }

        private Control[] CloneControls()
        {
            var arr_controls = new Control[UC_From.Controls.Count];
            UC_From.Controls.CopyTo(arr_controls, 0);

            return arr_controls;
        }
    }
}
