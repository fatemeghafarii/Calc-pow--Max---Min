using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
namespace Projectofc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a base number: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a pow number: ");
            double powNum = Convert.ToDouble(Console.ReadLine());
            var numPow = NumPow(baseNum, powNum);
            Console.WriteLine($"result is: {numPow}");

            var num = GetValueArray();
            Console.WriteLine($"Max num is: {num}");
        }
        static double NumPow(double baseNum, double powNum)
        {
            if(powNum == 0)
            return 1;
            return baseNum * NumPow(baseNum, powNum - 1);
            
        }
        static double GetValueArray()
        {
            double[] nums = new double[10];
            int i;
            int round = 0;
            for(i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Enter a num (round {++round}): ");
                nums[i] = Convert.ToDouble(Console.ReadLine());
            }
            double resultMax = nums.Max();
            double resultMin = nums.Min();
            Console.WriteLine($"Min num is: {resultMin}");
            return resultMax;
        }
    }    
}
