using System.Collections.Generic;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.Factory;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.ListViewItems;

namespace BismiSolutions.DesktopCore.UIItems
{
    public class ListViewCells : UIItemList<ListViewCell>
    {
        private readonly ListViewHeader header;

        public ListViewCells(List<AutomationElement> collection, ActionListener actionListener, ListViewHeader header)
            : base(collection, new ListViewCellFactory(), actionListener)
        {
            this.header = header;
        }

        /// <exception cref="UIActionException">when header row is not defined</exception>
        public virtual ListViewCell this[string columnName]
        {
            get
            {
                if (header == null && string.IsNullOrEmpty(columnName)) return this[0];
                if (header == null) throw new UIActionException("Cannot get cell for " + columnName);
                return this[header.Column(columnName)];
            }
        }

        internal virtual ListViewCell this[ListViewColumn column]
        {
            get
            {
                var span = new HorizontalSpan(column.Bounds);
                return Find(cell => !span.IsOutside(cell.Bounds));
            }
        }
    }
}