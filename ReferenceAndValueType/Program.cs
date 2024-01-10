using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30; //boş değer

            Console.WriteLine(number2);

            string[] cities1 = new string[]{"Ankara","Adana","Afyon"}; //referans numarasının 101 olduğunu varsayalım.
            string[] cities2 = new string[]{"Bursa","Bolu","Balıkesir"}; //Garbage Collector (çöp toplayıcı)
            //aşağıda referans numarası 102 den 101 oluyor ve bu bir performans işlemidir.
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable;
            DataTable dataTable2 = new DataTable(); //new kullanmak proje de yüklü performans kullanır.
            dataTable = dataTable2; //2 tane new kullanmaktansa bu şekilde kullanım performans artışı sağlar.

            Console.ReadLine();
        }
    }
}
