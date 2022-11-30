using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.WhileLoop
{
    class CountDigitFromNum
    {
        static void Main(string[] args)
        {
            int num, count=0;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                int r = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine("No of Digit in Number is " + count);

        }
    }
}
