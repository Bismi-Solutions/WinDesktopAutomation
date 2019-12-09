using System;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems
{
    [PlatformSpecificItem]
    public class WpfDatePicker : DateTimePicker
    {
        protected WpfDatePicker() {}
        public WpfDatePicker(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) { }

        public override void SetDate(DateTime? dateTime, DateFormat dateFormat)
        {
            var valuePattern = (ValuePattern)AutomationElement.GetCurrentPattern(ValuePattern.Pattern);
            valuePattern.SetValue(dateTime != null ? dateTime.Value.ToShortDateString() : "");
        }
    }
}