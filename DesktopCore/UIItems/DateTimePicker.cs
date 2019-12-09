using System;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.Configuration;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.WindowsAPI;

namespace BismiSolutions.DesktopCore.UIItems
{
    public class DateTimePicker : UIItem
    {
        protected DateTimePicker() {}
        public DateTimePicker(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}

        public virtual DateTime? Date
        {
            get
            {
                var property = (string) Property(ValuePattern.ValueProperty);
                if (string.IsNullOrEmpty(property))
                    return null;
                return DateTime.Parse(property);
            }
            set
            {
                SetDate(value, CoreAppXmlConfiguration.Instance.DefaultDateFormat);
            }
        }

        public virtual void SetDate(DateTime? dateTime, DateFormat dateFormat)
        {
            if (dateTime == null)
            {
                Logger.Warn("DateTime cannot be null, value will not be set");
                return;
            }

            keyboard.Send(dateFormat.DisplayValue(dateTime.Value, 0).ToString(), actionListener);
            keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.RIGHT, actionListener);
            keyboard.Send(dateFormat.DisplayValue(dateTime.Value, 1).ToString(), actionListener);
            keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.RIGHT, actionListener);
            keyboard.Send(dateFormat.DisplayValue(dateTime.Value, 2).ToString(), actionListener);
            keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.RIGHT, actionListener);
        }
    }
}