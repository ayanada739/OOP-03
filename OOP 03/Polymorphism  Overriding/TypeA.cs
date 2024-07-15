using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Polymorphism__Overriding
{
    internal class TypeA
    {
        public int A { get; set; }
        // Automatic Property
        // Compiler Will Generate Hidden Private Attr [Backing Field)

        public TypeA(int a)
        {
            A = a;
        }


        // object Member Functions [Non Static Functions)

        public void MyFun01()
        {
            Console.WriteLine("I am Base [Parent]");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }
}
