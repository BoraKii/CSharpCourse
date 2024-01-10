using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
             customerDal.Add();   
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Bora",
                LastName = "Kitirci",
                Address = "Eskisehir"
            };

            Student student = new Student()
            {
                Id = 2,
                FirstName = "Bensu",
                LastName = "Kitirci",
                Department = "Musicology"
            };

            manager.Add(customer);
            manager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Department { get; set; }

        }

        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Department { get; set; }

        }

        class PersonManager
        {
            public void Add(IPerson person) //IPerson interfacesini kapsayan bütün classları çektirtir.
            {
                Console.WriteLine(person.FirstName);
            }

            public void Add2(Customer customer) //Parametre olarak bana bir müşteri nesnesi ver anlamına gelir.
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
}
