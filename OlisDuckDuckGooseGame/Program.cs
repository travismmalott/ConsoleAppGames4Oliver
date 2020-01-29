using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OlisDuckDuckGooseGame
{
    using System;

    public class Program
    {
        private static string[] duckOrGoose = new string[] { "duck", "DUCK!", "duuuuuck", "Quack Quack I'm a duck!", "el pato", "QUACK!", "Shmuck, I mean Duck", "Lucky Duck!", "DUCK", "GOOOOOOOOSE! RUN!" };
        private static int randomIndex = -1;
        private static String UserInput = "";
        public static void Main()
        {
            Console.WriteLine("Welcome to the Duck, Duck, Goose game. You know what to do, if you're a duck, stay put and keep playing.");
            Console.WriteLine();
            Console.WriteLine("But!");
            Console.WriteLine();
            Console.WriteLine("If the wise, all powerful computer deems you a GOOSE, you better start to run!");
            Console.WriteLine();
            Console.WriteLine("Would you like to play?");
            Console.ReadLine();
            Console.WriteLine("So what will it be? Duck, duck, or Goose? Please type [D/G] to see what the computer believes you to be...");
            for (; ; )
            {
                ShowQuestion();
            }
        }
        private static void ShowQuestion()
        {
            Random rd = new Random();
            randomIndex = rd.Next(0, duckOrGoose.Length);
            getAnswer();
        }
        private static void getAnswer()
        {
            UserInput = Console.ReadLine();
            checkAnswer();
        }
        private static void checkAnswer()
        {
            Console.WriteLine(duckOrGoose[randomIndex]);
        }
    }
}
