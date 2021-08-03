using WebShopRepository;

namespace CustomerRepository
{
    public interface ICustomer
    {
        void TakeProduct(IProduct product);
        void CheckOut(IShop shop);
        decimal TakeMoney(decimal value);
    }
}