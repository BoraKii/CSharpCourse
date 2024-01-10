using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>( "Ankara", "İzmir", "Adana");

            foreach (var items in result)
            {
                Console.WriteLine(items);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName = "Bora"}, new Customer{FirstName = "Bensu"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }

        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }

        interface IProductDal : IRepository<Product>
        {
            
        }

        interface ICustomerDal : IRepository<Customer> //interface yazıldıktan sonra <T> parametre içerisine gelecek class belirlenir.
        {
            void Custom();
        }

        interface IEntity
        {
            
        }

        class Student : IEntity
        {

        }

        interface IStudentDal : IRepository<Student> // interface IRepository<T> where T: class,IEntity,new()  --> olsaydı burası veritabanına özel interface olarak çalışırdı.
        {

        }

        interface IRepository<T> //<T> şeklinde generic ettik.
        { //IEntity veritabanı işlemlerine denk gelir. (interface şeklindeyse) //sadece class olsaydı referans tiplere karşı gelir. (string vs.) //struct değer tiplere karşı gelid. (int vs.)
            T GetAll();
            T Get(int id);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
        }

        class Customer 
        {
            public string FirstName { get; set; }
        }

        class Product : IProductDal
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public Product GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }
    }
}
