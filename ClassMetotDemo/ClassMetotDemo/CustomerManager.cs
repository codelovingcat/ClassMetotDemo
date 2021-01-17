using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add()
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Ürem";
            customer.Surname = "Sancaktutan";
            customer.Adress = "İstanbul";

            Console.WriteLine(customer.Name +" : Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
        public void Delete()
        {
            Console.WriteLine("Customer Deleted!");
        }
    }
}
