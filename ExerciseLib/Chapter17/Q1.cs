using System.Collections.Generic;
class Q1
{
    // Q1. Write a program that finds the number 
    // of occurrences of a number in a tree of numbers.
    static void ans()
    {
        Tree tree = new Tree(23,
                        new Tree(19,
                            new Tree(1),
                            new Tree(12),
                            new Tree(23)),
                        new Tree(23),
                        new Tree(14,
                            new Tree(23),
                            new Tree(6)));
        tree.TraverseDFS();
        Console.WriteLine("the occurence is: " + tree.Occurence(23));
    }
    
}
