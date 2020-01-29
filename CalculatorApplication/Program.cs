using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            int y = 0;

            bool calculator = true;

            List<string> operators = new List<string>();

            operators.Add("+");

            operators.Add("-");

            operators.Add("/");

            operators.Add("*");

            operators.Add("%");

            while (calculator)
            {
                Console.WriteLine("please input the first number you'd like to be calculated");

                var first_operand = Console.ReadLine();

                if (Int32.TryParse(first_operand, out x))
                {
                    calculator = false;
                }
                else
                {
                    Console.WriteLine("invalid input, please try again");
                }
            }
            calculator = true;

            while (calculator)
            {
                Console.WriteLine("please input the second number you'd like to be calculated");

                var first_operand = Console.ReadLine();

                if (Int32.TryParse(first_operand, out y))
                {
                    calculator = false;
                }
                else
                {
                    Console.WriteLine("invalid input, please try again");
                }
            }
            calculator = true;

            while (calculator)
            {
                Console.WriteLine("please input your desired operator");

                var oprtr = Console.ReadLine();

                if (operators.Contains(oprtr) == true)
                {
                    if (oprtr == "+")
                    {
                        Console.WriteLine($"the answer is {x + y}");
                    }
                    if (oprtr == "-")
                    {
                        Console.WriteLine($"the answer is {x - y}");
                    }
                    if (oprtr == "/")
                    {
                        Console.WriteLine($"the answer is {x / y}");
                    }
                    if (oprtr == "*")
                    {
                        Console.WriteLine($"the answer is {x * y}");
                    }
                    if (oprtr == "%")
                    {
                        Console.WriteLine($"the answer is {x % y}");
                    }
                    calculator = false;
                }

                else
                {
                    Console.WriteLine("invalid operator, please try again");
                }
            }
        }
    }
}