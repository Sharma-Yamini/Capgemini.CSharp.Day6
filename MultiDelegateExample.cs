using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day6
{    
    /// <summary>
    /// Calculate Handler delegate used to reference method with(int,int) argument
    /// </summary>
    /// <param name="a"> Accept int value</param>
    /// <param name="b">Accept int value</param>
    /// <returns></returns>
    public delegate void CalculateHandler(int a,int b);//Step 1
    internal class MultiDelegateExample
    {
        public void Addition(int a,int b)
        {
            WriteLine($"Addition : {a+b}");
        }
        public void Multiply(int a,int b)
        {
            WriteLine($"Multiply : {a * b}");
        }
        static void Main(string[] args)
        {
            MultiDelegateExample obj=new MultiDelegateExample();

            // Instantiate or Initialize a delegate
            CalculateHandler cal = new CalculateHandler(obj.Addition);
            //  CalculateHandler cal = obj.Addition;
            cal += obj.Addition;
             cal += obj.Multiply;
            //  cal(10, 20);

            // //Deallocate a method, used to remove the method from the reference
            cal -= obj.Addition;
            cal(10,20);//Step 3
        }
    }
}
