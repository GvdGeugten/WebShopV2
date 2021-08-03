using CustomerRepository;
using Dif.Controller;
using WebShopRepository;

namespace WebShop.Bootstrapper
{
    public class Application
    {
        public static IDiController GetController()
        {
            var controller = new DiController();
            controller.Register<ICustomer, Customer>();
            controller.Register<IShop, Shop>();
            controller.Register<IProduct, Product>();
            controller.Register<IShoppingCart, ShoppingCart>();
            controller.Register<IProductRepository, ProductRepository>();

            return controller;
        }
    }
}
