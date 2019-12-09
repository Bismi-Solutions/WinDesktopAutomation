using System;
using BismiSolutions.DesktopCore.Factory;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Finders;

namespace BismiSolutions.DesktopCore.UIItems.Container
{
    internal class NonCachedContainerItemFactory : ContainerItemFactory
    {
        private readonly PrimaryUIItemFactory factory;

        public NonCachedContainerItemFactory(PrimaryUIItemFactory factory, ActionListener actionListener)
        {
            this.factory = factory;
            this.actionListener = actionListener;
        }

        public override void Visit(WindowControlVisitor windowControlVisitor)
        {
            throw new NotSupportedException("Use Cached approach");
        }

        protected override IUIItem Find(SearchCriteria searchCriteria)
        {
            return factory.Create(searchCriteria, actionListener);
        }

        public override UIItemCollection GetAll(SearchCriteria searchCriteria)
        {
            return factory.CreateAll(searchCriteria, actionListener);
        }
    }
}