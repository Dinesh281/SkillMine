using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class SumOfElement
    {
        public void Sum(int[] b)
        {
            int sum = 0;
            for(int i = 0; i < b.Length; i++)
            {
                sum = sum + b[i];
            }
            Console.WriteLine("Sum of Element in array is " + sum);
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
            SumOfElement s = new SumOfElement();
            s.Sum(a);
        }
    }
}
