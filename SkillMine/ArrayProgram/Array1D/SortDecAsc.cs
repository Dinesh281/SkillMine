using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class SortDecAsc
    {
        public void SortIt(int[] b)
        {
            for(int i = 0; i < b.Length; i++)
            {
                if (i < b.Length/2)
                {
                    for (int j = 0; j < b.Length/2-1; j++)
                    {
                        if (b[j] < b[j + 1])
                        {
                            int temp = b[j];
                            b[j] = b[j + 1];
                            b[j + 1] = temp;
                        }
                    }
                }
                else
                {
                    for (int j = 5; j < b.Length-1 ; j++)
                    {
                        if (b[j] > b[j + 1])
                        {
                            int temp = b[j];
                            b[j] = b[j + 1];
                            b[j + 1] = temp;
                        }
                    }
                }
            }
            foreach(int item in b)
            {
                Console.Write(item+" ");
            }
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
            SortDecAsc s = new SortDecAsc();
            s.SortIt(a);
        }
    }
}
