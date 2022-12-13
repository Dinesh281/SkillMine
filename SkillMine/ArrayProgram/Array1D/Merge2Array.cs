using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class Merge2Array
    {
        public void Merge(int[] a, int[] b)
        {
            int[] c = new int[20];
            int count = 0, flag = 0;
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    c[count] = a[i];
                    count++;
                }
            }
            for(int i = 0; i < b.Length; i++)
            {
                c[count] = b[i];
                count++;
            }
            Console.WriteLine("After Merging two array");
            for(int i = 0; i <= count-1; i++)
            {
                Console.Write(c[i]+" ");
            }
        }
    
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            Console.WriteLine("Enter 1st Array");
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter 2nd Array");
            for (int i = 0; i < 10; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Befor Merging Given array");
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine(string.Join(" ", b));
            Merge2Array m = new Merge2Array();
            m.Merge(a, b);
        }
    }
}
