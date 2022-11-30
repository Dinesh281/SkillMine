using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop
{
    class CalculateSum1To10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum 1 To 10 is " + sum);
        }
    }
}
