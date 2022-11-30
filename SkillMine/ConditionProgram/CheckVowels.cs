using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram
{
    class CheckVowels
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Character");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'A')
            {
                Console.WriteLine("It is a Vowels");
            }
            else if (ch == 'e' || ch == 'E')
            {
                Console.WriteLine("It is a Vowels");
            }
            else if (ch == 'i' || ch == 'I')
            {
                Console.WriteLine("It is a Vowels");
            }
            else if (ch == 'o' || ch == 'O')
            {
                Console.WriteLine("It is a Vowels");
            }
            else if (ch == 'u' || ch == 'U')
            {
                Console.WriteLine("It is a Vowels");
            }
            else
            {
                Console.WriteLine("Its a Consonent..");
            }
        }
    }
}
