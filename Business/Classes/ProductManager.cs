using System;
using System.Collections.Generic;
using DataAccess;
using Entities;

namespace Business
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Add(Product product)
        {
            if (product.ProductName == "Laptop")
            {
                throw new Exception("Laptop ekleyemezsiniz!");
            }

            _productDal.Add(product);
        }
    }
}