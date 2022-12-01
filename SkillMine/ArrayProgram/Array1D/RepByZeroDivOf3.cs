using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class RepByZeroDivOf3
    {
        public void DivBy3(int[] c)
        {
            Console.WriteLine("After Replaceing Element Divisible By 3 is");
            for(int i = 0; i < c.Length; i++)
            {
                if (c[i] % 3 == 0)
                {
                    c[i] = 0;
                }
            }
            Console.WriteLine(string.Join(" " , c));
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 Number");
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Given array");
            Console.WriteLine(string.Join(" ", a));
            RepByZeroDivOf3 r = new RepByZeroDivOf3();
            r.DivBy3(a);
        }
    }
}
