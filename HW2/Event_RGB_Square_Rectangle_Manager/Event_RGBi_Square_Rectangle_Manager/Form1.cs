using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_RGBi_Square_Rectangle_Manager
{
    public partial class Form1 : Form
    {
        public UserControl1[] arrUC = new UserControl1[2];
        public Control ButtonLabel_MinMax_RectangleSquare_control = null;
        private List<myControl> controlList= new List<myControl>();
        public Form1(string ButtonLabel, string MinMax, string RectangleSquare)
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
            {
                arrUC[i] = new UserControl1();
                arrUC[i].Location = new Point(100, 27 + 85 * i);
                this.Controls.Add(arrUC[i]);
            }
            this.Text = ButtonLabel;
            Min_Max_label.Text = MinMax;
            Rectangle_Square_label.Text = RectangleSquare;

            if (ButtonLabel == "Button")
                ButtonLabel_MinMax_RectangleSquare_control = new Button();
            else
                ButtonLabel_MinMax_RectangleSquare_control = new Label();
            ButtonLabel_MinMax_RectangleSquare_control.Size = new Size(20, 20);
            ButtonLabel_MinMax_RectangleSquare_control.BackColor = Color.White;
            ButtonLabel_MinMax_RectangleSquare_control.Location = new Point(2, 60);
            this.Controls.Add(ButtonLabel_MinMax_RectangleSquare_control);
            arrUC[0].myEvent += new myDelegate(fromUserControl);
            arrUC[1].myEvent += new myDelegate(fromUserControl);
        }
        private Color getSelectedColor()
        {
            if (radioButtonRed.Checked) { return Color.FromName("Red"); }
            if (radioButtonGreen.Checked) { return Color.FromName("Green"); }
            else { return Color.FromName("Blue"); }
            

        }
        private ShapeType getSelectedShapeType()
        {
            if (Rectangle_Square_label.Text == "Square")
            {
                return ShapeType.Square;
            }
            else
            {
                return ShapeType.Rectangle;
            }
        }
        private ShapeType isControlSquare(Control control)
        {
            if (control.Height == control.Width)
            {
                return ShapeType.Square;
            }
            else
            {
                return ShapeType.Rectangle;
            }
        }

        //TODO: add try to take care of empty lists
        //TODO: check that rectangles work
        private Control getMinControl(List<myControl> controls)
        {
            var a = controls.OrderBy(c => c.myHeight*c.myWidth).First();//Max(ctr1 => ctr1.myHeight);
            return a;
        }
        private Control getMaxControl(List<myControl> controls)
        {
            var a = controls.OrderByDescending(c => c.myHeight*c.myWidth).First();//Max(ctr1 => ctr1.myHeight);
            return a;
        }
        //TODO: need to go over both user controls, currently only one
        private void fromUserControl(object sender, myEventArgs e)
        {
            foreach (Control control in e.arrControls)
            {
                    //TODO: add to if, fis shape == rect/square?
                if (control.BackColor == getSelectedColor() && control.GetType().Name == this.Text && isControlSquare(control) == getSelectedShapeType())
                {
                    controlList.Add(new myControl(control.BackColor, control.GetType(), control.Width, control.Height));
                    
                }
            }
                    switch (Min_Max_label.Text)
                    {
                        case "Min":
                    Control min = getMinControl(controlList);
                    ButtonLabel_MinMax_RectangleSquare_control = min;
                            break;
                        case "Max":
                    Control max = getMaxControl(controlList);
                    ButtonLabel_MinMax_RectangleSquare_control = max;

                    break;
                        default:
                            break;
                    }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
     }
}