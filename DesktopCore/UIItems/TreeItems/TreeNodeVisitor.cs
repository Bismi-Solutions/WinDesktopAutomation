namespace BismiSolutions.DesktopCore.UIItems.TreeItems
{
    public interface TreeNodeVisitor
    {
        void Accept(TreeNode treeNode);
    }
}