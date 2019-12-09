using System.Windows.Automation;
using BismiSolutions.DesktopCore.Factory;
using BismiSolutions.DesktopCore.UIItems.WindowItems;

namespace BismiSolutions.DesktopCore.UIItems
{
    internal class SplashWindow : WinFormWindow
    {
        protected SplashWindow() {}
        public SplashWindow(AutomationElement automationElement, InitializeOption option) : base(automationElement, option) {}

        public override void WaitWhileBusy() {}
    }
}