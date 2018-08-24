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
                Action();
        }

        void Action()
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

            buttonList.Sort((x, y) => x.Width * x.Height - y.Width * y.Height);
            labelList.Sort((x, y) => x.Width * x.Height - y.Width * y.Height);

            button_labelWidth.Text = buttonList[buttonList.Count - 1].Size.Width.ToString();
            button_labelHeight.Text = buttonList[buttonList.Count - 1].Size.Height.ToString();

            label_labelWidth.Text = buttonList[0].Size.Width.ToString();
            label_labelWidth.Text = buttonList[0].Size.Height.ToString();

            Arrange(button_UC, buttonList);
            Arrange(label_UC, labelList);

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

        void Arrange(UserControl1 UC, List<Control> tempList)
        {
            UC.Controls.Clear();
            int currPosition = 2;
            for (int i = 0; i < tempList.Count; i++)
            {
                Control tempControl = tempList[i];
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
