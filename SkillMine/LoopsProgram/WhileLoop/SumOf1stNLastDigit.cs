using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.WhileLoop
{
    class SumOf1stNLastDigit
    {
        static void Main(string[] args)
        {
            int num, first=0, last;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            last = num % 10;
            while (num != 0)
            {
                first = num % 10;
                num = num / 10;
            }
            Console.WriteLine("Sum of 1st N Last Digit from Number is "+(first+last));
        }
    }
}
