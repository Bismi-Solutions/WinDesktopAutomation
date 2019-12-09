

using System.Runtime.Serialization;

namespace BismiSolutions.DesktopCore.ScreenMap
{
    [DataContract]
    public class AutomationPropertySurrogate
    {
        [DataMember]
        public virtual int AutomationId { get; set; }
    }
}
