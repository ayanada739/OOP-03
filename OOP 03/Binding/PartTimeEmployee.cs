using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Binding
{
    internal class PartTimeEmployee :Employee
    {
        public int CountOfHours { get; set; }

        public int HourRate { get; set; }



        public new void GetEmployeeType()
        {
            Console.WriteLine("I am PartTime Employee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"PrtTimeEmployee :  Id = {Id} , Name = {Name} , Age = {Age} , Count of Hours = {CountOfHours} , Hour Rate {HourRate}");
        }
    }
}
