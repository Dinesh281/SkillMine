using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter Year ");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine(" It's a Leap Year");
            }
            else
            {
                Console.WriteLine("It's Not a Leap Year");
            }
        }
    }
}
