using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram.SwitchProgram
{
    class CheckEvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            switch (num % 2 == 0)
            {
                case true:Console.WriteLine(num + " is a Even Number");
                    break;
                case false:Console.WriteLine(num + " is a Odd Number");
                    break;
            }

        }
    }
}
