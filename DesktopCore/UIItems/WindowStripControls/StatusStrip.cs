using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Finders;
using BismiSolutions.DesktopCore.UIItems.MenuItems;

namespace BismiSolutions.DesktopCore.UIItems.WindowStripControls
{
    public class StatusStrip : ContainerStrip, MenuContainer
    {
        private readonly Menus topLevelMenu;
        protected StatusStrip() {}

        public StatusStrip(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener)
        {
            topLevelMenu = new Menus(automationElement, actionListener);
        }

        public virtual Menu MenuItem(params string[] path)
        {
            return topLevelMenu.Find(path);
        }

        public virtual Menu MenuItemBy(params SearchCriteria[] path)
        {
            return topLevelMenu.Find(path);
        }
    }
}