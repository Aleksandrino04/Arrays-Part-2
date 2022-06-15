using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int index = 0; index < firstArr.Length; index++)
            {
                if (firstArr[index] != secondArr[index])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index.");
                    return;
                }
                else
                {
                    Console.WriteLine();

                }
            }


        }
    }
}
