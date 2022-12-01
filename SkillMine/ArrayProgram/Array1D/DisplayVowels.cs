using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class DisplayVowels
    {
        public void CheckVowels(char[] c)
        {
            Console.Write("List Of Vowels are ");
            for(int i = 0; i < c.Length; i++)
            {
                if(c[i]=='a'|c[i]=='A'| c[i] == 'e' | c[i] == 'E'| c[i] == 'i' | c[i] == 'I'| c[i] == 'o' | c[i] == 'O'| c[i] == 'u' | c[i] == 'U')
                {
                    Console.Write(c[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            char[] ch = new char[8];
            Console.WriteLine("Enter the 8 Character");
            for(int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            DisplayVowels d = new DisplayVowels();
            d.CheckVowels(ch);
        }
    }
}
