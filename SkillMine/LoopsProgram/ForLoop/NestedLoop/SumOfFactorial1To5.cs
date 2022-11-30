using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop.NestedLoop
{
    class SumOfFactorial1To5
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 5; i++)
            {
                int fact = 1;
                for(int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }
                sum = sum + fact;
            }
            Console.WriteLine("Sum of Factorial from 1 To 5 is " + sum);
        }
    }
}
