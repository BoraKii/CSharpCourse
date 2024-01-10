using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 201;
            /*Console.WriteLine(number == 10 ? "number is 10" : "number is not 10"); */ //single line if
            //if (number == 10)
            //{
            //    Console.WriteLine("number is 10");
            //}else if(number == 20)
            //{
            //    Console.WriteLine("number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("number is not 10 or 20");
            //}

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("number is 10");
            //        break; //olayı kes
            //    case 20:
            //        Console.WriteLine("number is 20");
            //        break; //olayı kes
            //    default:
            //        Console.WriteLine("number is not 10 or 20");
            //        break; //olayı kes
            //}

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }else if(number>100 && number <= 200)
            {
                Console.WriteLine("Number is between 100-200");
            }else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }
            
            Console.ReadLine();
        }
    }
}
