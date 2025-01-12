class Ch11Q11
{
    static void ans()
    {
        string[] LPhrases = { "The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };
        string[] LStories = { "Now I feel better.", "I managed to change.", "It made some miracle.", "I can��t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };
        string[] FirstName = { "Dayan", "Stella", "Hellen", "Kate" };
        string[] LastName = { "Johnson", "Peterson", "Charls" };
        string[] Cities = { "London", "Paris", "Berlin", "New York", "Madrid" };

        Random rnd = new Random();

        Console.WriteLine(LPhrases[rnd.Next(0, 3)] + " " + LStories[rnd.Next(0, 4)] + " -- " + FirstName[rnd.Next(0, 3)] + " "
            + " " + LastName[rnd.Next(0, 2)] + ", " + Cities[rnd.Next(0, 4)]);
    }
}
