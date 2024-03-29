using System;
using System.Collections.Generic;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.AutomationElementSearch;
using BismiSolutions.DesktopCore.Configuration;
using BismiSolutions.DesktopCore.Sessions;
using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.Finders;
using BismiSolutions.DesktopCore.UIItems.WindowItems;
using BismiSolutions.DesktopCore.Utility;

namespace BismiSolutions.DesktopCore.Factory
{
    public abstract class ChildWindowFactory
    {
        protected readonly AutomationElementFinder Finder;

        protected static readonly List<SpecializedWindowFactory> SpecializedWindowFactories = new List<SpecializedWindowFactory>();

        protected ChildWindowFactory(AutomationElementFinder finder)
        {
            Finder = finder;
        }

        public virtual Window ModalWindow(string title, InitializeOption option, WindowSession windowSession)
        {
            var message = "Could not find modal window with title: " + title;
            var modalWindowElement = WaitTillFound(() => Finder.FindWindow(title, 0), message);
            return Create(modalWindowElement, option, windowSession);
        }

        public virtual Window ModalWindow(SearchCriteria searchCriteria, InitializeOption option, WindowSession windowSession)
        {
            var message = "Could not find modal window with SearchCriteria: " + searchCriteria;
            var modalWindowElement = WaitTillFound(() => Finder.FindWindow(searchCriteria), message);
            return Create(modalWindowElement, option, windowSession);
        }

        protected virtual AutomationElement WaitTillFound(Func<AutomationElement> find, string message)
        {
            var element = Retry.For(find, CoreAppXmlConfiguration.Instance.FindWindowTimeout());
            if (element == null)
                throw new AutomationException(message, Debug.GetAllWindows());
            return element;
        }

        /// <exception cref="UIItemSearchException">The application type is not supported by White</exception>
        internal static Window Create(AutomationElement element, InitializeOption option, WindowSession windowSession)
        {
            SpecializedWindowFactory specializedWindowFactory = SpecializedWindowFactories.Find(factory => factory.DoesSpecializeInThis(element));
            if (specializedWindowFactory != null)
            {
                return specializedWindowFactory.Create(element, option, windowSession);
            }

            var windowsFramework = WindowsFrameworkExtensions.FromFrameworkId(element.Current.FrameworkId);
            if (windowsFramework == WindowsFramework.WinForms) return new WinFormWindow(element, option, windowSession);
            if (windowsFramework == WindowsFramework.Wpf) return new WPFWindow(element, WindowFactory.Desktop, option, windowSession);
            if (windowsFramework == WindowsFramework.Win32) return new Win32Window(element, WindowFactory.Desktop, option, windowSession);
            throw new UIItemSearchException(string.Format("{0} is not supported yet.", windowsFramework));
        }
    }
}