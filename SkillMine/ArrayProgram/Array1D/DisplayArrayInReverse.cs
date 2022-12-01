using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class DisplayArrayInReverse
    {
        public void RevArray(int[] r)
        {
            Console.WriteLine("After Reversing the Array is ");
            for(int i = 0; i < r.Length/2; i++)
            {
                int temp = r[i];
                r[i] = r[r.Length - i - 1];
                r[r.Length - i - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", r));
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
            DisplayArrayInReverse d = new DisplayArrayInReverse();
            d.RevArray(a);
        }
    }
}
