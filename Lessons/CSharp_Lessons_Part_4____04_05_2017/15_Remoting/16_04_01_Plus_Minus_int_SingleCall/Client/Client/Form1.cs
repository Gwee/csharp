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
        private ICommon myICommon;
        private int tempResult = 0;

        public Form1()
        {
            InitializeComponent();

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            myICommon = (ICommon)Activator.GetObject(
                typeof(ICommon),
                "http://localhost:1234/_Server_");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            label1.Text += " + " + textBox1.Text;
            tempResult = myICommon.Plus(tempResult, int.Parse(textBox1.Text));
            labelResult.Text = tempResult.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            label1.Text += " - " + textBox1.Text;
            tempResult = myICommon.Minus(tempResult, int.Parse(textBox1.Text));
            labelResult.Text = tempResult.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            tempResult = 0;
            labelResult.Text = "";
        }
    }
}

