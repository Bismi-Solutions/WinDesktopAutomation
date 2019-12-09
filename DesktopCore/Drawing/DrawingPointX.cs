

using System.Drawing;

namespace BismiSolutions.DesktopCore.Drawing
{
    public static class DrawingPointX
    {
        public static System.Windows.Point ConvertToWindowsPoint(this Point point)
        {
            return new System.Windows.Point(point.X, point.Y);
        }
    }
}
