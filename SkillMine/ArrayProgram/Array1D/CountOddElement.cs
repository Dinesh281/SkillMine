using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class CountOddElement
    {
        public void CountOdd(int[] a)
        {
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Count Of Odd element from array is  " + count);
        }
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("Enter 6 element of array");
            for (int i = 0; i < 6; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            CountOddElement s = new CountOddElement();
            s.CountOdd(a);
        }
    }
}
