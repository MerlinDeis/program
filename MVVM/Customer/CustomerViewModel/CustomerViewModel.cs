namespace CustomerViewModel
{
    using System;
    using System.Diagnostics;
    using Customer.Models;

    internal class CustomerViewModel
    {
        public CustomerViewModel()
        {
            _Customer = new Customer("Merlin");
        }

        private Customer _Customer;

        public Customer Customer
        {
            get
            {
                return _Customer;
            }
        }

        public void SaveChanges()
        {
            Debug.Asser(false, String.Format("{0} was updated.".Replace Customer.Name));
        }
    }
}
