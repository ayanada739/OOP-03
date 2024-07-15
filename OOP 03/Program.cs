using OOP_03.Polymorphism__Overriding;
using System;

namespace OOP_03
{
    internal class Program
    {


        #region Overloading
        //Method Overloading Using Just For Readability

        public static double Sum(double X, double Y)
        {
            return X + Y;
        }

        public static int Sum(int X, int Y)
        {
            return X + Y;
        }

        public static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }

        public static double Sum(int X, double Y)
        {
            return X + Y;
        }

      
        public static double Sum(double X , int Y)
        {
            return X + Y;
        }

        #endregion


        static void Main(string[] args)
        {

            #region Polymorphism (Overloading)

            //int Result = Sum(1, 2);
            //Console.WriteLine($"Result={Result}"); //3

            //Result = Sum(1, 2 , 3);
            //Console.WriteLine($"Result={Result}"); //6

            //double Result02 = Sum(1.2, 2.2);
            //Console.WriteLine($"Result={Result02}"); //3.40

            //Result02 = Sum(2, 2.2);


            //Console.WriteLine(1);
            //Console.WriteLine(1.2);
            //Console.WriteLine(1.2M);
            //Console.WriteLine(1.2F);
            //Console.WriteLine("3");
            //Console.WriteLine('3');
            #endregion


            #region Polymorphism [Overriding]
            //// Supported With Class ONLY
            //// Function Overriding Must be With Relationship [Inheritance]

            //TypeA typeA = new TypeA(1);
            //typeA.A = 10;
            //typeA.MyFun01(); //I am Base [Parent]
            //typeA.MyFun02(); //TypeA : A = 10 

            //Console.WriteLine("======================");

            //TypeB typeB = new TypeB(1 , 2);
            //typeB.A = 10;
            //typeB.B = 20;
            //typeB.MyFun01(); //I am Derived [Child]
            //typeB.MyFun02(); //TypeB : A = 10 , B = 20

            #endregion



        }
    }
}
