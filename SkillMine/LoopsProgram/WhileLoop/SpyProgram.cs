using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.WhileLoop
{
    class SpyProgram
    {
        static void Main(string[] args)
        {
            int num, sum = 0, prd = 1;
            Console.WriteLine("Enter NUmber ");
            num = int.Parse(Console.ReadLine());
            int temp = num;
            while (num != 0)
            {
                int r = num % 10;
                sum = sum + r;
                prd = prd * r;
                num = num / 10;
            }
            if (sum == prd)
            {
                Console.WriteLine(temp + " is a SPY Number");
            }
            else
            {
                Console.WriteLine(temp + " is Not a SPY Number");
            }
        }
    }
}
