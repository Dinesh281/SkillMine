using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop.NestedLoop
{
    class PrimeNumBtw1To20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number 1 To 20 are:");
            for(int i = 1; i <= 20; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && i != 1 && i !=2 )
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
