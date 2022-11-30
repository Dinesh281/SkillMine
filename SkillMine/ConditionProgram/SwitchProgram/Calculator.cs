using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ConditionProgram.SwitchProgram
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int choice,num1,num2;
            Console.WriteLine("Enter 2 Number");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:Console.WriteLine("Addition Of Two Number is " +(num1+num2));
                    break;

                case 2:Console.WriteLine("Subtraction Of Two Number is " + (num1 - num2));
                    break;

                case 4:Console.WriteLine("Division Of Two Number is " + (num1 / num2));
                    break;

                case 3:Console.WriteLine("Multiplication Of Two Number is " + (num1 * num2));
                    break;

                default : Console.WriteLine("Enter Valid Choice...!!!!!");
                    break;
            }
        }
    }
}
