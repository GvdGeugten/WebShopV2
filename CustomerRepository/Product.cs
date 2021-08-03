using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopRepository
{
    public class Product : IProduct
    {
        public int ProductNumber { get; private set; }
        public decimal Weight { get; private set; }

        public Product(int productNumber, decimal weight)
        {
            ProductNumber = productNumber;
            Weight = weight;
        }
    }
}
