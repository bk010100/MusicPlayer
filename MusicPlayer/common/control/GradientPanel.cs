using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MusicPlayer.common.component
{
    class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        public float GradientAngel { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom, GradientAngel);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(linearGradientBrush, ClientRectangle);
            base.OnPaint(e);
        }
    }
}
