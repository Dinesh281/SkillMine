using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class FrequencyOfElement
    {
        public void Frequency(int[]b,int n)
        {
            int count = 0;
            for(int i = 0; i < b.Length; i++)
            {
                if (b[i] == n)
                    count++;
            }
            Console.WriteLine("Frequency of " + n + " in array is " + count);
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
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            FrequencyOfElement f = new FrequencyOfElement();
            f.Frequency(a, num);
        }
    }
}
