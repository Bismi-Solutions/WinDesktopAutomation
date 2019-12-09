using System.Runtime.Serialization;
using System.Windows.Automation;

namespace BismiSolutions.DesktopCore.UIItems.Finders
{
    [DataContract]
    public class ControlTypeProperty : AutomationElementProperty
    {
        protected ControlTypeProperty()
        {
        }

        public ControlTypeProperty(ControlType controlType, string displayName)
            : base(controlType, displayName, AutomationElement.ControlTypeProperty) {}

        public override string DisplayValue
        {
            get { return ((ControlType) Value).LocalizedControlType; }
        }
    }
}