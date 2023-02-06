using System;

namespace Homework17_5
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic operand1 = double.NaN, operand2 = double.NaN;
            string user_input = default;
            char[] signs = new char[] { '+', '-', '*', '/' };
            bool op1 = false, op2 = false, sgn = false;


            do
            {
                if (op1 == false)
                {
                    Console.Write("Enter operand1:");
                    user_input = Console.ReadLine();
                    op1 = CheckInput(user_input);
                    operand1 = (op1 == true ? Convert.ToDouble(user_input) : double.NaN);
                }

                if (op1 == true && op2 == false)
                {
                    Console.Write("Enter operand2:");
                    user_input = Console.ReadLine();
                    op2 = CheckInput(user_input);
                    operand2 = (op2 == true ? Convert.ToDouble(user_input) : double.NaN);
                }

                if (op1 == true && op2 == true && sgn == false)
                {
                    Console.Write("Select sign ( ");
                    foreach (char ch in signs)
                    {
                        Console.Write(ch + " ");
                    }
                    Console.Write(" ) : ");

                    user_input = Console.ReadLine();

                    var p = Array.IndexOf(signs, Convert.ToChar(user_input));

                    if (p != -1)
                    {
                        if (operand2 == 0 && p == 3)
                        {
                            Console.WriteLine("Dividing by zero!");
                            op2 = false;
                        }
                        else
                        {
                            sgn = true;
                        }
                    }
                }

            } while (op1 == false || op2 == false || sgn == false);



            switch (user_input)
                {
                    case "+":
                        Console.WriteLine("Result of {0} {1} {2} = {3}", operand1, user_input, operand2, (Calculator.Add(operand1, operand2)));
                        break;
                    case "-":
                        Console.WriteLine("Result of {0} {1} {2} = {3}", operand1, user_input, operand2, (Calculator.Sub(operand1, operand2)));
                        break;
                    case "*":
                        Console.WriteLine("Result of {0} {1} {2} = {3}", operand1, user_input, operand2, (Calculator.Mul(operand1, operand2)));
                        break;
                    case "/":
                        Console.WriteLine("Result of {0} {1} {2} = {3}", operand1, user_input, operand2, (Calculator.Div(operand1, operand2)));
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }


           Console.ReadKey();
  
        }

        public static bool CheckInput(string p)
        {

            try
            {
                Convert.ToDouble(p);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
