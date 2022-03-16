using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day5
{
    public class Product1 : IComparable<Product1>
    {
        public int ProductNo { get; set; }
        public string Name { get; set; }
        public float Rate { get; set; }
        public int Stock { get; set; }


        public int CompareTo(Product1 other)
        {

            return this.ProductNo.CompareTo(other.ProductNo);
        }

    }
    public class Product2
    {
        public Product1 AddProduct(int productno, string name, float rate, int stock)
        {
            return new Product1
            {
                ProductNo = productno,
                Name = name,
                Rate = rate,
                Stock = stock
            };
        }


        public void Search(List<Product1> products, int p)
        {
            List<Product1> product = new List<Product1>();
            foreach (var pro in products)
            {
                if (pro.ProductNo == p)
                    product.Add(pro);
            }
            foreach (var pro in product)
                WriteLine($"Product No : {pro.ProductNo}\t Name :{pro.Name}\t Rate :{pro.Rate}\t Stock :{pro.Stock}");

        }
        public void Delete(List<Product1> products, int p)
        {

            List<Product1> product = new List<Product1>();
            List<Product1> product2 = new List<Product1>();
            foreach (var pro in products)
            {
                if (pro.ProductNo == p)
                    product2.Remove(pro);

            }


        }
        public void print(List<Product1> products)
        {

            foreach (var pro in products)
            {

                WriteLine($"Product No : {pro.ProductNo}\t Name :{pro.Name}\t Rate :{pro.Rate}\t Stock :{pro.Stock}");
            }
        }
        static void Main(string[] args)
        {
            List<Product1> ob = new List<Product1>();
            Product2 ob2 = new Product2();

            do

            {

                WriteLine("1.Add Product Number \n2.Print \n3.Delete  \n4. Search \n5. Exit");

                Write("Enter a Number:");

                int choice = int.Parse(ReadLine());

                switch (choice)

                {

                    case 1:

                        Write("Product number : ");

                        int productno = int.Parse(ReadLine());

                        Write("Enter Name :");

                        string name = ReadLine();

                        Write("Enter Rate :");

                        float city = float.Parse(ReadLine());
                        Write("Enter stock :");
                        int stock = int.Parse(ReadLine());

                        ob.Add(ob2.AddProduct(productno, name, city, stock));

                        break;
                    case 2:
                        ob.Sort();
                        ob2.print(ob);

                        break;

                    case 3:

                        Write("Enter Product No. to delete :");

                        int productno2 = int.Parse(ReadLine());

                        ob2.Delete(ob, productno2);

                        break;




                    case 4:

                        Write("Enter Product No. to perform search :");

                        int productno1 = int.Parse(ReadLine());

                        ob2.Search(ob, productno1);

                        break;

                    case 5:

                        Environment.Exit(0);

                        break;

                    default:

                        WriteLine("Invalid choice entered");

                        break;

                }

            } while (true);

        }
    }

}

