using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Update();
            customerManager.Delete();

            Console.ReadLine();
        }
    }
}
