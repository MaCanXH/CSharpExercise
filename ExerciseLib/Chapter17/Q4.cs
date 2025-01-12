class Q4
{
    // Q4. Write a program that finds in a binary tree of 
    // numbers the sum of the vertices of each level of the tree.
    static void ans()
    {
        BinaryTree<int> binaryTree =
            new BinaryTree<int>(14,
                new BinaryTree<int>(19,
                    new BinaryTree<int>(23),
                    new BinaryTree<int>(6,
                        new BinaryTree<int>(10),
                        new BinaryTree<int>(21))),
                new BinaryTree<int>(15,
                    new BinaryTree<int>(3),
                    null));
        binaryTree.PrintInOrder();
        InOrderSum(binaryTree);
    }
    
    // In order traverse method to get the sum of each level

    static void InOrderSum(BinaryTree<int> tree)
    {
        List<int> levelList = new List<int>();
        levelList = InOrderTraverse(tree, 0, levelList);
        Console.WriteLine();

        for (int i = 0; i < levelList.Count; i++)
        {
            // hide the level with sum = 0;
            if(levelList[i] != 0)
            {
                Console.WriteLine("The sum in Level {0} is {1}", i, levelList[i]);
            }
        }
    }
    static List<int> InOrderTraverse(BinaryTree<int> tree, int level, List<int> list)
    {
        // add a new level in the levelList
        list.Add(0);
        if(tree.leftChild != null)
        {
            InOrderTraverse(tree.leftChild, level + 1, list);
        }
        if(tree.rightChild != null)
        {
            InOrderTraverse(tree.rightChild, level + 1, list);
        }
        // add the value of this node in the corresponding level
        list[level] += tree.Value;
        return list;
    }
}
