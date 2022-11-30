using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram
{
    class CalculatePercentage
    {
        static void Main(String[] args)
        {
            int num1, num2, num3, num4, num5;
            Console.WriteLine("Enter 5 marks");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());
            float per=((num1+num2+num3+num4+num5)*100)/ 500;
            if (per > 70)
            {
                Console.WriteLine(per + "% Grade is Disticntion");
            }else if (per > 60 && per <= 70)
            {
                Console.WriteLine(per + "% Grade is First Class");
            }else if (per > 50 && per <= 60)
            {
                Console.WriteLine(per + "% Grade is Second Class");
            }else if (per >= 35 && per <= 50)
            {
                Console.WriteLine(per + "% Grade is Pass Class");
            }
            else if (per < 35)
            {
                Console.WriteLine(per + "% Grade is Failed Class");
            }

        }
    }
}
