using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Finders;
using BismiSolutions.DesktopCore.UIItems.MenuItems;

namespace BismiSolutions.DesktopCore.UIItems.WindowStripControls
{
    public class MenuBar : UIItem, MenuContainer
    {
        protected MenuBar() {}

        public MenuBar(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener)
        {
        }

        public virtual Menu MenuItem(params string[] path)
        {
            return TopLevelMenu.Find(path);
        }

        public virtual Menu MenuItemBy(params SearchCriteria[] path)
        {
            return TopLevelMenu.Find(path);
        }

        public virtual Menus TopLevelMenu
        {
            get { return new Menus(automationElement, actionListener); }
        }
    }
}