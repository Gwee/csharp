using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using Common;

namespace Client
{
    public partial class Form1 : Form
    {
        private Label[] arrLabels;
        private int arrSize;
        private ICommon myICommon;
        private int currCounter_Data = -1;

        public Form1()
        {
            InitializeComponent();

            Random myRand = new Random();
            arrSize = myRand.Next(5, 15);

            int currPosition = 2;
            arrLabels = new Label[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                arrLabels[i] = new Label();
                arrLabels[i].BackColor = Color.Red;

                int tempXY = myRand.Next(20, 40);
                switch (myRand.Next(4))
                {
                    case 0:
                    case 1: arrLabels[i].Size = new Size(tempXY, tempXY);
                        arrLabels[i].Text = "X"; break;
                    case 2: arrLabels[i].Size = new Size(tempXY * 2, tempXY); break;
                    case 3: arrLabels[i].Size = new Size(tempXY, tempXY * 2); break;
                }

                arrLabels[i].Location = new Point(currPosition, 3);
                currPosition += arrLabels[i].Size.Width + 2;
                this.Controls.Add(arrLabels[i]);
            }

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            myICommon = (ICommon)Activator.GetObject(
                typeof(ICommon),
                "http://localhost:1234/_Server_");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size[] arrTemp = new Size[arrSize];
            for (int i = 0; i < arrSize; i++)
                arrTemp[i] = new Size(arrLabels[i].Width, arrLabels[i].Height);
            myICommon.add_Client(arrTemp);        
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Size[] arrTemp = new Size[arrSize];
            for (int i = 0; i < arrSize; i++)
                arrTemp[i] = new Size(arrLabels[i].Width, arrLabels[i].Height);

            myICommon.remove_Client(arrTemp);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Common.Counter_Client_Rectangle_Square_Data myCounter_Client_Rectangle_Square_Data = myICommon.getData(currCounter_Data);

            if (myCounter_Client_Rectangle_Square_Data == null)
                return;

            All_Clients.Text = myCounter_Client_Rectangle_Square_Data.Counter_Client.ToString();
            Al_Rectangels.Text = myCounter_Client_Rectangle_Square_Data.Counter_Rectangles.ToString();
            All_Squares.Text = myCounter_Client_Rectangle_Square_Data.Counter_Squares.ToString();
            currCounter_Data = myCounter_Client_Rectangle_Square_Data.Counter_Data;
        }
    }
}

