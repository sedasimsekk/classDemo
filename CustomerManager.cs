using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
     class CustomerManager
    {
        public  void Add(Customer customer)
        {
            Console.WriteLine("--------------------ADD----------------------");
            Console.WriteLine("Please your name enter");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Please your surname enter");
            customer.Surname = Console.ReadLine();
            Console.WriteLine("Please your adress enter");
            customer.Adress = Console.ReadLine();
            Console.WriteLine("Customer Added!\n" + customer.Name + "\n" + customer.Surname + "\n" + customer.Adress);
        }

        public void List (Customer[] customers)
        {
            Console.WriteLine("---------------LİST-----------------------");
            foreach (var cust in customers)
            {
                
                Console.WriteLine("ID:"+cust.Id+"\nADİ:"+cust.Name+"\nSOYADİ:"+cust.Surname+"\nADRESS:"+cust.Adress);
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("--------------DELETE-----------------------");
            Console.WriteLine(customer.Name+" DELETED!");
        }
    }
}
