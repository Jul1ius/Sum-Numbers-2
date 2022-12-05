using System;

namespace sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < num)
            {
                int numNow = int.Parse(Console.ReadLine());
                sum += numNow;
            }
            Console.WriteLine(sum);
        }
    }
}
