using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopRepository;

namespace WebShop.Bootstrapper
{
    public class ShopFactory
    {
        public static IShop GetShop()
        {
            return new Shop();
        }
    }
}
