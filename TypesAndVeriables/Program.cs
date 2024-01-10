using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVeriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");
            //byte = 1bit, short = 16bit, int = 32bit, long = 64bit bellekte yer kaplar.
            //long sınırı -9223372036854775808 ve 9223372036854775807
            int number1 = 2147483647; //int sınırı -2147483648 ve +2147483647 sayısı alabileceği son değer
            long number2 = -9223372036854775808; //long veri tipi, int'e göre bellekte 2 kat daha fazla yer kaplar.
            short number3 = -32768; //short sınırı -32768 ve 32767
            byte number4 = 255; //byte sınırı 0 ve 255 arasındadır.
            bool condition = true; //Mantıksal veri tipi , true veya false
            char character = 'A';
            double number5 = 10.4; //Ondalıklı mantıksal veri tipi , bellekte 64 bitlik bir veri tutuşu sağlar.
            decimal number6 = 10.5m; //Ondalıklı 28-29 satır sayı yazılabilir.
            var number7 = 10;
            number7 = 'B'; //int veri tipine çevirdi.
            string city = "Ankara";
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine((int)Days.Monday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=3,Tuesday=10,Wednesday,Thursday,Friday,Saturday
    }
}
