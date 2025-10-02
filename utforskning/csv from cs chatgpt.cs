using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputPath = "test_data1.cs";   // input file
        string outputPath = "test_data1.csv"; // output CSV file

        var lines = File.ReadAllLines(inputPath);

        using (var writer = new StreamWriter(outputPath))
        {
            bool isHeader = true;

            foreach (var line in lines)
            {
                // Skip empty or dashed separator lines
                if (string.IsNullOrWhiteSpace(line) || line.Trim().StartsWith("-"))
                    continue;

                // Split by '|' and trim
                var columns = line.Split('|')
                                  .Select(col => col.Trim())
                                  .Where(col => !string.IsNullOrEmpty(col))
                                  .ToArray();

                if (columns.Length == 0)
                    continue;

                // Write header or data line
                writer.WriteLine(string.Join(",", columns));

                // After the first valid row (header), mark as data
                if (isHeader) isHeader = false;
            }
        }

        Console.WriteLine("CSV file created: " + outputPath);
    }
}
