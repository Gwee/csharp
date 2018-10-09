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
using System.Linq;
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
        List<ControlDesc> controlsDesc = new List<ControlDesc>();

        public void SetControls(ControlDesc item)
        {
            controlsDesc.Add(item);
        }

        public Response GetControls(int prevCounter, Filter filter)
        {
            if (controlsDesc.Count == prevCounter) return null;

            var filtred = controlsDesc.Where(x => x.color.Name == filter.color &&
                                             x.type.Name == filter.type &&
                                             x.shape == filter.shape);

            var ordered = filtred.OrderBy((x) => x.size.Height* x.size.Width);

            return new Response()
            {
                descArr = ordered.ToArray(),
                itemsNumber = controlsDesc.Count
            };
        }
    }
}