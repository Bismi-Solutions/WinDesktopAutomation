using System;
using BismiSolutions.DesktopCore.UIItems.Custom;

namespace BismiSolutions.DesktopCore.UIItems.Finders
{
    public static class TestControlTypeX
    {
        public static bool IsCustomType(this Type type)
        {
            return typeof (CustomUIItem).IsAssignableFrom(type);
        }
    }
}