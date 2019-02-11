using System;
namespace Course.Entities
{
    public class Employee
    {
        //Defined the variables
        public String Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        //Created the constructor without arguments
        public Employee()
        {
        }

        //Created the constructor with arguments
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //Created a method to calculate the Salary of the employee
        public virtual double Payment()
        {
           return Hours * ValuePerHour;
        }



    }
}
