using System;
using CustomerRepository;
using WebShop.Bootstrapper;
using WebShopRepository;

namespace WebShopv2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var controller = Application.GetController();
                //since customer needs to be instantiated with a name, it is not accessed successfully through the controller
                var customer = CustomerFactory.GetCustomer("shopper");
                var shop = controller.Resolve<IShop>();

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
