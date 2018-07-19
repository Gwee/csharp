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
        public ICommon myICommon;
        public Form1()
        {
            InitializeComponent();

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            ICommonFactory myICommonFactory = (ICommonFactory)Activator.GetObject(
                typeof(ICommonFactory),
                "http://localhost:1234/_Server_");

            myICommon = myICommonFactory.getNewInstance(); 
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            label1.Text += " + " + textBox1.Text;             
            myICommon.Plus(int.Parse(textBox1.Text));
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            label1.Text += " - " + textBox1.Text;
            myICommon.Minus(int.Parse(textBox1.Text));
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            labelResult.Text = myICommon.Sum().ToString();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            labelResult.Text = "";
            myICommon.Reset();
        }
    }
}

