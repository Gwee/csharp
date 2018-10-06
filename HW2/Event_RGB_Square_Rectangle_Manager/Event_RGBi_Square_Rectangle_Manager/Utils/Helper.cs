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

            if (form.Controls.Find("Rectangle_Square_label",false).Single().Text == "Square")
            {
                return ShapeType.Square;
            }
            else
            {
                return ShapeType.Rectangle;
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

        internal static List<Control> getAllControls(Form triggeredForm, Form form)
        {
            List<Control> retList = new List<Control>();
            retList.AddRange(triggeredForm.Controls.OfType<UserControl>().DefaultIfEmpty().ToArray<UserControl>());
            retList.AddRange(form.Controls.OfType<UserControl>().DefaultIfEmpty().ToArray<UserControl>());
            return retList;
        }
    }
}
