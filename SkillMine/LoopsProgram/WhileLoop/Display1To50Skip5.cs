using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.WhileLoop
{
    class Display1To50Skip5
    {
       static void Main(string[] args)
        {
            int i = 1;
            while (i <= 50)
            {
                if (i % 5 != 0)
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
