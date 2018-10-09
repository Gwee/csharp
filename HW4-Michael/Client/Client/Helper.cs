using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public static class Helper
    {
        public static Control[] arrayControl(ControlDesc[] descriptiones)
        {
            List<Control> list = new List<Control>();
            int position = 2;

            foreach (var desc in descriptiones)
            {

                list.Add(generateControl(desc, position));

                position += desc.size.Width + 5;
            }
            return list.ToArray();
        }


        public static Control generateControl(ControlDesc desc, int position)
        {
            Control control = null;
            if (desc.type.Name == "Button") { control = new Button(); }
            if (desc.type.Name == "Label") { control = new Label(); }

            control.BackColor = desc.color;
            control.Size = desc.size;
            control.Location = new Point(position, 90);

            return control;
        }
    }
}
