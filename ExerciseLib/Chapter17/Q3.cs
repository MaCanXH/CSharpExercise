class Q3
{
    // Q3. Write a program that finds the number of leaves 
    // and number of internal vertices of a tree.
    static void ans()
    {
        Tree tree = new Tree(2,
                        new Tree(19,
                            new Tree(1),
                            new Tree(12),
                            new Tree(23)),
                        new Tree(23),
                        new Tree(14,
                            new Tree(23),
                            new Tree(6,
                                new Tree(33),
                                new Tree(-2),
                                new Tree(9))));
        tree.TraverseDFS();
        result(tree);
    }
    // method to return the count of leaves and internal vertices
    static void result(Tree tree)
    {
        TreeNode root = tree.Root;
        int LeavesNum = NumberofLeaves(root);
        int VerticesNum = NumberofInternalVertices(root);

        Console.WriteLine("The number of leaves is " + LeavesNum);
        Console.WriteLine("The number of internal vertices is " + VerticesNum);
    }
    // method to find the number of leavses by DFS
    static int NumberofLeaves(TreeNode r)
    {
        if(r.ChildrenCount == 0)
        {
            // when the leave has reached, add 1 in the counter
            return 1;
        }
        // each time accessing a new node, the new does not count
        int count = 0;
        TreeNode child = null;
        for(int i = 0; i < r.ChildrenCount; i++)
        {
            child = r.GetChild(i);
            count += NumberofLeaves(child);
        }
        return count;
    }
    // method to find the number of internal vertices by DFS
    static int NumberofInternalVertices(TreeNode r)
    {
        if(r.ChildrenCount == 0)
        {
            // when the leave has reached, do not count the leave and return 0
            return 0;
        }
        TreeNode child = null;
        // each time accessing a new node, add 1 to the counter
        int count = 1;
        for(int i = 0; i < r.ChildrenCount; i++)
        {
            child = r.GetChild(i);
            count += NumberofInternalVertices(child);
        }
        return count;
    }
}