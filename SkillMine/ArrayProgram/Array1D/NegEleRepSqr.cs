using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ArrayProgram.Array1D
{
    class NegEleRepSqr
    {
        public void CheckNeg(int[] b)
        {
            for(int i = 0; i < b.Length; i++)
            {
                if (b[i] < 0)
                {
                    if (i == 0)
                    {
                        int j = b.Length - 1;
                        bool isCheck = true;
                        while (isCheck)
                        {
                            if (b[j] < 0)
                                j--;
                            else
                                isCheck = false;
                        }
                        b[i] = b[j] * b[j];
                    }
                    else
                    {

                        b[i] = b[i-1] * b[i-1]; 
                    }
                }
            }
            Console.WriteLine("After removing the negative element in array are");
            Console.WriteLine(string.Join(" ", b));
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 Number");
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Given array");
            Console.WriteLine(string.Join(" ", a));
            NegEleRepSqr n = new NegEleRepSqr();
            n.CheckNeg(a);
        }
    }
}
