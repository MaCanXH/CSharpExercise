class Q4
{
    static void ans()
    {
        string[] suits = { "diamond", "club", "heart", "spade" };

        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine(suits[i] + " Ace");
            for (int j = 2; j <= 10; j++)
            {
                Console.WriteLine(suits[i] + " " + j);
            }
            Console.WriteLine(suits[i] + " Jack");
            Console.WriteLine(suits[i] + " Queen");
            Console.WriteLine(suits[i] + " King");
        }

        //or using two string array e.g. suits = {diamond...) card = {ace, 2 ,3...}
        //or using switch case to check number.
    }
}