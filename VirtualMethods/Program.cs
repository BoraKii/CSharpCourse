using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class SqlServer : Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by Sql Code"); //Yeni ekleme işlemi
                //base.Add(); //Database classının içindeki kodları çeker
            }
        }

        class MySql : Database
        {
            //Herhangi bir ekleme kodu yoksa database sınıfının içindeki kod döner.
        }

    }
}