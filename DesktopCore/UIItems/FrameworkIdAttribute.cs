using System;

namespace BismiSolutions.DesktopCore.UIItems
{

    public class FrameworkIdAttribute : Attribute
    {
        private readonly string frameworkId;

        public FrameworkIdAttribute(string frameworkId)
        {
            this.frameworkId = frameworkId;
        }

        public virtual string FrameworkId
        {
            get { return frameworkId; }
        }
    }
}
