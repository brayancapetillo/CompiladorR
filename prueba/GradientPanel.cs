using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    public class GradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush Brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(Brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
