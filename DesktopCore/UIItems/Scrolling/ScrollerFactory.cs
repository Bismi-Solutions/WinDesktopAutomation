using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.Scrolling
{
    internal class ScrollerFactory
    {
        internal static IScrollBars CreateBars(AutomationElement parentElement, ActionListener listener)
        {
            var frameworkId = parentElement.Current.FrameworkId;
            if (frameworkId == WindowsFramework.Wpf.FrameworkId())
                return new WPFScrollBars(parentElement, listener);
            if (frameworkId == WindowsFramework.Silverlight.FrameworkId())
                return new ScrollBars(parentElement, listener, new SilverlightHScrollBarButtonAutomationIds(), new SilverlightVScrollBarButtonAutomationIds());
            return new ScrollBars(parentElement, listener, new DefaultScrollBarButtonAutomationIds(), new DefaultScrollBarButtonAutomationIds());
        }
    }
}
