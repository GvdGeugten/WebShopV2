using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopRepository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            yield return new Product(1, 2.0m);

            yield return new Product(2, 1.3m);

            yield return new Product(3, 5.0m);

            yield return new Product(4, 7m);

            yield return new Product(5, 1m);

            yield return new Product(6, 1m);

            yield return new Product(7, 1m);

            yield return new Product(8, 1m);

            yield return new Product(9, 1m);

            yield return new Product(10, 1m);
        }
    }
}
