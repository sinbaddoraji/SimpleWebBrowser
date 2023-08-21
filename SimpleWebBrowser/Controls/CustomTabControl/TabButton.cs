using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebBrowser.Controls.CustomTabControl
{
    public class TabButton : Button
    {
        public TabButton()
        {
            this.BackColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "button1";
            this.Size = new System.Drawing.Size(38, 38);
            this.TabIndex = 0;
            this.UseVisualStyleBackColor = false;
        }
    }
}
