using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.TableItems
{
    public class TableRowHeader : UIItem
    {
        protected TableRowHeader() {}
        public TableRowHeader(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}
    }
}