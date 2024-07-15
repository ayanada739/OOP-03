﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_03.Binding
{
    internal class Employee
    {
        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public Employee()
        { 
        
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
        public  void GetEmployeeType()
        {
            Console.WriteLine("I am Employee");
        }

        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"Employee : Id = {Id} ,Name = {Name} ,Age = {Age}");

        }



    }
}
