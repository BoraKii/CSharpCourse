using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 35;
            int number2;
            int x = 5;
            Console.WriteLine(Add(ref number1, out number2));
            Console.WriteLine(Add2(ref x,3,5,6,7,9,10));

            string[] developer = new string[3];
            developer[0] = "Bora";
            developer[1] = "Bensu";
            developer[2] = "Engin";

            foreach(var developers in developer)
            {
                Console.WriteLine(developers);
            }

            string[] developer2 = new string[3] { "Bora","Bensu","Engin" };
            string[] developerr = { "\nBora", "Bensu", "Engin" };

            foreach (var developerrs in developerr)
            {
                Console.WriteLine(developerrs);
            }

            string[,] regions = new string[5, 3]
            {
                { "\nİstanbul", "İzmit", "Balıkesir" },
                { "Ankara","Eskisehir","Konya" },
                { "Antalya","Adana","Mersin" },
                { "Rize","Trabzon","Samsun" },
                { "İzmir","Muğla","Manisa" }
            };

            for (int i=0; i <= regions.GetUpperBound(0); i++)
            {
                for(int j=0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********");
            }
            Console.ReadLine();
        }

        static int Add(ref int number1, out int number2)
        {
            number1 = 13;
            number2 = 30;
            var number = number1 + number2;
            return number;
        }

        static int Add2(ref int x, params int[] number2)
        {
            x = 10;
            return number2.Sum() + x;
        }

    }
}