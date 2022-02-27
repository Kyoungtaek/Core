using System;
using System.IO;

namespace ConsoleApp.ReadTextFileOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter target file name!");

                return;
            }

            string path = args[0];

            if (!File.Exists(path))
            {
                Console.WriteLine("Please check target file.");

                return;
            }

            using (var rdr = new StreamReader(path))
            {
                string line;

                using (var wr = new StreamWriter(@"data.txt.out"))
                {
                    while ((line = rdr.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');
                        int sum = 0;

                        for (int i = 1; i < temp.Length; i++)
                        {
                            sum += Convert.ToInt32(temp[i]);
                        }

                        int average = sum / (temp.Length - 1);

                        line += $",{sum},{average}";

                        wr.WriteLine(line);
                    }
                }
            }
        }
    }
}
