using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            customer.Add();
            customer.Update();
            customer.Delete();

            Console.ReadLine();
        }
    }
}
