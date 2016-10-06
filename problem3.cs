using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 6;
            numbers[2] = 8;
            numbers[3] = 2;
            numbers[4] = 11;

            Console.WriteLine("Max: " + Max(numbers) + "\n" + "Min: " + Min(numbers) + "\n" + "Mean: " + Average(numbers));
            Console.ReadLine();
        }

        //gets the max number in an int array
        static int Max(int[] funArray)
        {
            return funArray.Max();
        }

        //gets the min number in an int array
        static int Min(int[] funArray)
        {
            return funArray.Min();
        }

        //gets the average(mean) in an int array
        static float Average(int[] funArray)
        {
            int sum = 0;
            int numOfValues = 0;
            foreach (int value in funArray)
            {
                sum += value;
                numOfValues++;
            }
            return ((float)sum/(float)numOfValues);
        }


    }
}
