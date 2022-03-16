using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day6
{
    public delegate void CalculateHandle(int n1, int n2);
    internal class EventExample//Publisher
    {
        /// <summary>
        /// Create event based on delegate CalculateHandle and initialized to null
        /// </summary>
        public static event CalculateHandle Operation = null;

        public static void Addition(int x, int y)
        {
            WriteLine($"Addition:{ x + y}");
        }
        public static void Sub(int x,int y)
        {
            WriteLine($"Subtraction :{x-y}");
        }
        //Invoke Event
        public static void OnOperation(int x, int y)
        {
            if (Operation != null)
            {
                Operation(x, y);
            }
            else
            {
                WriteLine($"No method associated");
            }
        }
    }

    //Subscriber
    public class TestEvent
    {
        static void Main(string[] args)
        {

           EventExample.Operation += new CalculateHandle(EventExample.Addition);
            EventExample.OnOperation(100, 200);

           // EventExample.Operation-=new CalculateHandle(EventExample.Addition);

            EventExample.Operation+=new CalculateHandle(EventExample.Sub);
            EventExample.OnOperation(500, 100);

        }

    }
}
