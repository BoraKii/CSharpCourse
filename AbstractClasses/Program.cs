using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer(); //Abstract olan classta new kullanamazsın. (SqlServer kullandım)
            database.Add();
            database.Delete();
            Database database2 = new Oracle(); //Abstract olan classta new kullanamazsın. (Oracle kullandım)
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }

        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Added by default"); //Burası abstract olmadığı için Add(); kullanıldığında bu tanım çalışır.
            }

            public abstract void Delete(); //Her yerde farklı tanımda kullanmana yarar.
        }

        class SqlServer : Database
        {
            public override void Delete() //Yukarıda abstract olarak tanımladığın Delete kodunu her database abstract classını almış classta tanımlamalısın.
            {
                Console.WriteLine("Deleted by Sql");
            }
        }

        class Oracle : Database
        {
            public override void Delete() //Yukarıda abstract olarak tanımladığın Delete kodunu her database abstract classını almış classta tanımlamalısın.
            {
                Console.WriteLine("Deleted by Oracle");
            }
        }
    }
}
