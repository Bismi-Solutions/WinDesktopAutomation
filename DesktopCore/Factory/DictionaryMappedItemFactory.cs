using System;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.Mappings;
using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.Factory
{
    public class DictionaryMappedItemFactory : UIItemFactory
    {
        public virtual IUIItem Create(AutomationElement automationElement, ActionListener actionListener)
        {
            if (automationElement == null) return null;
            return Create(automationElement, ControlDictionary.Instance.GetTestControlType(automationElement), actionListener);
        }

        public virtual IUIItem Create(AutomationElement automationElement, ActionListener actionListener, Type customItemType)
        {
            if (automationElement == null) return null;
            if (customItemType != null) return Create(automationElement, customItemType, actionListener);
            return Create(automationElement, actionListener);
        }

        private IUIItem Create(AutomationElement automationElement, Type itemType, ActionListener actionListener)
        {
            if (itemType == null) return null;
            return (IUIItem) Activator.CreateInstance(itemType, automationElement, actionListener);
        }
    }
}