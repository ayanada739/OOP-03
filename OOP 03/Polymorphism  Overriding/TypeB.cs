using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Polymorphism__Overriding
{
    internal class TypeB : TypeA
     {
        public int B { get; set; }

        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }


        //Overriding
        //    1. Using New Keyword
        //    2. Using Override Keyword


        //    Apply Function Overriding Using New Keyword
        //Static Binding [Early Binding]
        //MyFun01() ==>Static Bonded Mettod
        //Static Binding Work During Compile Time
        //Compiler will Bind Function Call Based On Reference Type Not Object Type
        public new void MyFun01() //new version from MyFun01()
        {
            Console.WriteLine("I am Derived [Child]");
        }


        //Apply Function Overriding Using New Keyword
        //Function Must Be Public -Virsual
        //Dynamic Binding [Late Binding]
        //MyFun02()==> Dynamic Bonded Method
        //Dynamic Binding Work During Run Time
        //Compiler will Bind Function Call Based On Object Type Not Reference Type

        public new void MyFun02()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }



    }
}
