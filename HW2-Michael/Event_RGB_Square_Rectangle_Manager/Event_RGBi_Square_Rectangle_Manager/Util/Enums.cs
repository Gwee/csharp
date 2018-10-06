using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_RGBi_Square_Rectangle_Manager.Util
{
    public enum control_shape
    {
        Square,
        Rectangle
    }

    public enum control_type
    {
        Button,
        Label
    }

    public enum control_size
    {
        Min,
        Max
    }

    public enum control_color
    {
        Red,
        Green,
        Blue
    }

    public static class EnumHelper
    {
        public static control_type controlType(string text)
        {
            if (text.Equals("Button")) return control_type.Button;
            else return control_type.Label;
        }

        public static control_shape controlShape(string text)
        {
            if (text.Equals("Square")) return control_shape.Square;
            else return control_shape.Rectangle;
        }

        public static control_size controlSize(string text)
        {
            if (text.Equals("Min")) return control_size.Min;
            else return control_size.Max;
        }

        public static control_color controlColor(string text)
        {
            if (text.Equals("Red")) return control_color.Red;
            if (text.Equals("Green")) return control_color.Green;
            else return control_color.Blue;
        }
    }
}
