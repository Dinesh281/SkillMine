using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop
{
    class SumOfFactors
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of Factor " + num + " is " + sum);
        }
    }
}
