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
        private Control[] arrControls_Form;
        public Form1()
        {
            InitializeComponent();
            myUserControl1 = new UserControl1();
            myUserControl1.Location = new Point(10, 10);
            this.Controls.Add(myUserControl1);

            myUserControl1.myEvent += new myDelegate(fromUser);
        }

        int[] sorting (string[] arrStr)
        {
            SortedList mySortedList = new SortedList();
            Random myRand = new Random();
 
            for (int i = 0; i < arrStr.Length ; i++)
                if (arrStr[i]  != "")
                    mySortedList.Add(int.Parse(arrStr[i]) + myRand.Next(1000) * 0.00001, i);
            int[] returnArr = new int[mySortedList.Count];
            for (int i = 0; i < mySortedList.Count; i++)
                returnArr[i] = (int)(mySortedList.GetByIndex(i));
            return returnArr;
        }
        private void fromUser(object sender, myEventArgs e)
        {
            if (arrControls_Form != null)
                for (int i = 0; i < arrControls_Form.Length; i++)
                    this.Controls.Remove(arrControls_Form[i]);

            string[] arrStr = new string[e.arrControls.Length];
            for (int i = 0; i < e.arrControls.Length; i++)
                arrStr[i] = e.arrControls[i].Text;

            int[] arrIndex = sorting(arrStr);
            arrControls_Form = new Control[arrIndex.Length];
            int lastY = 10;
            for (int i = 0; i < arrIndex.Length; i++)
            {
                //////////// Copy controls
                if (e.arrControls[arrIndex[i]].GetType().Name == "Label")
                {
                    arrControls_Form[i] = new Label();
                    ((Label)arrControls_Form[i]).TextAlign = ContentAlignment.MiddleCenter;
                    ((Label)arrControls_Form[i]).BorderStyle = BorderStyle.FixedSingle;
                }
                else
                    arrControls_Form[i] = new Button();
                arrControls_Form[i].Font = e.arrControls[arrIndex[i]].Font;
                arrControls_Form[i].Size = e.arrControls[arrIndex[i]].Size;
                arrControls_Form[i].BackColor = e.arrControls[arrIndex[i]].BackColor;
                arrControls_Form[i].Text = e.arrControls[arrIndex[i]].Text;

                //////////// Move controls
                //arrControls_Form[i] = e.arrControls[arrIndex[i]];
                //myUserControl1.Controls.Remove(arrControls_Form[i]);

                arrControls_Form[i].Location = new Point(160, lastY);
                lastY += arrControls_Form[i].Size.Height + 5;
                this.Controls.Add(arrControls_Form[i]);
            }
        }
    }
}