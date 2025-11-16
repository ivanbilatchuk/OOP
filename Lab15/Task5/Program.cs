using System.Text;

public class Program
{
    static void Main()
    {
        string path = Console.ReadLine();
        string reportFileName = "report.txt";

        string reportContent = TraverseDirectory(path);
        Console.WriteLine(reportContent);

        WriteReportToDesktop(reportContent, reportFileName);
    }

    public static string TraverseDirectory(string inputFolderPath)
    {
        string[] files = Directory.GetFiles(inputFolderPath);
        var filesByExtension = files
            .Select(f => new FileInfo(f))
            .GroupBy(f => f.Extension.ToLower())
            .OrderByDescending(g => g.Count())
            .ThenBy(g => g.Key)
            .ToDictionary(g => g.Key, g => g
                .OrderBy(f => f.Length)
                .ToList());
        StringBuilder sb = new StringBuilder();
        foreach (var extGroup in filesByExtension)
        {
            sb.AppendLine(extGroup.Key);
            foreach (var file in extGroup.Value)
            {
                sb.AppendLine($"--{file.Name} - {file.Length / 1024.0:f3}kb");
            }    
        }

        return sb.ToString();
    }

    public static void WriteReportToDesktop(string reportContent, string reportFileName)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string reportPath = Path.Combine(desktopPath, reportFileName);
        File.WriteAllText(reportPath, reportContent);
    }
}