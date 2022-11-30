using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop
{
    class CountOddNum
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 1; i <= 20; i++)
            {
                if(i%2==1)
                count++;
            }
            Console.WriteLine("Count of Odd number 1 to 20 is " + count);
        }
    }
}
