using System.Globalization;

class Q5
{
    // Q5. Write a program that finds and prints all vertices 
    // of a binary tree, which have for only leaves successors.
    static void ans()
    {
        BinaryTree<int> binaryTree =
            new BinaryTree<int>(14,
                new BinaryTree<int>(19,
                    new BinaryTree<int>(23,
                        new BinaryTree<int>(2),
                        null),
                    new BinaryTree<int>(6,
                        new BinaryTree<int>(10),
                        new BinaryTree<int>(21))),
                new BinaryTree<int>(15,
                    new BinaryTree<int>(3),
                    null));
        binaryTree.PrintInOrder();
        Console.WriteLine();
        LeavesParentPrint(binaryTree);
    }
    static bool leftleaf = false;
    static bool rightleaf = false;
    static void LeavesParentPrint(BinaryTree<int> tree)
    {
        List<int> leavesParent = new List<int>();
        LeavesParentTraverse(tree, tree.Value, leavesParent);

        Console.WriteLine("The leaves parents are: ");
        for(int i = 0; i < leavesParent.Count; i++)
        {
            Console.Write(leavesParent[i] + " ");
        }
    }
    static void LeavesParentTraverse(BinaryTree<int> tree, int parent, List<int> list)
    {
        if(tree.leftChild == null && tree.rightChild == null)
        {
            list.Add(parent);
        }
        if(tree.leftChild != null)
        {
            parent = tree.Value;
            LeavesParentTraverse(tree.leftChild, parent, list);
        }
        if(tree.rightChild != null)
        {
            parent = tree.Value;
            LeavesParentTraverse(tree.rightChild, parent, list);
        }
    }
}