﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class DisplayEvenPosition
    {
        public void Position(int[] c)
        {
            Console.WriteLine("Even Position Of Element in array is");
            for(int i = 0; i < c.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(c[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 Number");
            for(int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Given array");
            Console.WriteLine(string.Join(" ", a));
            DisplayEvenPosition d = new DisplayEvenPosition();
            d.Position(a);
        }
    }
}
