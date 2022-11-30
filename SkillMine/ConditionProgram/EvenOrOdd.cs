using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        } 
    }
}
