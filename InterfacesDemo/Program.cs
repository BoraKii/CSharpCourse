using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robots()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eating = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };
            foreach (var eat in eating)
            {
                eat.Eat();
            }

            ISalary[] salarying = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salarying)
            {
                salary.Salary();
            }
            Console.ReadLine();
        }

        interface IWorker
        {
            void Work();
        }
        //SOLID, Interface Segregation
        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void Salary();
        }

        class Manager : IWorker, IEat, ISalary
        {
            public void Work()
            {
                Console.WriteLine("Managers are working");
            }

            public void Eat()
            {
                Console.WriteLine("Managers are eating");
            }

            public void Salary()
            {
                Console.WriteLine("Managers are salarying");
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Work()
            {
                Console.WriteLine("Workers are working");
            }
            public void Eat()
            {
                Console.WriteLine("Workers are eating");
            }

            public void Salary()
            {
                Console.WriteLine("Workers are salarying");
            }
        }

        class Robots : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robots are working");
            }
        }




    }
}
