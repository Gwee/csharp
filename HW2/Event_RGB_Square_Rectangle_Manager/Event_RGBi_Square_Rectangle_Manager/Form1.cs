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
        private ShapeType getControlShapeType(Control control)
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

        private myControl getMinControl(List<myControl> controls)
        {
            myControl a =null;
            try
            {
                a = controls.OrderBy(c => c.myHeight*c.myWidth).First();
            }
            catch (System.InvalidOperationException)
            {

                Console.WriteLine("Missing control");
            }
            return a;
        }
        private myControl getMaxControl(List<myControl> controls)
        {
            myControl a = null;
            try
            {
                a = controls.OrderByDescending(c => c.myHeight * c.myWidth).First();
            }
            catch (System.InvalidOperationException)
            {

                Console.WriteLine("Missing control");
            }
            return a;
        }
        private void fromUserControl(object sender, myEventArgs e)
        {
            foreach (Control control in e.arrControls)
            {
                if (control.BackColor == getSelectedColor() && control.GetType().Name == this.Text && getControlShapeType(control) == getSelectedShapeType())
                {
                    controlList.Add(new myControl(control.BackColor, control.GetType(), control.Width, control.Height));
                    
                }
            }

            //TODO: Fix this ugly code
                    switch (Min_Max_label.Text)
                    {
                        case "Min":
                    myControl min = getMinControl(controlList);
                    if (min==null)
                    {
                        MessageBox.Show("No minimum control found");
                        break;
                    }

 
                    if (min.myType.Name == "Label")
                    {
                        Label newLbl = min.convertToLabel();
                    newLbl.Location = ButtonLabel_MinMax_RectangleSquare_control.Location;
                    Controls.Remove(ButtonLabel_MinMax_RectangleSquare_control);
                    this.Controls.Add(newLbl);
                    newLbl.Visible = true;
                    ButtonLabel_MinMax_RectangleSquare_control = newLbl;
                        controlList.Clear();
                    }
                    else
                    {
                        Button newBtn = min.convertToButton();
                        newBtn.Location = ButtonLabel_MinMax_RectangleSquare_control.Location;
                        Controls.Remove(ButtonLabel_MinMax_RectangleSquare_control);
                        this.Controls.Add(newBtn);
                        newBtn.Visible = true;
                        ButtonLabel_MinMax_RectangleSquare_control = newBtn;
                        controlList.Clear();

                    }
                    break;
                        case "Max":
                    myControl max = getMaxControl(controlList);
                    if (max == null)
                    {
                        MessageBox.Show("No minimum control found");
                        break;
                    }
                    if (max.myType.Name == "Label")
                    {
                        Label newLbl = max.convertToLabel();
                        newLbl.Location = ButtonLabel_MinMax_RectangleSquare_control.Location;
                        Controls.Remove(ButtonLabel_MinMax_RectangleSquare_control);
                        this.Controls.Add(newLbl);
                        newLbl.Visible = true;
                        controlList.Clear();

                    }
                    else
                    {
                        Button newBtn = max.convertToButton();
                        newBtn.Location = ButtonLabel_MinMax_RectangleSquare_control.Location;
                        Controls.Remove(ButtonLabel_MinMax_RectangleSquare_control);
                        this.Controls.Add(newBtn);
                        newBtn.Visible = true;
                        controlList.Clear();

                    }
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