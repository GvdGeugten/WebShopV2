using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopRepository
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly ICollection<Product> _contents = new List<Product>();

        public ICollection<Product> Contents
        {
            get { return _contents; }
        }
        public decimal Value
        {
            get { return Contents.Sum(i => new WeightToValueCalculator(i).GetValue()); }
        }

        public void Add(Product product)
        {
            Contents.Add(product);
        }
    }
}
