using System.Text;
using Microsoft.VisualBasic;
class Q3
{
    // Q3. Write a program that counts how many times each word 
    // from a given text file words.txt appears in it. The result 
    // words should be ordered by their number of occurrences in the text.
    static void ans()
    {
        // read the text from the external txt.
        string word = "word.txt";
        StreamReader reader = new StreamReader(word);
        Dictionary<string, int> dict = new Dictionary<string, int>();

        using(reader)
        {
            string line = reader.ReadLine();

            while(line != null)
            {
                Console.WriteLine(line);
                string[] textArr = line.Split(' ', ',', '.', '?', '!', '-');

                // initialization of the hash table
                // ignore the cases
                foreach(string txt in textArr)
                {
                    if(!string.IsNullOrEmpty(txt.Trim()))
                    {
                        dict[txt.ToLower()] = 0;  
                    }
                }
                // count the number of each text
                foreach(string txt in textArr)
                {
                    if(!string.IsNullOrEmpty(txt.Trim()))
                    {
                        dict[txt.ToLower()] =  dict[txt.ToLower()] + 1;
                    }
                }
                line = reader.ReadLine();
            }

            // sort the order by the number of occurence
            var sorted = dict.OrderBy(p => p.Value);

            Console.Write("Result: ");
            foreach (var orderTxt in sorted)
            {
                Console.Write("{0} -> {1}, ", orderTxt.Key, orderTxt.Value);
            }
        }
    }
}