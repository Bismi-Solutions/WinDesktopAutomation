using System.Collections.Generic;

namespace BismiSolutions.DesktopCore.UIItems.ListViewItems
{
    public interface SuggestionList
    {
        List<string> Items { get; }
        void Select(string text);
    }
}