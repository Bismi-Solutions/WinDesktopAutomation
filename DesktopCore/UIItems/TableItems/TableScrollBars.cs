using System.Windows.Automation;
using BismiSolutions.DesktopCore.AutomationElementSearch;
using BismiSolutions.DesktopCore.Configuration;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Scrolling;

namespace BismiSolutions.DesktopCore.UIItems.TableItems
{
    public class TableScrollBars : AbstractScrollBars
    {
        private readonly IVScrollBar verticalScrollBar;
        private readonly IHScrollBar horizontalScrollBar;

        public TableScrollBars(AutomationElementFinder finder, ActionListener actionListener, TableVerticalScrollOffset tableVerticalScrollOffset)
        {
            AutomationElement verticalScrollElement = finder.Child(AutomationSearchCondition.ByControlType(ControlType.Pane).OfName(UIItemIdAppXmlConfiguration.Instance.TableVerticalScrollBar));
            verticalScrollBar = (verticalScrollElement == null)
                                    ? (IVScrollBar) new NullVScrollBar()
                                    : new TableVerticalScrollBar(verticalScrollElement, actionListener, tableVerticalScrollOffset);
            AutomationElement horizontalScrollElement = finder.Child(AutomationSearchCondition.ByControlType(ControlType.Pane).OfName(UIItemIdAppXmlConfiguration.Instance.TableHorizontalScrollBar));
            horizontalScrollBar = (horizontalScrollElement == null)
                                      ? (IHScrollBar) new NullHScrollBar()
                                      : new TableHorizontalScrollBar(horizontalScrollElement, actionListener);
        }

        public override IHScrollBar Horizontal
        {
            get { return horizontalScrollBar; }
        }

        public override IVScrollBar Vertical
        {
            get { return verticalScrollBar; }
        }
    }
}
