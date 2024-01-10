using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer","bilgisayar");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key); //sol anahtar kelime tarafı
                Console.WriteLine(item.Value); //sağ değer tarafı
            }

            Console.WriteLine(dictionary.ContainsKey("glass")); // dizi içinde glass varsa true döner yoksa false döner.
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Adana")); //Array içinde "Adana" verisi yoksa False döner.

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer(){Id = 1, FirstName = "Bora"});
            //customers.Add(new Customer(){Id = 2, FirstName = "Bensu"}); // 2 şekilde de kullanılabilir.

            List<Customer> customers = new List<Customer>
            {
                new Customer() { Id = 1, FirstName = "Bora" },
                new Customer() { Id = 2, FirstName = "Bensu" }
            };

            var customer2 = new Customer()
            {
                Id = 3, FirstName = "Kuzey"
            };
            customers.Add(customer2);

            var index = customers.IndexOf(customer2); // girilen parametreyi baştan arar ve sonucu verir.
            Console.WriteLine("Index : {0}", index);
            customers.Add(customer2);

            var index2 = customers.LastIndexOf(customer2); // girilen parametreyi sondan arar ve sonucu verir.
            Console.WriteLine("Index2 : {0}", index2);

            customers.Insert(0, customer2); // girilen indexin değerini değiştirmek için kullanılır.

            customers.Remove(customer2); // belirtilen parametredeki ilk elemanı kaldırır.
            customers.RemoveAll(c =>
                c.FirstName == "Kuzey"); // Belirtilen parametrede ki verinin tamamını kaldırmak için kullanılır.

            customers.AddRange(new Customer[2] //birden fazla veri eklemek için AddRange kullanılır.
            {
                new Customer() { Id = 4, FirstName = "Zeynep" },
                new Customer() { Id = 5, FirstName = "Ercan" }
            });

            Console.WriteLine(customers.Contains(customer2)); //customer2 var olduğundan dolayı True döner.

            //customers.Clear(); //bütün elemanları temizler

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count();
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add('A');
            cities.Add(1);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
