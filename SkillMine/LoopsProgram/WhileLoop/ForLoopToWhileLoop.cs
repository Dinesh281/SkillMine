using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.WhileLoop
{
    class ForLoopToWhileLoop
    {
    }
    //WAP Display number between 1 to 10
    class CalculateSum1To10
    {
        static void Main(string[] args)
        {
            int sum = 0, i =1;
            while(i <= 10){
                sum = sum + i;
                i++;
            }
            Console.WriteLine("Sum 1 To 10 is " + sum);
        }
    }

    //
    class CountOddNum
    {
        static void Main(string[] args)
        {
            int count = 0, i = 1;
            while (i <= 20)
            {
                if (i % 2 == 1)
                    count++;
            }
            Console.WriteLine("Count of Odd number 1 to 20 is " + count);
        }
    }
    class Display120To200
    {
        static void Main(string[] args)
        {
            int i = 120;
            while (i <= 200)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    class Display1To10
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    class Display75To61
    {
        static void Main(string[] args)
        {
            for (int i = 75; i >= 61; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    class DisplayTables
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
            }
        }
    }
    class Divisible5N3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
    class OddNumBtwn120To81
    {
        static void Main(string[] args)
        {
            for (int i = 120; i >= 81; i--)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class SumOfFactors
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of Factor " + num + " is " + sum);
        }
    }
}
