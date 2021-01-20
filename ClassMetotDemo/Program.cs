using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Elif";
            customer1.LastName = "Ertürk";
            customer1.AccountNumber = 123456;
            customer1.Telephone = 343458858;
            customer1.City = "İstanbul";
            customer1.Password = true;

            
            Customer customer2 = new Customer();
            customer2.FirstName = "Murat";
            customer2.LastName = "Ertürk";
            customer2.AccountNumber = 145452366;
            customer2.Telephone = 333444858;
            customer2.City = "İstanbul";
            customer2.Password = false;

            Customer customer3 = new Customer();
            customer3.FirstName = "Burak";
            customer3.LastName = "Yüce";
            customer3.AccountNumber = 1455453446;
            customer3.Telephone = 35558858;
            customer3.City = "İstanbul";
            customer3.Password = true;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(" Müşteri Adı: " + customer.FirstName + "\n Müşteri Soyadı: " + customer.LastName + "\n Hesap Numarası: " + customer.AccountNumber + "\n");
                
            }

            Console.WriteLine("\n------- Metotlar Kullanıldı-------- \n");

            CustomerManager customerManager = new CustomerManager();
            customerManager.MusteriEkle(customer1);
            customerManager.MusteriGuncelle(customer2);
            customerManager.MusteriListeleme(customer2);
            customerManager.MusteriSil(customer3);

            Console.WriteLine("\n-------- Şifre Kontrolu Yapıldı----------- \n");

            if (customer1.Password == true)
            {
                Console.WriteLine("Sayın " + customer1.FirstName + " " + customer1.LastName + " Hoşgeldiniz.Hesap hareketlerinizi görebilirsiniz.");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız.Lütfen Şifrenizi Tekrar Deneyiniz...");
            }

            if (customer2.Password == true)
            {
                Console.WriteLine("Sayın " + customer2.FirstName + " " + customer2.LastName + " Hoşgeldiniz.Hesap hareketlerinizi görebilirsiniz.");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız.Lütfen Şifrenizi Tekrar Deneyiniz...");
            }

            if (customer3.Password == true)
            {
                Console.WriteLine("Sayın " + customer3.FirstName + " " + customer3.LastName + "Hoşgeldiniz.Hesap hareketlerinizi görebilirsiniz.");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız.Lütfen Şifrenizi Tekrar Deneyiniz...");
            }

        }
    }
}
