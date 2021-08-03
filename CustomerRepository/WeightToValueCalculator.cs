using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopRepository
{
    public class WeightToValueCalculator
    {
        private readonly Product _product;
        public WeightToValueCalculator(Product product)
        {
            _product = product;
        }

        public decimal GetValue()
        {
            if (_product.Weight < 5) return 1;
            else return 2;
        }
    }
}
