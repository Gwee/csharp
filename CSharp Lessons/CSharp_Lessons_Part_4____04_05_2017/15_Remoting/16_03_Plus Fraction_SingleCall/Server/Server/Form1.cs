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
                WellKnownObjectMode.SingleCall);
        }
    }

    class ServerPart : MarshalByRefObject, IFraction
    {
        public ServerPart() { }
        public Fraction Plus(Fraction A, Fraction B)
        {
            return new Fraction(A.fieldNum * B.fieldDenom + A.fieldDenom * B.fieldNum, A.fieldDenom * B.fieldDenom);
        }
    }

}