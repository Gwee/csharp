using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Image_AND_Text_DragAndDrop
{
    public class dragClass
    {
        private Image dragImage;
        private string dragString;

        public Image getSetImage			
        {
            get
            {
                return dragImage;
            }
            set
            {
                dragImage = value;
            }
        }
        public string getSetString
        {
            get
            {
                return dragString;
            }
            set
            {
                dragString = value;
            }
        }

    }
}
