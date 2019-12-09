using BismiSolutions.DesktopCore.UIItems;

namespace BismiSolutions.DesktopCore.UIItemEvents
{
    public class ComboBoxEvent : ListControlEvent
    {
        public ComboBoxEvent(IUIItem uiItem, string selectedItem) : base(uiItem, selectedItem) {}
    }
}