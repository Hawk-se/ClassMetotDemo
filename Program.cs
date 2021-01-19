using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankamıza Hoşgeldiniz!");
            Console.WriteLine(" ");
            
            Customer customer1 = new Customer();
            customer1.Name = "Yiğit";
            customer1.Surname = "Taşçı";
            customer1.Id = "1234567890";
            customer1.Age = 54;
            customer1.Credibility = 7.8;
            
            Customer customer2 = new Customer();
            customer2.Name = "Ceren";
            customer2.Surname = "Küçük";
            customer2.Id = "2345678901";
            customer2.Age = 26;
            customer2.Credibility = 5.1;
            
            Customer customer3 = new Customer();
            customer3.Name = "Ayça";
            customer3.Surname = "Bilici";
            customer3.Id = "3456789012";
            customer3.Age = 35;
            customer3.Credibility = 8.2;
            

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri Adı: " + customer.Name);
                Console.WriteLine("        Soyadı: " + customer.Surname);
                Console.WriteLine("        T.C. Kimlik No: " + customer.Id);
                Console.WriteLine("        Güvenilirliği: "+ customer.Credibility);
                Console.WriteLine(" ");
            }

            CustomerManager CustomerManager = new CustomerManager();
            CustomerManager.Add(customer1);
            CustomerManager.Delete(customer2);
            CustomerManager.Suspend(customer3);

        }

    }

}