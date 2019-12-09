using BismiSolutions.DesktopCore.UIItems;

namespace BismiSolutions.DesktopCore.UIItemEvents
{
    public class ListBoxEvent : ListControlEvent
    {
        public ListBoxEvent(IUIItem uiItem, string selectedItem) : base(uiItem, selectedItem) {}
    }
}