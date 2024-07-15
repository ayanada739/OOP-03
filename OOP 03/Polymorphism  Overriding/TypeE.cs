using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Polymorphism__Overriding
{
    // Type A ==> Indirect Parent
    // Type B ==> Indirect Parent
    // Type C ==> Indirect Parent
    // Type D ==> direct Parent


    internal class TypeE : TypeD
    {

        public int E { get; set; }

        public TypeE(int a, int b, int c, int d, int e) : base(a, b, c, d)
        {
            E = e;
        }


        // In TypeD MyFun02() public new -->You Can Not Overriding Using Keyword Override 
        // In TypeD MyFun02() public new virsual -->You Can Overriding Using Keyword Override 


        public override void MyFun02()
        {

            Console.WriteLine($"TypeE : A = {A} , B = {B} , C = {C} , D = {D} , E = {E}");

        }



    }
}
