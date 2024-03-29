using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Finders;

namespace BismiSolutions.DesktopCore.UIItems.MenuItems
{
    public class PopUpMenu : UIItem
    {
        protected PopUpMenu() {}

        public PopUpMenu(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener)
        {
            this.actionListener = actionListener;
        }

        public virtual Menus Items
        {
            get { return new Menus(automationElement, actionListener); }
        }

        public virtual Menu Item(params string[] text)
        {
            return Items.Find(text);
        }

        public virtual Menu ItemBy(params SearchCriteria[] path)
        {
            return Items.Find(path);
        }
    }
}