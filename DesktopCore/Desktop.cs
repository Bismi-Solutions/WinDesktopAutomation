using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Automation;
using BismiSolutions.DesktopCore.AutomationElementSearch;
using BismiSolutions.DesktopCore.Factory;
using BismiSolutions.DesktopCore.Sessions;
using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.ListBoxItems;
using BismiSolutions.DesktopCore.UIItems.WindowItems;

namespace BismiSolutions.DesktopCore
{
    public class Desktop : UIItemContainer
    {
        public static readonly Desktop Instance = Create();
        private readonly AutomationElementFinder finder;

        private static Desktop Create()
        {
            return new Desktop(AutomationElement.RootElement, new NullActionListener(), InitializeOption.NoCache, new NullWindowSession());
        }

        private Desktop(AutomationElement automationElement, ActionListener actionListener, InitializeOption initializeOption,
                        WindowSession windowSession) : base(automationElement, actionListener, initializeOption, windowSession)
        {
            finder = new AutomationElementFinder(automationElement);
        }

        public virtual ListItems Icons
        {
            get { return IconsList.Items; }
        }

        private ListControl IconsList
        {
            get
            {
                AutomationElement element =
                    finder.Child(new[]
                                     {
                                         AutomationSearchCondition.ByControlType(ControlType.Pane).OfName("Program Manager"),
                                         AutomationSearchCondition.ByControlType(ControlType.List).OfName("Desktop")
                                     });
                return new ListControl(element, new ProcessActionListener(element));
            }
        }

        public virtual void Drop(UIItem uiItem)
        {
            Mouse.DragAndDrop(uiItem, IconsList);
        }

        public virtual List<Window> Windows()
        {
            return WindowFactory.Desktop.DesktopWindows();
        }

        /// <summary>
        /// Captures a screenshot of the entire desktop, and returns the bitmap
        /// </summary>
        public static Bitmap CaptureScreenshot()
        {
            var screenCapture = new ScreenCapture();
            return screenCapture.CaptureScreenShot();
        }

        /// <summary>
        /// Takes a screenshot of the entire desktop, and saves it to disk
        /// </summary>
        /// <param name="filename">The fullname of the file (including extension)</param>
        /// <param name="imageFormat"></param>
        public static void TakeScreenshot(string filename, ImageFormat imageFormat)
        {
            var bitmap = CaptureScreenshot();
            bitmap.Save(filename, ImageFormat.Png);
        }
    }
}