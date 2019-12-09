using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.Factory
{
    public class ListViewCellFactory : UIItemFactory
    {
        public virtual IUIItem Create(AutomationElement automationElement, ActionListener actionListener)
        {
            return new ListViewCell(automationElement, actionListener);
        }
    }
}