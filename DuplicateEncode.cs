using System;


public class Program
{
    public static string DuplicateEncode(string word)
    {
        string result = "";
        int count = 0;
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    count += 1;
                }
            }
            if (count > 1)
            {
                result += ")";
                count = 0;
            }
            else
            {
                result += "(";
                count = 0;
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        string w = "";
        w = Console.ReadLine();
        string word = w.ToUpper();
        Console.WriteLine((DuplicateEncode(word)).Length);
        Console.WriteLine(DuplicateEncode(word));
    }

}