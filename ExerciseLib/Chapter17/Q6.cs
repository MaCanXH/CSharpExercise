using System.Security.AccessControl;

class Q6
{
    // Q6. Write a program that checks whether a binary tree 
    // is perfectly balanced.
    static void ans()
    {
        BinaryTree<int> binaryTree1 =
            new BinaryTree<int>(14,
                new BinaryTree<int>(19,
                    new BinaryTree<int>(23),
                    new BinaryTree<int>(6,
                        new BinaryTree<int>(10),
                        new BinaryTree<int>(21))),
                new BinaryTree<int>(15,
                    new BinaryTree<int>(3),
                    null));

        BinaryTree<int> binaryTree2 =
            new BinaryTree<int>(14,
                new BinaryTree<int>(19,
                    new BinaryTree<int>(23),
                    new BinaryTree<int>(6,
                        new BinaryTree<int>(10),
                        new BinaryTree<int>(21))),
                new BinaryTree<int>(15,
                    new BinaryTree<int>(3),
                    new BinaryTree<int>(2,
                        new BinaryTree<int>(3),
                        new BinaryTree<int>(9))));
        binaryTree1.PrintInOrder();
        Console.WriteLine();
        CheckPerfectBalanced(binaryTree1);
        Console.WriteLine();
        binaryTree2.PrintInOrder();
        Console.WriteLine();
        CheckPerfectBalanced(binaryTree2);
    }

    // method to return wether the the a binary tree is perfectly balanced
    static void CheckPerfectBalanced(BinaryTree<int> tree)
    {
        int leftCount = CountNode(tree.leftChild);;
        int rightCount = CountNode(tree.rightChild);;

        if(leftCount - rightCount == 1 || leftCount - rightCount == 0 || leftCount - rightCount == 1)
        {
            Console.WriteLine("It is a perfectly balanced binary tree.");
        }
        else
        {
            Console.WriteLine("It is not a perfectly balanced binary tree.");
        }
    }
    // method to return the count of the total node of a tree by DFS
    static int CountNode(BinaryTree<int> tree)
    {
        if(tree.leftChild == null && tree.rightChild == null)
        {
            return 1;
        }
        int count  = 1;
        if(tree.leftChild != null)
        {
            count = count + CountNode(tree.leftChild);
        }
        if(tree.rightChild != null)
        {
            count = count + CountNode(tree.rightChild);
        }
        return count;
    }
}