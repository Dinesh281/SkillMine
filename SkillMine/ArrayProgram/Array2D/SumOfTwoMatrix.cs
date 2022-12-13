using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array2D
{
    class SumOfTwoMatrix
    {
        public void Sum(int[,] a, int[,] b)
        {
            Console.WriteLine("Befor addition given array");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();

            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] sum = new int[4, 4];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("After addition of two matrix");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(sum[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4]
            {
                {1,2,3,4 },
                {1,2,3,4 },
                {1,2,3,4 },
                {1,2,3,4 }
            };
            int[,] b = new int[4, 4]
            {
                {4,3,2,1 },
                {4,3,2,1 },
                {4,3,2,1 },
                {4,3,2,1 }
            };
            SumOfTwoMatrix s = new SumOfTwoMatrix();
            s.Sum(a, b);

        }
    }
}
