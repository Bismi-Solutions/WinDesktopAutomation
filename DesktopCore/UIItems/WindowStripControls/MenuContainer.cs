using BismiSolutions.DesktopCore.UIItems.Finders;
using BismiSolutions.DesktopCore.UIItems.MenuItems;

namespace BismiSolutions.DesktopCore.UIItems.WindowStripControls
{
    public interface MenuContainer
    {
        Menu MenuItem(params string[] path);
        Menu MenuItemBy(params SearchCriteria[] path);
    }
}