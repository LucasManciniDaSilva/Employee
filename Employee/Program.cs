using System;
using System.Collections.Generic;
using Course.Entities;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a List 
            List<Employee> list = new List<Employee>();

            //Created the interaction with the user
            Console.Write("Enter the numbers of employess: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced? (Y/N): ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("ValuePerHour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                //Created an "If" to define if the employee is Outsourced or not
                if ( c == 'Y')
                {
                    Console.Write("Additional Charge: ");
                    double additional = double.Parse(Console.ReadLine());
                    list.Add(new OutsourceEmployee(name, hours, valuePerHour, additional));
                }

                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                }

            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - " + emp.Payment().ToString());

            }

        }
    }
}
