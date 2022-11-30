using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.WhileLoop
{
    class Trimorphic
    {
        static void Main(string[] args)
        {
            int num, cube = 1;
            bool istrimorphic = true;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            int temp = num;

            cube = num * num * num;
            Console.WriteLine(cube);
            while (temp > 0)
            {
                if (temp % 10 != cube % 10)
                {
                    istrimorphic = false;
                    break;
                }
                temp = temp / 10;
                cube = cube / 10;
            }
            if (istrimorphic)
            {
                Console.WriteLine(num + " ia a Trimorphic Number.");
            }
            else
            {
                Console.WriteLine(num + " is Not a Trimorphic Number.");
            }

        }
    }
}
