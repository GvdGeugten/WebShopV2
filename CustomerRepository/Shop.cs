using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopRepository
{
    public class Shop : IShop
    {
        public IEnumerable<Product> Products { get; set; }
        public decimal Wallet { get; set; }

        public void OrderFromMerchant()
        {
            var productService = new ProductRepository();
            Products = productService.GetProducts();
        }

        public Product FindProduct(int productnummer)
        {
            return Products.FirstOrDefault(i => i.ProductNumber == productnummer);
        }

        public void Give(decimal money)
        {
            Wallet += money;
        }
    }
}
