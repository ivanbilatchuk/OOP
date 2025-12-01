using System;
using System.IO;

class Program
{
    static void Main()
    {
        string wordsPath = @"..\..\..\words.txt";
        string textPath = @"..\..\..\text.txt";
        string actualPath = @"..\..\..\actualResult.txt";
        string expectedPath = @"..\..\..\expectedResult.txt";

        ProcessWords(wordsPath, textPath, actualPath, expectedPath);
    }

    public static void ProcessWords(string wordsPath, string textPath, string resultPath, string expectedPath)
    {
        string[] words = File.ReadAllLines(wordsPath);
        string text = File.ReadAllText(textPath).ToLower();

        Dictionary<string, int> counts = new Dictionary<string, int>();
        
        foreach (string w in words)
        {
            string word = w.ToLower();
            string[] tokens = text.Split(new char[] { ' ', '\r', '\n', ',', '.', '!', '?', '-', ';', ':' });

            int counter = 0;
            foreach (string t in tokens)
            {
                if (t == word)
                {
                    counter++;
                }
            }

            counts[word] = counter;
        }
        
        var sorted = counts.OrderByDescending(x => x.Value);

        List<string> output = new List<string>();
        foreach (var pair in sorted)
        {
            output.Add($"{pair.Key} - {pair.Value}");
        }
        
        File.WriteAllLines(resultPath, output);
        string[] expected = File.ReadAllLines(expectedPath);

        bool match = expected.SequenceEqual(output);
        Console.WriteLine(match ? "Results match expectedResult.txt" : "Results do not match expectedResult.txt");
    }

}