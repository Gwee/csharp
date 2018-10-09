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

        private string ButtonLabel = "";
        private string RectangleSquare = "";

        private int prevCounter = 0;

        private static Random myRand = new Random();

        public Form1()
        {
            InitializeComponent();

            int arrSize = myRand.Next(12, 16);

            arrControls = new Control[arrSize];

            int currPosition = 2;
            for (int i = 0; i < arrSize; i++)
            {
                if (myRand.Next(2) == 0)
                {
                    arrControls[i] = new Button();
                    ButtonLabel = "Button";
                }
                else
                {
                    arrControls[i] = new Label();
                    ButtonLabel = "Label";
                }
                arrControls[i].Location = new Point(currPosition, 3);
                int temp = myRand.Next(15, 40);
                switch (myRand.Next(4))
                {
                    case 0: arrControls[i].Size = new Size(temp, temp); break;
                    case 1: arrControls[i].Size = new Size(2 * temp, 2 * temp); break;
                    case 2: arrControls[i].Size = new Size(2 * temp, temp); break;
                    case 3: arrControls[i].Size = new Size(temp, 2 * temp); break;
                }

                string tempColor = "Red";
                switch (myRand.Next(3))
                {
                    case 1:  tempColor = "Green"; break;
                    case 2:  tempColor = "Blue"; break;
                }

                currPosition += arrControls[i].Size.Width + 2;
                arrControls[i].BackColor = Color.FromName(tempColor);
                this.Controls.Add(arrControls[i]);
            }
            ButtonLabel = "Button";
            if (myRand.Next(2) == 0)
                ButtonLabel = "Label";

            RectangleSquare = "Rectangle";
            if (myRand.Next(2) == 0)
                RectangleSquare = "Square";
            this.Text = ButtonLabel + " " + RectangleSquare;

            ClientColor.Text = "Red";
            switch (myRand.Next(3))
            {
                case 1: ClientColor.Text = "Green"; break;
                case 2: ClientColor.Text = "Blue"; break;
            }
            ClientColor.ForeColor = Color.FromName(ClientColor.Text);

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            myICommon = (ICommon)Activator.GetObject(
                typeof(ICommon),
                "http://localhost:1234/_Server_");
       }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<myControl> ControlList = new List<myControl>();
            foreach (Control control in arrControls)
            {
                ControlList.Add(new myControl(control.GetType().Name, control.BackColor.Name, getShape(control),control.Height,control.Width));
            }
            myControl[] myControlArray = ControlList.ToArray();
            myICommon.AddControlsToServer(myControlArray);
        }

        private void GetControlsFromServer(myControl[] mcArray)
        {
            //myControl[] result = myICommon.GetResultControls(prevCounter, Color.FromName(ClientColor.Text), ButtonLabel, RectangleSquare);
            //myControl[] mcArray = myICommon.CommonControls();
            List<Control> arrControls_resultList = new List<Control>();
            Control control;
            foreach (var mc in mcArray)
            {
                if (mc.Type == "Label")
                {
                    control = new Label();
                }
                else
                {
                    control = new Button();
                }
                control.BackColor = Color.FromName(mc.Color);
                control.Width = mc.Width;
                control.Height = mc.Height;
                arrControls_resultList.Add(control);
            }
            arrControls_result = arrControls_resultList.ToArray();
            ShowResultControls();
        }
        private String getShape(Control c)
        {
            if (c.Height == c.Width)
            {
                return "Square";
            }
            else
            {
                return "Rectangle";
            }
        }
        private void ShowResultControls()
        {
            int currPosition = 2;

            foreach (Control control in arrControls_result)
            {
                if (control.BackColor == Color.FromName(ClientColor.Text) && control.GetType().Name == ButtonLabel && getShape(control) == RectangleSquare )
                {
                    control.Location = new Point(currPosition, 100);
                    currPosition += control.Size.Width + 2;
                    this.Controls.Add(control);
                    control.Visible = true;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //fix this (if prevCounter = servers prev, server returns null else, update arrControls_result
            myControl[] temp = myICommon.GetResultControls(prevCounter, Color.FromName(ClientColor.Text), ButtonLabel, RectangleSquare);
            if ( temp != null)
            {
                GetControlsFromServer(temp);
                prevCounter = temp.Length;
            }
        }
    }
}

