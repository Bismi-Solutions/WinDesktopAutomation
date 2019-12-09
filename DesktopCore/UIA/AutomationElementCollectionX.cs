using System;
using System.Windows.Automation;

namespace BismiSolutions.DesktopCore.UIA
{
    public static class AutomationElementCollectionX
    {

        public static bool Contains(this AutomationElementCollection collection, Predicate<AutomationElement> predicate)
        {
            foreach (AutomationElement automationElement in collection)
            {
                if (predicate(automationElement)) return true;
            }
            return false;
        }




    }
}
