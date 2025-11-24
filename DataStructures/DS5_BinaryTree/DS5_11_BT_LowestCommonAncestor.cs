using DataStructures.BinaryTree;

public class DS5_11_BT_LowestCommonAncestor
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode first, TreeNode second)
    {
        if (root == null)
        {
            return null;
        }
        if (root == first || root == second)
        {
            return root;
        }

        TreeNode left = LowestCommonAncestor(root.left, first, second);
        TreeNode right = LowestCommonAncestor(root.right, first, second);

        if (left != null && right != null)
        {
            return root;
        }

        if(left == null && right == null)
        {
            return null;
        }

        return (left != null) ? left : right; // Note: each node is a ancestor to itself also
    }
    
}