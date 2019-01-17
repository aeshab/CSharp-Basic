using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_1
{
    class pattern2
    {
        public static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
