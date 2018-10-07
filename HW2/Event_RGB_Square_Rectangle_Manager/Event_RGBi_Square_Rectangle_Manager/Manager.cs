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
    public partial class Manager : Form
    {
        private Form1 myForm_1 = null, myForm_2 = null;
        private Random myRand = new Random();
        public Manager()
        {
            InitializeComponent();

            string ButtonLabel1 = "Button", ButtonLabel2 = "Label";
            if (myRand.Next(2) == 0)
            {
                ButtonLabel1 = "Label"; ButtonLabel2 = "Button";
            }

            string MinMax1 = "Min", MinMax2 = "Max";
            if (myRand.Next(2) == 0)
            {
                MinMax1 = "Max"; MinMax2 = "Min";
            }

            string RectangleSquare1 = "Rectangle", RectangleSquare2 = "Square";
            if (myRand.Next(2) == 0)
            {
                RectangleSquare1 = "Square"; RectangleSquare2 = "Rectangle";
            }

            myForm_1 = new Form1(ButtonLabel1, MinMax1, RectangleSquare1);
            myForm_1.UCEvent += new myDelegate(FromFormTrigger);
            myForm_1.Show();
            myForm_2 = new Form1(ButtonLabel2, MinMax2, RectangleSquare2);
            myForm_2.UCEvent += new myDelegate(FromFormTrigger);
            myForm_2.Show();
        }
        private void FromFormTrigger (object sender, myEventArgs e)
        {
            Form triggeredForm = (Form)sender;
            Form form;
            List<Control> UserControls = new List<Control>();
            List<myControl> RetControls = new List<myControl>();

            if (triggeredForm == myForm_1)
            {
                form = myForm_2;
            }
            else
            {
                form = myForm_1;
            }
            UserControls = Utils.Helper.getAllUserControls(triggeredForm, form);

            foreach (UserControl uc in UserControls)
            {
                foreach (Control control in uc.Controls)
                {
                    if (control.BackColor == Color.FromName(Utils.Helper.getColor(triggeredForm).Text) && control.GetType().Name == triggeredForm.Text && Utils.Helper.getControlShapeType(control) == Utils.Helper.getSelectedShapeType(triggeredForm))
                    {
                        RetControls.Add(new myControl(control.BackColor, control.GetType(), control.Width, control.Height));
                        //Console.WriteLine(control.Name);
                    }
                }
            }
            e.uc.BackColor = Color.Blue;
            Console.WriteLine("hi");
            Control repl = triggeredForm.Controls.Find("ButtonLabel_MinMax_RectangleSquare_control", false).Single();
            switch (Utils.Helper.getMinMax(triggeredForm))
            {
                case ShapeSize.Min:
                    Utils.Helper.placeMinControlInForm(triggeredForm, RetControls, repl);
                    break;
                case ShapeSize.Max:
                    Utils.Helper.placeMaxControlInForm(triggeredForm, RetControls, repl);
                    break;
                default:
                    break;
            }
            //Utils.Helper.placeMinMaxControlInForm(triggeredForm, RetControls, Utils.Helper.getMinMax(triggeredForm));
        }

    }
}
