using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class EvenOdd
    {
        public void checkEvenOdd(int[] b)
        {
            int[] even = new int[10];
            int[] odd = new int[10];
            int e = 0, o = 0;
            for(int i = 0; i < 10; i++)
            {
                if (b[i] % 2 == 0)
                {
                    even[e] = b[i];
                    e++;
                }
                else
                {
                    odd[o] = b[i];
                    o++;
                }
            }
            Console.WriteLine("Even Number array");
            for(int i = 0; i < e; i++)
            {
                Console.Write(even[i]+" ");
            }
            Console.WriteLine("\nOdd Number array");
            for(int i = 0; i < o; i++)
            {
                Console.Write(odd[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 element in array ");
            for(int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            EvenOdd e = new EvenOdd();
            e.checkEvenOdd(a);
        }
    }
}
