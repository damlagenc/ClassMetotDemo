using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer1)
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Delete(Customer customer1)
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public void List(Customer[] customers)
        {
            Console.WriteLine("Müsteriler Listelendi");
        }

    }
}
