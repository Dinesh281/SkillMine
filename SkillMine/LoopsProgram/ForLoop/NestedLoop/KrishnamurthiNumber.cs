using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop.NestedLoop
{
    class KrishnamurthiNumber
    {
        static void Main(string[] args)
        {
            int num, sum=0, fact, temp;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                fact = 1;
                int r = num % 10;
                for(int i = r; i >= 1; i--)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " is a Krishnamurthi Number");
            }
            else
            {
                Console.WriteLine(temp + " is Not a Krishnamurthi Number");
            }
        }
    }
}
