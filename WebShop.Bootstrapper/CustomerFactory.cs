using System;
using CustomerRepository;

namespace WebShop.Bootstrapper
{
    public class CustomerFactory
    {
        public static ICustomer GetCustomer(string customer)
        {
            return new Customer(customer);
        }
    }
}
