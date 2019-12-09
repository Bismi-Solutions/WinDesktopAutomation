using System.Collections.Generic;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.AutomationElementSearch;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.ListViewItems
{
    public class ListViewHeader : UIItem
    {
        private readonly AutomationElementFinder automationElementFinder;

        protected ListViewHeader() {}

        public ListViewHeader(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener)
        {
            automationElementFinder = new AutomationElementFinder(automationElement);
        }

        public virtual ListViewColumns Columns
        {
            get
            {
                List<AutomationElement> collection = automationElementFinder.Children(AutomationSearchCondition.ByControlType(ControlType.HeaderItem));
                return new ListViewColumns(collection, actionListener);
            }
        }

        public virtual ListViewColumn Column(string text)
        {
            return Columns.Find(delegate(ListViewColumn column) { return column.Text.Equals(text); });
        }
    }
}