using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class SortChar
    {
        //  WAP sort character type of array
        public void sort(char[] c)
        {
            Console.WriteLine("After sorting the Array ");
            for(int i = 0; i < c.Length; i++)
            {
                for(int j = 0; j < c.Length - 1; j++)
                {
                    if (c[j] > c[j + 1])
                    {
                        char temp = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", c));
        }
        static void Main(string[] args)
        {
            char[] ch = new char[10];
            Console.WriteLine("Enter 10 Character");
            for(int i = 0; i < 10; i--)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Befor Sorting given Array ");
            Console.WriteLine(string.Join(" ", ch));
            SortChar s = new SortChar();
            s.sort(ch);

        }
    }
}
