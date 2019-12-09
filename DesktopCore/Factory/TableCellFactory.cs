using System;
using System.Collections.Generic;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.AutomationElementSearch;
using BismiSolutions.DesktopCore.Configuration;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.TableItems;

namespace BismiSolutions.DesktopCore.Factory
{
    public class TableCellFactory
    {
        private readonly AutomationElement tableElement;
        private readonly ActionListener actionListener;
        private List<AutomationElement> customControlTypes;

        public TableCellFactory(AutomationElement tableElement, ActionListener actionListener)
        {
            this.tableElement = tableElement;
            this.actionListener = actionListener;
        }

        public virtual TableCells CreateCells(TableHeader tableHeader, AutomationElement rowElement)
        {
            if (customControlTypes == null)
                customControlTypes = new AutomationElementFinder(tableElement).Descendants(AutomationSearchCondition.ByControlType(ControlType.Custom));
            string rowNameSuffix = " " + rowElement.Current.Name;
            Predicate<AutomationElement> cellPredicate = element =>
            {
                string name = element.Current.Name;
                return name.EndsWith(rowNameSuffix);
            };
            List<AutomationElement> tableCellElements = customControlTypes.FindAll(cellPredicate);
            return new TableCells(tableCellElements, tableHeader, actionListener);
        }
    }
}