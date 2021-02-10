using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Damla";
            customer1.LastName= "Genç";
            customer1.Id = 01;
            customer1.City = "Malatya";

            Customer customer2 = new Customer();
            customer2.Name = "İrem";
            customer2.LastName = "Çatal";
            customer2.Id = 02;
            customer2.City = "Mersin";

            Customer customer3 = new Customer();
            customer3.Name = "Mustafa";
            customer3.LastName = "Erdoğan";
            customer3.Id = 03;
            customer3.City = "İstanbul";


            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("----------------------------MÜŞTERİLER--------------------------");

            foreach (var customer in customers)
            {
                
                Console.WriteLine("Müşteri Id : " + customer.Id);
                Console.WriteLine("Müşteri Adı Soyadı : " + customer.Name + " " + customer.LastName);
                Console.WriteLine("Müşteri Şehri : " + customer.City);
                Console.WriteLine("------------------------------------");
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Customer[] customers1 = new Customer[] { customer1, customer2, customer3 };
            

            

            Console.WriteLine("---------------ADD-------------");
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            

            Console.WriteLine("---------------DELETE---------------");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            

            Console.WriteLine("---------------LIST----------------");
            customerManager.List(customers);


        }
    }
}
