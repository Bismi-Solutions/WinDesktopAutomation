using System;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.Configuration;
using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.Utility;

namespace BismiSolutions.DesktopCore.Factory
{
    public static class ToolTipFinder
    {
        public static ToolTip FindToolTip(Func<AutomationElement> perform, AutomationElement parentAutomationElement)
        {
            var automationElement = Retry.For(perform, CoreAppXmlConfiguration.Instance.TooltipWaitTimeSpan());
            if (automationElement == null)
                throw new AutomationException("Unable to find tooltip", Debug.Details(parentAutomationElement));

            return new ToolTip(automationElement, new NullActionListener());
        }
    }
}