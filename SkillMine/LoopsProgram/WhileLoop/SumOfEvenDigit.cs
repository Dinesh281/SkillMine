using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.WhileLoop
{
    class SumOfEvenDigit
    {
        static void Main(string[] args)
        {
            int num,sum=0;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                int r = num % 10;
                if (r % 2 == 0)
                    sum = sum + r;
                num = num / 10;
            }
            Console.WriteLine("Sum of Even Digit from Number " + sum);
        }
    }
    class CountOfOddDigit
    {
        static void Main(string[] args)
        {
            int num, count = 0;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                int r = num % 10;
                if (r % 2 != 0)
                    count++;
                num = num / 10;
            }
            Console.WriteLine("Count of Odd Digit from Number " + count);
        }
    }
}
