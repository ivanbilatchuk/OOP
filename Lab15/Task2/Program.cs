using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";
        string outputFilePath = @"..\..\..\output.txt";

        ProcessLines(inputFilePath, outputFilePath);
    }

    public static void ProcessLines(string inputFilePath, string outputFilePath)
    {
        string[] lines = File.ReadAllLines(inputFilePath);
        List<List<string>> groups = new List<List<string>>();
        List<string> current = new List<string>();
        foreach (var line in lines)
        {
            if (line.StartsWith("-"))
            {
                if (current.Count > 0)
                {
                    groups.Add(new List<string>(current));
                }

                current.Clear();
                current.Add(line);
            }
            else
            {
                current.Add(line);
            }
        }

        if (current.Count > 0)
        {
            groups.Add(current);
        }

        List<string> output = new List<string>();
        int lineNumber = 1;
        foreach (var group in groups)
        {
            int letters = 0;
            int punct = 0;

            foreach (string line in group)
            {
                foreach (char ch in line)
                {
                    if (char.IsLetter(ch))
                    {
                        letters++;
                    }

                    if (char.IsPunctuation(ch))
                    {
                        punct++;
                    }
                }
            }

            output.Add($"Line {lineNumber}: {group[0]}");
            for (int i = 1; i < group.Count; i++)
            {
                output.Add(group[i]);
            }

            output[output.Count - 1] = output[output.Count - 1] + $" ({letters})({punct})";
            lineNumber++;
        }

        File.WriteAllLines(outputFilePath, output);
    }
}