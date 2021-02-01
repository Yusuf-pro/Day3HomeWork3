using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Müşteri Ekle     : 1\n" + "Müşteri Güncelle : 2\n" + "Müşteri Sil      : 3\n" + "Operasyon Numarası Seçiniz: ");

            var operation = Console.ReadLine();

            Console.WriteLine("\n");

            Customer customer = new Customer();
            CustomerManager customerManager = new CustomerManager();

            if (operation == "1")
            {
                Console.Write("Müşteri TC No: ");
                customer.IdNumber = Console.ReadLine();

                Console.Write("Müşteri İsmi: ");
                customer.FirstName = Console.ReadLine();

                Console.Write("Müşteri Soyismi: ");
                customer.LastName = Console.ReadLine();

                Console.Write("Müşteri Yaşı: ");
                customer.Age = Console.ReadLine();

                Console.Write("Müşteri Şehri: ");
                customer.City = Console.ReadLine();

                customerManager.AddCustomer(customer);
            }
            else if (operation == "2")
            {
                Customer customer0 = new Customer();

                customer0.IdNumber = "25698725369";
                customer0.FirstName = "Murat";
                customer0.LastName = "UĞUR";
                customer0.Age = "27";
                customer0.City = "ISTANBUL";

                Customer customer1 = new Customer();

                customer1.IdNumber = "16524896371";
                customer1.FirstName = "Mehmet Can";
                customer1.LastName = "UĞUR";
                customer1.Age = "18";
                customer1.City = "ISTANBUL";

                Customer[] customers = new Customer[]
                {
                    customer0, customer1
                };
                customerManager.ListCustomer(customers);

                Console.Write("Bilgilerini Güncellemek İstediğiniz Müşterinin ID numarası: ");
                string id = Console.ReadLine();

                if (id == "101")
                {
                    Console.WriteLine("");

                    Console.Write("Müşteri TC No: ");
                    customer.IdNumber = Console.ReadLine();

                    Console.Write("Müşteri İsmi: ");
                    customer.FirstName = Console.ReadLine();

                    Console.Write("Müşteri Soyismi: ");
                    customer.LastName = Console.ReadLine();

                    Console.Write("Müşteri Yaşı: ");
                    customer.Age = Console.ReadLine();

                    Console.Write("Müşteri Şehri: ");
                    customer.City = Console.ReadLine();

                    customerManager.UpdateCustomer(customer);
                }
                else if (id == "102")
                {
                    Console.WriteLine("");

                    Console.Write("Müşteri TC No: ");
                    customer.IdNumber = Console.ReadLine();

                    Console.Write("Müşteri İsmi: ");
                    customer.FirstName = Console.ReadLine();

                    Console.Write("Müşteri Soyismi: ");
                    customer.LastName = Console.ReadLine();

                    Console.Write("Müşteri Yaşı: ");
                    customer.Age = Console.ReadLine();

                    Console.Write("Müşteri Şehri: ");
                    customer.City = Console.ReadLine();

                    customerManager.UpdateCustomer(customer);
                }

            }
            else if (operation == "3")
            {
                Customer customer0 = new Customer();

                customer0.IdNumber = "25698725369";
                customer0.FirstName = "Serdar";
                customer0.LastName = "Yılmaz";
                customer0.Age = "14";
                customer0.City = "Ankara";

                Customer customer1 = new Customer();

                customer1.IdNumber = "16524896371";
                customer1.FirstName = "Yusuf Taha";
                customer1.LastName = "Yılmaz";
                customer1.Age = "10";
                customer1.City = "ISTANBUL";

                Customer[] customers = new Customer[]
                {
                    customer0, customer1
                };
                customerManager.ListCustomer(customers);

                Console.Write("Silmek İstediğiniz Müşterinin ID numarası: ");
                string id = Console.ReadLine();

                if (id == "101")
                {
                    customerManager.DeleteCustomer();
                }
                else if (id == "102")
                {
                    customerManager.DeleteCustomer();
                }
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız!! Tekrar Deneyiniz..");
            }

        }
    }
}
