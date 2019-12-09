using System.Linq;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Finders;

namespace BismiSolutions.DesktopCore.UIItems.WindowStripControls
{
    public class WPFStatusBar : UIItem
    {
        protected WPFStatusBar() {}
        public WPFStatusBar(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}

        public virtual UIItemCollection Items
        {
            get
            {
                var uiItemCollection = factory.CreateAll(SearchCriteria.All, actionListener)
                    .Where(i=>i.AutomationElement.Current.ClassName == "StatusBarItem");
                return new UIItemCollection(uiItemCollection);
            }
        }
    }
}