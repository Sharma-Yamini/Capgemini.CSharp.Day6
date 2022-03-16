using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day6
{
    public delegate string w(string msg);
    internal class Anonymous
    {
        //public string WelcomeMethod(String msg)
        //{ 
        //    return $"Welcomw{msg}";

        //}
        static void Main(string[] args)
        {
            //Anonymous types
            // var employee = new { Id = 1, name = "flash", city = "kolkata" };
            //Console.WriteLine(employee.Id);

            //Anonymous method-method without name
            w obj = (delegate (string msg)
              {
                  return $"Welcome....{msg}";
              });
            string result = obj("Admin");
            
            WriteLine(result);


        }
       
    }
}
