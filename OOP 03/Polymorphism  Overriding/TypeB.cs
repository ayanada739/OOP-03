using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Polymorphism__Overriding
{
    internal class TypeB : TypeA
    {
        //public int B { get; set; }

        //public TypeB(int a, int b) : base(a)
        //{
        //    B = b;
        //}


        ////Overriding
        ////1. Using New Keyword
        ////2. Using Override Keyword


        ////Apply Function Overriding Using New Keyword
        //public new void MyFun01() //new version from MyFun01()
        //{
        //    Console.WriteLine("I am Derived [Child]");
        //}


        ////Apply Function Overriding Using New Keyword
        ////Function Must Be Public -Virsual
        //public new void MyFun02()
        //{
        //    Console.WriteLine($"TypeB : A = {A} , B = {B}");
        //}



    }
}
