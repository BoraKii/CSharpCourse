using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(10);
            //int number1 = 20;
            //int number2;
            //var result2 = Add3(ref number1, out number2);
            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.WriteLine(number2);
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int x,int number1=20, int number2=30)
        {
            //return number1 + number2; or
            var result = x * number1 + number2;
            return result;
        }
        static int Add3(ref int number1, out int number2)
        {
            number1 = 75;
            number2 = 35;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(int number1, params int[] numbers) //number1 (1,2,3,4) de ki 1 olan kısmı kapsar.
        {
            return numbers.Sum();
        }
   
    }
}
