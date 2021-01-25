using System.Collections.Generic;
using Entities;

namespace Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
    }
}