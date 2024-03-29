using System.Collections.Generic;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIA;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems.PropertyGridItems
{
    public class PropertyGrid : UIItem
    {
        private readonly PropertyGridElementFinder finder;
        protected PropertyGrid() {}

        public PropertyGrid(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener)
        {
            finder = new PropertyGridElementFinder(automationElement);
        }

        /// <summary>
        /// Provides a list of categories in the property grid.
        /// </summary>
        public virtual List<PropertyGridCategory> Categories
        {
            get
            {
                var categories = new List<PropertyGridCategory>();
                List<AutomationElement> rows = finder.FindRows();
                foreach (AutomationElement element in rows)
                {
                    var automationPatterns = new AutomationPatterns(element);
                    if (!automationPatterns.HasPattern(ValuePattern.Pattern))
                        categories.Add(new PropertyGridCategory(element, actionListener, finder));
                }

                return categories;
            }
        }

        /// <summary>
        /// Find a category
        /// </summary>
        /// <param name="name"></param>
        /// <returns>PropertyGridCategory matching the name</returns>
        public virtual PropertyGridCategory Category(string name)
        {
            return Categories.Find(category => Equals(name, category.Text));
        }
    }
}