using System;

using System.IO;

using static System.Console;

namespace Capgemini.CSharp.Day6

{

    public class Employee

    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public double Salary { get; set; }

    }

    internal class FileExample

    {

        private FileStream fs = null;

        private StreamWriter sw = null;

        private StreamReader sr = null;

        public void WriteToFile(Employee employee, string fileName)

        {

            try

            {

                //Creating FileStream Object and Append the content

                fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);

                sw = new StreamWriter(fs);

                sw.WriteLine($"Employee Details on {DateTime.Now}");

                sw.WriteLine($"Employee Id :{employee.Id}");

                sw.WriteLine($"Employee Name :{employee.Name}");

                sw.WriteLine($"Department :{employee.Department}");

                sw.WriteLine($"Salary :{employee.Salary}");

                sw.Flush();//Clear the clipboard or buffer memory

            }

            catch (IOException ex)

            {

                WriteLine($"IO Exception :{ex.Message}");

            }

            catch (Exception ex)

            {

                WriteLine($"Base Exception :{ex.Message}");

            }

            finally

            {
                if (sw != null)

                    sw.Close();

                if (fs != null)

                    fs.Close();

              

            }

        }

        public void ReadFromFile(string fileName)

        {
            
           

                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                sr = new StreamReader(fs);

               sr.BaseStream.Seek(20, SeekOrigin.Begin);//Read from the beginning of the file

                WriteLine(sr.ReadToEnd());
            

           


        }

        static void Main(string[] args)

        {

            FileExample file = new FileExample();

            Employee employee = new Employee

            {

                Id = 1006,

                Name = "January",

                Department = "IT Admin",

                Salary = 645666.99

            };

            //string verbatium

            string fileName = @"C:\Users\LENOVO\OneDrive\Documents\capgemini\csharp\Employee.txt";

            //Calling WriteToFile method to write Employee Data to File

            file.WriteToFile(employee, fileName);

            //Calling ReadFromFile methos to read Employee and display in Console.

            file.ReadFromFile(fileName);

        }

    }

}