using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri bilgileri sisteme eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri bilgileri sistemden çıkarıldı");
        }

        public void Suspend(Customer customer)
        {
            Console.WriteLine("Müşteri bilgileri askıya alındı");
        }



    }
}
