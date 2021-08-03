using System;
using WebShopRepository;

namespace CustomerRepository
{
    public class Customer : ICustomer
    {
        private ShoppingCart _shoppingCart;
        public string Name { get; set; }
        public decimal Wallet { get; set; }

        public ShoppingCart ShoppingCart
        {
            get { return _shoppingCart ?? (_shoppingCart = new ShoppingCart()); }
        }

        public Customer(string name)
        {
            Name = name;
        }

        public void TakeProduct(IProduct product)
        {
            ShoppingCart.Add((Product)product);
        }

        public void CheckOut(IShop shop)
        {
            shop.Give(TakeMoney(ShoppingCart.Value));
        }

        public decimal TakeMoney(decimal value)
        {
            Wallet -= value;
            return value;
        }
    }
}
