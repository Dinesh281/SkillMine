using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.WhileLoop
{
    class Sum1To20
    {
        static void Main(string[] args)
        {
            int i = 1,sum=0;
            while (i <= 20)
            {
                sum = sum + i;
                if (sum > 10)
                {
                    break;
                }
                Console.WriteLine(sum);
                i++;
            }
        }
    }
}
