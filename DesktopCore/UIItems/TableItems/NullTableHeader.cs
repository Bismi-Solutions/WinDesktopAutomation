using System.Collections.Generic;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.TableItems
{
    public class NullTableHeader : TableHeader
    {
        public override TableColumns Columns
        {
            get { return new TableColumns(new List<AutomationElement>(), new NullActionListener()); }
        }
    }
}