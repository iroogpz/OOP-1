using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CatagoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CatagoryId = 4,
                ProductName = "Kalem",
                UnitsInStock = 10,
                UnitPrice = 25
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


        }
    }
}
