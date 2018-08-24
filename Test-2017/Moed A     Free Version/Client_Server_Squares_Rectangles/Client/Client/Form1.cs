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
        private Control[] arrControls;
        private ICommon myICommon;
        private Control[] arrControls_result = null;

        public Form1()
        {
            InitializeComponent();

            Random myRand = new Random();
            int arrSize = myRand.Next(5, 10);

            int currPosition = 2;
            arrControls = new Control[arrSize];

            Color myColor = Color.FromArgb(myRand.Next(100, 256), myRand.Next(100, 256), myRand.Next(100, 256));
            for (int i = 0; i < arrSize; i++)
            {
                if(myRand.Next(2) == 0)
                    arrControls[i] = new Button();
                else
                    arrControls[i] = new Label();
                arrControls[i].BackColor = myColor;

                int tempXY = myRand.Next(20, 40);
                switch (myRand.Next(4))
                {
                    case 0:
                    case 1: arrControls[i].Size = new Size(tempXY, tempXY); break;
                    case 2: arrControls[i].Size = new Size(tempXY * 2, tempXY); break;
                    case 3: arrControls[i].Size = new Size(tempXY, tempXY * 2); break;
                }

                arrControls[i].Location = new Point(currPosition, 3);
                currPosition += arrControls[i].Size.Width + 2;
                this.Controls.Add(arrControls[i]);
            }

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            myICommon = (ICommon)Activator.GetObject(
                typeof(ICommon),
                "http://localhost:1234/_Server_");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void radioButtonSquareRectangle_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}

