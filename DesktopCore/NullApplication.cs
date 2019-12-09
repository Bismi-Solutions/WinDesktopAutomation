using BismiSolutions.DesktopCore.UIItems.WindowItems;
using System.Collections.Generic;


namespace BismiSolutions.DesktopCore
{
    public class NullApplication : Application
    {
        public override string Name
        {
            get { return "<Choose any supported application>"; }
        }

        public override void Kill() {}

        public override List<Window> GetWindows()
        {
            return new List<Window>();
        }
    }
}