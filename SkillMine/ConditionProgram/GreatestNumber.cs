using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram
{
    class GreatestNumber
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.WriteLine("Enter 3 Number");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Greatest Number is " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Greatest Number is " + num2);
            }else
            {
                Console.WriteLine("Greatest Number is " + num3);
            }
        }
    }
}
