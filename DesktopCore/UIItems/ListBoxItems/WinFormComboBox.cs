using System.Windows.Automation;
using BismiSolutions.DesktopCore.AutomationElementSearch;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.ListBoxItems
{
    //todo document specialized classes and their methods somehow
    [PlatformSpecificItem]
    public class WinFormComboBox : ComboBox
    {
        protected WinFormComboBox() {}

        public WinFormComboBox(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}

        //todo implement this for Win32ComboBox as well
        /// <summary>
        /// Set the text in the TextBox inside the combobox.
        /// </summary>
        public virtual string Text
        {
            get { return GetTextBox().Text; }
            set { GetTextBox().Text = value; }
        }

        private TextBox GetTextBox()
        {
            return new TextBox(Finder.Child(AutomationSearchCondition.ByControlType(ControlType.Edit)), actionListener);
        }
    }
}