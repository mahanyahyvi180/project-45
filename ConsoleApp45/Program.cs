using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Employee before instantiation:{Employee.Count}");

            var e1 = new Employee("susan", "Baker");
            var e2 = new Employee("Bob", "Blue");

            Console.WriteLine($"Employee after instantiation:{Employee.Count}");

            Console.WriteLine($"\nEmployee 1:{e1.FirstName}{e1.LastName}");
            Console.WriteLine($"Employee 2:{e2.FirstName}{e2.LastName}");
            Console.ReadLine();

            e1 = null;
            e2 = null;


        }
    }
}

