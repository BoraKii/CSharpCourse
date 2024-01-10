using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
     class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager.cs dosyasından veri çekiyor.
            CustomerManager customerManager = new CustomerManager(); //Classın bir örneği oluşturulurken "customerManager" ilk kelime harfi her zaman küçük oluşturulur.
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            VoiceManager voiceManager = new VoiceManager();
            voiceManager.Add();
            voiceManager.Update();

            Customer customer = new Customer(); //Uzun kod kullanımı
            customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Bora";
            customer.LastName = "Kitirci";
            customer.Age = 21;
            customer.City = "Eskişehir";

            Customer customer2 = new Customer() //Kısa ve öz kod kullanımı
            {
                Id = 2, City = "İstanbul", Age = 30, FirstName = "Bensu", LastName = "Kitirci" //set kodu
            };

            Console.WriteLine(customer.FirstName); //get kodu
            Console.WriteLine(customer2.FirstName); //get kodu
            Console.ReadLine();
        }
    }
    //Class oluşturulduğunda kelimelerin ilk harfleri büyük oluşturulur.

    class ProductManager
     {
         public void Add()
         {
             Console.WriteLine("Product Added!");
         }

         public void Update()
         {
             Console.WriteLine("Product Updated!");
         }
     }

    class VoiceManager
    {
        public void Add()
        {
            Console.WriteLine("Voice Added!");
        }

        public void Update()
        {
            Console.WriteLine("Voice Updated!");
        }
    }
}
