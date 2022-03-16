using System;

using System.IO;



using static System.Console;

namespace Capgemini.CSharp.Day6

{

    internal class FileInfoExample

    {

        static void Main(string[] args)

        {

            //FileInfo fi = new FileInfo(@"D:\Training_Demos\Capgemini\Files\Employee.txt");

            //WriteLine($"Full Name :{fi.FullName}");

            //WriteLine($"Length :{fi.Length}");

            //WriteLine($"Create Date :{fi.CreationTime}");

            ////if (fi.Exists)

            ////{

            //// fi.Delete();

            ////}

            ////else

            ////{

            //// WriteLine("File doesn't exists");

            ////}

            //// FileStream fs = fi.Create();

            //FileStream fs = fi.OpenWrite();

            //StreamWriter sw=new StreamWriter(fs); ;

            //sw.WriteLine("This is a Test");

            //sw.Close();

            //fs.Close();

            //DirectoryInfo

            DirectoryInfo d1 = new DirectoryInfo(@"D:\Training_Demos\Capgemini\Files");

            var files = d1.GetFiles();

            foreach (var f in files)

            {

                WriteLine($"Full Name :{f.FullName}");

                WriteLine($"Create Date :{f.CreationTime}");

                WriteLine($"File Extension :{f.Extension}");

            }

            // d1.CreateSubdirectory("SubDirectory");

            d1 = new DirectoryInfo(@"D:\Training_Demos\Capgemini\Files\SubDirectory");

            if (d1.Exists)

            {

                d1.Delete();

                WriteLine("Sub Directory Deleted");

            }

        }

    }

}




