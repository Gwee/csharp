using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Drawing;
using System.Collections;

namespace Common
{
    public interface ICommon
    {
        //Should be done with <T>
        void AddControlsToServer(myControl[] controlList);
        myControl[] ConvertControlListToMyControlArray();
        void ConvertMyControlArrayToControlList(myControl[] mcArray);
        myControl[] CommonControls();
        
    }
    [Serializable]
    public class myControl
    {
        public String Type { get; set; }
        public String Color { get; set; }
        public String Shape { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public myControl(String type, String color, String shape, int height, int width)
        {
            this.Type = type;
            this.Color = color;
            this.Shape = shape;
            this.Height = height;
            this.Width = width;
        }
        

    }
}
