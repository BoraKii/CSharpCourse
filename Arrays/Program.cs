using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Bora";
            students[1] = "Bensu";
            students[2] = "Zeynep\n";

            string[] students2 = new string[3] {"Bora2","Bensu2","Zeynep2"};

            string[] students3 = {"Bora3","Bensu3","Zeynep3"};
            foreach(var student in students)
            {
               Console.WriteLine(student);
            }




            string[,] regions = new string[5, 3] {


            {"İstanbul","İzmit","Balıkesir" }, //Marmara Bölgesi
            {"Ankara","Eskisehir","Konya" }, //İç Anadolu Bölgesi
            {"Antalya","Adana","Mersin" }, //Akdeniz Bölgesi
            {"Rize","Trabzon","Samsun" }, //Karadeniz Bölgesi
            {"İzmir","Muğla","Manisa" } //Ege Bölgesi


            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********");
            }
            Console.ReadLine();
        }
    }
}
