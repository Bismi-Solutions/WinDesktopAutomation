using System.Windows;

namespace BismiSolutions.DesktopCore
{
    public class HorizontalSpan : Span
    {
        public HorizontalSpan(Rect bounds) : base(bounds.Left, bounds.Right) {}

        public virtual bool IsOutside(Rect rect)
        {
            return DoesntContain(rect, rect.Left, rect.Right);
        }
    }
}