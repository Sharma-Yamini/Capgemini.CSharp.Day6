using System;

using System.Runtime.Serialization.Formatters.Binary;

using System.IO;

namespace Capgemini.CSharp.Day6

{

    internal class Serialization_Binary

    {

        private FileStream fs = null;

        /// <summary>

        /// This method is used to Serialize object in Binary Format

        /// </summary>

        /// <param name="employee">Accepts Employee class object</param>

        /// <param name="fileName">Accept file path to store the serialized object</param>

        public void BSerialize(Employee employee, string fileName)

        {

            fs = File.Create(fileName);

            BinaryFormatter binary = new BinaryFormatter();

            binary.Serialize(fs, employee);

            fs.Close();

        }

        public Employee BDeserialize(string fileName)

        {

            fs = File.OpenRead(fileName);

            BinaryFormatter formatter = new BinaryFormatter();

            var emp = formatter.Deserialize(fs) as Employee;

            if (emp != null)

            {

                return emp;

            }

            else

            {

                throw new Exception("Unable to Deserialize");

            }

        }

        static void Main(string[] args)

        {

            Serialization_Binary obj = new Serialization_Binary();

            //Employee emp = new Employee { Id = 1, Name = "Pradeep", Department = "Marketing", Salary = 5555 };

            string fileName = @"D:\Training_Demos\Capgemini\Files\BinaryEmployee.txt";

            //obj.BSerialize(emp, fileName);

            var employee = obj.BDeserialize(fileName);

            Console.WriteLine($"ID :{employee.Id}\tName :{employee.Name}\tDepartment :{employee.Department}\tSalary :{employee.Salary}");

        }

    }

}
