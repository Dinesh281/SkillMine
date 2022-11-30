using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram.SwitchProgram
{
    class CheckVowels
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Character");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':Console.WriteLine("It is a Vowel");
                    break;

                case 'A':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'E':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'I':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'O':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'U':
                    Console.WriteLine("It is a Vowel");
                    break;
                default: Console.WriteLine("It is a Consonent");
                    break;
            }
        }
    }
}
