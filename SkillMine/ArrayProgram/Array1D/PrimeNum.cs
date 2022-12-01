using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class PrimeNum
    {
        public void CheckPrime(int[] b)
        {
            Console.WriteLine("Prime Number from given array are");
            for(int i = 0; i < b.Length; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (b[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && b[i] != 1 && b[i] != 2)
                {
                    Console.Write(b[i] + " ");
                }
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
            PrimeNum p = new PrimeNum();
            p.CheckPrime(a);
        }
    }
}
