using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        class Customer
        {
            private int Id; //private tanımı kullanılan classın içindeki her yerde tanımladığın kodu kullanabileceğin anlamına gelir.
            protected int Id2 { get; set; }
            public void Save()
            {
                Console.WriteLine(Id);
            }
            public void Delete()
            {
                Console.WriteLine(Id2); //protected tanımını kullanılan class içinde ve interitance olan classlarda kullanabiliriz. 
            }
        }

        class Student:Customer
        {
            //Yukarıda private tanımlı Id'yi burada kullanamayız.
            public void Save2()
            {
                Console.WriteLine(Id2); //Id2 kodu inheritance olan classın içinde kullanılmıştır.
            }
        }

        internal class Course //Herhangi bir classın default tipi internal'dir ve sadece bulunduğu proje içinde kullanılır
        {
            public string Name { get; set; }
            //internal classlara herhangi bir dosya içinde erişim sağlanır.
        }

        public class CourseDemo //public bir classı dizinde bulunan bütün dosyalardan, her yerden çektirtebilirsin.
        {
            public string Name { get; set; }
        }

    }
}
