using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Event_RGBi_Square_Rectangle_Manager
{
    public enum ShapeType
    {
        Square, Rectangle
    }
    public enum ShapeSize
    {
        Min, Max
    }

    public class myControl : Control
    {
        private Color myColor;
        public Type myType { get; }
        public ShapeType shapeType { get; }
        public int myWidth { get; }
        public int myHeight { get; }

        public myControl (Color color, Type type, int width, int height)
        {
            this.myColor = color;
            this.myType = type;
            this.myWidth = width;
            this.myHeight = height;
            if (myWidth == myHeight) {
                this.shapeType = ShapeType.Square;
            }
        }
        public Label convertToLabel()
        {
            Label retLbl = new Label();
            retLbl.BackColor = myColor;
            retLbl.Width = myWidth;
            retLbl.Height = myHeight;
            return retLbl;
        }
        public Button convertToButton()
        {
            Button retBtn = new Button();
            retBtn.BackColor = myColor;
            retBtn.Width = myWidth;
            retBtn.Height = myHeight;
            return retBtn;
        }

    }
}
