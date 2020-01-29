using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8x8chessboard
{
    class Program
    {
        static void Main(string[] args)
        {
            string chessmatch = "";
            Console.WriteLine("Do you want to play a game of chess? I'm horrible I swear... y or n?");
            chessmatch = Console.ReadLine();
                switch(chessmatch)
                {
                case "y":
                case "Y":
                    {
                        int i = 0;
                        int line = 0;
                        for (line = 0; line < 8; line++)
                        {
                            if (line % 2 == 0)
                            {
                                for (i = 0; i <= 8; i++)
                                {
                                    if (i % 2 == 0)
                                    {
                                        Console.Write("X");
                                    }
                                    else
                                        Console.Write("O");
                                }
                            }
                            else if (line % 2 != 0)
                            {
                                for (i = 0; i <= 8; i++)
                                {
                                    if (i % 2 == 0)
                                    {
                                        Console.Write("O");
                                    }
                                    else
                                        Console.Write("X");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case "n":
                case "N":
                    Console.Write("Well that's too bad, have a great day, HUMAN.");
                    break;
                default:
                    Console.WriteLine("That's an invalid entry, oops! Goodbye.");
                    break;
                }
        }
    }
}
