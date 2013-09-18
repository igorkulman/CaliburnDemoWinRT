using System.Collections.Generic;
using System.Linq;
using CaliburnDemo.Data;

namespace CaliburnDemo.Servcies
{
    public class ProductService: IProductService
    {
        private readonly List<Product> _products = new List<Product>()
            {
                new Product
                    {
                        Id = 1,
                        Name = "Product 1"
                    },
                     new Product
                    {
                        Id = 2,
                        Name = "Product 2"
                    }
            };

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product Get(int id)
        {
            return _products.SingleOrDefault(l => l.Id == id);
        }
    }
}
