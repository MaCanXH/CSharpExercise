using System.Text;
class Ch13Q24
{
	static void ans()
    {
    Console.WriteLine("Enter a text message: ");
    string txt = Console.ReadLine();

    Console.WriteLine("The identical letters are:");
    Console.WriteLine(IdenSeq(txt));
    }

    static string IdenSeq(string s)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(s[0]);

        for (int i = 0; i < s.Length - 1; i++)
        {
            if(s[i] != s[i + 1])
            {
            sb.Append(s[i + 1]);
            }
        }
        return sb.ToString();
    }
}
