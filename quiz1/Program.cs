using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();

            product.ID = 1;
            product.Name = "Laptop";
            product.UnitePrice = 10000;

            Product product1 = new Product { ID = 2, Name = "Tablet", UnitePrice = 4000 };

            Product[] list = new Product[] {
            product,product1};

            Console.WriteLine("-----Foreach-----");
            foreach (var item in list)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.UnitePrice);
                Console.WriteLine("------------");
            }
            Console.WriteLine("-----While-----");
            int i = 0;
            while ( i < list.Length){
                Console.WriteLine(list[i].ID);
                Console.WriteLine(list[i].Name);
                Console.WriteLine(list[i].UnitePrice);
                Console.WriteLine("------------");
                i++;
            }
            Console.WriteLine("-----For-----");
            for ( i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].ID);
                Console.WriteLine(list[i].Name);
                Console.WriteLine(list[i].UnitePrice);
                Console.WriteLine("------------");
            }

            Console.ReadLine();
        }
    }
}
