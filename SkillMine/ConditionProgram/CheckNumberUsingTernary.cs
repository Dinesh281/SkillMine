using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram
{
    class CheckNumberUsingTernary
    {
       static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            string sign = num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";
            Console.WriteLine("Number is " + sign);
        }

    }
}
