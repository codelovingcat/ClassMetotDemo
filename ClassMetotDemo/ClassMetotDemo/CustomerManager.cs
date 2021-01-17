using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        Customer customer3 = new Customer { Id = 3, Name = "Bedirhan", Surname = "Aygün", Adress = "Üsküdar" };
        Customer customer2 = new Customer { Id = 2, Name = "Batuhan", Surname = "Aygün", Adress = "Üsküdar" };

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
            Console.WriteLine(customer2.Name + " : Customer Updated!");
        }
        public void Delete()
        {
            Console.WriteLine(customer3.Name+ " : Customer Deleted!");
        }
    }
}
