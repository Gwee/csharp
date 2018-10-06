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

private AutoResetEvent[] arrAutoResetEvent_1 = new AutoResetEvent[3], arrAutoResetEvent_2 = new AutoResetEvent[3];

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }

        void fromTransport_Function(object o)
        {

        }

        private void add(UserControl1 UC, int index, Control C)
        {

        }
        private void remove(UserControl1 UC, int index, Control C)
        {
     
        }

    }
}
