using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.TableItems;

namespace BismiSolutions.DesktopCore.Factory
{
    public class TableHeaderFactory : UIItemFactory
    {
        public virtual IUIItem Create(AutomationElement automationElement, ActionListener actionListener)
        {
            return new TableHeader(automationElement, actionListener);
        }
    }
}