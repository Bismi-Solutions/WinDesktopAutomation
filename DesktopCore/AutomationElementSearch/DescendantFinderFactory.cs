

using BismiSolutions.DesktopCore.Configuration;
using System.Windows.Automation;

namespace BismiSolutions.DesktopCore.AutomationElementSearch
{
    public class DescendantFinderFactory
    {
        public static IDescendantFinder Create(AutomationElement automationElement)
        {
            if (CoreAppXmlConfiguration.Instance.RawElementBasedSearch) return new RawAutomationElementFinder(automationElement);
            return new DescendantFinder(automationElement);
        }
    }
}
