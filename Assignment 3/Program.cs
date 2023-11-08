using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment 3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employeename");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Employeegender");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            DateTime doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID\tEmployee Name\tEmployee Gender\tEmployee Salary\t\tDOJ");
            Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t{salary:C2}\t\t{doj:MM/dd/yyyy}");
            if (salary > 90000)
            {
                Console.WriteLine("You have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("You have to pay 15% tax");
            }
            Console.ReadKey();


        }
    }
}



