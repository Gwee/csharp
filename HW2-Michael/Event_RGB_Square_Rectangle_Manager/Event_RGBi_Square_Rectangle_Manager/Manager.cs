using Event_RGBi_Square_Rectangle_Manager.Util;
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
    public delegate void myDelegate(object sender, myEventArgs e);

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
            myForm_1.myCallbackFormEvent += new myDelegate(my_managerTrigger);
            myForm_1.Show();

            myForm_2 = new Form1(ButtonLabel2, MinMax2, RectangleSquare2);
            myForm_2.myCallbackFormEvent += new myDelegate(my_managerTrigger);
            myForm_2.Show();
        }

        private void my_managerTrigger(object sender, myEventArgs e)
        {
            Control[] result = new Control[] { };

            Form fired_form = (Form)sender;
            Form form = myForm_1 != fired_form ? myForm_1 : myForm_2;

            Control[] controls = getControls(fired_form, form);

            var typeControl = EnumHelper.controlType(fired_form.Text);
            var shape = EnumHelper.controlShape(FooStack.GetControlByName(fired_form, "Rectangle_Square_label").Text);
            var size = EnumHelper.controlSize(FooStack.GetControlByName(fired_form, "Min_Max_label").Text);
            var color = EnumHelper.controlColor(FooStack.GetCheckedControl(fired_form).Text);
            var resultArea1 = FooStack.GetControlByName(fired_form, "ButtonLabel_MinMax_RectangleSquare_control");
            var resultArea2 = e.userControl;

            Process process = new Process(controls, typeControl, color, size, shape);

            setResult(process.getControls(), process.getControl(), resultArea1, resultArea2);

        }

        private Control[] getControls(Form form1, Form form2)
        {
            List<Control> result = new List<Control>();
            List<UserControl> userControls = new List<UserControl>();

            userControls.AddRange(FooStack.GetControlsByType<Form, UserControl>(form1, typeof(UserControl1)).ToList());
            userControls.AddRange(FooStack.GetControlsByType<Form, UserControl>(form2, typeof(UserControl1)).ToList());

            userControls.ForEach(c => result.AddRange(c.Controls.Cast<Control>()));

            return result.ToArray();
        }

        private void setResult(Control[] controls, Control control, Control resultArea1, UserControl1 resultArea2)
        {
            resultArea1.BackColor = control.BackColor;
            resultArea1.Size = control.Size;
            resultArea2.Controls.Clear();

            int lastX = 2;
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].Location = new Point(lastX,5);
                lastX += controls[i].Size.Width + 2;
                resultArea2.Controls.Add(controls[i]);
            }
        }
    }
}