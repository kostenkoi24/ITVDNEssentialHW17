using System;

namespace Homework17_5
{

    class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        
    }

    class Program
    {

        static void Main(string[] args)
        {

            dynamic calculator = new Calculator();

            Console.WriteLine(calculator.Add(20, 10));

            Console.WriteLine(calculator.Add("2", 2));


            Console.ReadKey();


        }
    }
}
