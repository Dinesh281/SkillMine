using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram
{
    class DaysProgram
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Days Number 1 to 7");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Day is Monday");
            }
            else if (num == 2)
            {
                Console.WriteLine("Day is Tuesday");
            }
            else if (num == 3)
            {
                Console.WriteLine("Day is Wednesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("Day is Thursday");
            }
            else if (num == 5)
            {
                Console.WriteLine("Day is Friday");
            }
            else if (num == 6)
            {
                Console.WriteLine("Day is Saturday");
            }
            else if (num == 7)
            {
                Console.WriteLine("Day is Sunday");
            }else
            {
                Console.WriteLine("Enter Valid Days Number...!!!!");
            }
        }
    }
}
