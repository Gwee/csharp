using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace UserControls_DragDrop
{
    public partial class UserControl1 : UserControl
    {
        public Control[] arrControls;
        public int arrControls_size;
        private static Random myRand = new Random();

        UserControl1 UserControl_First, UserControl_Second;

        public UserControl1(string str)
        {
            InitializeComponent();
            arrControls_size = myRand.Next(5, 10);
            label1.Text = str;

            arrControls = new Control[arrControls_size];
            int lastPosition = 20;
            for (int i = 0; i < arrControls_size; i++)
            {
                if (myRand.Next(0, 2) == 0)
                    arrControls[i] = new Label();
                else
                    arrControls[i] = new Button();

                arrControls[i].Size = new Size(myRand.Next(20, 71), myRand.Next(20, 71));
                arrControls[i].BackColor = Color.FromArgb(myRand.Next(100, 256), myRand.Next(100, 256), myRand.Next(100, 256));
                arrControls[i].Location = new Point(3, lastPosition);

                lastPosition += arrControls[i].Size.Height + 2;
                this.Controls.Add(arrControls[i]);
            }        
        }

        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
            dragClass tempDragClass = new dragClass();
            tempDragClass.dragUserControl = this;
            DoDragDrop(tempDragClass, DragDropEffects.All);
        }

        private void UserControl1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void UserControl1_DragDrop(object sender, DragEventArgs e)
        {
            dragClass tempDragClass = (dragClass)(e.Data.GetData(typeof(dragClass)));
            UserControl_First  = tempDragClass.dragUserControl;
            UserControl_Second = this;

            List<Control> List_Button = controlsSeparate(UserControl_First, UserControl_Second, "Button");
            List<Control> List_Label = controlsSeparate(UserControl_First, UserControl_Second, "Label");

            if (UserControl_First.label1.Text == "Button")
            {
                userControl_Arrange(UserControl_First, List_Button);
                userControl_Arrange(UserControl_Second, List_Label);
            }
            else
            {
                userControl_Arrange(UserControl_First, List_Label);
                userControl_Arrange(UserControl_Second, List_Button);
            }
        }

        private List<Control> controlsSeparate(UserControl1 myUserControl_First, UserControl1 myUserControl_Second, string str)
        {
            List<Control> tempList = new List<Control>();

            for (int i = 0; i < myUserControl_First.arrControls_size; i++)
                if (myUserControl_First.arrControls[i].GetType().Name == str)
                    tempList.Add(myUserControl_First.arrControls[i]);
            for (int i = 0; i < myUserControl_Second.arrControls_size; i++)
                if (myUserControl_Second.arrControls[i].GetType().Name == str)
                    tempList.Add(myUserControl_Second.arrControls[i]);

            return tempList;
        }
        private void userControl_Arrange(UserControl1 myUC, List<Control> LC)
        {
            for (int i = 0; i < myUC.arrControls_size; i++)
                myUC.Controls.Remove(myUC.arrControls[i]);

            myUC.arrControls = new Control[LC.Count];
            myUC.arrControls_size = LC.Count;

            int lastPosition = 20;
            for (int i = 0; i < myUC.arrControls_size; i++)
            {
                myUC.arrControls[i] = LC[i]; ;
                myUC.arrControls[i].Location = new Point(3, lastPosition);
                lastPosition += myUC.arrControls[i].Size.Height + 2;

                myUC.Controls.Add(myUC.arrControls[i]);
            }
        }

    }
}
