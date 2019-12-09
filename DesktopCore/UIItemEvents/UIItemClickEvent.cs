using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.Utility;

namespace BismiSolutions.DesktopCore.UIItemEvents
{
    public class UIItemClickEvent : UserEvent
    {
        private static readonly string CachedActionName;

        static UIItemClickEvent()
        {
            CachedActionName = MethodNameResolver.NameFor<UIItem>(i => i.Click());
        }

        public UIItemClickEvent(IUIItem uiItem) : base(uiItem) {}

        protected override string ActionName(EventOption eventOption)
        {
            return CachedActionName;
        }
    }
}