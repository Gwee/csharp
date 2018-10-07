using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Event_RGBi_Square_Rectangle_Manager.Utils
{
    public static partial class Helper
    {

        public static Color getSelectedColor(RadioButton rad)
        {
            if (rad.Checked) { return Color.FromName("Red"); }
            if (rad.Checked) { return Color.FromName("Green"); }
            else { return Color.FromName("Blue"); }


        }
        public static Control getColor(Form form)
        {
            return form.Controls.OfType<RadioButton>().Single(c => c.Checked == true);
        }

        public static ShapeType getSelectedShapeType(Form form)
        {

            if (form.Controls.Find("Rectangle_Square_label", false).Single().Text == "Square")
            {
                return ShapeType.Square;
            }
            else
            {
                return ShapeType.Rectangle;
            }
        }
        public static ShapeSize getMinMax(Form form)
        {
            if (form.Controls.Find("Min_Max_label", false).Single().Text == "Min")
            {
                return ShapeSize.Min;
            }
            else
            {
                return ShapeSize.Max;
            }
        }
        public static ShapeType getControlShapeType(Control control)
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

        public static myControl getMinControl(List<myControl> controls)
        {
            myControl a = null;
            try
            {
                a = controls.OrderBy(c => c.myHeight * c.myWidth).First();
            }
            catch (System.InvalidOperationException)
            {

                Console.WriteLine("Missing control");
            }
            return a;
        }
        public static myControl getMaxControl(List<myControl> controls)
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

        internal static List<Control> getAllUserControls(Form triggeredForm, Form form)
        {
            List<Control> retList = new List<Control>();
            retList.AddRange(triggeredForm.Controls.OfType<UserControl>().DefaultIfEmpty().ToArray<UserControl>());
            retList.AddRange(form.Controls.OfType<UserControl>().DefaultIfEmpty().ToArray<UserControl>());
            return retList;
        }

        internal static void placeMinControlInForm(Form triggeredForm, List<myControl> retControls, Control toReplace)
        {
            toReplace.Visible = false;
            myControl minControl = getMinControl(retControls);
            if (toReplace is Label)
            {
                Label newLbl = minControl.convertToLabel();
                newLbl.Location = toReplace.Location;
                triggeredForm.Controls.Remove(minControl);
                newLbl.Name = "ButtonLabel_MinMax_RectangleSquare_control";
                triggeredForm.Controls.Add(newLbl);
                newLbl.Visible = true;
            }
            else
            {
                Button newBtn = minControl.convertToButton();
                newBtn.Location = toReplace.Location;
                triggeredForm.Controls.Remove(minControl);
                newBtn.Name = "ButtonLabel_MinMax_RectangleSquare_control";
                triggeredForm.Controls.Add(newBtn);
                newBtn.Visible = true;
            }
            triggeredForm.Controls.Remove(toReplace);
        }

        internal static void placeMaxControlInForm(Form triggeredForm, List<myControl> retControls, Control toReplace)
        {
            toReplace.Visible = false;
            myControl maxControl = getMaxControl(retControls);
            if (toReplace is Label)
            {
                Label newLbl = maxControl.convertToLabel();
                newLbl.Location = toReplace.Location;
                triggeredForm.Controls.Remove(maxControl);
                newLbl.Name = "ButtonLabel_MinMax_RectangleSquare_control";
                triggeredForm.Controls.Add(newLbl);
                newLbl.Visible = true;
            }
            else
            {
                Button newBtn = maxControl.convertToButton();
                newBtn.Location = toReplace.Location;
                triggeredForm.Controls.Remove(maxControl);
                newBtn.Name = "ButtonLabel_MinMax_RectangleSquare_control";
                triggeredForm.Controls.Add(newBtn);
                newBtn.Visible = true;
            }
            triggeredForm.Controls.Remove(toReplace);
        }
    }
}
