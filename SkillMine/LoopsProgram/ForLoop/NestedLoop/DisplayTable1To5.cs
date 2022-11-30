using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop.NestedLoop
{
    class DisplayTable1To5
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("/////////////////");
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
            }
        }
    }
}
