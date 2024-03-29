using BismiSolutions.DesktopCore.Finder;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Finders;

namespace BismiSolutions.DesktopCore.UIItems.Container
{
    internal class CachedContainerItemFactory : ContainerItemFactory
    {
        private readonly CachedUIItems children;

        public CachedContainerItemFactory(CachedUIItems cachedUIItems, ActionListener actionListener)
        {
            children = cachedUIItems;
            this.actionListener = actionListener;
        }

        protected override IUIItem Find(SearchCriteria searchCriteria)
        {
            return children.Get(searchCriteria, actionListener);
        }

        public override void Visit(WindowControlVisitor windowControlVisitor)
        {
            UIItemCollection uiItems = children.UIItems(actionListener);
            foreach (UIItem uiItem in uiItems)
                uiItem.Visit(windowControlVisitor);
        }

        public override UIItemCollection GetAll(SearchCriteria searchCriteria)
        {
            return children.GetAll(searchCriteria, actionListener);
        }
    }
}