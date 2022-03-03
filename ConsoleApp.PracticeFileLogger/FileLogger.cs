using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleApp.PracticeFileLogger
{
    public class FileLogger
    {
        private string filePath;
        public FileLogger(string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            this.filePath = filePath;
        }

        public int LogSize
        {
            get
            {
                var fi = new FileInfo(this.filePath);
                return (int)fi.Length;
            }
        }
        public string LogFile
        {
            get { return Path.GetFileName(this.filePath); }
        }

        public void Write(string msg)
        {
            File.AppendAllText(this.filePath, $"{DateTime.Now} {msg}");
        }

        public void WriteLine(string msg)
        {
            File.AppendAllText(this.filePath, $"{DateTime.Now} {msg}{Environment.NewLine}");
        }

        public List<string> Find(string keyword)
        {
            using(var rd = new StreamReader(this.filePath))
            {
                var result = new List<string>();
                string line;

                while ((line = rd.ReadLine()) != null)
                {
                    if (line.IndexOf(keyword) != -1)
                    {
                        result.Add(line);
                    }
                }

                return result;
            }
        }

        public List<string> GetTopN(int n)
        {
            return GetAll().Take(n).ToList();
        }

        public List<string> GetLastN(int n)
        {
            string[] temp = GetAll().ToArray();

            return temp.Reverse().Take(n).ToList();
        }
        private List<string> GetAll()
        {
            return File.ReadAllLines(this.filePath).ToList();
        }

    }
}
