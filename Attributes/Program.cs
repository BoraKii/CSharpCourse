using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Kitirci", Age = 21};
            CustomerDal _customerDal = new CustomerDal();
            _customerDal.AddNew(customer);

            Console.ReadLine();
        }

        [ToTable("Customers")]
        [ToTable("tblCustomers")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty] //FirstName'yi zorunlu kılmak için Attribute kullanıyoruz.
            public string FirstName { get; set; }
            [RequiredProperty]
            public string LastName { get; set; }
            [RequiredProperty]
            public int Age { get; set; }
        }

        class CustomerDal
        {
            [Obsolete("Dont use Add, instead AddNew Method.")] //Bu kodun eskidiğini, yeni kodu kullanman gerektiğini söyler.
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added!", customer.Id,customer.FirstName,customer.LastName,customer.Age);
            }

            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
        }

        [AttributeUsage(AttributeTargets.Property)] //Sadece property de kullanabilirsin.
        class RequiredPropertyAttribute : Attribute
        {

        }

        [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)] //Sadece class da kullanabilirsin(AttributeTargets.Class) ve çoklu olarak kullanabilirsin.(AllowMultiple)
        class ToTableAttribute : Attribute
        {
            private string _tableName;

            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;
            }
        }

    }
}
