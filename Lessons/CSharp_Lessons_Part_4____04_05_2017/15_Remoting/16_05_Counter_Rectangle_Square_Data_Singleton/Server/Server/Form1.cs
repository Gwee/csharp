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
        private int allClients, allRectangles, allSquares, allCounter_Data;
        public void add_Client(Size[] arrSize)
        {
            allClients++;
            allCounter_Data++;

            for (int i = 0; i < arrSize.Length; i++)
                if (arrSize[i].Width == arrSize[i].Height)
                    allSquares++;
                else
                    allRectangles++;
        }
        public Counter_Client_Rectangle_Square_Data getData(int prevCounter_Data)
        {
            if( prevCounter_Data != allCounter_Data)
                return new Counter_Client_Rectangle_Square_Data(allClients, allRectangles, allSquares, allCounter_Data);
            return null;
        }
        public void remove_Client(Size[] arrSize)
        {
            allClients--;
            allCounter_Data++;

            for (int i = 0; i < arrSize.Length; i++)
                if (arrSize[i].Width == arrSize[i].Height)
                    allSquares--;
                else
                    allRectangles--;
        }

     }
}