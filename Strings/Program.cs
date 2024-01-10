using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Bora Kitirci";
            var result = sentence.Length; //Cümle uzunluğunu belirler.
            var result2 = sentence.Clone(); //Bu metot kendisini çağıran dizinin tüm elemanlarını kopyalayıp aynı sırada (yani aynı indeks değerlerine gelecek şekilde) diğer diziye atar.

            bool result3 = sentence.EndsWith("ğ"); //Cümle ğ ile mi bitiyor?
            bool result4 = sentence.StartsWith("M"); //Cümle M ile mi başlıyor?

            var result5 = sentence.IndexOf("name"); //Cümle içindeki kelimeyi bulmayı sağlar. bulamazsa -1 döndürür.
            var result6 = sentence.IndexOf(" "); //Cümle içindeki ilk boşluğun kaçıncı harften başladığını bulur.
            var result7 = sentence.LastIndexOf(" "); //Cümle içindeki son boşluğun kaçıncı harften başladığını bulur.
            var result8 = sentence.Insert(0, "Hello, "); //Cümlenin 0. harfinden itibaren yazılan kelimeyi yazdırır.
            var result9 = sentence.Substring(3); //Cümleyi 3.harften itibaren yazdırır. 3,4 yazılırsa 3.harften itibaren 4 harfi yazdır anlamına gelir.
            var result10 = sentence.ToLower(); //Bütün harfleri küçük yapar.
            var result11 = sentence.ToUpper(); //Bütün harfleri büyük yapar.
            var result12 = sentence.Replace(" ","-"); //Cümle içindeki boşlukları - harfine çevirir.
            var result13 = sentence.Remove(2,5); //Cümle içinde 2.indexten itibaren 5 tane harf siler. Eğer 2 yazarsan ilk 2 harfe kadar tüm yazıyı siler.
            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string City = "Ankara";
            //Console.WriteLine(City[0]);

            foreach (var item in City)
            {
                Console.WriteLine(item);
            }

            String City2 = "İstanbul";
            Console.WriteLine(String.Format("{0} {1}", City, City2));
        }
    }
}
