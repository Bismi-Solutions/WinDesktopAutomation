using BismiSolutions.DesktopCore.Configuration;

namespace BismiSolutions.DesktopCore
{
    public static class Constants
    {
        public static string BusyMessage
        {
            get { return string.Format(", after waiting for {0} ms", CoreAppXmlConfiguration.Instance.BusyTimeout); }
        }
    }
}