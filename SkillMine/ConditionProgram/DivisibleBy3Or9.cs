using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram
{
    class DivisibleBy3Or9
    {
      static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            if (num % 3 == 0)
            {
                if (num % 9 == 0)
                {
                    Console.WriteLine("Number is Divisible by 3 & 9");
                }
                else
                {
                    Console.WriteLine("Number is Divisible by 3");
                }
            }
            else
            {
                Console.WriteLine("Number is Not Divisible by 3 & 9");
            }
        }
    }
}
