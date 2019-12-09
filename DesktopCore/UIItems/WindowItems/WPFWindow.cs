using System.Diagnostics;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.Factory;
using BismiSolutions.DesktopCore.Sessions;
using BismiSolutions.DesktopCore.UIItems.Finders;
using BismiSolutions.DesktopCore.UIItems.MenuItems;

namespace BismiSolutions.DesktopCore.UIItems.WindowItems
{
    [PlatformSpecificItem]
    internal class WPFWindow : Window
    {
        private readonly WindowFactory windowFactory;
        protected WPFWindow() {}

        public WPFWindow(AutomationElement automationElement, WindowFactory windowFactory, InitializeOption initializeOption,
                         WindowSession windowSession) : base(automationElement, initializeOption, windowSession)
        {
            this.windowFactory = windowFactory;
        }

        public override PopUpMenu Popup
        {
            get { return factory.WPFPopupMenu(this) ?? windowFactory.PopUp(this); }
        }

        public override Window ModalWindow(string title, InitializeOption option)
        {
            WindowFactory desktopWindowsFactory = WindowFactory.Desktop;
            return desktopWindowsFactory.FindModalWindow(title, Process.GetProcessById(automationElement.Current.ProcessId), option, automationElement,
                                                         WindowSession.ModalWindowSession(option));
        }

        public override Window ModalWindow(SearchCriteria searchCriteria, InitializeOption option)
        {
            WindowFactory desktopWindowsFactory = WindowFactory.Desktop;
            return desktopWindowsFactory.FindModalWindow(searchCriteria, option, automationElement, WindowSession.ModalWindowSession(option));
        }
    }
}