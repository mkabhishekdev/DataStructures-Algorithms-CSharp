//PreOrder traversal (Type = DFS) [root -> left -> right]
//InOrder traversal (Type = DFS) [left -> root -> right]
//PostOrder traversal (Type = DFS) [left -> right -> root]

using DataStructures.BinaryTree;

public class DS5_1_DFS_TraversalRecursiveWayImpl
{


    public void PreOrderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        Console.WriteLine(root.data);
        PreOrderTraversal(root.left);
        PreOrderTraversal(root.right);
    }

    public void InOrderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        InOrderTraversal(root.left);
        Console.WriteLine(root.data);
        InOrderTraversal(root.right);
    }

    public void PostOrderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        PostOrderTraversal(root.left);
        PostOrderTraversal(root.right);
        Console.WriteLine(root.data);
    }

}

/*
  DS5_1_DFS_TraversalRecursiveWayImpl dfs = new DS5_1_DFS_TraversalRecursiveWayImpl();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);
        root.left.right.left = new TreeNode(6);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(7);
        root.right.right = new TreeNode(8);
        root.right.right.left = new TreeNode(9);
        root.right.right.right = new TreeNode(10);

        Console.WriteLine("DFS - PreOrder traversal of the tree is below: ");
        dfs.PreOrderTraversal(root);

        Console.WriteLine("DFS - InOrder traversal of the tree is below: ");
        dfs.InOrderTraversal(root);

        Console.WriteLine("DFS - PostOrder traversal of the tree is below: ");
        dfs.PostOrderTraversal(root);
*/