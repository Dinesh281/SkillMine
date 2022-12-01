using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class MinMaxChar
    {
        public void check(char[] c)
        {
            char min = c[0];
            char max = c[c.Length - 1];
            for(int i = 0; i < c.Length; i++)
            {
                if (c[i] > max)
                {
                    max = c[i];
                }else if (c[i] < min)
                {
                    min = c[i];
                }
            }
            Console.WriteLine("Max = " + max + "\nMin = " + min);
        }
        static void Main(string[] args)
        {
            char[] ch = new char[6];
            Console.WriteLine("Enter 6 Character");
            for(int i = 0; i < 6; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            MinMaxChar m = new MinMaxChar();
            m.check(ch);
        }
    }
}
