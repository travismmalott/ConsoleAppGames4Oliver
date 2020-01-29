using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = GetUserName();
            Console.WriteLine(name);

            VerifyUserName();
        }
        static string GetUserName()
        {
            string result;
            Console.WriteLine("Please type your username and hit enter...");
            result = Console.ReadLine();
            return result;
        }
        static string VerifyUserName()
        {
            do
            {

            } while (true);
        }
    }
}
