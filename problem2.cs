using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            mulTable(7);
            Console.ReadLine();
        }

        static void mulTable(int k)
        {
            int currentNum = 1;

            for (int j = currentNum; j <= k; j++)
            {
                for (int i = 1; i <= k; i++)
                {
                    Console.Write((currentNum * i) + " ");
                }

                Console.WriteLine();
                currentNum++;
            }
        }

    }
}
