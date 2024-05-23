using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Project_v2
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class CircleButton : Button
    {

        public CircleButton()
        {

            this.FlatStyle = FlatStyle.Flat; // Usuń standardowe obramowanie
            this.FlatAppearance.BorderSize = 0; // Wyłącz obramowanie
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        }
    }
}
