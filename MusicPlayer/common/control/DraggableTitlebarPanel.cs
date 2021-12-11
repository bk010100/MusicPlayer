using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer.common.control
{
    class DraggableTitlebarPanel : Panel
    {
        private Form form;
        private bool isTitleDragging = false;
        private Point titleStartPoint = new Point(0, 0);


        public void SetDraggable()
        {
            form = FindForm();
            MouseDown += OnMouseDownTitleBar;
            MouseUp += OnMouseUpTitleBar;
            MouseMove += OnMouseMoveTitleBar;
        }


        private void OnMouseMoveTitleBar(object sender, MouseEventArgs e)
        {
            if (isTitleDragging)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = form.PointToScreen(p1);
                Point p3 = new Point(p2.X - titleStartPoint.X, p2.Y - titleStartPoint.Y);
                form.Location = p3;
            }
        }


        private void OnMouseUpTitleBar(object sender, MouseEventArgs e)
        {
            isTitleDragging = false;
        }


        private void OnMouseDownTitleBar(object sender, MouseEventArgs e)
        {
            titleStartPoint = e.Location;
            isTitleDragging = true;
        }
    }
}
