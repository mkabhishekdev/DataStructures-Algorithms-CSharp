using DataStructures.BinaryTree;
using System.Xml;

public class DS5_8_HeightOfBinaryTree_Recursive
{
    public int HeightOfTree(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftSize = HeightOfTree(root.left);
        int rightSize = HeightOfTree(root.right);

        return 1 + Math.Max(leftSize, rightSize);
    }
}