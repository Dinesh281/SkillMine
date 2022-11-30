using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.WhileLoop
{
    class SumOfOddNum
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;
            while (i <= 20)
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;
                }
                i++;
            }
            Console.WriteLine("Sum Of Odd Number between 1 To 20 is " + sum);
        }

    }
}
