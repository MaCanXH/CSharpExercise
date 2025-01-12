class Q10
{
    static void ans10()
    {
        Console.WriteLine("Please enter the score [1…9]: ");
        int score = int.Parse(Console.ReadLine());

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                {
                    score = score * 10;
                    Console.WriteLine(score); break;
                }
            case 4:
            case 5:
            case 6:
                {
                    score = score * 100;
                    Console.WriteLine(score); break;
                }
            case 7:
            case 8:
                {
                    score = score * 1000;
                    Console.WriteLine(score); break;
                }
            default:
                Console.WriteLine("error!"); break;
        }

    }
}