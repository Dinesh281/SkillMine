using System;

namespace SkillMine
{
    class Program
    {
/*        Written Test :
1. Check if given number is Armstrong or not
2. Swap values of two integer variables without using third variable.
3. Count number of digits in any number.
4. Accept a number from user and Create table of a number.
5. Find first 10 even numbers.*/
        static void Main(string[] args)
        {
            //check number is armstrong or not
            /*           int num, count = 0, sum = 0, s1;
                       Console.WriteLine("Enter Number");
                       num = Convert.ToInt32(Console.ReadLine());
                       int temp = num;
                       while (num > 0)
                       {
                           count++;
                           num = num / 10;
                       }
                       Console.WriteLine(count);
                       num = temp;
                       for(int i = 0; i < count; i++)
                       {
                           s1 = 1;
                           int r = num % 10;
                           for(int j = 0; j < count; j++)
                           {
                               s1 =s1 * r;
                              // Console.WriteLine($"s1 {s1}");
                           }
                           sum = sum + s1;
                           num = num / 10;

                       }
                      // Console.WriteLine(sum);
                       if (temp == sum)
                       {
                           Console.WriteLine(temp + " It is a Armstrong Number");
                       }
                       else
                       {
                           Console.WriteLine(temp + " It is not a Armstrong Number");
                       }*/
            int num1, num2;
            Console.WriteLine("Enter two Number");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before Swapping \n num1 = {num1} \n num2 = {num2}");
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine($"After Swapping \n num1 = {num1} \n num2 = {num2}");

        }
    }
}
