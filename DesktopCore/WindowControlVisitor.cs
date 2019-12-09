using BismiSolutions.DesktopCore.UIItems;

namespace BismiSolutions.DesktopCore
{
    public interface WindowControlVisitor
    {
        void Accept(UIItem uiItem);
    }
}