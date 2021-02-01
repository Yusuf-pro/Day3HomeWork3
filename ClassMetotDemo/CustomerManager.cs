using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Customer customerId = new Customer();
            int IdNo = customerId.Id = 101;

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Sisteme Başarıyla Eklenmişyir.\n");
        }

        public void ListCustomer(Customer[] customers)
        {
            Customer customerId = new Customer();
            int idNo = customerId.Id = 101;

            Console.WriteLine("Id Nu");

            foreach (Customer customer in customers)
            {
                Console.WriteLine(" " + idNo +
                    "   " + customer.IdNumber +
                    "   " + customer.FirstName +
                    "   " + customer.LastName +
                    "   " + customer.Age +
                    "   " + customer.City);
                idNo++;
            }
            Console.WriteLine("\n");
        }
        public void UpdateCustomer(Customer customer)
        {
            Customer customerId = new Customer();
            int idNo = customerId.Id = 101;

            Console.WriteLine(customer.FirstName + " " +
                              " " + customer.LastName +
                              "Sistem Başarıyla Güncellendi.\n");
        }
        public void DeleteCustomer()
        {
            Console.WriteLine("Silme işlemi tamamlanmıştır.");
        }
    }
}
