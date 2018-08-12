using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Thread1
{
    public delegate void appendTextToLabelDelegate(Label label, string text);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(inputNumber.Text);
                if(num < 1)
                {
                    throw new FormatException();
                }

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";

                Thread thread1 = new Thread(Action);
                Params p1 = new Params(label1, num);
                thread1.Start(p1);

                Thread thread2 = new Thread(Action);
                Params p2 = new Params(label2, num);
                thread2.Start(p2);

                Thread thread3 = new Thread(Action);
                Params p3 = new Params(label3, num);
                thread3.Start(p3);
            }
            catch(FormatException)
            {
                MessageBox.Show("Illigal number! \nNumber should be integer greather then 0");
            }
        }

        private void Action(object o)
        {
            Params p = o as Params;
            int num = p.Num;
            Label label = p.ActiveLabel;
                 
            for(int i=1; i<=num; i++)
            {
                label.Invoke(new appendTextToLabelDelegate(AppendTextToLabel), label,
                    i.ToString());

                Thread.Sleep(200);
            }
        }

        private void AppendTextToLabel(Label label, string text)
        {
            label.Text += " " + text;
        }
    }

    public class Params
    {
        public Label ActiveLabel { get; set; }
        public int Num { get; set; }

        public Params(Label label, int num)
        {
            ActiveLabel = label;
            Num = num;
        }
    }
}
