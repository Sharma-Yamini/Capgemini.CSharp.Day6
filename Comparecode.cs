using System;

using System.Collections.Generic;

using static System.Console;

namespace Capgemini.CSharp.Day6

{

    public class Product// : IComparable<Product>

    {

        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        ////method 1

        //public int CompareTo(object obj)

        //{

        // // Product p = (Product)obj; //Invalidcastexception

        // Product p = obj as Product; //Nullreferenceexception

        // return this.Price.CompareTo(p.Price);

        //}

        //method 2

        //public int CompareTo(Product other)

        //{

        //    return this.Name.CompareTo(other.Name);

        //}

        /* 1 - swap

         * 0 - retain

         * -1 No Swap

         */

    }

    //public class PriceComparer : IComparer<Product>

    //{

    //    public int Compare(Product x, Product y)

    //    {

    //        return x.Price.CompareTo(y.Price);

    //    }

    //}

    public class TestClass

    {

        static void Main(string[] args)

        {

            //Collection Initializer

            List<Product> list = new List<Product>()
            { 
            

      

        //Object Initializer

        new Product{Id=1,Name="Mouse",Price=500},

        new Product{Id=2,Name="Keyboard",Price=1500},

        new Product{Id=3,Name="Water Bottle",Price=850},

        new Product{Id=4,Name="Pen",Price=150},

      };

            list.Sort(delegate (Product x,Product y)
            {
                return x.Name.CompareTo(y.Name);
            });

            WriteLine("Sort By Name");

            foreach (Product prd in list)

            {

                WriteLine($"Id :{prd.Id}\tName :{prd.Name}\tPrice :{prd.Price}");

            }

            //PriceComparer obj = new PriceComparer();

            //list.Sort(obj);

            //    list.Sort(new PriceComparer());
            list.Sort(delegate (Product x, Product y)
            {
                return x.Price.CompareTo(y.Price);
            });


            WriteLine("Sort By Price");

            foreach (Product prd in list)

            {

                WriteLine($"Id :{prd.Id}\tName :{prd.Name}\tPrice :{prd.Price}");

            }

            //List<int> listInt = new List<int> { 1, 3, 5, 2, 10, 11, 6 };

            //listInt.Sort();

            //foreach (var item in listInt)

            //{

            // WriteLine(item);

            //}

        }

    }

}