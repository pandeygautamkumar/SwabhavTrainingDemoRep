using System;
using System.IO;

namespace StreamReadWriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriterCaseStudy();                         // For StreamWrite
            StreamReaderCaseStudy();                           // For StreamRead
        }

        private static void StreamReaderCaseStudy()
        {
            string path = "C:\\SwbhavLiveSessions/Pandey.txt";
            FileStream file = new FileStream(path, FileMode.Open);

            StreamReader readFileContent = new StreamReader(file);
            string line = "";
            while ((line = readFileContent.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        private static void StreamWriterCaseStudy()
        {
            string path = "C:\\SwbhavLiveSessions/Pandey.txt";
            FileStream file = new FileStream(path, FileMode.Create);

            StreamWriter writeFileContent = new StreamWriter(file);

            writeFileContent.WriteLine("My Name is Gautam Kumar Pandey.");
            writeFileContent.WriteLine("Currentally Pursuing MCA from NIT Jamshedpur.");
            writeFileContent.WriteLine("I belong to Varanasi.");

            writeFileContent.Close();
            Console.WriteLine("Text Will Be Added in File.");
        }
    }
}
