using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class RepAlterChar
    {
        public void replace(char[] c)
        {
            for(int i = 0; i < c.Length; i++)
            {
                if (c[i] == 'y' || c[i] == 'Y' || c[i] == 'z' || c[i] == 'Z')
                {
                    c[i] = (char)(c[i] - 24);
                }
                else
                {
                    c[i] = (char)(c[i] + 2);
                }
            }
            Console.WriteLine("After Replacing alternate Character is ");
            Console.WriteLine(string.Join(" ", c));
        }
        static void Main(string[] args)
        {
            char[] ch = new char[6];
            Console.WriteLine("Enter 6 Character");
            for(int i = 0; i < 6; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Before replacing array");
            Console.WriteLine(string.Join(" " , ch));
            RepAlterChar r = new RepAlterChar();
            r.replace(ch);
        }
    }
}
