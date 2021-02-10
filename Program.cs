using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Engin";
            customer.Surname = "Demiroğ";
            customer.Adress = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Seda";
            customer2.Surname = "Şimşek";
            customer2.Adress = "Diyarbakir";

            Customer[] customers = new Customer[] { customer, customer2 };
            CustomerManager customerManager = new CustomerManager();
            Customer customer3 = new Customer();//boş bir customer nesnesi add kısmında içini dolduruyoruz
            customerManager.Add(customer3);
            customerManager.List(customers);
            customerManager.Delete(customer);

        }
    }
}

