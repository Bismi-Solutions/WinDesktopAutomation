using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems
{
    public class GroupBox : UIItemContainer
    {
        protected GroupBox() {}
        public GroupBox(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}
    }
}