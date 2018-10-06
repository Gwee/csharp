using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace RGB_ButtonsLabels_Transports_UserControls
{
    public static class Extensions
    {
        public static Control[] Clone(this ControlCollection c)
        {
            var arr_controls = new Control[c.Count];
            c.CopyTo(arr_controls, 0);
            return arr_controls;
        }
    }
}
