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
        private int resultCounter = 0;
        private bool isSquare = true;

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
            TypeSizeColor[] arrTypeSizeColor = new TypeSizeColor[arrControls.Length];
            for (int i = 0; i < arrControls.Length; i++)
            {
                arrTypeSizeColor[i] = new TypeSizeColor();
                arrTypeSizeColor[i].mType = arrControls[i].GetType().Name;
                arrTypeSizeColor[i].mSize = arrControls[i].Size;
                arrTypeSizeColor[i].mColor = arrControls[i].BackColor;
            }
            myICommon.add_Client(arrTypeSizeColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TypeSizeColor[] temp_arrTypeSizeColor = myICommon.getData(isSquare, resultCounter);
            if (temp_arrTypeSizeColor == null)
                return;

            if(arrControls_result != null)
                for (int i = 0; i < arrControls_result.Length; i++)
                    this.Controls.Remove(arrControls_result[i]);

            resultCounter = temp_arrTypeSizeColor.Length;
            int currPosition = 2;

            arrControls_result = new Control[resultCounter];
            for (int i = 0; i < resultCounter; i++)
            {
                if (temp_arrTypeSizeColor[i].mType == "Button")
                    arrControls_result[i] = new Button();
                else
                    arrControls_result[i] = new Label();
                arrControls_result[i].Size = temp_arrTypeSizeColor[i].mSize;
                arrControls_result[i].BackColor = temp_arrTypeSizeColor[i].mColor;
                arrControls_result[i].Location = new Point(currPosition, 100);
                currPosition += arrControls_result[i].Size.Width + 2;
                this.Controls.Add(arrControls_result[i]);
            }
        }

        private void radioButtonSquareRectangle_CheckedChanged(object sender, EventArgs e)
        {
            resultCounter = 0;
            if (((Control)sender).Text == "all Squares")
                isSquare = true;
            else
                isSquare = false;
        }
    }
}

