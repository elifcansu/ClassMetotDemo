using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void MusteriEkle(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi : " + customer.FirstName);
        }

        public void MusteriListeleme(Customer customer)
        {
            Console.WriteLine("Müşteri listelendi : " + customer.FirstName + " " + customer.LastName + " isimli " + customer.Telephone + " numaraya sahip " + customer.City + " şehrin de yaşayan müşterimiz." );
        }

        public void MusteriSil(Customer customer)
        {
            Console.WriteLine("Müşteri silindi : " + customer.FirstName);
        }

        public void MusteriGuncelle(Customer customer)
        {
            Console.WriteLine("Müşteri güncellendi : " + customer.FirstName);
        }
    }
}
