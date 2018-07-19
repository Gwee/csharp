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

namespace Client
{
    public partial class Form1 : Form
    {
        IFraction myIFraction;

        public Form1()
        {
            InitializeComponent();
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            myIFraction = (IFraction)Activator.GetObject(
                typeof(IFraction),
                "http://localhost:1234/_Server_");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction A = new Fraction(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
            Fraction B = new Fraction(Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
            Fraction C = myIFraction.Plus(A, B);
            textBox5.Text = C.fieldNum.ToString();
            textBox6.Text = C.fieldDenom.ToString();
        }
    }
}