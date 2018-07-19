using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace UserControl_Different_Controls
{
    public partial class Form1 : Form
    {
        private UserControl1 myUserControl1;
        private List<Control> ListControls_Form = new List<Control>();

        public Form1()
        {
            InitializeComponent();
            myUserControl1 = new UserControl1();
            myUserControl1.Location = new Point(10, 10);
            this.Controls.Add(myUserControl1);

            myUserControl1.myEvent += new myDelegate(fromUser);
        }

        private void fromUser(object sender, myEventArgs e)
        {
            for (int i = 0; i < ListControls_Form.Count; i++)
                this.Controls.Remove(ListControls_Form[i]);
            ListControls_Form.Clear();

            for(int i = 0; i < e.arrControls.Length; i++)
                if (e.arrControls[i].Text != "")
                {
                    //////////// Copy controls
                    Control tempControl;
                    if (e.arrControls[i].GetType().Name == "Label")
                    {
                        tempControl = new Label();
                        ((Label)tempControl).TextAlign = ContentAlignment.MiddleCenter;
                        ((Label)tempControl).BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                        tempControl = new Button();

                    tempControl.Font = e.arrControls[i].Font;
                    tempControl.Size = e.arrControls[i].Size;
                    tempControl.BackColor = e.arrControls[i].BackColor;
                    tempControl.Text = e.arrControls[i].Text;

                    ListControls_Form.Add(tempControl);

                    //////////// Move controls
                    // ListControls_Form.Add(e.arrControls[i]);
                    // myUserControl1.Controls.Remove(e.arrControls[i]);
                }

            ListControls_Form.Sort((x, y) => int.Parse(x.Text) - int.Parse(y.Text));

            int lastY = 10;
            for (int i = 0; i < ListControls_Form.Count; i++)
            {
                ListControls_Form[i].Location = new Point(200, lastY);
                lastY += ListControls_Form[i].Size.Height + 5;
                this.Controls.Add(ListControls_Form[i]);
            }
        }
    }
}