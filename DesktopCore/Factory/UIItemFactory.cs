using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.Factory
{
    public interface UIItemFactory
    {
        IUIItem Create(AutomationElement automationElement, ActionListener actionListener);
    }
}