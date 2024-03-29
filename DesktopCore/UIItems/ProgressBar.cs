using System.Windows.Automation;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.UIItems
{
    public class ProgressBar : UIItem
    {
        protected ProgressBar() {}
        public ProgressBar(AutomationElement automationElement, ActionListener actionListener) : base(automationElement, actionListener) {}

        public virtual double Minimum
        {
            get { return (double) Property(RangeValuePattern.MinimumProperty); }
        }

        public virtual double Maximum
        {
            get { return (double) Property(RangeValuePattern.MaximumProperty); }
        }

        public virtual double Value
        {
            get { return (double) Property(RangeValuePattern.ValueProperty); }
        }
    }
}