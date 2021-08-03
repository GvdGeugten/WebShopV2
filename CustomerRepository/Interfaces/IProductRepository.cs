using System.Collections.Generic;

namespace WebShopRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}