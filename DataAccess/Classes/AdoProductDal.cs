using System;
using System.Collections.Generic;
using Entities;

namespace DataAccess
{
    public class AdoProductDal:IProductDal//IProductDal'ı implement ediyorum.
    {
        //Ado.NET
        private List<Product> _products; //Product tipinde liste oluşturuyorum, ürünleri listeleyebilmek için.

        public AdoProductDal() //Constructor oluşturuyorum. Bu sayede bu class'ı new'lediğimde otomatik olarak product'larım olacak.
        {
            _products = new List<Product>() //Listeye elemanları ekliyorum.
            {
                new Product() {ProductId = 1, ProductName = "Ado.NET Macbook Air", QuantityPerUnit = "Power. It’s in the Air.", UnitPrice = 999, UnitsInStock = 23},
                new Product() {ProductId = 2, ProductName = "Ado.NET Macbook Pro 16", QuantityPerUnit = "The best for the brightest.", UnitPrice = 2399, UnitsInStock = 12},
                new Product() {ProductId = 3, ProductName = "Ado.NET Macbook Pro 13", QuantityPerUnit = "All systems Pro.", UnitPrice = 1299, UnitsInStock = 17},
                new Product() { ProductId = 4, ProductName = "Ado.NET Mac Mini", QuantityPerUnit = "New guts. More glory.", UnitPrice = 699, UnitsInStock = 6 }
            };
        }

        public List<Product> GetAll()
        {
            return _products;//Listeyi döndürüyorum.
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.NET ile eklendi");
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}