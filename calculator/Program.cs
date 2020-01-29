using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            int y = 0;

            bool b = true;



            List<string> operators = new List<string>();

            operators.Add("+");

            operators.Add("-");

            operators.Add("/");

            operators.Add("*");

            operators.Add("%");





            while (b)
            {



                Console.Write("please input the first number you'd like to calculate - ");

                var first_operand = Console.ReadLine();

                if (Int32.TryParse(first_operand, out x))
                {

                    b = false;

                }

                else
                {

                    Console.WriteLine("invalid input, please try again");

                }

            }

            b = true;



            while (b)
            {

                Console.Write("please input the second number you'd like to calculate - ");

                var first_operand = Console.ReadLine();

                if (Int32.TryParse(first_operand, out y))
                {

                    b = false;

                }

                else
                {

                    Console.WriteLine("invalid input, please try again");

                }



            }

            b = true;

            while (b)
            {

                Console.Write("please input the operator you wish to use - ");

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

                    b = false;

                }

                else
                {

                    Console.WriteLine("invalid operator, please try again");

                }
            }
        }
    }
}