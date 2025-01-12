using System.Text;
class Ch13Q11
{
	static void ans()
    {
        string s = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
        StringBuilder sb = new StringBuilder(s);
        Console.Write("Enter the forbidden words: ");
        string[] forbid = Console.ReadLine().Split(',');

        for (int i = 0; i < forbid.Length; i++)
        {
            sb.Replace(forbid[i], Aster(forbid[i].Length));
        }
        Console.WriteLine(sb.ToString());
    }
    static string Aster(int f)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < f; i++)
        {
            sb.Append("*");
        }
    return sb.ToString();
    }
}
