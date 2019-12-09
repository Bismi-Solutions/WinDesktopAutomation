using System.Collections.Generic;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.AutomationElementSearch;
using BismiSolutions.DesktopCore.Configuration;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.TableItems
{
    public class TableHeader : UIItem
    {
        protected TableHeader() {}

        public TableHeader(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}

        public virtual TableColumns Columns
        {
            get
            {
                var descendants = new AutomationElementFinder(automationElement)
                    .Descendants(AutomationSearchCondition.ByControlType(ControlType.Header));
                var columnElements = new List<AutomationElement>(descendants)
                    .FindAll(obj => !obj.Current.Name.StartsWith(UIItemIdAppXmlConfiguration.Instance.TableColumn));
                return new TableColumns(columnElements, actionListener);
            }
        }
    }
}