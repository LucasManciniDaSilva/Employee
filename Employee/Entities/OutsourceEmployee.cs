using System;
namespace Course.Entities

{
    public class OutsourceEmployee : Employee
    {

        //Defined the variables
        public double AdditionalCharge { get; set; }

        //Created the constructor without arguments
        public OutsourceEmployee()
        {
        }

        //Created the constructor with arguments
        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        //Added a new function to payment if the employee as OutSourced.
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
