using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.ListViewItems;

namespace BismiSolutions.DesktopCore.UIItems
{
    [PlatformSpecificItem]
    public class WinFormTextBox : TextBox
    {
        public WinFormTextBox(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}
        public WinFormTextBox() {}

        public virtual SuggestionList SuggestionList
        {
            get { return SuggestionListView.WaitAndFind(actionListener); }
        }
    }
}