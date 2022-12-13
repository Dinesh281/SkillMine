using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array2D
{
    class MaxInColumn
    {
        public void Max(int[,] a)
        {
            int max = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a.GetLength(1); i++)
            {
                max = a[0, i];
                for (int j = 1; j < a.GetLength(0); j++)
                {
                    if (a[j, i] > max)
                    {
                        max = a[j, i];
                    }
                }
                Console.Write(max + " ");
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("Enter the 4by4 Matrix Element");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            MaxInColumn s = new MaxInColumn();
            s.Max(a);
        }
    }
}
