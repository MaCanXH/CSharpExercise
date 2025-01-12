using System.Collections.Generic;
class Q2
{
    // Q2. Write a program that displays the roots of those 
    // sub-trees of a tree, which have exactly k nodes, 
    // where k is an integer.
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
        int k = 4;
        Console.WriteLine("The sub-trees with {0} nodes: ", k);
        FindSubTree(tree, k);
    }
    // using DFS to find the number of nodes in a sub-tree
    // 
    static int FindSubTreeDFS(TreeNode t, int targetNum)
    {
        if(t.ChildrenCount == 0)
        {
            return 1;
        }
        TreeNode child = null;

        // initialize count = 1 for every node entered
        // total number of children/ grandchild will be returned by the following iteration
        int count = 1;
        for(int i = 0; i < t.ChildrenCount; i++)
        {
            child = t.GetChild(i);
            // add total number of node in the children sub-tree
            count += FindSubTreeDFS(child, targetNum);
        }
        if(count == targetNum)
        {
            Console.WriteLine(t.Value);
        }
        // return the total number of the node subtree for its parent
        return count;
    }
    static void FindSubTree(Tree t, int target)
    {
        TreeNode root = t.Root;
        FindSubTreeDFS(root, target);
    }
}
