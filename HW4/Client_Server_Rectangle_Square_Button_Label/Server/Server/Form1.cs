using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Collections;
using Common;
namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HttpChannel chnl = new HttpChannel(1234);
            ChannelServices.RegisterChannel(chnl, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ServerPart),
                "_Server_",
                WellKnownObjectMode.Singleton);
        }
    }

    class ServerPart : MarshalByRefObject, ICommon
    {
        //Should be done with <T>
        private List<Control> ControlList = new List<Control>();
        public void AddControlsToServer(myControl[] controlList)
        {
            ConvertMyControlArrayToControlList(controlList);
        }



        private myControl convertControlToMyControl(Control control)
        {
            return new myControl(control.GetType().Name, control.BackColor.Name, getShape(control), control.Height, control.Width);
        }

        public static String getShape(Control c)
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


        public void ConvertMyControlArrayToControlList(myControl[] mcArray)
        {
            Control control;
            foreach (myControl mc in mcArray)
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
                ControlList.Add(control);
            }
        }

        public myControl[] GetResultControls(int prevCounter, Color controlColor, string controlType, string controlShape)
        {
            List<myControl> retList = new List<myControl>();
            foreach (Control control in ControlList)
            {
                if (control.BackColor == controlColor && control.GetType().Name == controlType && getShape(control) == controlShape)
                {
                    retList.Add(convertControlToMyControl(control));
                }

            }
            myControl[] myControlResult = retList.ToArray();
            if (prevCounter == myControlResult.Length)
            {
                return null;
            }
            else
            {
                return myControlResult;
            }
        }
    }
}