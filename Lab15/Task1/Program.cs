using System;
public class Program
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";

        Console.WriteLine(ProcessLines(inputFilePath));
    }

    public static string ProcessLines(string inputFilePath)
    {
        char[] replaceChars = { '-', ',', '.', '!', '?' };
        List<string> output = new List<string>();

        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            string line;
            int index = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if (index % 2 == 0)
                {
                    foreach (char c in replaceChars)
                    {
                        line = line.Replace(c, '@');
                    }    
                    string[] words = line.Split(' ');
                    Array.Reverse(words);
                    string result = string.Join(" ", words);
                    output.Add(result);
                }    
                index++;
            }    
        }    
        return string.Join("\n", output);
    }
}