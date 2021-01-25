using System;
using Business;
using DataAccess;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EntityProductDal()); //PM'i kullanabilmek için newliyorum (referans alıyorum).

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine($"{product.ProductName} {product.QuantityPerUnit} {product.UnitPrice}");
            }

            productManager.Add(new Product() { ProductId = 10, ProductName = "iPhone XS MAX", QuantityPerUnit = "iPhone", UnitPrice = 999, UnitsInStock = 10 });
        }
    }
}
