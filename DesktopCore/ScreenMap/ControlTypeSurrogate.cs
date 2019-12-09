

using System.Runtime.Serialization;

namespace BismiSolutions.DesktopCore.ScreenMap
{
    [DataContract]
    public class ControlTypeSurrogate
    {
        [DataMember]
        public virtual int ControlTypeId { get; set; }
    }
}
