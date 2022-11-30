using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop.NestedLoop
{
    class DisariumNumber
    {
        static void Main(string[] args)
        {
            int num,length=0,sum=0;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            int temp = num;
            while (num != 0)
            {
                length++;
                num = num / 10;
            }
           // Console.WriteLine(length);
            num = temp;
            for(int i = length; i>=1; i--)
            {
                int prd = 1;
                int r = num % 10;
                for (int j = 1; j <= i; j++)
                {
                    prd = prd * r;
                }
               //Console.WriteLine(prd);
                sum = sum + prd;
              //  Console.WriteLine(sum);
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " is a Disarium Number");
            }
            else
            {
                Console.WriteLine(temp + " is Not a Disarium Number");
            }

        }
    }
}
