using System;
using System.IO;
using System.Linq;

namespace FileDirectroyINfoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();                // For Directories
            CaseStudy2();                // For Files
        }
        private static void CaseStudy2()
        {
            string path = "C:\\SwbhavLiveSessions/Gautam.txt";
            FileInfo fileInfo = new FileInfo(@path);
            GetFileDetails(fileInfo);
        }

        private static void CaseStudy1()
        {
            string path = "C:\\SwbhavLiveSessions";
            DirectoryInfo directory = new DirectoryInfo(@path);
            ShowAllDirectory(directory);
            GetDetailsOfDirectory(directory);
        }

        private static void GetFileDetails(FileInfo fileInfo)
        {
            Console.WriteLine("File Name is : "+fileInfo.Name);
            Console.WriteLine("File Full Name is : " + fileInfo.FullName);
            Console.WriteLine("File Creation Time is : " + fileInfo.CreationTime);
            Console.WriteLine("File Last Access Time is : " + fileInfo.LastAccessTime);
            Console.WriteLine($"File Length is : {fileInfo.Length} bytes.");
            Console.WriteLine("File Extension is : " + fileInfo.Extension);
            Console.WriteLine("File Exist of Not is : " + fileInfo.Exists);
            Console.WriteLine("File Last Write Time: " + fileInfo.LastWriteTime);
            Console.WriteLine("----------------------------------------------------------------------------");
        }

        private static void GetDetailsOfDirectory(DirectoryInfo directory)
        {
            Console.WriteLine("Number Of Files Will be : " + directory.GetFiles().Length) ;
            Console.WriteLine("Number Of Folder Will be : " + directory.GetDirectories().Length);
            Console.WriteLine("Directory Name is : " + directory.Name);
            Console.WriteLine("Directory Creation Time is : " + directory.CreationTime);
            Console.WriteLine("Directory Last Access Time is : " + directory.LastAccessTime);
            Console.WriteLine("Directory Exist or Not is : " + directory.Exists);
            Console.WriteLine("Directory Last Write Time is : " + directory.LastWriteTime);
            Console.WriteLine("Directory Root is : " + directory.Root);
            Console.WriteLine("Directory Full Name is : " + directory.FullName);
            Console.WriteLine("----------------------------------------------------------------------------");
        }
        private static void ShowAllDirectory(DirectoryInfo directory)
        {
            DirectoryInfo[] directoryInfos = directory.GetDirectories();
            foreach (var directoryInfo in directoryInfos)
            {
                Console.WriteLine(directoryInfo);
            }
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
