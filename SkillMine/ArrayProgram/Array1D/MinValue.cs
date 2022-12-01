using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class MinValue
    {
        public void CheckMin (int[] a)
        {
            int min = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Minimum Value from the array is " + min);
        }
        static void Main(string[] args)
        {
            int[] num = new int[6];
            Console.WriteLine("Enter the 6 number");
            for(int i = 0; i < 6; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            MinValue m = new MinValue();
            m.CheckMin(num);
        }
    }
}
