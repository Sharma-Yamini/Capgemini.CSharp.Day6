using System;

using System.Collections.Generic;

using static System.Console;

namespace Capgemini.CSharp.Day6

{

    internal class ActionAndFunction

    {

        public void Add(int x, int y)

        {

            WriteLine($"Addition :{x + y}");

        }

        public void GetProducts(int id, string name, double price, int qty)

        {

            WriteLine("Product Details");

            WriteLine($"Id :{id}\tName :{name}\tPrice :{price}\tQuantity :{qty}");

        }

        public float Divide(int a, int b)

        {

            return (float)a / (float)b;

        }

        public List<Product> PrintProducts()

        {

            List<Product> products = new List<Product>();

            for (int i = 0; i < 4; i++)

            {

                Product p1 = new Product();

                WriteLine("Enter Id :");

                p1.Id = int.Parse(ReadLine());

                Write("Enter Name :");

                p1.Name = ReadLine();

                Write("Enter Price :");

                p1.Price = double.Parse(ReadLine());

                products.Add(p1);

            }

            return products;

        }

        static void Main(string[] args)

        {

            ActionAndFunction obj = new ActionAndFunction();

            //Action Delegate

            Action<int, int> calc = obj.Add; //Instantiate Delegate

            calc(5, 8);//Call Delegate

            Action<int, string, double, int> products = obj.GetProducts;

            products(1, "Mouse", 500.6, 120);

            //Function Delegate

            Func<int, int, float> divide = obj.Divide;

            WriteLine($"Divide : {divide(2, 9)}");

            Func<List<Product>> prd = obj.PrintProducts;

            prd();

        }

    }

}