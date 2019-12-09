using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.ListBoxItems;
using BismiSolutions.DesktopCore.Utility;

namespace BismiSolutions.DesktopCore.UIItemEvents
{
    public class ListControlEvent : UserEvent
    {
        private readonly string selectedItem;
        private static readonly string CachedMethodName;

        static ListControlEvent()
        {
            CachedMethodName = MethodNameResolver.NameFor<ComboBox>(c=>c.Select(null));
        }

        public ListControlEvent(IUIItem uiItem, string selectedItem) : base(uiItem)
        {
            this.selectedItem = selectedItem;
        }

        protected override string ActionName(EventOption eventOption)
        {
            return CachedMethodName;
        }

        public override object[] ActionParameters
        {
            get { return new object[] {selectedItem}; }
        }
    }
}