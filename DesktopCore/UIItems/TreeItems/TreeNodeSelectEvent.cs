using BismiSolutions.DesktopCore.UIItemEvents;
using BismiSolutions.DesktopCore.Utility;

namespace BismiSolutions.DesktopCore.UIItems.TreeItems
{
    public class TreeNodeSelectEvent : TreeNodeEvent
    {
        private readonly TreeNode selectedNode;
        private static readonly string SelectEventName;

        static TreeNodeSelectEvent()
        {
            SelectEventName = MethodNameResolver.NameFor<TreeNode>(n => n.Select());
        }

        public TreeNodeSelectEvent(Tree tree, TreeNode node) : base(tree)
        {
            selectedNode = node;
        }

        protected override string ActionName(EventOption eventOption)
        {
            return "Node( " + PathTo(selectedNode) + ")." + SelectEventName;
        }
    }
}