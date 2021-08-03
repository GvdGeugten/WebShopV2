namespace WebShopRepository
{
    public interface IShop
    {
        void OrderFromMerchant();
        Product FindProduct(int productnummer);
        void Give(decimal money);
    }
}