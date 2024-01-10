using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal // Dal kelimesi veritabanı işlemleri yapılırken kullanılır.
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal //SQL veritabanı işlemleri
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class OracleCustomerDal : ICustomerDal //Oracle veritabanı işlemleri
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class MySqlServerCustomerDal : ICustomerDal //SQL veritabanı işlemleri
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
    }

    class CustomerManager //Main dosyaya gönderip işlem yaptırdığımız class
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
