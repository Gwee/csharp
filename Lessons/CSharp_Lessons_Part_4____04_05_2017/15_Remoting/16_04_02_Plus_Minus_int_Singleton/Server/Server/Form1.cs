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
        private int Sum = 0;
        public int Plus(int a, int b)
        {
            Sum += b;
            return a + b;
        }
        public int Minus(int a, int b)
        {
            Sum -= b;
            return a - b;
        }
        public int CommonSum()
        {
            return Sum;
        }
        public void Reset()
        {
            Sum = 0;
        }
     }
}