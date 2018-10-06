using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_RGBi_Square_Rectangle_Manager.Util
{
    public static class FooStack
    {
        public static Control GetControlByName<T>(T parent_control, string name) where T : Control
        {
            return parent_control.Controls.Find(name, false).Single();
        }

        public static Control GetCheckedControl<T1>(T1 parent_control) where T1 : Control
        {
            return parent_control.Controls.OfType<RadioButton>().Single(c => c.Checked == true);
        }

        public static T2[] GetControlsByType<T1,T2>(T1 parent_control, Type type) where T1 : Control where T2 : Control
        { 
            return parent_control.Controls.OfType<T2>().DefaultIfEmpty().ToArray<T2>();
        }
    }
}
