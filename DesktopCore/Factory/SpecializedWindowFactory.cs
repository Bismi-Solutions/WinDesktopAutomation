using System.Windows.Automation;
using BismiSolutions.DesktopCore.Sessions;
using BismiSolutions.DesktopCore.UIItems.WindowItems;

namespace BismiSolutions.DesktopCore.Factory
{
    public interface SpecializedWindowFactory
    {
        bool DoesSpecializeInThis(AutomationElement windowElement);
        Window Create(AutomationElement automationElement, InitializeOption initializeOption, WindowSession session);
    }
}