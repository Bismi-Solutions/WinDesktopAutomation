using System.Windows;
using BismiSolutions.DesktopCore.UIA;
using BismiSolutions.DesktopCore.UIItems.Finders;

namespace BismiSolutions.DesktopCore.ScreenMap
{
    public class NullWindowItemsMap : WindowItemsMap
    {
        public override void Add(Point point, SearchCriteria searchCriteria)
        {
        }

        public override bool LoadedFromFile
        {
            get { return false; }
        }

        public override Point CurrentWindowPosition
        {
            set { }
        }

        public override Point GetItemLocation(SearchCriteria searchCriteria)
        {
            return RectX.UnlikelyWindowPosition;
        }

        public override void Save()
        {
        }
    }
}