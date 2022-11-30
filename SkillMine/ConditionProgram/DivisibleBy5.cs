using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram
{
    class DivisibleBy5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
                Console.WriteLine("Number is Divisible by 5");
            else
                Console.WriteLine("Number is Not Divisible by 5");
        }
    }
}
