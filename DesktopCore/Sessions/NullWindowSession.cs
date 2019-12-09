using BismiSolutions.DesktopCore.Factory;
using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Container;
using BismiSolutions.DesktopCore.UIItems.Finders;
using BismiSolutions.DesktopCore.UIItems.WindowItems;

namespace BismiSolutions.DesktopCore.Sessions
{
    public class NullWindowSession : WindowSession
    {
        public override WindowSession ModalWindowSession(InitializeOption modalInitializeOption)
        {
            return new NullWindowSession();
        }

        public override IUIItem Get(ContainerItemFactory containerItemFactory, SearchCriteria searchCriteria, ActionListener actionListener)
        {
            return containerItemFactory.Get(searchCriteria, actionListener);
        }

        public override void Dispose()
        {
        }

        public override void Register(Window window)
        {
        }

        public override void LocationChanged(Window window)
        {
        }
    }
}