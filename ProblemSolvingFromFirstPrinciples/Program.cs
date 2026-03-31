class Program
{
    static void Main(string[] args)
    {
        BuildTree bt = new BuildTree();

        int[] preorder = new int[]{3,9,20,15,7};
        int[] inorder = new int[]{9,3,15,20,7};

        TreeBuilderHelper.PrintTree(bt.BuildTreeImpl(preorder,inorder));
    
    }
}
