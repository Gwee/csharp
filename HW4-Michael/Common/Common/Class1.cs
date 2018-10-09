using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace Common
{
    [Serializable]
    public class Filter
    {
        public string color { get; set; }
        public string type { get; set; }
        public string shape { get; set; }
    }


    [Serializable]
    public class ControlDesc
    {
        public Color color { get; set; }
        public Type type { get; set; }
        public Size size { get; set; }
        public string shape { get; set; }

        public ControlDesc(Control control)
        {
            color = control.BackColor;
            type = control.GetType();
            size = control.Size;
            shape = control.Size.Height == control.Size.Width ? "Rectangle" : "Square";
        }
    }

    [Serializable]
    public class Response
    {
        public int itemsNumber { get; set; }
        public ControlDesc[] descArr { get; set; }
    }

    public interface ICommon
    {
        void SetControls(ControlDesc list);

        Response GetControls(int prevCounter, Filter filter);
    }
}
