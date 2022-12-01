using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class DisplayAlternateNum
    {
        public void AlterNumber(int[] b)
        {
            Console.WriteLine("After Altering Number in array is");
            for(int i = 0; i < b.Length; i++)
            {
                b[i] = b[i] + 2;
            }
            Console.WriteLine(string.Join(" ", b));
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
            DisplayAlternateNum d = new DisplayAlternateNum();
            d.AlterNumber(a);
        }
    }
}
