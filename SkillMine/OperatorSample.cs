using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine
{
    class OperatorSample
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;
            float d;
            Console.WriteLine("Enter Number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(c + a + b);
           // Console.WriteLine("Enter float value");
           // d = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
