using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Binding
{
    internal class FullTimeEmployee :Employee
    {
        public decimal Salary { get; set; }


        public FullTimeEmployee(int id, string name, int age, decimal salary) :base (id , name , age)
        { 
            Salary = salary;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am FullTimeEmployee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"FullTimeEmloyee :  Id = {Id} , Name = {Name} , Age = {Age} , Salary = {Salary}");
        }


    }
}
