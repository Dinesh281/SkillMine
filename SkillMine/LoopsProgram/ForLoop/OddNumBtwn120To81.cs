using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop
{
    class OddNumBtwn120To81
    {
        static void Main(string[] args)
        {
            for(int i = 120; i >= 81; i--)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
