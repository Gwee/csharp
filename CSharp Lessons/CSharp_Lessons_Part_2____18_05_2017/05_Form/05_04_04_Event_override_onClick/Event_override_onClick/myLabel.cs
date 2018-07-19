using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Event_override_onClick
{
    class myLabel:System.Windows.Forms.Label
    {
        public myLabel()
		{
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Location = new System.Drawing.Point(12, 76);
            this.Name = "label1";
            this.Size = new System.Drawing.Size(264, 40);
		}
		protected override void OnClick(EventArgs e)
		{
            this.Text = this.Name + "  clicked";
		}
    }
}
