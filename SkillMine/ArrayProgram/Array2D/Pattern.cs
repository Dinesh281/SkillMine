using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array2D
{
    class Pattern
    {
        public void Pattern1(int[,] a)
        {
            Console.WriteLine("----------------------------------------");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 | j == 0 | i == 3 | j == 3)
                    {
                        Console.Write(a[i,j]+" ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }
        public void Pattern2(int[,] a)
        {
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j | j == 0 |  j == 3)
                    {
                        Console.Write(a[i, j]+" ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
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
            Pattern p = new Pattern();
            Console.WriteLine("Given array");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            p.Pattern1(a);
            p.Pattern2(a);
        }
    }
}
