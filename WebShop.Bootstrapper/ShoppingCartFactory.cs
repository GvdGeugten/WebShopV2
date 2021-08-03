using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopRepository;

namespace WebShop.Bootstrapper
{
    public class ShoppingCartFactory
    {
        public static IShoppingCart GetShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
