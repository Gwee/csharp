using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_RGBi_Square_Rectangle_Manager.Util
{
    internal class Process
    {
        #region Processor : properties
        #region Processor : properties : configurations
        private readonly control_type type;
        private readonly control_size size;
        private readonly control_color color;
        private readonly control_shape shape;
        #endregion
        private readonly Control[] controls;
        #endregion

        #region Processor : constructor
        internal Process(Control[] controls, control_type type, control_color color, control_size size, control_shape shape)
        {
            this.controls = controls;

            this.type = type;
            this.size = size;
            this.color = color;
            this.shape = shape;
        }

        internal Control[] getControls()
        {      
            return filter();
        }

        internal Control getControl()
        {
            var filtered = filter();
            return getMinMax(filtered);
        }

        private Control[] filter()
        {
            var filtered = filterByType(controls);

            filtered = filterByColor(filtered);
            filtered = filterByShape(filtered);
            filtered = orderByArea(filtered);

            return filtered;
        }

        private Control[] orderByArea(Control[] filtered)
        {
            return filtered.OrderBy(x => x.Height * x.Width).ToArray();
        }

        private Control[] filterByShape(Control[] controls)
        {
            Control[] c = null;

            switch (shape)
            {
                case control_shape.Square:
                    c = controls.Where(x => x.Height == x.Width).ToArray();
                    break;
                case control_shape.Rectangle:
                    c = controls.Where(x => x.Height != x.Width).ToArray();
                    break;
                default:
                    break;
            }
            return c;
        }

        private Control[] filterByType(Control[] controls)
        {
            Control[] c = null;

            switch (type)
            {
                case control_type.Button:
                    c = controls.OfType<Button>().ToArray();
                    break;
                case control_type.Label:
                    c = controls.OfType<Label>().ToArray();
                    break;
                default:
                    break;
            }
            return c;
        }

        private Control[] filterByColor(Control[] controls)
        {
            return controls.Where(x => x.BackColor.Name.Equals(color.ToString())).ToArray();
        }

        private Control getMinMax(Control[] filtered)
        {
            Control control = null;

            switch (size)
            {
                case control_size.Min:
                    control = filtered.First();
                    break;
                case control_size.Max:
                    control = filtered.Last();
                    break;
                default:
                    break;
            }
            return control;
        }

        #endregion
    }
}
