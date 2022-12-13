using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array2D
{
    class SumOfColumn
    {
        public void Sum(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    sum = sum + a[j, i];
                }
                Console.Write(sum+" ");
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("Enter the 4by4 Matrix Element");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            SumOfColumn s = new SumOfColumn();
            s.Sum(a);
        }
    }
}
