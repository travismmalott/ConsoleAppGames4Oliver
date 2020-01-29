using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oliver_s_Duck_Duck_Goose
{
   class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (x = 0; x <= 7; x++)
            {
                Console.WriteLine("Duck");
            }
            if (x == 7)
            {
                x++;
            }
            if (x == 8)
            {
                Console.WriteLine("Goose");
            }
            Console.ReadKey();

        }
    }
}
