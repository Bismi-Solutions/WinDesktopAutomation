using System.Windows.Automation;
using BismiSolutions.DesktopCore.Factory;
using BismiSolutions.DesktopCore.Sessions;
using BismiSolutions.DesktopCore.UIItems.Actions;
using BismiSolutions.DesktopCore.UIItems.Finders;

namespace BismiSolutions.DesktopCore.UIItems.WindowStripControls
{
    //bug: eliminate this class to reduce code.....user can get the controls using the same API as UIItemContainer
    public class ContainerStrip : UIItemContainer
    {
        protected ContainerStrip() {}

        protected ContainerStrip(AutomationElement element, ActionListener listener)
            : base(element, listener, InitializeOption.NoCache, new NullWindowSession()) {}

        internal virtual InitializeOption Cached
        {
            set { ReInitialize(value); }
        }

        public virtual UIItem GetLabel(string text)
        {
            return Get<TextBox>(SearchCriteria.ByText(text));
        }

        public virtual StatusStripSplitButton GetSplitButton(string name)
        {
            var textBox = Get<TextBox>(SearchCriteria.ByText(name));
            if (textBox == null) return null;
            return new StatusStripSplitButton(textBox);
        }

        public virtual StatusStripDropDownButton GetDropDownButton(string name)
        {
            var textBox = Get<TextBox>(SearchCriteria.ByText(name));
            if (textBox == null) return null;
            return new StatusStripDropDownButton(textBox);
        }

        public virtual ProgressBar GetProgressBar()
        {
            return Get<ProgressBar>(SearchCriteria.ByText(string.Empty));
        }

        public virtual ProgressBar GetProgressBar(int index)
        {
            return Get<ProgressBar>(SearchCriteria.ByText(string.Empty).AndIndex(index));
        }
    }
}