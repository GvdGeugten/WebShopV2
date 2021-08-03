using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopRepository;

namespace WebShop.Bootstrapper
{
    public class ProductFactory
    {
        public static IProductRepository GetProductRepository()
        {
            return new ProductRepository();
        }
    }
}
