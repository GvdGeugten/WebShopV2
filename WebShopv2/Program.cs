using System;
using WebShop.Bootstrapper;

namespace WebShopv2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var customer = CustomerFactory.GetCustomer("shopper");
                var shop = ShopFactory.GetShop();

                shop.OrderFromMerchant();
                customer.TakeProduct(shop.FindProduct(3));
                customer.CheckOut(shop);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
