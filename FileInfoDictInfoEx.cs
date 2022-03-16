using System;
using System.IO;
using static System.Console;

namespace Capgemini.CSharp.Day6
{
    internal class FileInfoDictInfoEx
    {
        static void Main(string[] args)
        {
            //FileInfo fi = new FileInfo(@"C:\Users\LENOVO\OneDrive\Documents\capgemini\csharp\Employee.txt");
            //WriteLine($"full name : {fi.FullName}");
            //WriteLine($"length : {fi.Length}");
            //WriteLine($"create date : {fi.CreationTime}");

            //if (fi.Exists)
            //    fi.Delete();
            //else
            //    WriteLine("file does not exist");
            // FileStream fs= fi.Create();

            //FileStream fs = fi.OpenWrite();
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("this is a test");
            //sw.Close();
            //fs.Close();
            DirectoryInfo d1 = new DirectoryInfo(@"C:\Users\LENOVO\OneDrive\Documents\capgemini\csharp");
            var files = d1.GetFiles();
            foreach (var f in files)
            {
                WriteLine($"FULL NAME {f.FullName}");
                WriteLine($"creation time: {f.CreationTime}");
                WriteLine($"file extension: {f.Extension}");
                
            }
           // d1.CreateSubdirectory("Subdirectory");
           d1=new DirectoryInfo(@"C:\Users\LENOVO\OneDrive\Documents\capgemini\csharp\Subdirectory");
            if(d1.Exists)
            {
                d1.Delete();
                WriteLine($"subdirectory deleted");
            }
            
           

        }
    }
}
