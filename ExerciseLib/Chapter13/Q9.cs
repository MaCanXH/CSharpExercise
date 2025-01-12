using System.Text;
class Ch13Q9
{
	static void ans()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Enter a cipher code: ");
        string ciph = Console.ReadLine();
        
        string en = Encrypt(text, ciph);
        Console.WriteLine("The encrypted unicode is");
        Console.WriteLine(ToUnicode(en));
    }
    static string Encrypt(string txt, string c)
    {
        StringBuilder en = new StringBuilder();
        for (int i = 0; i < txt.Length; i++)
        {
            char k = (char)((int)txt[i] ^ (int)c[i % c.Length]);
            en.Append(k);
        }
    return en.ToString();
    }
    static string ToUnicode(string s)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            sb.Append("\\u");
            sb.Append(String.Format("{0:x4}", (int)c));
        }
        return sb.ToString();
    }
}
