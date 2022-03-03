using System;

namespace ConsoleApp.PracticeFileLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Logs\SystemLog.txt";

            var fileLogger = new FileLogger(path);

            fileLogger.WriteLine("Service Started.");
            fileLogger.Write("Memory error occurred.");
            fileLogger.Write("Network error occurred.");
            fileLogger.WriteLine("Memory error occurred.");
            fileLogger.WriteLine("1.Memory error occurred.");
            fileLogger.WriteLine("2.Memory error occurred.");
            fileLogger.WriteLine("3.Memory error occurred.");
            fileLogger.WriteLine("4.Memory error occurred.");
            fileLogger.WriteLine("5.Memory error occurred.");


            Console.WriteLine("-----Start Find Keyword: Memory");
            foreach (string findKeyword in fileLogger.Find("Memory"))
            {
                Console.WriteLine(findKeyword);
            }

            Console.WriteLine("-----End Find Keyword");
            Console.WriteLine();

            // Get Top(N) lines from file
            Console.WriteLine("-----Start GetTop(N)");
            foreach (string item in fileLogger.GetTopN(2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----End GetTop(N)");
            Console.WriteLine();

            // Get Bottom(N) lines from file
            Console.WriteLine("-----Start GetLast(N)");
            foreach (string item in fileLogger.GetLastN(5))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----End GetLast(N)");
            Console.WriteLine();

            Console.WriteLine($"Logfile Name: {fileLogger.LogFile}");
            Console.WriteLine($"Logfile Size: {fileLogger.LogSize}");

        }
    }
}
