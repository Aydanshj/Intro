using System;

namespace Homestask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 14;
            int c = 17;

            if (a<=b && b<=c)
            {
                Console.WriteLine(a);               
              
            }
            else if (b<=a && b<=c)
            {
                Console.WriteLine(b);

            }
            else
            {
                Console.WriteLine(c);

            }
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

        //    int max = 0;

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] > max)
        //        {
        //            max = numbers[i];
        //        }

        //    }
        //    Console.WriteLine(max);


        //    int[] nums = { 1, 6, 9, 13, 14 };

        //    int avg = 0;
        //    int count = 0;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] % 3 == 0)
        //        {
        //            avg += nums[i];
        //            count++;

        //        }
        //    }
        //    if (count == 0)
        //    {
        //        Console.WriteLine('There is not divisible by 3');
        //    }
        //    else
        //    {
        //        Console.WriteLine(avg / count);
        //    }

        //    int[] numbers = { 20, 45, 82, 70, 12, 200 };
        //    bool is3Digits = false;

        //    for (int i =0; i<numbers.Length; i++)
        //    {
        //        if (numbers[i] >= 100 && numbers[i] <= 999)
        //        {
        //            is3Digits = true;break;
        //        }
        //    }
        //    if (is3Digits)
        //    {
        //        Console.WriteLine('Yes');
        //    }
        //    else
        //    {
        //        Console.WriteLine('No');
        //    }

        //}
    }
}
