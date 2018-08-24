using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace WidthHeight_Events
{
    public partial class Form1 : Form
    {
        private UserControl1[] arrUserControl;
        private int arrUser_size = 2;

        static private UserControl1 button_UC, label_UC;
///        static private string button_MinMaxSize, label_MinMaxSize;
        static private Label button_labelWidth, button_labelHeight, label_labelWidth, label_labelHeight;
        static private bool button_isRed, button_isGreen, button_isBlue, label_isRed, label_isGreen, label_isBlue;
        static private int counterEvents = 0;
        static private List<Control> buttonList = new List<Control>(), labelList = new List<Control>();


        public Form1(int counter)
        {
            InitializeComponent();
            if (counter == 1)
            {
                this.Text = "Button";
                labelMinMaxSize.Text = "MAX SIZE";
            }
            else
            {
                this.Text = "Label";
                labelMinMaxSize.Text = "MIN SIZE";
            }

            arrUserControl = new UserControl1[arrUser_size];
            for (int i = 0; i < arrUser_size; i++)
            {
                arrUserControl[i] = new UserControl1();
                arrUserControl[i].Location = new Point(58, 35 + 127 * i);
                arrUserControl[i].event_From_User += new delegate_MyEventHadler(Form_event_From_User);
                this.Controls.Add(arrUserControl[i]);
            }

            if (counter > 1)
            {
                Form1 temp = new Form1(counter - 1);
                temp.Show();
            }
        }


        private void Form_event_From_User(object sender, myEventArgs e)
        {
            if (this.Text == "Button")
            {
                button_UC = e.UC;
                button_labelWidth = this.labelWidth;
                button_labelHeight = this.labelHeight;
                button_isRed = this.checkBoxRed.Checked;
                button_isGreen = this.checkBoxGreen.Checked;
                button_isBlue = this.checkBoxBlue.Checked;
            }
            else
            {
                label_UC = e.UC;
                label_labelWidth = this.labelWidth;
                label_labelHeight = this.labelHeight;
                label_isRed = this.checkBoxRed.Checked;
                label_isGreen = this.checkBoxGreen.Checked;
                label_isBlue = this.checkBoxBlue.Checked;
            }
            counterEvents++;

            if (counterEvents == 2)
                ActionMinMax();
            if (counterEvents == 4)
                ActionSort();
        }

        void ActionMinMax()
        {
            if (button_UC == null)
                Console.WriteLine("1111111111111");
            if (label_UC == null)
                Console.WriteLine("22222222222222");

            for (int i = 0; i < button_UC.arrControls.Length; i++)
            {
                if (button_UC.arrControls[i].GetType().Name == "Button")
                    buttonList.Add(button_UC.arrControls[i]);
                else
                    labelList.Add(button_UC.arrControls[i]);
            }

            for (int i = 0; i < label_UC.arrControls.Length; i++)
            {
                if (label_UC.arrControls[i].GetType().Name == "Button")
                    buttonList.Add(label_UC.arrControls[i]);
                else
                    labelList.Add(label_UC.arrControls[i]);
            }

            buttonList = filter_RGB(buttonList, button_isRed, button_isGreen, button_isBlue);
            labelList = filter_RGB(labelList, label_isRed, label_isGreen, label_isBlue);

            Size buttonSize = calculateMinMaxSize(buttonList, "Max");
            Size labelSize = calculateMinMaxSize(labelList, "Min");

            button_labelWidth.Text = buttonSize.Width.ToString();
            button_labelHeight.Text = buttonSize.Height.ToString();

            label_labelWidth.Text = labelSize.Width.ToString();
            label_labelHeight.Text = labelSize.Height.ToString();
        }
        Size calculateMinMaxSize(List<Control> tempList, string MinMaxSize)
        {
            Size returnSize = new Size(1, 1);
            if (MinMaxSize == "Min")
                 returnSize = new Size(99999, 99999);

            for (int i = 0; i < tempList.Count; i++)
            {
                if (MinMaxSize == "Min" && tempList[i].Width * tempList[i].Height < returnSize.Width * returnSize.Height
                        ||
                     MinMaxSize == "Max" && tempList[i].Width * tempList[i].Height > returnSize.Width * returnSize.Height)
                {
                    returnSize.Width = tempList[i].Width;
                    returnSize.Height = tempList[i].Height;
                }
            }
            return returnSize;
        }
        void ActionSort()
        {
            int[] buttonArrIndexes = arrIndex_newSequence(buttonList);
            int[] labelArrIndexes = arrIndex_newSequence(labelList);

            button_UC.Controls.Clear();
            label_UC.Controls.Clear();

            Arrange(button_UC, buttonList, buttonArrIndexes);
            Arrange(label_UC, labelList, labelArrIndexes);
        }

        List<Control>  filter_RGB(List<Control>  tempList, bool isRed, bool isGreen, bool isBlue)
        {
            List<Control>  returnList = new List<Control>();
            for (int i = 0; i < tempList.Count; i++)
            {
                Control tempControl = tempList[i];
                if (tempControl.BackColor.Name == "Red" && isRed == true
                       ||
                       tempControl.BackColor.Name == "Green" && isGreen == true
                       ||
                       tempControl.BackColor.Name == "Blue" && isBlue == true)
                    returnList.Add(tempList[i]);
            }
            return returnList;
        }

        private int[] arrIndex_newSequence( List<Control> tempList)
        {
            Random myRand = new Random();
            SortedList mySortedList = new SortedList();
            for (int i = 0; i < tempList.Count; i++)
                mySortedList.Add(tempList[i].Height * tempList[i].Width + myRand.Next(1000) * 0.00001, i);

            int SortedList_Length = mySortedList.Count;
            int[] returnArr = new int[SortedList_Length];
            for (int i = 0; i < SortedList_Length; i++)
                returnArr[i] = (int)(mySortedList.GetByIndex(i));
            return returnArr;
        }

        void Arrange(UserControl1 UC, List<Control> tempList, int[] arrIndexes)
        {
            int currPosition = 2;
            for (int i = 0; i < arrIndexes.Length; i++)
            {
                Control tempControl = tempList[arrIndexes[i]];
                tempControl.Location = new Point(currPosition, 2);
                UC.Controls.Add(tempControl);
                currPosition += tempControl.Width + 2;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
