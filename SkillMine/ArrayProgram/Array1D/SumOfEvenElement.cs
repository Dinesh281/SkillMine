using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class SumOfEvenElement
    {
        public void SumOfEven(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("Sum Of Even element from array is  " + sum);
        }
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("Enter 6 element of array");
            for(int i = 0; i < 6; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            SumOfEvenElement s = new SumOfEvenElement();
            s.SumOfEven(a);
        }
    }
}
