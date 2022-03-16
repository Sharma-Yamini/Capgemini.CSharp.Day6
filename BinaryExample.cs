using System;
using System.IO;
using static System.Console;


namespace Capgemini.CSharp.Day6
{

    internal class BinaryExample
    {
        private FileStream fs=null;
        private BinaryWriter bw=null;   
        private BinaryReader br=null;

        public void Binary_Write(string filename)
        {
            using (fs= new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                using(bw= new BinaryWriter(fs))
                {
                    bw.Write(123456);
                    bw.Write(145643);
                    bw.Write("Hello");
                    bw.Write(4555.78);
                    bw.Write(false);
                    bw.Flush();
                }
            }
        }
        public void Binary_Read(string filename)
        {
            using(fs= new FileStream(filename,FileMode.Open, FileAccess.Read))
            {
                using(br= new BinaryReader(fs))
                {
                    br.BaseStream.Seek(0, SeekOrigin.Begin);
                    //WriteLine($"read string :{br.ReadString()}");
                    WriteLine($"read integer :{br.ReadInt32()}");
                    WriteLine($"read integer :{br.ReadInt32()}");
                    WriteLine($"read string :{br.ReadString()}");
                    WriteLine($"read double :{br.ReadDouble()}");
                   WriteLine($"read boolean :{br.ReadBoolean()}");
                   
                }
            }
        }

        static void Main(string[] args)
        {
            BinaryExample obj=new BinaryExample();
            string filename = @"C:\Users\LENOVO\OneDrive\Documents\capgemini\csharp\Binary.dat";
            obj.Binary_Write(filename);
            obj.Binary_Read(filename);

        }

    }
}
